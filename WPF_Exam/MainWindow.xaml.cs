using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using Newtonsoft.Json;

namespace WPF_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string urlSW = "https://swapi.co/api/people/";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LoadClick(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(page.Text))
            {
                MessageBox.Show("Страница не введена!");
            }
            else
            {
                int pnum = 0;
                int.TryParse(page.Text, out pnum);
                WebClient webClient = new WebClient();
                string json = webClient.DownloadString(urlSW);
                RootObject root = JsonConvert.DeserializeObject<RootObject>(json);
                card.Items.Add(root);
            }
        }
    }
}
