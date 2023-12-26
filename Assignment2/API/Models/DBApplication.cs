using System.Data;
using System.Data.SqlClient;

namespace RestAPICohort12.Models
{
    public class DBApplication
    {
        public Response GetAllOrders(SqlConnection con)
        {
            // step 1: Create instance of the Response class
            Response response = new Response();

            // Step 2: Create the Query
            string Query = "Select * from orders";
            
            // step 3 : Need data adapter to read the data from database
            // and a table structure to add it in the table
            SqlDataAdapter da = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // step 4: initialize the list of orders variable
            List<Order> listOforders = new List<Order>();

            // step 5: verify the database query retrieved in dt
            if(dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    Order order = new Order(); // to capture each entry 
                                                // in the table
                    order.p_name = (string) dt.Rows[i]["p_name"];
                    order.p_id = (string)dt.Rows[i]["p_id"];
                    order.p_amount = Convert.ToSingle(dt.Rows[i]["p_amount"]);
                    order.p_price = Convert.ToSingle(dt.Rows[i]["p_price"]);

                    listOforders.Add(order);
                }
            }

            // step 6: verify the list of orders and configure response
            if (listOforders.Count > 0)
            {
                response.status_code = 200;
                response.status_message = "Successfull";
                response.orders = listOforders;
                response.order = null;
            }
            else
            {
                response.status_code = 100;
                response.status_message = "The query is not successfull.." +
                    " check it";
                response.orders = null;
                response.order = null;
            }
            return response;

        }

        public Response GetOrderByID(SqlConnection con, string id)
        {
            Response response = new Response();
            // generate the Query
            string Query = "Select * from orders where p_id= '" + id + "'";
            // Generate the Adapter, pass the query and execute
            SqlDataAdapter adapter = new SqlDataAdapter(Query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                Order order = new Order();
                order.p_name = (string)dt.Rows[0]["p_name"];
                order.p_id = (string)dt.Rows[0]["p_id"];
                order.p_amount = Convert.ToSingle(dt.Rows[0]["p_amount"]);
                order.p_price = Convert.ToSingle(dt.Rows[0]["p_price"]);

                response.status_code = 200;
                response.status_message = "Order found and listed";
                response.order = order;
                response.orders = null;
            }
            else
            {
                response.status_code = 100;
                response.status_message = "Nothing is reported or found";
                response.order = null;
                response.orders = null;
            }
            return response;
        }

        public Response AddOrder(SqlConnection con, Order order) {
        
            Response response = new Response();
            // Query Generation
            string Query = "insert into orders values(@p_name, @p_id, @p_amount, @p_price)";
            // Sql Command
            SqlCommand command = new SqlCommand(Query, con);
            command.Parameters.AddWithValue("@p_name", order.p_name);
            command.Parameters.AddWithValue("@p_id", order.p_id);
            command.Parameters.AddWithValue("@p_amount", order.p_amount);
            command.Parameters.AddWithValue("@p_price", order.p_price);
            con.Open();

            // Execute our query
            int i = command.ExecuteNonQuery(); // return 0 when unsuccessful, return 1
            // when successful

            if (i > 0)
            {
                response.status_code= 200;
                response.status_message = "The order is inserted properly";
                response.order = order;
                response.orders = null;
            }
            else
            {
                response.status_code = 100;
                response.status_message = "The insertion was unsuccessful";
                response.order = null;
                response.orders = null;
            }
            return response;
        }

        public Response UpdateOrder(SqlConnection con, Order order, string id)
        {
            Response response = new Response();

            // Generate the Query
            string Query = "Update orders set p_name=@p_name, p_amount=@p_amount" +
                ", p_price=@p_price where p_id='"+ id +"'";

            // Execute the Command
            SqlCommand cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@p_name", order.p_name);
            cmd.Parameters.AddWithValue("@p_amount", order.p_amount);
            cmd.Parameters.AddWithValue("@p_price", order.p_price);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                response.status_code= 200;
                response.status_message = "Updated Successfully";
                response.order = order;
                
            }
            else
            {
                response.status_code = 100;
                response.status_message = "Couldn't update successfully";
                response.order = null;
            }
            con.Close();
            return response;

        }

        public Response DeleteOrder(SqlConnection con, string id)
        {
            Response response = new Response();
            //Query
            string Query = "Delete from orders where p_id='" + id + "'";
            // Generate SQL command
            SqlCommand cmd = new SqlCommand(Query, con);
            
            con.Open();
            // execute
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                response.status_code= 200;
                response.status_message = "Order deleted.. check all orders";
            }
            else
            {
                response.status_code = 100;
                response.status_message = "Nothing deleted .....";
            }
            con.Close( );
            return response;       
        }
    }
}
