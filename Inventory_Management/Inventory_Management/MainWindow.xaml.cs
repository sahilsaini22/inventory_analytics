using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
namespace Inventory_Management
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Item Selected_item = new Item();
        
        public MainWindow(int back)
        {
            InitializeComponent();
            Category.DataContext = new ComboView();
            if ( back > 0)
            {
                
                for (int i = 0; i < App._item.Count; i++)
                {
                    if (App._item[i].Number == back)
                    {
                        SP_Details.DataContext = App._item[i];
                        Category.DataContext = App._item[i];
                        Edit.IsEnabled = true;                        
                        break;
                    }
                }
            }

            if (App._selected.Count > 0)
            {
                for (int i = 0; i < App._item.Count; i++)
                {
                    if (App._item[i].Number == App._selected[0].Number)
                    {

                        SP_Details.DataContext = App._item[i];
                        Category.DataContext = App._item[i];
                       
                        App._selected.Clear();
                        Tbx_Des1.IsEnabled = false;
                        Category.IsEnabled = false;
                        Exp.IsEnabled = false;
                        Sl_S.IsEnabled = false;
                        Sl_St.IsEnabled = false;
                        Sl_P.IsEnabled = false;
                        Sl_Pt.IsEnabled = false;
                        Sl_T.IsEnabled = false;
                        Sl_Tt.IsEnabled = false;
                        T_Quan.IsEnabled = false;
                        T_Quan_Sh.IsEnabled = false;                       
                        Edit.IsEnabled = true;
                        Delete.IsEnabled = true;
                        break;

                    }
                }
            }
        }

        
        
        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }


        private void Des_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            Tbx_Num.Text = "";
            Tbx_Des.Text = "";
            Tbx_Num.IsEnabled = true;
            Tbx_Des.IsEnabled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {        
                Window1 Analytics = new Window1();
                Analytics.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                Analytics.Show();
                this.Close();
           
        }

        

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            int item = 0;            
            bool found = false;            

            String Str1 = Tbx_Num.ToString();
            String Str2 = Tbx_Des.ToString();
            if ( Str1 == "System.Windows.Controls.TextBox") 
            {
                if (Str2 == "System.Windows.Controls.TextBox")
                {
                    String message = "Enter an Item Number or Item Description to search";
                    String title = "No Input Provided!";
                    Move.IsEnabled = false;
                    Edit.IsEnabled = false;                 
                }
                else
                {                    
                    for (int i = 0; i < App._item.Count; i++)
                    {
                        if ( App._item[i].Description == Tbx_Des.Text )
                        {
                            Category.DataContext = App._item[i];
                            Lbx_dummyitems.Visibility = Visibility.Hidden;
                            Move.IsEnabled = true;
                            Edit.IsEnabled = true;
                            break;
                        }
                    }                    
                }

            }
            else
            {                
                int n = Convert.ToInt32(Tbx_Num.Text);
                
                for (int i = 0; i < App._item.Count; i++)
                {
                    if (App._item[i].Number == n)
                    {
                        found = true;
                        SP_Details.DataContext = App._item[i];
                        Category.DataContext = App._item[i];
                        Tbx_Num.DataContext = null;
                        Move.IsEnabled = true;
                        Edit.IsEnabled = true;
                        break;
                    }
                }
            }
            if (found == true && Str2 == "System.Windows.Controls.TextBox" ) 
                {
             
                }
                else
                {
                    if ( item == 0 && Str2 == "System.Windows.Controls.TextBox")
                        System.Windows.MessageBox.Show("No entry with this key found!");
                    Move.IsEnabled = false;
                    Edit.IsEnabled = false;
            }

            


        }

        private void MessageBox(string v)
        {
            throw new NotImplementedException();
        }

        
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void T_Quan_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void T_Quan_Sh_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        
        

        
        

        private void B_An_Click(object sender, RoutedEventArgs e)
        {
            Window1 Analytics = new Window1();
            Analytics.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Analytics.Show();
            this.Close();
        }
       
        private void B_Up_Sub(object sender, RoutedEventArgs e)
        {

        }

        private void B_Up_Add(object sender, RoutedEventArgs e)
        {

        }

        private void Reset_Edit(object sender, RoutedEventArgs e)
        {
            Edit.IsEnabled = false;
            Delete.IsEnabled = true;
            Tbx_Des1.IsEnabled = true;
            Category.IsEnabled = true;
            Exp.IsEnabled = true;
            Sl_S.IsEnabled = true;
            Sl_St.IsEnabled = true;
            Sl_P.IsEnabled = true;
            Sl_Pt.IsEnabled = true;
            Sl_T.IsEnabled = true;
            Sl_Tt.IsEnabled = true;
            T_Quan.IsEnabled = true;
        }
        private void ViewW_Click(object sender, RoutedEventArgs e)
        {

            MainWindow Main = new MainWindow(0);
            Main.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Main.Show();
            this.Close();

        }

        private void AddP_Click(object sender, RoutedEventArgs e)
        {
            Window3 Add = new Window3();
            Add.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Add.Show();
            this.Close();
        }

        private void Move_Items(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(Tbx_Num1.Text);

            Window5 Add = new Window5(num);
            Add.ShowDialog();
            
            MainWindow Re = new MainWindow(num);
            Re.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.Close();
            Re.ShowDialog();

        }


        private void Sl_P_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Delete_click(object sender, RoutedEventArgs e)
        {
            Edit.IsEnabled = false;
            Delete.IsEnabled = false;          
            Tbx_Des1.IsEnabled = false;
            Category.IsEnabled = false;
            Exp.IsEnabled = false;
            Sl_S.IsEnabled = false;
            Sl_St.IsEnabled = false;
            Sl_P.IsEnabled = false;
            Sl_Pt.IsEnabled = false;
            Sl_T.IsEnabled = false;
            Sl_Tt.IsEnabled = false;
            App._item.Remove(App._item.Where(i => i.Number == Convert.ToInt32(Tbx_Num1.Text)).Single());
            Move.IsEnabled = false;
            Edit.IsEnabled = false;
            Delete.IsEnabled = false;
            System.Windows.MessageBox.Show("Item Deleted");
            SP_Details.DataContext = null;
            Category.DataContext = null;

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            switch (Nav.SelectedIndex)
            {
                case 0:
                    Window1 Navig = new Window1();
                    Navig.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Navig.Show();
                    this.Close();
                    break;
                case 1:
                    Window7 Cus = new Window7();
                    Cus.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Cus.Show();
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void TextBoxNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex r = new Regex("^[0-9]+$");
            if ((Tbx_Num.Text != "") && (! r.IsMatch(Tbx_Num.Text)))
            {                
                Tbx_Num.Text = new string(Tbx_Num.Text.Where(c => char.IsDigit(c)).ToArray());
                Tbx_Num.Select(Tbx_Num.Text.Length, 0);
            }
            if (Tbx_Num.Text == "")
            {
                Tbx_Des.IsEnabled = true;
            }
            else
            {
                Tbx_Des.Text = "";
                Tbx_Des.IsEnabled = false;
            }


        }

        private void Tbx_Des_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Tbx_Des.Text == "")
            {
                Tbx_Num.IsEnabled = true;
                Lbx_dummyitems.Visibility = Visibility.Hidden;
                Move.IsEnabled = false;
                Edit.IsEnabled = false;
            }
            else
            {
                Tbx_Num.Text = "";
                Tbx_Num.IsEnabled = false;                             
            }

            if (Tbx_Des.Text != "")
            {
                string input = Tbx_Des.Text.ToLower();
                

                string inp = Tbx_Des.Text.ToLower();
                if (Tbx_Des.Text.ToString() == null)
                {
                    Lbx_dummyitems.ItemsSource = null;
                    Move.IsEnabled = false;
                    Edit.IsEnabled = false;
                }
                else
                {
                    var lst = from m in App._item where m.Description.ToLower().Contains(input) select m;
                    Lbx_dummyitems.ItemsSource = lst;
                    Lbx_dummyitems.Visibility = Visibility.Visible;                    
                }
            }               
        }

    private void Lbx_dummyitems_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {        
            var a = Lbx_dummyitems.SelectedItem;
            Lbx_dummyitems.SelectedIndex = -1;            
            SP_Details.DataContext = a;
            Category.DataContext = a;
            Move.IsEnabled = true;
            Edit.IsEnabled = true;
            Lbx_dummyitems.ItemsSource = null;
            Tbx_Des.Text = "";            
            Lbx_dummyitems.Visibility = Visibility.Hidden;
        }
}

    
}
