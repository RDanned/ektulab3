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
using System.Windows.Shapes;

namespace lab
{
    /// <summary>
    /// Interaction logic for RouteDetail.xaml
    /// </summary>
    public partial class RouteDetail : Window
    {
        public RouteDetail(Route route)
        {
            InitializeComponent();

            RoutePreview.Source = new BitmapImage(new Uri(route.imagePath));
            RouteName.Content = route.name;
            RouteDescription.Text = route.description;
        }
    }
}
