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


namespace Inventory_Management
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            Item_score It_stock = new Item_score();
            Item_score It_unstock = new Item_score();
            Item_score It_expiring = new Item_score();
            App._stock.Clear();
            App._unstock.Clear();
            App._expiring.Clear();

           // G_stock = new ObservableCollection
            int shelf_sp;
            InitializeComponent();
            for (int i = 0; i < App._item.Count; i++)
            {
                Item_score Inter = new Item_score();
                Inter.Number = App._item[i].Number;
                Inter.Description = App._item[i].Description;
                Inter.Category = App._item[i].Category;
                Inter.Margin = App._item[i].Margin;
                Inter.Space = App._item[i].Space;
                shelf_sp = 10 - App._item[i].Space;
                Inter.Throughput = App._item[i].Throughput;
                Inter.Expiry = App._item[i].Expiry;
                Inter.Q_In = App._item[i].Q_In;
                Inter.Q_Sh = App._item[i].Q_Sh;
                Inter.score = App._item[i].Margin + shelf_sp + Inter.Throughput;
                App._stock.Add( Inter );
                App._unstock.Add( Inter );
                App._expiring.Add( Inter );
                
            }
            //App._stock.OrderBy< score >;

            var orderByResult = from s in App._stock                                
                                orderby s.score descending, s.Expiry ascending
                                select s;
            
                //ct(c => c.Count);

            int Max = App._stock.Count;
            if (App._stock.Count > 30 )
            Max = 30;            
            for (int i=0;i<Max;i++)
            {
                var mid = orderByResult.ElementAt(i);
                G_stock.Items.Add(mid);
            }
            

            var orderByResult2 = from s in App._unstock
                                orderby s.score ascending, s.Expiry descending
                                select s;

            
            Max = App._unstock.Count;
            if (App._unstock.Count > 30)
                Max = 30;
            for (int i = 0; i < Max; i++)
            {
                var mid = orderByResult2.ElementAt(i);
                G_unstock.Items.Add(mid);
            }


            var orderByResult3 = from s in App._expiring
                                 orderby s.Expiry ascending, s.score descending
                                 select s;
            

            Max = App._unstock.Count;
            if (App._stock.Count > 30)
                Max = 30;
            for (int i = 0; i < Max; i++)
            {
                var mid = orderByResult3.ElementAt(i);
                G_expiring.Items.Add(mid);
            }



        }

        

        private void do_nothing(object sender, SelectionChangedEventArgs e)
        {


        }

        public void fillDataGrid()
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Main = new MainWindow(0);
            Main.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Main.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_s_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SP_Details.DataContext = G_stock.SelectedItem;
            Category_v.DataContext = G_stock.SelectedItem;            
        }

        private void DataGrid_u_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SP_Details.DataContext = G_unstock.SelectedItem;
            Category_v.DataContext = G_unstock.SelectedItem;            
        }

        private void DataGrid_e_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SP_Details.DataContext = G_expiring.SelectedItem;
            Category_v.DataContext = G_expiring.SelectedItem;            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window7 window7 = new Window7();
            window7.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window7.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (Nav.SelectedIndex)
            {
                case 1:
                    Window7 Navig = new Window7();
                    Navig.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Navig.Show();
                    this.Close();
                    break;
                case 2:
                    MainWindow Main = new MainWindow(0);
                    Main.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Main.Show();
                    this.Close();
                    break;
                case 3:
                    Window3 Win3 = new Window3();
                    Win3.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Win3.Show();
                    this.Close();
                    break;
            }
            
        }

        private void Tbx_v_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Sl_S_v_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Sl_P_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Sl_T_v_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void do_nothing(object sender, MouseButtonEventArgs e)
        {

        }
    }
    
}
