using System;
using System.Collections;
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

namespace HashTableApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            //add
            hashtable.Add(key.Text,value.Text);
            key.Text = "";
            value.Text = "";
                      
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //remove key only
            hashtable.Remove(key.Text);
            key.Text = "";

        }

        private void ShowAll_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            //showall
            foreach(string key in icollection)
            {
                MessageBox.Show(hashtable[key].ToString());
            }
        }
    }
}
