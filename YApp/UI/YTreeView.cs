using System.Runtime.InteropServices;
using System.Xml.Linq;
using YY.Logging;

namespace YY.UI;

internal class YTreeView : TreeView {
    [DllImport("user32.dll", CharSet = CharSet.Auto)]
#pragma warning disable SYSLIB1054 // Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time
    private static extern IntPtr SendMessage(IntPtr targetWindowHandle, int messageType, IntPtr messageData, ref TreeViewItem messageExtraData);
#pragma warning restore SYSLIB1054 // Use 'LibraryImportAttribute' instead of 'DllImportAttribute' to generate P/Invoke marshalling code at compile time

    [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Auto)]
    private struct TreeViewItem {
        public int itemFieldMask;
        public IntPtr itemHandle;
        public int itemState;
        public int itemStateMask;
        [MarshalAs(UnmanagedType.LPTStr)]
        public string itemLabelText;
        public int itemTextMaxLength;
        public int itemImageIndex;
        public int itemSelectedImageIndex;
        public int itemChildCount;
        public IntPtr itemUserData;
    }

    private static void HideCheckBox(TreeView treeView, TreeNode treeNode) {
        TreeViewItem treeViewItem = new() {
            itemFieldMask = 0x8,
            itemHandle = treeNode.Handle,
            itemState = 0,
            itemStateMask = 0xF000
        };
        _ = SendMessage(treeView.Handle, 0x1100 + 63, IntPtr.Zero, ref treeViewItem);
    }

    private void HideChildCheckBoxes(TreeNode treeNode) {
        HideCheckBox(this, treeNode);
        foreach(TreeNode childTreeNode in treeNode.Nodes) {
            HideChildCheckBoxes(childTreeNode);
        }
    }

    private void SetCheckboxOnCondition(TreeNode rootTreeNode, string conditionKeyString, string conditionValueString) {
        foreach(TreeNode childTreeNode in rootTreeNode.Nodes) {
            if(childTreeNode.Text.Contains(conditionKeyString)) {
                string[] map = childTreeNode.Text.Split(": ");
                if(map[1].Contains(conditionValueString)) {
                    TreeNode parentTreeNode = childTreeNode.Parent;
                    while(parentTreeNode != null) {
                        parentTreeNode.Checked = true;
                        parentTreeNode = parentTreeNode.Parent;
                    }
                }
            }
            SetCheckboxOnCondition(childTreeNode, conditionKeyString, conditionValueString);
        }
    }

    private static void AddTreeNodesFromXElement(TreeNode parentTreeNode, XElement parentXElement) {
        foreach(XElement childXElement in parentXElement.Elements()) {
            TreeNode childTreeNode = new(childXElement.Name.LocalName);

            if(childXElement.Name.LocalName == "NodeTitle") {
                childTreeNode.Text = childXElement.FirstNode?.ToString();
            }

            if(childXElement.HasElements) {
                AddTreeNodesFromXElement(childTreeNode, childXElement);
            } else {
                childTreeNode.Text += $": {childXElement.Value}";
            }
            _ = parentTreeNode.Nodes.Add(childTreeNode);
        }
    }

    internal void BuildFromXDoc(XDocument xDocument) {
        try {
            Nodes.Clear();
            TreeNode rootTreeNode = new();

            XElement rootXElement = xDocument.Root ?? new("");
            string type = rootXElement.Name.ToString();

            string wakeProperty = type switch {
                "Tasks" => "WakeToRun",
                "Devices" => "Enable",
                _ => throw new Exception()
            };
            AddTreeNodesFromXElement(rootTreeNode, rootXElement);

            foreach(TreeNode childTreeNode in rootTreeNode.Nodes) {
                HideChildCheckBoxes(childTreeNode);
                SetCheckboxOnCondition(childTreeNode, wakeProperty, "true");
                _ = Nodes.Add(childTreeNode);
            }

            foreach(TreeNode parentTreeNode in Nodes) {
                foreach(TreeNode childTreeNode in parentTreeNode.Nodes) {
                    HideChildCheckBoxes(childTreeNode);
                }
            }
        } catch(Exception ex) {
            YLog.Error(ex);
        }
    }

    internal static string GetValueFromTreeNodeText(TreeNode treeNode, string value) {
        foreach(TreeNode childTreeNode in treeNode.Nodes) {
            if(childTreeNode.Text.Contains(value)) {
                return childTreeNode.Text.Split(": ")[1];
            } else {
                _ = GetValueFromTreeNodeText(childTreeNode, value);
            }
        }
        return string.Empty;
    }

    /// Convert Checkbox double-click to single-click
    protected override void WndProc(ref Message m) {
        if(m.Msg == 0x0203) {
            m.Msg = 0x0201;
        }
        base.WndProc(ref m);
    }
}