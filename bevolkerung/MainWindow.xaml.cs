using System.IO;
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

namespace Bevolkerung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<bevolkerung> citizens = new();

            using StreamReader sr = new(@"..\..\..\src\bevölkerung.txt");

            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                citizens.Add(new(sr.ReadLine()));
            }

            dataContainer.ItemsSource = citizens;
            hanySor.Content = $"{citizens.Count()} sora van a listának.";
            var elsoSor = citizens.First();
            elsoSorAdatai.Content = elsoSor.ToString();
        }
    }
}