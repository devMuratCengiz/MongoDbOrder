using MongoDbOrder.Entities;
using MongoDbOrder.Services;

namespace MongoDbOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OrderOperation orderOperation = new OrderOperation();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var order = new Order
            {
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                City = txtCity.Text,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text)
            };

            orderOperation.AddOrder(order);
            MessageBox.Show("Sipariþ eklendi.");
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Order> orders = orderOperation.GetAllOrders();
            dataGridView1.DataSource = orders;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string orderId = txtId.Text;
            orderOperation.DeleteOrder(orderId);
            MessageBox.Show("Silme iþlemi baþarýlý.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            var updateOrder = new Order
            {
                City = txtCity.Text,
                CustomerName = txtCustomer.Text,
                District = txtDistrict.Text,
                TotalPrice = Convert.ToDecimal(txtTotalPrice.Text),
                Id = id
            };
            orderOperation.UpdateOrder(updateOrder);
        }

        private void btnGetById_Click(object sender, EventArgs e)
        {
            Order order = orderOperation.GetOrderById(txtId.Text);
            dataGridView1.DataSource = new List<Order> { order};
        }
    }
}
