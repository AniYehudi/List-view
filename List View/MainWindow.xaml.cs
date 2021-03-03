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

namespace List_View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Filme
    {
        public int ID { get; set; }
        public string Numele { get; set; }
        public int Anul { get; set; }
        public string Actorul { get; set; }
        public string Regizorul { get; set; }
        public double Buget { get; set; }
    }

    public partial class MainWindow : Window
    {
        public List<Filme> produse = new List<Filme>();
        public MainWindow()
        {
            InitializeComponent();
            produse.Add(new Filme() {ID = 1, Numele = "Back in the future", Anul = 1986, Actorul = "Mark McFly", Regizorul = "Joseph Brown", Buget = 359751 });
            produse.Add(new Filme() {ID = 2, Numele = "Back in the future 2", Anul = 1988, Actorul = "Mark McFly", Regizorul = "Joseph Brown", Buget = 245862 });
            produse.Add(new Filme() {ID = 3, Numele = "Back in the future 3", Anul = 1989, Actorul = "Mark McFly", Regizorul = "Joseph Brown", Buget = 586924 });
            fillList();
        }

        private void fillList()
        {
            for(int i = 0; i < produse.Count; i++)
            {
                this.ListView1.Items.Add(produse[i]);
            }
        }

        private void clearList()
        {
            for (int i = 0; i < produse.Count; i++)
            {
                this.ListView1.Items.Remove(produse[i]);
            }
                
        }

        private void add_List(object sender, RoutedEventArgs e)
        {
            bool unique = true;
            for(int i = 0; i < produse.Count; i++)
            {
                if(Convert.ToInt32(this.textBox0.Text) == produse[i].ID)
                {
                    unique = false;
                    break;
                }
            }

            if(unique == true)
            {
                clearList();
                produse.Add(new Filme() { ID = Convert.ToInt32(this.textBox0.Text), Numele = this.textBox1.Text, Anul = Convert.ToInt32(this.textBox2.Text), Actorul = this.textBox3.Text, Regizorul = this.textBox4.Text, Buget = Convert.ToDouble(this.textBox5.Text) });
                fillList();
            }
        }

        private void removeList(object sender, RoutedEventArgs e)
        {
            int i;
            clearList();
            for(i = 0; i < produse.Count; i++)
            {
                if(Convert.ToInt32(this.textBox6.Text) == produse[i].ID)
                {
                    break;
                }
            }
            produse.RemoveAt(i);
            fillList();
        }

    }
}
