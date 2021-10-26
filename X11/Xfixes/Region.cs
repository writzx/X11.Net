using System;
using System.Runtime.InteropServices;

namespace X11.XFixes {
    using XserverRegion = XID;
    
    public enum WindowRegionKind : int {
        WindowRegionBounding = 0,
        WindowRegionClip = 1
    }

    public partial class XFixes {
        [DllImport("libXfixes.so.3")]
        public static extern XserverRegion
            XFixesCreateRegion(IntPtr dpy, XRectangle[] rectangles, int nrectangles);


        [DllImport("libXfixes.so.3")]
        public static extern XserverRegion
            XFixesCreateRegionFromBitmap(IntPtr dpy, Pixmap bitmap);


        [DllImport("libXfixes.so.3")]
        public static extern XserverRegion
            XFixesCreateRegionFromWindow(IntPtr dpy, Window window, WindowRegionKind kind);


        [DllImport("libXfixes.so.3")]
        public static extern XserverRegion
            XFixesCreateRegionFromGC(IntPtr dpy, IntPtr gc);


        [DllImport("libXfixes.so.3")]
        public static extern XserverRegion
            XFixesCreateRegionFromPicture(IntPtr dpy, XID picture);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesDestroyRegion(IntPtr dpy, XserverRegion region);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesSetRegion(IntPtr dpy, XserverRegion region, XRectangle[] rectangles, int nrectangles);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesCopyRegion(IntPtr dpy, XserverRegion dst, XserverRegion src);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesUnionRegion(IntPtr dpy, XserverRegion dst, XserverRegion src1, XserverRegion src2);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesIntersectRegion(IntPtr dpy, XserverRegion dst, XserverRegion src1, XserverRegion src2);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesSubtractRegion(IntPtr dpy, XserverRegion dst, XserverRegion src1, XserverRegion src2);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesInvertRegion(IntPtr dpy, XserverRegion dst, ref XRectangle rect, XserverRegion src);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesTranslateRegion(IntPtr dpy, XserverRegion region, int dx, int dy);


        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesRegionExtents(IntPtr dpy, XserverRegion dst, XserverRegion src);

        [DllImport("libXfixes.so.3")]
        public static extern IntPtr
            XFixesFetchRegion(IntPtr dpy, XserverRegion region, ref int nrectanglesRet);

        [DllImport("libXfixes.so.3")]
        public static extern IntPtr
            XFixesFetchRegionAndBounds(IntPtr dpy, XserverRegion region, ref int nrectanglesRet, ref XRectangle bounds);

        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesSetGCClipRegion(IntPtr dpy, IntPtr gc, int clip_x_origin, int clip_y_origin, XserverRegion region);

        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesSetWindowShapeRegion(IntPtr dpy, Window win, int shape_kind, int x_off, int y_off,
                XserverRegion region);

        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesSetPictureClipRegion(IntPtr dpy, XID picture,
                int clip_x_origin, int clip_y_origin,
                XserverRegion region);

        [DllImport("libXfixes.so.3")]
        public static extern void
            XFixesExpandRegion(IntPtr dpy, XserverRegion dst, XserverRegion src,
                uint left, uint right, uint top, uint bottom);
    }
}
