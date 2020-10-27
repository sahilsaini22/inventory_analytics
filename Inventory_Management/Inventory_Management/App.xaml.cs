using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;



namespace Inventory_Management
{
   
    public partial class App : Application
    {
        public static ObservableCollection<Item> _item;
        public static ObservableCollection<Item> _selected;
        public static ObservableCollection<Item> _search;
        public static ObservableCollection<Hits> _hits;
        public static ObservableCollection<Item_score> _stock;
        public static ObservableCollection<Item_score> _unstock;
        public static ObservableCollection<Item_score> _expiring;
        public static ObservableCollection<Item> _filtered;
        public static ObservableCollection<Categories> _categories;
        



        private void Application_Start(object sender, StartupEventArgs e)
        {            
            _item = MYStorage.MYStorage.ReadXml<ObservableCollection<Item>>("Item.xml");
            if (_item == null )
            _item = new ObservableCollection<Item>();

            _categories = MYStorage.MYStorage.ReadXml<ObservableCollection<Categories>>("Categories.xml");
            
            if (_categories == null)
                _categories = new ObservableCollection<Categories>();
            
            _hits = MYStorage.MYStorage.ReadXml<ObservableCollection<Hits>>("Hits.xml");
            if (_hits == null)
                _hits = new ObservableCollection<Hits>();
                
                _selected = new ObservableCollection<Item>();
                _search = new ObservableCollection<Item>();
                _stock = new ObservableCollection<Item_score>();
                _unstock = new ObservableCollection<Item_score>();
                _expiring = new ObservableCollection<Item_score>();
                _filtered = new ObservableCollection<Item>();
        }
        

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MYStorage.MYStorage.WriteXml<ObservableCollection<Item>>(_item, "Item.xml");            
        }

    }
}
