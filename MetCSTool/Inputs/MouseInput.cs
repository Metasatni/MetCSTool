using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MetCSTool.Inputs
{
    internal class MouseInput
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        private const int LEFTDOWN = 0x02;
        private const int LEFTUP = 0x04;
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000;

        public static void MouseClick()
        {
            mouse_event(LEFTDOWN, 0, 0, 0, 0);
            mouse_event(LEFTUP, 0, 0, 0, 0);

        }
        public static void MouseMove(int right, int down)
        {
            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, right, down, 0, 0);
        }
        public static void FluencyMouseMoveRight(int right)
        {
            for (int i = 0; i < right/2; i++)
            {
                mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, 2, 0, 0, 0);
            }
        }
        public static void FluencyMouseMoveLeft(int left)
        {
            for (int i = 0; i < left/2 ; i++)
            {
                mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, -2, 0, 0, 0);
            }
        }
    }
}
