using SharpDX.XInput;
using System;
using System.Collections.Generic;
using System.Text;

namespace torreta
{
    public class XboxController
    {
        private Controller controller;
        private Gamepad gamepad;
        private State state;

        public XboxController(UserIndex userIndex)
        {
            controller = new Controller(userIndex);
            try
            {
                gamepad = controller.GetState().Gamepad;
            }catch (Exception ex) { return; }
        }

        public void UpdateState()
        {
            state = controller.GetState();
        }

        public bool IsConnected()
        {
            return controller.IsConnected;
        }

        public short GetLeftThumbX()
        {
            return state.Gamepad.LeftThumbX;
        }

        public short GetLeftThumbY()
        {
            return state.Gamepad.LeftThumbY;
        }

        public short GetRightThumbX()
        {
            return state.Gamepad.RightThumbX;
        }

        public short GetRightThumbY()
        {
            return state.Gamepad.RightThumbY;
        }
    }
}
