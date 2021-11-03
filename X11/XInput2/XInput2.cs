using System;
using System.Runtime.InteropServices;

namespace X11.XInput2 {
    public struct XIEventMask {
        public int deviceid;
        public int mask_len;
        public IntPtr mask;
    }

    public struct XIValuatorState {
        public int mask_len;
        public IntPtr mask; // unsigned char *
        public IntPtr values; // double *
    }

    public struct XIRawEvent {
        public int type; /* GenericEvent */
        public ulong serial;
        public bool send_event;
        public IntPtr display;
        public int extension;
        public int evtype;
        public ulong time;
        public int deviceid;
        public int sourceid; // 0
        public int detail;
        public int flags;
        public XIValuatorState valuators;
        public IntPtr raw_values; // double*
    }


    public partial class XInput2 {
        [DllImport("libXi.so.6")]
        public static extern int XISelectEvents(IntPtr dpy, Window win, XIEventMask[] masks, int num_masks);

        public static void XISetMask(ref byte[] mask, int evt) {
            mask[evt >> 3] |= (byte) (1 << (evt & 7));
        }
    }
}
