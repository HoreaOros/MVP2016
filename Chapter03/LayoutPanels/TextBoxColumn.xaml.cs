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
using Microsoft.Win32;

namespace LayoutPanels
{
    /// <summary>
    /// Interaction logic for TextBoxColumn.xaml
    /// </summary>

    public partial class TextBoxColumn : System.Windows.Window
    {

        public TextBoxColumn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Alege un fisier..";
            ofd.CheckFileExists = true;
            
            ofd.ShowDialog(this);

            txtHome.Text = ofd.FileName;
            
        }
    }
}