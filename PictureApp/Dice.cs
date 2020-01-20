using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    class Dice
    {
        // fields
        private Square2D wall;
        private Square2D window;
        private Triangle2D roof;
        private Circle2D sun;

        // create picture
        public Dice()
        {
            wall = new Square2D();
            wall.X = 100;
            wall.Y = 300;
            wall.Size = 200;
            wall.Color = "Red";
            wall.IsVisible = true;

            window = new Square2D();
            window.X = 120;
            window.Y = 340;
            window.Size = 80;
            window.Color = "Black";
            window.IsVisible = true;

            roof = new Triangle2D();
            roof.X = 80;
            roof.Y = 60;
            roof.Size = 240;
            roof.Color = "Black";
            roof.IsVisible = true;

            sun = new Circle2D();
            sun.X = 360;
            sun.Y = 40;
            sun.Color = "Yellow";
            sun.IsVisible = true;
            // to be able to set breakpoint on next line
            sun.IsVisible = true;
        }

        public void Roll()
        {
            
        }
    }
}
