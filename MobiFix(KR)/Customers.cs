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


    public partial class Customers : UserControl
    {
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        string connectionString = @"Data Source=DESKTOP-5GMG8OU\SQLEXPRESS;Initial Catalog=MobiFix;Integrated Security=True";
        DataTable dataTable = null;

        public Customers()
        {
            InitializeComponent();
            DataLoad();

        }
        private void DataLoad()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM [MobiFix].[CustomersDirectory]", sqlConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            CustomerContent.DataSource = dataTable;
            sqlConnection.Close();
        }
    }
}
