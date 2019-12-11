using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

using Microsoft.Toolkit.Uwp.Helpers;
using Windows.Foundation;

namespace PictureApp
{
    /// <summary>
    /// A canvas to add shapes to.
    /// 
    /// Changes made will be reflected in the user interface.
    /// 
    /// Singelton
    /// </summary>
    class CanvasModel
    {
        private static CanvasModel instance;
        private Canvas canvasView;
        private Dictionary<object, Shape> shapesMap = new Dictionary<object, Shape>();

        private CanvasModel()
        {
            canvasView = MainPage.CanvasView;
        }

        /// <summary>
        /// Get the single canvas model.
        /// 
        /// Singelton get instance. 
        /// </summary>
        /// <returns>Returns instance, or null if user interface is not ready.</returns>
        public static CanvasModel GetCanvasModel()
        {
            if (instance == null)
            {
                if (MainPage.CanvasView == null)
                {
                    return null;
                }
                instance = new CanvasModel();
            }
            return instance;
        }
        /// <summary>
        /// Update the specified shape int the user interface.
        /// 
        /// Will add new shapes and change existing.
        /// 
        /// Only visible shapes will be cept. Invisible shapes will be removed.
        /// </summary>
        /// <param name="shape2D">The shape to update.</param>
        public void Update(IShape2D shape2D)
        {
            // only visible objects in shapeMap
            Shape shape;
            if (!shapesMap.ContainsKey(shape2D))
            {
                // shape2D not in shapesMap
                if (shape2D.IsVisible())
                {
                    // shape not added yet, then add it
                    if (shape2D is Square2D)
                    {
                        shape = new Rectangle();
                    }
                    else if (shape2D is Circle2D)
                    {
                        shape = new Ellipse();
                    }
                    else if (shape2D is Triangle2D)
                    {
                        shape = new Polygon();
                    }
                    else
                    {
                        // no such type shape2D
                        return;
                    }

                    canvasView.Children.Add(shape);
                    shapesMap.Add(shape2D, shape);
                }
                else
                {
                    return;
                }
            }
            else
            {
                // shape2D in shapesMap
                // find object
                shape = shapesMap[shape2D];
                if (!shape2D.IsVisible())
                {
                    // remove invisible object
                    shapesMap.Remove(shape);
                    canvasView.Children.Remove(shape);
                    return;
                } 
            }

            // update size
            // Triangles are treated differently from circles and squares
            if (shape2D is Triangle2D && shape is Polygon)
            {
                PointCollection points = new PointCollection();
                // lower left
                points.Add(new Point(0, shape2D.GetSize()));
                // lower right
                points.Add(new Point(shape2D.GetSize(), shape2D.GetSize()));
                // upper middle
                points.Add(new Point(shape2D.GetSize() / 2, 0));
                (shape as Polygon).Points = points;
            }
            else
            {
                shape.Width = shape2D.GetSize();
                shape.Height = shape2D.GetSize();
            }

            //default color if color string is invalid
            Windows.UI.Color color;
            try
            {
                color = shape2D.GetColor().ToColor();
            }
            catch (FormatException)
            {
                // us default color
                color = Windows.UI.Colors.Black;
            }

            // update color
            shape.Fill = new SolidColorBrush(color);

            // update position
            Canvas.SetTop(shape, shape2D.GetY());
            Canvas.SetLeft(shape, shape2D.GetX());
        }
    }
}
