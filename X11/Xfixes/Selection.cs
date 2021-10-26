namespace X11.XFixes {
    public enum Selection: int {
        XFixesSetSelectionOwnerNotify = 0,
        XFixesSelectionWindowDestroyNotify = 1,
        XFixesSelectionClientCloseNotify = 2
    }
    public enum SelectionNotifyMask : ulong {
        XFixesSetSelectionOwnerNotifyMask = (1L << 0),
        XFixesSelectionWindowDestroyNotifyMask = (1L << 1),
        XFixesSelectionClientCloseNotifyMask = (1L << 2)
    }
}
