using LevelEditor2._0.GUI;
using LevelEditor2._0.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace LevelEditor2._0
{
    class Main 
    {
        public Camera camera;
        UserFace userFace;
        Button create; //<-- create?

        //------------------------------
        Utilities.Menu popUpMenu;
        bool showMenu;
        
        MouseEvents mouseEvents;
        public Main()
        {
            MouseEvents.OnMouseRightPress += MouseEvents_OnMouseRightPress;
            MouseEvents.OnMousePress += MouseEvents_OnMousePress;
            MouseEvents.OnMouseMoved += MouseEvents_OnMouseMoved;
            MouseEvents.OnMouseRelease += MouseEvents_OnMouseRelease;
        }

        private void MouseEvents_OnMouseRelease(Point p)
        {
        }

        private void MouseEvents_OnMouseMoved(Point p)
        {
        }

        private void MouseEvents_OnMousePress(Point p)
        {
        }

        private void MouseEvents_OnMouseRightPress(Point p)
        {
            showMenu = true;
            Console.WriteLine("Right click" + showMenu);
            Vector2 temp = new Vector2(p.X, p.Y);
            popUpMenu = new Utilities.Menu(temp, 5);
            showMenu = true;
        }

        public void LoadContent(ContentManager Content, Viewport view)
        {
            camera = new Camera(view);
            camera.active = true;
            userFace = new UserFace();
            userFace.LoadContent(Content, view);

            create = new Button(ResManager.create, new Vector2(500,200));
            //create.SetPos(500, 200);
            create.SetRect(150, 70);
            create.SetColor(Color.Blue);
        }
        public void Update(float delta)
        {
            camera.Update();
            userFace.Update(delta,this);

        }
        public void Render(SpriteBatch batch)
        {

            batch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, camera.transForm);
            //Draw something here
            create.Render(batch);
            if(showMenu)
                popUpMenu.Draw(batch);
            batch.End();
            userFace.Render(batch);
        }
    }
}
