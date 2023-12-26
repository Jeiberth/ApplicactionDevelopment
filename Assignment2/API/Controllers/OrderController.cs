using Microsoft.AspNetCore.Mvc;
using RestAPICohort12.Models;
using System.Data.SqlClient;
using System.Diagnostics;

namespace RestAPICohort12.Controllers
{
    // Need to provide the controller information/ Rest API information to
    // view the base information properly

    [Route("[controller]")]
    [ApiController] // the definition of the class we are going to provide here
    public class OrderController : ControllerBase
    {
        // we are going to use the Base controller only to structure the
        // contents.. View will be handled by either wpf or web browser

        // step 1: create a connection state receiver
        private readonly IConfiguration _configuration;
        public OrderController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        // step 2: Create the API for controller, which is going to act as
        // rest API

        // step 2.1: Create GetAllOrders api
        [HttpGet] // generate get Request
        [Route("GetAllOrders")]

        public Response GetAllOrders()
        {
            // step 1: Create instance of the Response Class
            Response response = new Response();
            // step 2: WE need the database connection to be provided over
            // here

            SqlConnection con =
                new SqlConnection(_configuration.
                GetConnectionString("orderConnection"));

            // Step 3: Generate the Query and Execute
            // We want to have a separate database class which we are
            // going to create under Models folder
            DBApplication dba = new DBApplication();
            response = dba.GetAllOrders(con);

            // step 4: return the Response
            return response;
        }

        ////------------------------/////
        /// GetOrderbyId

        [HttpGet] // this is going generate get request from Client
        [Route("GetOrderByID/{id}")]

        public Response GetOrderByID(string id)
        {
            Response response = new Response();
            // configure the connection
            SqlConnection con =
                new SqlConnection(
                    _configuration.GetConnectionString("orderConnection"));
            // Call the DBApplication Class member
            DBApplication dba = new DBApplication();
            response = dba.GetOrderByID(con, id);

            return response;
        }

        ////-- Add Order ////
        //// Adding anything in RestAPI always generate Post Request

        [HttpPost]
        [Route("AddOrder")]
        public Response AddOrder(Order order)
        {
            Response response = new Response();

            // Configure the Connection
            SqlConnection con =
                new SqlConnection(
                    _configuration.GetConnectionString("orderConnection"));
            // Call the DBApplication class instance
            DBApplication dBA = new DBApplication();
            response = dBA.AddOrder(con, order);

            return response;
        }

        //// -- Update the Order information ///
        ///Any update command for Database in Put Request to the Server

        [HttpPut]
        [Route("UpdateOrder/{id}")]

        public Response UpdateOrder(Order order, string id)
        {
            Response response = new Response();

            SqlConnection con =
                new SqlConnection(
                    _configuration.GetConnectionString("orderConnection"));

            DBApplication dBA = new DBApplication();
            response = dBA.UpdateOrder(con, order, id);

            return response;


        }

        //// --- Delete Order ////
        ///To delete any order/entry we need to generate Delete Request

        [HttpDelete]
        [Route("DeleteOrder/{id}")]
        public Response DeleteOrder(string id)
        {
            Response response = new Response();

            SqlConnection con =
                new SqlConnection(
                    _configuration.GetConnectionString("orderConnection"));

            DBApplication dBA = new DBApplication();
            response = dBA.DeleteOrder(con, id);
            return response;
        }

    }
}
