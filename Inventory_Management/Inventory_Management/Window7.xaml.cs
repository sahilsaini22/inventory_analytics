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
    /// Interaction logic for Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        public Window7()
        {
            InitializeComponent();
            App._filtered.Clear();            
            for (int i = 0; i < App._item.Count(); i++)
            {
                var mid = App._item[i];
                App._filtered.Add(mid);                
            }
            for (int i = 0; i < App._filtered.Count(); i++)
            {
                
                G_stock.Items.Add(App._filtered[i]);
            }

        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {
            Filter();
        }



        public void Filter()
        {
            App._filtered.Clear();
            if ( G_stock !=  null)
            {
                G_stock.Items.Clear();
                G_stock.Items.Refresh();
            }
                            
            for (int i = 0; i < App._item.Count(); i++)            
            {
                var mid = App._item[i];                
                if (Ch_cat.IsChecked == true && mid != null)                
                {                    
                    String a = "System.Windows.Controls.ComboBoxItem: " + mid.Category;                                      
                    if ( a != Cat.SelectedItem.ToString())                    
                    {
                        mid = null;
                    }
                }

                if (Exp != null)
                {
                    if (Ch_exp.IsChecked == true && mid != null)                   
                    {
                        String a = Ss_ex.SelectedItem.ToString();
                        if (a == "System.Windows.Controls.ComboBoxItem: on")
                        {
                            if (mid.Expiry != Exp.SelectedDate)
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: before")
                        {
                            if (mid.Expiry >= Exp.SelectedDate)
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: after")
                        {
                            if (mid.Expiry <= Exp.SelectedDate)
                            {
                                mid = null;
                            }
                        }
                    }
                

                }

                
                if (Sl_St != null)
                {
                    if (Ch_sh.IsChecked == true && mid != null)                    
                    {
                        String a = Ss_co.SelectedItem.ToString();
                        if (a == "System.Windows.Controls.ComboBoxItem: equal to")
                        {
                            if (mid.Space != Convert.ToInt32(Sl_St.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: more than")
                        {
                            if (mid.Space <= Convert.ToInt32(Sl_St.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: less than")
                        {
                            if (mid.Space >= Convert.ToInt32(Sl_St.Text))
                            {
                                mid = null;
                            }
                        }

                    }
                }



                if (Sl_Pt != null)
                {
                    if (Ch_pm.IsChecked == true && mid != null)                    
                    {
                        String a = Pm_co.SelectedItem.ToString();
                        if (a == "System.Windows.Controls.ComboBoxItem: equal to")
                        {
                            if (mid.Margin != Convert.ToInt32(Sl_Pt.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: more than")
                        {
                            if (mid.Margin <= Convert.ToInt32(Sl_Pt.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: less than")
                        {
                            if (mid.Margin >= Convert.ToInt32(Sl_Pt.Text))
                            {
                                mid = null;
                            }
                        }

                    }
                }


                if (Sl_Tt != null)
                {
                    if (Ch_tp.IsChecked == true && mid != null)                 
                    {
                        String a = Tp_co.SelectedItem.ToString();
                        if (a == "System.Windows.Controls.ComboBoxItem: equal to")
                        {
                            if (mid.Throughput != Convert.ToInt32(Sl_Tt.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: more than")
                        {
                            if (mid.Throughput <= Convert.ToInt32(Sl_Tt.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: less than")
                        {
                            if (mid.Throughput >= Convert.ToInt32(Sl_Tt.Text))
                            {
                                mid = null;
                            }
                        }

                    }
                }
                


                if (Q_in != null)
                {
                    if (Ch_q_i.IsChecked == true && mid != null)                    
                    {
                        String a = Qi_co.SelectedItem.ToString();
                        if (a == "System.Windows.Controls.ComboBoxItem: equal to")
                        {
                            if (Q_in.Text != "")
                            if (mid.Q_In != Convert.ToInt32(Q_in.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: more than")
                        {
                            if (Q_in.Text != "")
                            if (mid.Q_In <= Convert.ToInt32(Q_in.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: less than")
                        {
                            if (Q_in.Text != "")
                            if (mid.Q_In >= Convert.ToInt32(Q_in.Text))
                            {
                                mid = null;
                            }
                        }

                    }
                }




                if (Q_sh != null)
                {
                    if (Ch_q_s.IsChecked == true && mid != null)                    
                    {
                        String a = Qs_co.SelectedItem.ToString();
                        if (a == "System.Windows.Controls.ComboBoxItem: equal to")
                        {
                            if (mid.Q_Sh != Convert.ToInt32(Q_sh.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: more than")
                        {
                            if (mid.Q_Sh <= Convert.ToInt32(Q_sh.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: less than")
                        {
                            if (mid.Q_Sh >= Convert.ToInt32(Q_sh.Text))
                            {
                                mid = null;
                            }
                        }

                    }
                }




                if (Quan != null)
                {
                    if (Ch_q.IsChecked == true && mid != null)                    
                    {
                        String a = Q_co.SelectedItem.ToString();
                        int total = mid.Q_Sh + mid.Q_In;
                        if (a == "System.Windows.Controls.ComboBoxItem: equal to")
                        {
                            if (total != Convert.ToInt32(Quan.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: more than")
                        {
                            if (total <= Convert.ToInt32(Quan.Text))
                            {
                                mid = null;
                            }
                        }
                        else if (a == "System.Windows.Controls.ComboBoxItem: less than")
                        {
                            if (total >= Convert.ToInt32(Quan.Text))
                            {
                                mid = null;
                            }
                        }

                    }
                }
                



                if (mid != null)
                    App._filtered.Add(mid);
            }
            if (G_stock != null)
            {
                for (int i = 0; i < App._filtered.Count(); i++)
                {
                    var mid = App._filtered[i];
                    G_stock.Items.Add(mid);
                }
            }
            
        }


        private void Ch_cat_MouseDownk(object sender, MouseEventArgs e)
        {
            

        }

        private void exp_changed(Object sender, EventArgs e)
        {

            Filter();

        }

        private void Ch_cat_changed(Object sender, EventArgs e)
        {
 
        }
            private void Num_TextChanged(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void Tbx_Des_TextChanged(object sender, RoutedEventArgs e)
        {
            Filter();
        }
        private void B_An_Click(object sender, RoutedEventArgs e)
        {
        
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window1 Navig = new Window1();
            Navig.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            Navig.Show();
            this.Close();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
                            
                Ch_cat.IsChecked = false;
                Ch_exp.IsChecked = false;
                Ch_sh.IsChecked = false;
                Ch_pm.IsChecked = false;
                Ch_tp.IsChecked = false;
                Ch_q_i.IsChecked = false;
                Ch_q_s.IsChecked = false;
                Ch_q.IsChecked = false;
                App._filtered.Clear();
                G_stock.Items.Clear();
                G_stock.Items.Refresh();
                Filter();




        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void Tbx_Des_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void Cat_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Qi_co_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = G_stock.SelectedItem;
            if (a != null)
            {
                
            }
            
            int i = 0;
        }

        
        private void Q_in_TextChanged(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void Q_sh_TextChanged(object sender, RoutedEventArgs e)
        {
            Filter();
        }

        private void Q_TextChanged(object sender, RoutedEventArgs e)
        {
            Filter();
        }


        private void Ch_cat_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Ss_ex_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Ss_co_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Pm_co_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Tp_co_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Qs_co_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Q_co_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        

        private void Des_TextChanged(object sender, TextChangedEventArgs e)
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

        private void Tbx_v_TextChanged(object sender, TextChangedEventArgs e)
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

        private void Ch_cat_Changed(object sender, RoutedEventArgs e)
        {
            Cat.SelectedIndex = -1;
            Filter();                  
        }

        private void Ch_exp_Changed(object sender, RoutedEventArgs e)
        {
            Exp.SelectedDate = null;            
            Filter();
        }

        private void Ch_sh_Changed(object sender, RoutedEventArgs e)
        {
            Ss_co.SelectedIndex = 1;
            Sl_S.Value = 0;            
            Filter();
        }

        private void Ch_pm_Changed(object sender, RoutedEventArgs e)
        {
            Pm_co.SelectedIndex = 1;
            Sl_P.Value = 0;            
            Filter();
        }

        private void Ch_tp_Changed(object sender, RoutedEventArgs e)
        {
            Tp_co.SelectedIndex = 1;
            Sl_T.Value = 0;
            Filter();
        }
       
        private void Ch_qi_Changed(object sender, RoutedEventArgs e)
        {
            Q_in.Text = "";
            Qi_co.SelectedIndex = 1;
            Filter();
        }

        private void Ch_qs_Changed(object sender, RoutedEventArgs e)
        {
            Q_sh.Text = "";
            Qs_co.SelectedIndex = 1;
            Filter();
        }

        private void Ch_q_Changed(object sender, RoutedEventArgs e)
        {
            Quan.Text = "";
            Q_co.SelectedIndex = 1;
            Filter();
        }


    }
}
