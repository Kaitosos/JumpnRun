using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace JumpnRun
{
    class Input
    {
        public bool jumpStart;
        public bool jumpAktiv;
        public bool jumpEnd;
        public bool leftStart;
        public bool leftAktiv;
        public bool leftEnd;
        public bool rightStart;
        public bool rightAktiv;
        public bool rightEnd;
        public bool attackStart;
        public bool attackAktiv;
        public bool attackEnd;
        public bool switchStart;
        public bool switchAktiv;
        public bool switchEnd;
        public bool dashStart;
        public bool dashAktiv;
        public bool dashEnd;
        private int player;
        private bool controlleraktiv;
        private PlayerIndex PID;
        private Controller controller;
        private myKeyboard keyboard = new myKeyboard();
        public Input(int playerID, PlayerIndex PID = PlayerIndex.Four)
        {
            if (PID == PlayerIndex.Four)
            {
                this.controller = new Controller(PID);
                this.controlleraktiv = false;
            }
        }

        public void Update()
        {
            if (controlleraktiv)
            {
                #region controllerInput
                this.controller.Update();

                this.jumpStart = this.controller.JumpGetPressed();
                this.jumpAktiv = this.controller.JumpPressed();
                this.jumpEnd = this.controller.JumpReleased();
                this.leftStart = this.controller.LeftGetPressed();
                this.leftAktiv = this.controller.LeftPressed();
                this.leftEnd = this.controller.LeftReleased();
                this.rightStart = this.controller.RightGetPressed();
                this.rightAktiv = this.controller.RightPressed();
                this.rightEnd = this.controller.RightReleased();
                this.attackStart = this.controller.AttackGetPressed();
                this.attackAktiv = this.controller.AttackPressed();
                this.attackEnd = this.controller.AttackReleased();
                this.switchStart = this.controller.SwitchGetPressed();
                this.switchAktiv = this.controller.SwitchPressed();
                this.switchEnd = this.controller.SwitchReleased();
                this.dashStart = this.controller.DashGetPressed();
                this.dashAktiv = this.controller.DashPressed();
                this.dashEnd = this.controller.DashReleased();
                #endregion
            }
            else
            {
                #region keyboardInput
                this.keyboard.Update();

                this.jumpStart = this.keyboard.JumpGetPressed();
                this.jumpAktiv = this.keyboard.JumpPressed();
                this.jumpEnd = this.keyboard.JumpReleased();
                this.leftStart = this.keyboard.LeftGetPressed();
                this.leftAktiv = this.keyboard.LeftPressed();
                this.leftEnd = this.keyboard.LeftReleased();
                this.rightStart = this.keyboard.RightGetPressed();
                this.rightAktiv = this.keyboard.RightPressed();
                this.rightEnd = this.keyboard.RightReleased();
                this.attackStart = this.keyboard.AttackGetPressed();
                this.attackAktiv = this.keyboard.AttackPressed();
                this.attackEnd = this.keyboard.AttackReleased();
                this.switchStart = this.keyboard.SwitchGetPressed();
                this.switchAktiv = this.keyboard.SwitchPressed();
                this.switchEnd = this.keyboard.SwitchReleased();
                this.dashStart = this.keyboard.DashGetPressed();
                this.dashAktiv = this.keyboard.DashPressed();
                this.dashEnd = this.keyboard.DashReleased();
                #endregion
            }
        }
    }
}
