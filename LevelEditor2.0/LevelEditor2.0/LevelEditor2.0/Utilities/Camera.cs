using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor2._0.Utilities
{
    class Camera
    {
        public Matrix transForm { get; set; }
        public Viewport view { get; set; }
        public bool active { get; set; }
        public Vector2 center;
        public Camera(Viewport view)
        {
            this.view = view;
            active = false;
        }
        public void Update()
        {
            center = new Vector2(center.X, center.Y);
            transForm = Matrix.CreateScale(new Vector3(1, 1, 0)) * Matrix.CreateTranslation(new Vector3(-center.X, -center.Y, 0));
            
            if (active)
            {
                MoveCamera();
            }
        }
        private void MoveCamera()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                center.X -= 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                center.X += 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                center.Y += 5;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                center.Y -= 5;
            }
        }
    }
}
