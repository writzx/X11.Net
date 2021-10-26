using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace X11.XFixes {
    [StructLayout(LayoutKind.Sequential)]
    public struct XFixesCursorNotifyEvent {
        public int type; /* event base */
        public ulong serial;
        public bool send_event;
        public IntPtr display;
        public Window window;
        public int subtype;
        public ulong cursor_serial;
        public long timestamp;
        public Atom cursor_name;
    }


    [StructLayout(LayoutKind.Sequential)]
    public struct XFixesCursorImage {
        public short x, y;
        public ushort width, height;
        public ushort xhot, yhot;
        public ulong cursor_serial;
        public IntPtr pixels;
        public Atom atom;
        public string name;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XFixesCursorImageAndName {
        public short x, y;
        public ushort width, height;
        public ushort xhot, yhot;
        public ulong cursor_serial;
        public IntPtr pixels;
        public Atom atom;
        public string name;
    }

    public partial class XFixes {
        [DllImport("libXfixes.so")]
        public static extern void
            XFixesSelectCursorInput(IntPtr dpy, Window win, Events eventMask);

        [DllImport("libXfixes.so")] // returns XFixesCursorImage
        public static extern IntPtr XFixesGetCursorImage(IntPtr dpy);

        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesSetCursorName(IntPtr dpy, Cursor cursor, string name);

        [DllImport("libXfixes.so.3")]
        public static extern string
            XFixesGetCursorName(IntPtr dpy, Cursor cursor, ref Atom atom);

        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesChangeCursor(IntPtr dpy, Cursor source, Cursor destination);

        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesChangeCursorByName(IntPtr dpy, Cursor source, string name);


        [DllImport("libXfixes.so.3")]
        public static extern void XFixesHideCursor(IntPtr dpy, Window win);

        [DllImport("libXfixes.so.3")]
        public static extern void XFixesShowCursor(IntPtr dpy, Window win);
    }
}
