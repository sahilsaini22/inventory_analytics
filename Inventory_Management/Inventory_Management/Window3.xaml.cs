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
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
            Exp.DisplayDateStart = DateTime.Today;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            bool found = false;
            if (T_Quan.Text == "0" | Tbx_Des.Text == "" | Exp.SelectedDate == null | Sl_St.Text == "0" | Sl_Tt.Text == "0" | Sl_Pt.Text == "0" | T_Quan.Text == "0")
            {
                MessageBox.Show("Please fill-in all the fields");
            }
            else
            {
                int xd;
                try
                {
                    Int32.TryParse(Tbx_Num.Text, out xd);
                    int nb = Convert.ToInt32(Tbx_Num.Text);

                    for (int i = 0; i<App._item.Count;i++)
                    {
                        if (App._item[i].Number == nb)
                        {
                            found = true;
                        }    
                            
                    }

                    if ( found == true)
                    {
                        MessageBox.Show("Item Number already exists, please use a different item number!");
                    }
                    else
                    {
                        var newitem = new Item
                        {
                            Number = nb,
                            Description = Tbx_Des.Text,
                            Category = Cat.Text,
                            Expiry = Exp.SelectedDate,
                            Space = Convert.ToInt32(Sl_S.Value),
                            Margin = Convert.ToInt32(Sl_P.Value),
                            Throughput = Convert.ToInt32(Sl_T.Value),
                            Q_In = Convert.ToInt32(T_Quan.Text),
                            Q_Sh = 0
                        };

                        App._item.Add(newitem);
                        MessageBox.Show("Item Added!");
                        App._selected.Add(newitem);
                        MainWindow mw = new MainWindow(0);
                        mw.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                        mw.Show();
                        this.Close();
                    }
                                                          
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please fill-in a Number for 'Item Number'");
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Please fill-in a smaller number for 'Item Number'");
                }
            }
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Main = new MainWindow(0);
            Main.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Main.Show();
            this.Close();
        }


        

        private void B_An_Click(object sender, RoutedEventArgs e)
        {
            Window1 Analytics = new Window1();
            Analytics.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Analytics.Show();
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex r = new Regex("^[0-9]+$");
            if ((Tbx_Num.Text != "") && (!r.IsMatch(Tbx_Num.Text)))
            {                
                Tbx_Num.Text = new string(Tbx_Num.Text.Where(c => char.IsDigit(c)).ToArray());
                Tbx_Num.Select(Tbx_Num.Text.Length, 0);
            }
        }

        private void Tbx_Des_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex r = new Regex("^[0-9]+$");
            if ((Sl_St.Text != "") && (!r.IsMatch(Sl_St.Text)))
            {                
                Sl_St.Text = new string(Sl_St.Text.Where(c => char.IsDigit(c)).ToArray());
                Sl_St.Select(Tbx_Num.Text.Length, 0);
            }
        }

        private void Tbx_Des2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex r = new Regex("^[0-9]+$");
            if ((Sl_Pt.Text != "") && (!r.IsMatch(Sl_Pt.Text)))
            {                
                Sl_Pt.Text = new string(Sl_Pt.Text.Where(c => char.IsDigit(c)).ToArray());
                Sl_Pt.Select(Tbx_Num.Text.Length, 0);
            }
        }

        private void Tbx_Des3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Regex r = new Regex("^[0-9]+$");
            if ((Sl_Tt.Text != "") && (!r.IsMatch(Sl_Tt.Text)))
            {                
                Sl_Tt.Text = new string(Sl_Tt.Text.Where(c => char.IsDigit(c)).ToArray());
                Sl_Tt.Select(Tbx_Num.Text.Length, 0);
            }
        }

        private void Sl_P_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private int _numValue = 0;

        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                T_Quan.Text = value.ToString();
            }
        }

        public void NumberUpDown()
        {
            InitializeComponent();
            T_Quan.Text = _numValue.ToString();
            
        }

        private void B_Up_Add(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void B_Up_Sub(object sender, RoutedEventArgs e)
        {
            if(NumValue > 0)
            NumValue--;
        }

        private void T_Quan_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (T_Quan == null)
            {
                return;
            }

            if (!int.TryParse(T_Quan.Text, out _numValue))
                T_Quan.Text = _numValue.ToString();
        }

        private void Cat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

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
                case 2:
                    MainWindow Main = new MainWindow(0);
                    Main.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                    Main.Show();
                    this.Close();
                    break;
            }
        }

        //New Window additions
    }
}
