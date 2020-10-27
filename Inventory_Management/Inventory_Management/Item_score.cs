using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management
{
        public class Item_score
        {
            public int Number { get; set; }
            public String Description { get; set; }
            public string Category { get; set; }
            public DateTime? Expiry { get; set; }
            public int Space { get; set; }
            public int Margin { get; set; }
            public int Throughput { get; set; }
            public int Q_In { get; set; }
            public int Q_Sh { get; set; }
            public int score { get; set; }

             
        }
 
}
