using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMSSQL.Models
{
    internal class Order
    {
        public string p_name { get; set; }
        public string p_id { get; set; }
        public float p_amount { get; set; }
        public float p_price { get; set; }
    }
}
