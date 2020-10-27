using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
    public class ComboView
    {
        public List<string> Catgs { get; set; }
        public ComboView()
        {
            for (int i = 0; i < App._categories.Count; i++)
            {
                Catgs = new List<String>()
                {
                    "Food",
                   "Home",
                    "Cosmetics",
                    "Drinks",
                    "Liqour"
                };
                
                
            }
        }

    }
}   

