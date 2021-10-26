using System;
using System.Runtime.InteropServices;

namespace X11.XFixes {
    [StructLayout(LayoutKind.Sequential)]
    public struct XFixesSelectionNotifyEvent {
        public int type; /* event base */
        public ulong serial;
        public bool send_event;
        public IntPtr display;
        public Window window;
        public int subtype;
        public Window owner;
        public Atom selection;
        public long timestamp;
        public long selection_timestamp;
    }

    public partial class XFixes {
        [DllImport("libXfixes.so")]
        public static extern bool
            XFixesQueryExtension(IntPtr dpy, ref int event_base_return, ref int error_base_return);

        [DllImport("libXfixes.so")]
        public static extern Status
            XFixesQueryVersion(IntPtr dpy, ref int major_version_return, ref int minor_version_return);

        [DllImport("libXfixes.so")]
        public static extern int XFixesVersion();

        [DllImport("libXfixes.so")]
        public static extern void
            XFixesChangeSaveSet(IntPtr dpy, Window win, int mode, int target, int map);

        [DllImport("libXfixes.so")]
        public static extern void
            XFixesSelectSelectionInput(IntPtr dpy, Window win, Atom selection, SelectionNotifyMask eventMask);
    }
}
