namespace RestAPICohort12.Models
{
    public class Response
    {
        /*
         * This class designed to give a structure to the response message
         * of the server
         */

        public int status_code { get; set; }
        public string status_message { get; set;}
        public Order order { get; set; } // this is to capture one 
                                             // order every time
        public List<Order> orders { get; set;} // this is to capture
                                            // more than one order from the
                                            // remote server
    }
}
