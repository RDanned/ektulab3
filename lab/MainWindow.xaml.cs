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
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Data;

namespace lab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Route> routes = new ObservableCollection<Route>();

        public MainWindow()
        {
            InitializeComponent();
            Loaded += new RoutedEventHandler(Window1_Loaded);
            DataContext = this;


        }

        void Window1_Loaded(object sender, RoutedEventArgs e)
        {

            this.routes.Add(
                new Route()
                .setName("Тур по Парижу")
                .setImage("E:/ektu/course1/progtech/lab3/lab/img/paris.jpg")
                .setDescription("Увлекательный тур по Парижу")
            );

            this.routes.Add(
                new Route()
                .setName("Тур по Москве")
                .setImage("E:/ektu/course1/progtech/lab3/lab/img/moskau.jpg")
                .setDescription("Увлекательный тур по Москве")
            );

            this.routes.Add(
                new Route()
                .setName("Тур по Лондону")
                .setImage("E:/ektu/course1/progtech/lab3/lab/img/london.jpg")
                .setDescription("Увлекательный тур по Москве")
            );

            RoutesDataGrid.ItemsSource = routes;

            Style rowStyle = new Style(typeof(DataGridRow));
            rowStyle.Setters.Add(new EventSetter(DataGridRow.MouseDoubleClickEvent,
                                 new MouseButtonEventHandler(OpenRoute)));
            RoutesDataGrid.RowStyle = rowStyle;
        }

        void OpenRoute(object sender, RoutedEventArgs e)
        {
            DataGridRow row = sender as DataGridRow;

            Route route = row.Item as Route;

            RouteDetail detailPage = new RouteDetail(route);

            detailPage.Show();
        }
    }
}
