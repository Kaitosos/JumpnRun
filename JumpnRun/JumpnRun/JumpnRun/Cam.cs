using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace JumpnRun
{
    class Cam
    {
        private float zoom = 1f;
        /// <summary>
        /// Position der Kamera.
        /// </summary>
        public Vector2 Position
        {
            get { return position; }
            set { position = value; }
        }
        private Vector2 position;

        public void Update(Vector2 movement)
        {
            this.position.X += movement.X;
            this.position.Y += movement.Y;
        }
        public void SetSpawn()
        {
            this.position = new Vector2(0, 0);
        }
        public void ZoomOut()
        {
            this.zoom = 0.3f;
        }
        public void ZoomIn()
        {
            this.zoom = 2f;
        }
        public void ZoomNormal()
        {
            this.zoom = 1f;
        }
        public Matrix GetMatrix()
        {
            return Matrix.CreateTranslation(new Vector3(position, 0)) * Matrix.CreateScale(zoom);
        }
    }
}
