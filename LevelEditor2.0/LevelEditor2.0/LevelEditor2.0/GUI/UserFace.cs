
using LevelEditor2._0.Utilities;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor2._0.GUI
{
    class UserFace
    {
        Camera camera;
        public Button create, inactiveCamera, activeCamera, sideMenu, bottomMenu, tileButton, fanButton,enemyButton,propSheet;
        public UserFace()
        {

        }
        public void LoadContent(ContentManager Content, Viewport view)
        {
            camera = new Camera(view);

            create = new Button(ResManager.create, new Vector2(10,10));
            create.SetPos(10, 10);
            create.SetRect(30, 30);
            create.SetColor(Color.BurlyWood);

            inactiveCamera = new Button(ResManager.cameraInactive, new Vector2(80, 650));
            //inactiveCamera.SetPos(80,650);
            inactiveCamera.SetRect(50, 50);
            inactiveCamera.SetColor(Color.Black);

            activeCamera = new Button(ResManager.cameraActive, new Vector2(10, 650));
            activeCamera.SetPos(10,650);
            activeCamera.SetRect(50,50);
            activeCamera.SetColor(Color.White);

            //Menu props
            sideMenu = new Button(ResManager.userMenu, new Vector2(0, 0));
            //sideMenu.SetPos(0,0);
            sideMenu.SetRect(150,720);
            sideMenu.SetColor(Color.White);

            bottomMenu = new Button(ResManager.userMenu, new Vector2(150, 620));
            bottomMenu.SetPos(150,620);
            bottomMenu.SetRect(1130,100);
            bottomMenu.SetColor(Color.White);

            //Tile
            tileButton = new Button(ResManager.tileButton, new Vector2(10, 60));
            //tileButton.SetPos(10, 60);
            tileButton.SetRect(30, 30);
            tileButton.SetColor(Color.White);

            //entitys
            fanButton = new Button(ResManager.fanButton, new Vector2(10, 90));
            //fanButton.SetPos(10, 90);
            fanButton.SetRect(30, 30);
            fanButton.SetColor(Color.White);

            propSheet = new Button(ResManager.propertySheet, new Vector2(10, 150));
            //propSheet.SetPos(10, 150);
            propSheet.SetRect(30, 30);
            propSheet.SetColor(Color.White);

            //Enemys
            enemyButton = new Button(ResManager.enemyButton, new Vector2(10, 120));
            //enemyButton.SetPos(10, 120);
            enemyButton.SetRect(30, 30);
            enemyButton.SetColor(Color.White);

        }
        public void Update(float delta, Main main)
        {
            //Inaktiverar Main kameran
            if (inactiveCamera.Press())
            {
                main.camera.active = false;
            }
            //Återaktiverar main kameran
            if (activeCamera.Press())
            {
                main.camera.active = true;  
            }
            camera.Update();
        }
        public void Render(SpriteBatch batch)
        {
            batch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, null, null, null, null, camera.transForm);
            //Put in draw logic
            sideMenu.Render(batch);
            bottomMenu.Render(batch);
            create.Render(batch);
            tileButton.Render(batch);
            fanButton.Render(batch);
            enemyButton.Render(batch);

            if (fanButton.Press())
            {
                propSheet.Render(batch);
            }

            inactiveCamera.Render(batch);
            activeCamera.Render(batch);
            
            batch.End();
        }
    }
}
