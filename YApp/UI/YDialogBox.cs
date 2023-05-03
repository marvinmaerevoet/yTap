namespace YY.UI;

internal static class YDialogBox {
    internal static void ShowError(string message) {
        string caption = "Error";
        _ = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
    }

    internal static void ShowInfo(string message) {
        string caption = "Information";
        _ = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
    }
}