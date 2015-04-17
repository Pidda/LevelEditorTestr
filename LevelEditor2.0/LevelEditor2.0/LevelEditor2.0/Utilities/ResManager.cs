using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor2._0.Utilities
{
    static class ResManager
    {
        public static Texture2D create, cameraInactive, cameraActive, userMenu, tileButton, fanButton, enemyButton, propertySheet, tempButton;

        public static void LoadContent(ContentManager Content)
        {

            tempButton = Content.Load<Texture2D>("tempButton");
            
            create = Content.Load<Texture2D>("Add");
            cameraInactive = Content.Load<Texture2D>("Camera_inactive");
            cameraActive = Content.Load<Texture2D>("Camera_active");
            userMenu = Content.Load<Texture2D>("Hud_texture");
            //Tiles
            tileButton = Content.Load<Texture2D>("Brick_Tile");
            //entities. Fans etc
            fanButton = Content.Load<Texture2D>("fan_Texture");
            propertySheet = Content.Load<Texture2D>("prop_sheetAll");
            //Enemys
            enemyButton = Content.Load<Texture2D>("enemys");
        }
    }
}
