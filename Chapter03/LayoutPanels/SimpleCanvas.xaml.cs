using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LayoutPanels
{
    /// <summary>
    /// Interaction logic for SimpleCanvas.xaml
    /// </summary>

    public partial class SimpleCanvas : System.Windows.Window
    {

        public SimpleCanvas()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();

            Rectangle r = new Rectangle();
            r.Width = rnd.Next(150);
            r.Height = rnd.Next(50);
            r.Stroke = Brushes.Black;
            r.StrokeThickness = 3;

            r.SetValue(Canvas.LeftProperty, (double)rnd.Next((int)(this.ActualWidth)));
            r.SetValue(Canvas.TopProperty, (double)rnd.Next((int)(this.ActualHeight)));
            mycanvas.Children.Add(r);
        }
    }
}