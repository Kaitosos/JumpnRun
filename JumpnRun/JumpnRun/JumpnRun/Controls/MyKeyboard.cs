using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace JumpnRun
{
    class myKeyboard
    {
        private KeyboardState KeystateOld;
        private KeyboardState KeystateNew;
        public myKeyboard()
        {
            this.KeystateOld = Keyboard.GetState();
            this.KeystateNew = Keyboard.GetState();
        }
        public void Update()
        {
            this.KeystateOld = this.KeystateNew;
            this.KeystateNew = Keyboard.GetState();
        }
        public bool JumpGetPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.Space) == true && KeystateOld.IsKeyUp(Keys.Space) == true)
            {
                return true;
            }
            if (KeystateNew.IsKeyDown(Keys.W) == true && KeystateOld.IsKeyUp(Keys.W) == true)
            {
                return true;
            }
            return false;
        }
        public bool JumpPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.Space) == true && KeystateOld.IsKeyDown(Keys.Space) == true)
            {
                return true;
            }
            if (KeystateNew.IsKeyDown(Keys.W) == true && KeystateOld.IsKeyDown(Keys.W))
            {
                return true;
            }
            return false;
        }
        public bool JumpReleased()
        {
            if (KeystateNew.IsKeyUp(Keys.Space) == true && KeystateOld.IsKeyDown(Keys.Space) == true)
            {
                return true;
            }
            if (KeystateNew.IsKeyUp(Keys.W) == true && KeystateOld.IsKeyDown(Keys.W) == true)
            {
                return true;
            }
            return false;
        }

        public bool LeftGetPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.A) == true && KeystateOld.IsKeyUp(Keys.A) == true)
            {
                return true;
            }
            return false;
        }
        public bool LeftPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.A) == true && KeystateOld.IsKeyDown(Keys.A) == true)
            {
                return true;
            }
            return false;
        }
        public bool LeftReleased()
        {
            if (KeystateNew.IsKeyUp(Keys.A) == true && KeystateOld.IsKeyDown(Keys.A) == true)
            {
                return true;
            }
            return false;
        }

        public bool RightGetPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.D) == true && KeystateOld.IsKeyUp(Keys.D) == true)
            {
                return true;
            }
            return false;
        }
        public bool RightPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.D) == true && KeystateOld.IsKeyDown(Keys.D) == true)
            {
                return true;
            }
            return false;
        }
        public bool RightReleased()
        {
            if (KeystateNew.IsKeyUp(Keys.D) == true && KeystateOld.IsKeyDown(Keys.D) == true)
            {
                return true;
            }
            return false;
        }

        public bool AttackGetPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.G) == true && KeystateOld.IsKeyUp(Keys.G) == true)
            {
                return true;
            }
            return false;
        }
        public bool AttackPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.G) == true && KeystateOld.IsKeyDown(Keys.G) == true)
            {
                return true;
            }
            return false;
        }
        public bool AttackReleased()
        {
            if (KeystateNew.IsKeyUp(Keys.G) == true && KeystateOld.IsKeyDown(Keys.G) == true)
            {
                return true;
            }
            return false;
        }

        public bool SwitchGetPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.T) == true && KeystateOld.IsKeyUp(Keys.T) == true)
            {
                return true;
            }
            return false;
        }
        public bool SwitchPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.T) == true && KeystateOld.IsKeyDown(Keys.T) == true)
            {
                return true;
            }
            return false;
        }
        public bool SwitchReleased()
        {
            if (KeystateNew.IsKeyUp(Keys.T) == true && KeystateOld.IsKeyDown(Keys.T) == true)
            {
                return true;
            }
            return false;
        }

        public bool DashGetPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.V) == true && KeystateOld.IsKeyUp(Keys.V) == true)
            {
                return true;
            }
            return false;
        }
        public bool DashPressed()
        {
            if (KeystateNew.IsKeyDown(Keys.V) == true && KeystateOld.IsKeyDown(Keys.V) == true)
            {
                return true;
            }
            return false;
        }
        public bool DashReleased()
        {
            if (KeystateNew.IsKeyUp(Keys.V) == true && KeystateOld.IsKeyDown(Keys.V) == true)
            {
                return true;
            }
            return false;
        }
    }
}
