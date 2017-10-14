using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Smart_Busses
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Station[] items;
        public MainWindow()
        {
            InitializeComponent();

            Station.InitStations();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MapPolyline poly = new MapPolyline();
            var lc = new LocationCollection();
            poly.Stroke = new SolidColorBrush(Colors.Blue);
            poly.StrokeThickness = 5;
            poly.Opacity = 0.7;
            foreach (var item in items)
            {
                lc.Add(new Microsoft.Maps.MapControl.WPF.Location(item.location.x, item.location.y));
            }
            map.Children.Add(poly);
        }
    }
}
