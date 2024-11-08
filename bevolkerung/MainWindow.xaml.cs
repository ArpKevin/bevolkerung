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

            List<Bevolkerung> citizens = new();

            using StreamReader sr = new(@"..\..\..\src\bevölkerung.txt");

            _ = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                citizens.Add(new(sr.ReadLine()));
            }

            dataContainer.ItemsSource = citizens.Select(x => x.Id);
            hanySor.Content = $"{citizens.Count()} sora van a listának.";
            var elsoSor = citizens.First(); 
            elsoSorAdatai.Content = $"{elsoSor.Id} {elsoSor.Nem} {elsoSor.SzuletesiEv} {elsoSor.Suly} {elsoSor.Magassag} {elsoSor.Dohanyzik} {elsoSor.Nemzetiseg} {elsoSor.Nepcsoport} {elsoSor.Tartomany} {elsoSor.NettoJovedelem} {elsoSor.IskolaiVegzettseg} {elsoSor.PolitikaiNezet} {elsoSor.AktivSzavazo} {elsoSor.SorFogyasztasEvente} {elsoSor.KrumpliFogyasztasEvente}";
        }
    }
}