using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace JumpnRun
{
    class Movement
    {


        public Movement()
        {
        }

       

        public Vector2 MoveRight(int Movement)
        {
            Vector2 PosAnder = new Vector2();
            PosAnder.Y = Movement;
            return PosAnder;
        }

    }
}
