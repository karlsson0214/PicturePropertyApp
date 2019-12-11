using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PictureApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private static Canvas canvasView;
        public MainPage()
        {
            this.InitializeComponent();
            canvasView = canvas;

            MakePicture();
        }
        /// <summary>
        /// Reference to the canvas in the user interface.
        /// </summary>
        public static Canvas CanvasView
        {
            get
            {
                return canvasView;
            }
        }
        /// <summary>
        /// Create picture.
        /// </summary>
        private void MakePicture()
        {
            Picture image = new Picture();
        }
        
    }
}
