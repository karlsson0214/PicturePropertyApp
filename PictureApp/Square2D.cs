using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureApp
{
    /// <summary>
    /// An object of this class represents a geometric square.
    /// </summary>
    class Square2D : IShape2D
    {
        private int x = 50;
        private int y = 100;
        private int size = 80;
        private bool isVisible = false;
        private string color = "Blue";

        /// <summary>
        /// Make a square object.
        /// </summary>
        public Square2D()
        {
            
        }

        /// <summary>
        /// Get color as a string.
        /// </summary>
        /// <returns>Color as a string.</returns>
        /// See <see cref="Windows.UI.Colors"/> for valid color strings.
        /// Or see: https://docs.microsoft.com/en-us/uwp/api/windows.ui.colors
        public string GetColor()
        {
            return color;
        }
        /// <summary>
        /// Get the size of the object.
        /// </summary>
        /// <returns>Size of object in pixels.</returns>
        public int GetSize()
        {
            return size;
        }

        /// <summary>
        /// Get the x-coordinate of the upper left corner.
        /// </summary>
        /// <returns>x-coordinate in pixels</returns>
        public int GetX()
        {
            return x;
        }

        /// <summary>
        /// Get the y-coordinate of the upper left corner.
        /// OBS y is 0 at the top of the canvas and increases downwards.
        /// </summary>
        /// <returns>y-coordinate in pixels</returns>
        public int GetY()
        {
            return y;
        }

        /// <summary>
        /// Returns true if this shape is visible on the canvas.
        /// </summary>
        /// <returns></returns>
        public bool IsVisible()
        {
            return isVisible;
        }

        /// <summary>
        /// Make this shape visible.
        /// </summary>
        public void MakeInVisible()
        {
            isVisible = false;
            Update();
        }

        /// <summary>
        /// Make this shape invisible.
        /// </summary>
        public void MakeVisible()
        {
            isVisible = true;
            Update();
        }

        /// <summary>
        /// Set color as a string. Invalid value will make shape black.
        /// </summary>
        /// <param name="color">Color as a string, for example: "Blue", "Green", "Red"</param>
        /// See <see cref="Windows.UI.Colors"/> for valid color strings.
        /// Or see: https://docs.microsoft.com/en-us/uwp/api/windows.ui.colors
        public void SetColor(string color)
        {
            this.color = color;
            Update();
        }
        /// <summary>
        /// Set the size of the object.
        /// </summary>
        /// <param name="size">The new size in pixels.</param>
        public void SetSize(int size)
        {
            this.size = size;
            Update();
        }

        /// <summary>
        /// Set the x-coordinate of the upper left corner.
        /// </summary>
        /// <param name="value">New x-coordinate in pixels from top of canvas.</param>
        public void SetX(int value)
        {
            x = value;
            Update();
        }
        /// <summary>
        /// Set the y-coordinate of the upper left corner.
        /// OBS y is 0 at the top of the canvas and increases downwards.
        /// </summary>
        /// <param name="value">New y-coordinate in pixels from top of canvas.</param>
        public void SetY(int value)
        {
            y = value;
            Update();
        }

        // Update changes made to this object on screen.
        private void Update()
        {
            CanvasModel.GetCanvasModel().Update(this);
        }
    }
}
