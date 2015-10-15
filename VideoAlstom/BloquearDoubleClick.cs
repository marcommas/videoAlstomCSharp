using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace VideoAlstom
{
    class BloquearDoubleClick : IMessageFilter
    {
        private Control _Parent { get; set; }
        private Control _Target { get; set; }

        public BloquearDoubleClick(Control parent, Control target)
        {
            _Parent = parent;
            _Target = target;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (_Parent == null)
                return false;

            // Get the Control beneath the current X, Y coordinates
            // of the cursor
            Control child = _Parent.GetChildAtPoint(Cursor.Position);
            if (child == null)
                return false;

            // Determine if the Control over which the cursor is currently
            // hovering if the target control for which we want to ignore any
            // mouse click activity
            if (child != _Target)
                return false;

            // At this point, we have identified that the cursor is hovering
            // above our target Control; now we need to determine if the current
            // window message is one that should be ignored...
            if (m.Msg == 0x202 /* WM_LBUTTONUP*/
                    || m.Msg == 0x204 /* WM_RBUTTONDOWN */
                    || m.Msg == 0x205 /* WM_RBUTTONUP */
                    || m.Msg == 0x203 /* WM_LBUTTONDBLCLK*/)
            {
                // Return true to prevent the current window message from being
                // dispatched any further
                return true;
            }

            // The current window message is one that should not ignore
            return false;
        }
    }


    /*class BloquearDoubleClick : IMessageFilter
    {
        private Control parent { get; set; }
        private Control target { get; set; }

        public BloquearDoubleClick(Control parent, Control target)
        {
            this.parent = parent;
            this.target = target;
        }

        public bool PreFilterMessage(ref Message messageBeforeFiltering)
        {
            const Boolean FilterTheMessageOut = true;
            const Boolean LetTheMessageThrough = false;

            if (IsNull(parent)) return LetTheMessageThrough;
            if (IsNull(target)) return LetTheMessageThrough;
            if (WasNotClickedOnTarget(parent, target)) return LetTheMessageThrough;
            if (MessageContainsAnyMousebutton(messageBeforeFiltering)) return FilterTheMessageOut;
            return LetTheMessageThrough;
        }

        private bool MessageContainsAnyMousebutton(Message message)
        {
            if (message.Msg == 0x202) return true;
            if (message.Msg == 0x203) return true;
            if (message.Msg == 0x204) return true;
            if (message.Msg == 0x205) return true;
            return false;
        }

        private bool WasNotClickedOnTarget(Control parent, Control target)
        {
            Control clickedOn = parent.GetChildAtPoint(Cursor.Position);
            if (IsNull(clickedOn)) return true;
            if (AreEqual(clickedOn, target)) return false;
            return true;
        }

        private bool AreEqual(Control controlA, Control controlB)
        {
            if (controlA == controlB) return true;
            return false;
        }

        private bool IsNull(Control control)
        {
            if (control == null) return true;
            return false;
        }

    }*/

}
