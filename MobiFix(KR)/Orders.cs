using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobiFix_KR_
{
    public partial class Orders : UserControl   {
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        string connectionString = @"Data Source=DESKTOP-5GMG8OU\SQLEXPRESS;Initial Catalog=MobiFix;Integrated Security=True";
        DataTable dataTable = null;
        MobiFixDataSet DataSet = new MobiFixDataSet();
        Customers customers = new Customers();
        


        public Orders()
        {
            InitializeComponent();
            DataLoad();
        }

        private void DataLoad()
        {
            try
            {
                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter("SELECT * FROM [MobiFix].[Orders]", sqlConnection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    OrderContent.DataSource = dataTable;
                    sqlConnection.Close();
                }
                using (sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection = new SqlConnection(connectionString);
                    sqlConnection.Open();
                    dataAdapter = new SqlDataAdapter("SELECT OrderName,OrderPrice FROM  MobiFix.OfeersDirectory JOIN MobiFix.OrderContent ON MobiFix.OfeersDirectory.IdOffer = MobiFix.OrderContent.IdOffer", sqlConnection);
                    dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    OrderInformation.DataSource = dataTable;
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }


        private void OrderContent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int rowindex = OrderContent.CurrentCell.RowIndex;
            int cellindex = OrderContent.CurrentCell.ColumnIndex;
            int DeletedItem = Convert.ToInt32(OrderContent.Rows[rowindex].Cells["OrderNumber"].Value);
            int DeletedIDCustomer = Convert.ToInt32(OrderContent.Rows[rowindex].Cells["IdCustomers"].Value);

            if (MessageBox.Show("Видалити ці дані?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        string sqlCommandDeleteOrderNumber = "Delete  FROM MobiFix.OrderContent where OrderNumber=" + DeletedItem;
                        
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandDeleteOrderNumber, sqlConnection);
                        dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        OrderContent.DataSource = dataTable;
                        
                    }
                    using (sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        string sqlCommandDeleteOrder = "Delete  FROM MobiFix.Orders where OrderNumber=" + DeletedItem;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandDeleteOrder, sqlConnection);
                        dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        OrderContent.DataSource = dataTable;

                    }
                    using (sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        string sqlCommandDeleteCustomer = "Delete  FROM MobiFix.CustomersDirectory where IdCustomers=" + DeletedIDCustomer;
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandDeleteCustomer, sqlConnection);
                        dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        customers.CustomerContent.DataSource = dataTable;

                    }
                    DataLoad();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Помилка при вдилаенні клієнта");
                }
            }
        }
        
    }
}   

