using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    class Picture
    {
        // fields
        private Square2D wall;

        // add your code here


        // create picture
        public Picture()
        {
            wall = new Square2D();
            wall.X = 100;
            wall.Y = 300;
            wall.Size = 200;
            wall.Color = "Red";
            wall.IsVisible = true;

           // and add code here too
        }
    }
}
