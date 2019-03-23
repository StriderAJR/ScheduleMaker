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

namespace ScheduleMaker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        private Reference reference = new Reference();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = reference;
            RefreshCanvas();
        }

        private void RoomsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            RoomsWindow roomsWindow = new RoomsWindow(reference);
            roomsWindow.Show();
        }

        private void RefreshCanvas() {
            ScheduleCanvas.Children.Clear();

            Label lbl = new Label();
            lbl.Content = $"Создано {reference.Rooms.Count} аудиторий";

            ScheduleCanvas.Children.Add(lbl);
        }
    }
}
