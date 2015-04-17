using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor2._0.Utilities
{
    class Button
    {
        private Vector2 pos;
        private int width, height;
        private Texture2D tex;
        private Color color;
        private Rectangle srcRect;
        
        //-----------------
        private SpriteFont font;
        public String buttonText = null;

        public Button(Texture2D tex, Vector2 pos)
        {
            this.tex = tex;
            this.pos = pos;
        }
        public void SetPos(float x, float y)
        {
            pos.X = x;
            pos.Y = y;
        }
        public void SetRect(int width, int height)
        {
            this.height = height;
            this.width = width;
        }
        public void SetColor(Color color)
        {
            this.color = color;
        }
        public void setText(String text)
        {
            this.buttonText = text;
        }
        public Color getColor()
        {
            return color;
        }
        public void setFont(SpriteFont font)
        {
            this.font = font;
        }
        public Rectangle ButtonRect()
        {
            return new Rectangle((int)pos.X, (int)pos.Y, width, height);
        }
        public bool Press()
        {
            if (CheckMouseClick(ButtonRect()))
            {
                return true;
            }
            return false;
        }
        public bool mouseHoverButton()
        {
            if (ButtonRect().Contains(Mouse.GetState().X, Mouse.GetState().Y))
                return true;
            else return false;
        }
        private bool CheckMouseClick(Rectangle rect)
        {
            //Checks if the Mouse is inside the rectangel you choose
            if (rect.Contains(Mouse.GetState().X, Mouse.GetState().Y))
            {
                //Checkes that the Mouse makes a click
                if (Mouse.GetState().LeftButton == ButtonState.Pressed)
                {
                    return true;
                }
            }
            return false;
        }
        public void Render(SpriteBatch batch)
        {
            batch.Draw(tex, ButtonRect(), color);
            if (buttonText != null)
            {

                batch.DrawString(font, buttonText, pos, color);
            }
        }
    }
}
