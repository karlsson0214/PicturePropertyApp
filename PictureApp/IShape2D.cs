using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    interface IShape2D
    {
        string Color { get; set; }
        bool IsVisible { get; set; }
        int Size { get; set; }
        int X { get; set; }
        int Y { get; set; }

    }
}
