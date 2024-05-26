using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfElelmiszer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Elelmiszer> Elelmiszerek;
        public ElelmiszerContext db;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Kajak kajak = lbKajak.SelectedItem as Kajak;
            if (kajak != null && kajak.Id != 0)
            {
                int index = lbKajak.SelectedIndex;
                db.Elelmiszerek.Remove(kajak);
                db.SaveChanges();
                ReflesElelmiszerek();
                lbKajak.SelectedIndex = index < lbKajak.Items.Count ? index : lbKajak.Items.Count - 1;
            }
        }
}

