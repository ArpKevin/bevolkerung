﻿using System.IO;
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

            List<Allampolgar> lakossag = new();

            using StreamReader sr = new(@"..\..\..\src\bevölkerung.txt");

            _ = sr.ReadLine();

            string? line;
            while ((line = sr.ReadLine()) != null) lakossag.Add(new Allampolgar(line));

            dataContainerListbox.ItemsSource = lakossag.Select(l => l.ToString(true));
            hanySor.Content = $"{lakossag.Count()} sora van a listának.";
            var elsoSor = lakossag.First();
            elsoSorAdatai.Content = elsoSor.ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}