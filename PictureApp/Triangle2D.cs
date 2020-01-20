using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    class Triangle2D : IShape2D
    {
        private int x = 150;
        private int y = 50;
        private int size = 60;
        private bool isVisible = false;
        private string color = "Green";

        /// <summary>
        /// Make a triangle object.
        /// </summary>
        public Triangle2D()
        {

        }
        /// <summary>
        /// Get color as a string or set the color as a string.
        /// Invalid color string will render a black shape.
        /// 
        /// </summary>
        /// See <see cref="Windows.UI.Colors"/> for valid color strings.
        /// Or see: https://docs.microsoft.com/en-us/uwp/api/windows.ui.colors
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                if (value != null)
                {
                    color = value;
                    Update();
                }
            }
        }
        /// <summary>
        /// Read if this object is visible or set its visibility.
        /// </summary>
        public bool IsVisible
        {
            get
            {
                return isVisible;
            }
            set
            {
                isVisible = value;
                Update();
            }

        }
        /// <summary>
        /// Get or set the x-coordinate of the upper left corner.
        /// </summary>
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                Update();
            }
        }
        /// <summary>
        /// Get or set the y-coordinate of the upper left corner.
        /// OBS y is 0 at the top of the canvas and increases downwards.
        /// </summary>
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                Update();
            }
        }
        /// <summary>
        /// Get or set the size of the object.
        /// </summary>
        public int Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value > 0)
                {
                    size = value;
                    Update();
                }
            }
        }

        // Update changes made to this object on screen.
        private void Update()
        {
            CanvasModel.GetCanvasModel().Update(this);
        }
    }
}

