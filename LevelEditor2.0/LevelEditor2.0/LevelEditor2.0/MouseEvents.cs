using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LevelEditor2._0
{
    class MouseEvents
    {

        MouseState ms;

        ButtonState oldMouseLeftButtonState = ButtonState.Released;
        ButtonState oldMouseRightButtonState = ButtonState.Released;
        ButtonState oldMouseMiddleButtonState = ButtonState.Released;
        public delegate void PointDelegate(Point p);
        public static event PointDelegate OnMousePress, OnMouseRelease, OnMouseMoved, OnMouseRightPress, OnMouseMiddlePress, OnMouseMiddleMoved;

        public MouseEvents()
        {

        }
        public Point getMousePos()
        {
            return new Point(ms.X, ms.Y);
        }
        public void Update()
        {
            ms = Mouse.GetState();
            Point point = new Point(ms.X, ms.Y);
            if (oldMouseLeftButtonState == ButtonState.Released && ms.LeftButton == ButtonState.Pressed && OnMousePress != null)
                OnMousePress(point);
            else if (oldMouseLeftButtonState == ButtonState.Pressed && ms.LeftButton == ButtonState.Released && OnMouseRelease != null)
                OnMouseRelease(point);
            else if (oldMouseLeftButtonState == ButtonState.Pressed && ms.LeftButton == ButtonState.Pressed && OnMouseMoved != null)
                OnMouseMoved(point);
            //RightMouseButton
            else if (oldMouseRightButtonState == ButtonState.Released && ms.RightButton == ButtonState.Pressed && OnMouseRightPress != null)
                OnMouseRightPress(point);
            //MiddleMouseButton
            else if (oldMouseMiddleButtonState == ButtonState.Released && ms.MiddleButton == ButtonState.Pressed && OnMouseMiddlePress != null)
                OnMouseMiddlePress(point);
            else if (oldMouseMiddleButtonState == ButtonState.Pressed && ms.MiddleButton == ButtonState.Pressed && OnMouseMiddleMoved != null)
                OnMouseMiddleMoved(point);
            oldMouseRightButtonState = ms.RightButton;
            oldMouseMiddleButtonState = ms.MiddleButton;
            oldMouseLeftButtonState = ms.LeftButton;
        }
    }
}
