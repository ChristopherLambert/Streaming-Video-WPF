using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M8_Demo2
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        MediaPlayer mp = new MediaPlayer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            mp.Open(new Uri(@"C:\Users\chris\Videos\teste.mp4"));
            
            VideoDrawing vd = new VideoDrawing();
            vd.Player = mp;
            vd.Rect = new Rect(0, 0, 100, 100);

            DrawingBrush db = new DrawingBrush(vd);

       
                btnVideo5.Background = db;
          
            mp.Play();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            mp.Stop();
        }

        private void btnVideo5_Click(object sender, RoutedEventArgs e)
        {
            mp.Play();
        }
    }
}
