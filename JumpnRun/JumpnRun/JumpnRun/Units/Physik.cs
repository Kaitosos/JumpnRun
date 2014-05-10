using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JumpnRun
{
    class Physik
    {
        private float gravity = -9.81f;
        public float mass;
        public float velocety;
        public float jumpPower;
        public bool standing;
        public float movingUD;

        public Physik(float mass, float velocety)
        {
            this.mass = mass;
            this.velocety = velocety;
            
        this.jumpPower = 0;
        this.standing = true;
        this.movingUD = 0;
        }

        public float update()
        {
            return movingUD;
        }
    }
}
