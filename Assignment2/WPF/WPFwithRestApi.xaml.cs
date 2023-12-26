using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
using WpfAppMSSQL.Models;

namespace WpfAppMSSQL
{
    /// <summary>
    /// Lógica de interacción para WPFwithRestApi.xaml
    /// </summary>
    public partial class WPFwithRestApi : Window
    {
        HttpClient client = new HttpClient();

        public WPFwithRestApi()
        {
            //We get this from the api program running the code
            client.BaseAddress = new Uri("https://localhost:7296/Order/");

            client.DefaultRequestHeaders.Accept.Clear();

            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json")
                );

            InitializeComponent();
        }

        private async void show_Click(object sender, RoutedEventArgs e)
        {
            var server_response = await client.GetStringAsync("GetAllOrders");

            Response response_Json = JsonConvert.DeserializeObject<Response>(server_response);

            dbGrid.ItemsSource = response_Json.orders;
            DataContext = this;

        }

        private async void select_Click(object sender, RoutedEventArgs e)
        {
            var server_response = await client.GetStringAsync("GetOrderByID/"+ int.Parse(p_id.Text));

            Response response_Json = JsonConvert.DeserializeObject<Response>(server_response);

            p_name.Text = response_Json.order.p_name;
            p_id.Text = response_Json.order.p_id;
            p_amount.Text = response_Json.order.p_amount.ToString();
            p_price.Text = response_Json.order.p_price.ToString();

        }

        private async void insert_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();

            order.p_name = p_name.Text;
            order.p_id = p_id.Text;
            order.p_amount = float.Parse(p_amount.Text);
            order.p_price = float.Parse(p_price.Text);

            var server_response = await client.PostAsJsonAsync("AddOrder", order);

            //Response response_Json = JsonConvert.DeserializeObject<Response>(server_response.ToString());
            MessageBox.Show(server_response.ToString());
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order();

            order.p_name = p_name.Text;
            order.p_id = p_id.Text;
            order.p_amount = float.Parse(p_amount.Text);
            order.p_price = float.Parse(p_price.Text);

            var server_response = await client.PostAsJsonAsync("UpdateOrder/", order);
            MessageBox.Show(server_response.ToString());



        }

        private async void delete_Click(object sender, RoutedEventArgs e)
        {
            var response_JSON = await client.DeleteAsync("DeleteOrder/"+p_id.Text);
            MessageBox.Show(response_JSON.StatusCode.ToString());
            MessageBox.Show(response_JSON.RequestMessage.ToString());

        }

        private void sales_Click(object sender, RoutedEventArgs e)
        {
            Sales M = new Sales();
            this.Close();
            M.Show();
        }
    }
}
