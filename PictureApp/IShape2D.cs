using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    interface IShape2D
    {
        string GetColor();
        bool IsVisible();
        int GetSize();
        int GetX();
        int GetY();
        void MakeVisible();
        void MakeInVisible();
        void SetColor(string color);
        void SetSize(int size);
        void SetX(int value);
        void SetY(int value);


    }
}
