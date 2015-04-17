
using LevelEditor2._0.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor2._0.Utilities
{
    class Menu
    {
        List<Utilities.Button> buttonList = new List<Utilities.Button>();

        public Menu(Vector2 menuPosition, int nbrOfButtons)
        {
            Console.WriteLine("Menu create at " + menuPosition);
            //Rectangle rect;
            for (int i = 0; i < nbrOfButtons; i++)
            {
                //rect = new Rectangle((int)menuPosition.X, (int)menuPosition.Y + (ResManager.tempButton.Height * i), ResManager.tempButton.Width, ResManager.tempButton.Height);
                Vector2 tempVector = new Vector2(menuPosition.X, menuPosition.Y + (ResManager.tempButton.Height * i));
                Utilities.Button tempButton = new Utilities.Button(ResManager.tempButton, tempVector);
                tempButton.setText("Button " + i);
                buttonList.Add(new Utilities.Button(ResManager.tempButton, tempVector));
                Console.WriteLine(buttonList);
            }
        }
        //public int buttonClicked()
        //{
        //    foreach (Button b in buttonList)
        //        if (b.getColor() == Color.Yellow)
        //            //Console.WriteLine("Click button " + b.getButtonId());
        //            return b.getButtonId();
        //    return -1;
        //}
        public void hover(Point p)
        {
            foreach (Utilities.Button b in buttonList)
                if (b.mouseHoverButton())
                    b.SetColor(Color.Yellow);
                else
                    b.SetColor(Color.White);
        }
        public void Draw(SpriteBatch spriteBatch)
        {
            foreach (Utilities.Button b in buttonList)
                b.Render(spriteBatch);
        }
    }
}
