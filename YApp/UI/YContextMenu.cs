using System.Runtime.InteropServices;

namespace YApp.UI;

internal class YContextMenu : ContextMenuStrip {
    [DllImport("dwmapi.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    private static extern long DwmSetWindowAttribute(IntPtr hwnd,
                                                        DWMWINDOWATTRIBUTE attribute,
                                                        ref DWM_WINDOW_CORNER_PREFERENCE pvAttribute,
                                                        uint cbAttribute);

    internal YContextMenu() {
        DWM_WINDOW_CORNER_PREFERENCE preference = DWM_WINDOW_CORNER_PREFERENCE.DWMWCP_ROUND;
        _ = DwmSetWindowAttribute(Handle,
                              DWMWINDOWATTRIBUTE.DWMWA_WINDOW_CORNER_PREFERENCE,
                              ref preference,
                              sizeof(uint));
    }

    private enum DWMWINDOWATTRIBUTE {
        DWMWA_WINDOW_CORNER_PREFERENCE = 33
    }

    private enum DWM_WINDOW_CORNER_PREFERENCE {
        DWMWA_DEFAULT = 0,
        DWMWCP_DONOTROUND = 1,
        DWMWCP_ROUND = 2,
        DWMWCP_ROUNDSMALL = 3,
    }
}

internal class YMenuColorTable : ProfessionalColorTable {
    public override Color MenuItemBorder {
        get { return Color.Transparent; }
    }

    public override Color MenuItemPressedGradientBegin {
        get { return ColorTranslator.FromHtml("#4C4A48"); }
    }
    public override Color MenuItemPressedGradientEnd {
        get { return ColorTranslator.FromHtml("#5F5D5B"); }
    }

    public override Color MenuItemSelectedGradientBegin {
        get { return ColorTranslator.FromHtml("#353535"); }
    }

    public override Color MenuItemSelectedGradientEnd {
        get { return ColorTranslator.FromHtml("#353535"); }
    }
}