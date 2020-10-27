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
    /// Interaction logic for Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        private int item_num;
        public Window5(int num = 0 )
        {
            InitializeComponent();
            item_num = num;
            for (int i = 0; i < App._item.Count; i++)
            {
                if (App._item[i].Number == num)
                {
                    T_Quan.Text = Convert.ToString(App._item[i].Q_In);
                    T_Quan_Sh.Text = Convert.ToString(App._item[i].Q_Sh);
                }
            }
        }

        private void Save_Button_Click(object sender, RoutedEventArgs e)
        {            
            for (int i = 0; i < App._item.Count; i++)
            {
                if (App._item[i].Number == item_num)
                {
                    App._item[i].Q_In = Convert.ToInt32(T_Quan.Text);
                    App._item[i].Q_Sh = Convert.ToInt32(T_Quan_Sh.Text);
                    this.Close();
                    
                }
            }

        }

        private void Move_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void B_Up_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                int xd;
                Int32.TryParse(T_Move.Text, out xd);
                int move = Convert.ToInt32(T_Move.Text);
                int inv = Convert.ToInt32(T_Quan.Text);
                int she = Convert.ToInt32(T_Quan_Sh.Text);
                if ( move > she)
                {
                    MessageBox.Show("Number higher than shelf size!");
                    T_Move.Text = "";
                }
                else
                {
                    inv = inv + move;
                    she = she - move;
                    T_Quan.Text = inv.ToString();
                    T_Quan_Sh.Text = she.ToString();
                    T_Move.Text = "";

                }

            }
            catch (FormatException)
            {
               
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please fill-in a smaller number");
            }
        }

        private void B_Up_Sub(object sender, RoutedEventArgs e)
        {
            try
            {
                int xd;
                Int32.TryParse(T_Move.Text, out xd);
                int move = Convert.ToInt32(T_Move.Text);
                int inv = Convert.ToInt32(T_Quan.Text);
                int she = Convert.ToInt32(T_Quan_Sh.Text);
                if (move > inv)
                {
                    MessageBox.Show("Number higher than inventory size!");
                    T_Move.Text = "";
                }
                else
                {
                    inv = inv - move;
                    she = she + move;
                    T_Quan.Text = inv.ToString();
                    T_Quan_Sh.Text = she.ToString();
                    T_Move.Text = "";
                }

            }
            catch (FormatException)
            {
               
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please fill-in a smaller number");
            }
        }

        private void T_Quan_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    

    private void T_Move_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int xd;
                Int32.TryParse(T_Move.Text, out xd);
                int move = Convert.ToInt32(T_Move.Text);
                int inv = Convert.ToInt32(T_Quan.Text);
                int she = Convert.ToInt32(T_Quan_Sh.Text);
                if (move > inv && move > she)
                {
                    MessageBox.Show("Number too high!");
                    T_Move.Text = "";
                    B_Up.IsEnabled = false;
                    B_Down.IsEnabled = false;
                }
                if (move > she )
                {                    
                    B_Up.IsEnabled = false;                    
                }
                else
                {
                    B_Up.IsEnabled = true;                    
                }

                if (move > inv)
                {                    
                    B_Down.IsEnabled = false;
                }
                else
                {
                    B_Down.IsEnabled = true;
                }

            }
            catch (FormatException)
            {
               
            }
            catch (OverflowException)
            {
                MessageBox.Show("Please fill-in a smaller number");
            }

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
