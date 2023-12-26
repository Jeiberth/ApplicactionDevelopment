using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppMSSQL.Models
{
    internal class Response
    {

        public int status_code { get; set; }
        public string status_message { get; set; }
        public Order order { get; set; } // this is to capture one 
                                         // order every time
        public List<Order> orders { get; set; } // this is to capture
                                                // more than one order from the
                                                // remote server

    }
}
