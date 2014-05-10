using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace JumpnRun
{
    class Controller
    {
        private GamePadState GPSold;
        private GamePadState GPSnew;
        private PlayerIndex playerID;
        public Controller(PlayerIndex playerID)
        {
            this.playerID = playerID;
            this.GPSnew = GamePad.GetState(playerID);
            this.GPSold = GamePad.GetState(playerID);
        }

        public void Update()
        {
            this.GPSold = this.GPSnew;
            this.GPSnew = GamePad.GetState(playerID);
        }
        public bool JumpGetPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.A) == true && GPSold.IsButtonUp(Buttons.A) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool JumpPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.A) == true && GPSold.IsButtonDown(Buttons.A) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool JumpReleased()
        {
            if (GPSnew.IsButtonUp(Buttons.A) == true && GPSold.IsButtonDown(Buttons.A) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool LeftGetPressed()
        {
            if (GPSnew.ThumbSticks.Left.X < 0 && GPSold.ThumbSticks.Left.X >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LeftPressed()
        {
            if (GPSnew.ThumbSticks.Left.X < 0 && GPSold.ThumbSticks.Left.X < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool LeftReleased()
        {
            if (GPSnew.ThumbSticks.Left.X >= 0 && GPSold.ThumbSticks.Left.X < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RightGetPressed()
        {
            if (GPSnew.ThumbSticks.Left.X > 0 && GPSold.ThumbSticks.Left.X <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RightPressed()
        {
            if (GPSnew.ThumbSticks.Left.X > 0 && GPSold.ThumbSticks.Left.X > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RightReleased()
        {
            if (GPSnew.ThumbSticks.Left.X <= 0 && GPSold.ThumbSticks.Left.X > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AttackGetPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.RightTrigger) == true && GPSold.IsButtonUp(Buttons.RightTrigger) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AttackPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.RightTrigger) == true && GPSold.IsButtonDown(Buttons.RightTrigger) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AttackReleased()
        {
            if (GPSnew.IsButtonUp(Buttons.RightTrigger) == true && GPSold.IsButtonDown(Buttons.RightTrigger) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SwitchGetPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.RightShoulder) == true && GPSold.IsButtonUp(Buttons.RightShoulder) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SwitchPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.RightShoulder) == true && GPSold.IsButtonDown(Buttons.RightShoulder) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool SwitchReleased()
        {
            if (GPSnew.IsButtonUp(Buttons.RightShoulder) == true && GPSold.IsButtonDown(Buttons.RightShoulder) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DashGetPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.LeftTrigger) == true && GPSold.IsButtonUp(Buttons.LeftTrigger) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DashPressed()
        {
            if (GPSnew.IsButtonDown(Buttons.LeftTrigger) == true && GPSold.IsButtonDown(Buttons.LeftTrigger) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DashReleased()
        {
            if (GPSnew.IsButtonUp(Buttons.LeftTrigger) == true && GPSold.IsButtonDown(Buttons.LeftTrigger) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
