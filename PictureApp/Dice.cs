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
        private static Random randomGenerator;

        private Square2D wall;
        private Square2D window;
        private Triangle2D roof;
        private Circle2D sun;

        // create picture
        public Dice()
        {
            randomGenerator = new Random();

            // TODO 
            // replace code below

            wall = new Square2D();
            wall.SetX(100);
            wall.SetY(300);
            wall.SetSize(200);
            wall.SetColor("Red");
            wall.MakeVisible();

            window = new Square2D();
            window.SetX(120);
            window.SetY(340);
            window.SetSize(80);
            window.SetColor("Black");
            window.MakeVisible();

            roof = new Triangle2D();
            roof.SetX(80);
            roof.SetY(60);
            roof.SetSize(240);
            roof.SetColor("Black");
            roof.MakeVisible();

            sun = new Circle2D();
            sun.SetX(360);
            sun.SetY(40);
            sun.SetColor("Yellow");
            sun.MakeVisible();
            // to be able to set breakpoint on next line
            sun.MakeVisible();
        }

        public void Roll()
        {
            int numberOfDots = randomGenerator.Next(1, 7);

            // Add code to hide or show dots
        }
    }
}
