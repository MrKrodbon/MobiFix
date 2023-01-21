using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MobiFix_KR_
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();

        }
        SqlConnection sqlConnection = null;
        SqlDataAdapter dataAdapter = null;
        string connectionString = @"Data Source=DESKTOP-5GMG8OU\SQLEXPRESS;Initial Catalog=MobiFix;Integrated Security=True";
        DataTable dataTable = null;
        Orders orders = new Orders();
        Random random = new Random();
        Form1 form1 = new Form1();


        private void AddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobiFixDataSet.OrderContent". При необходимости она может быть перемещена или удалена.
            this.orderContentTableAdapter.Fill(this.mobiFixDataSet.OrderContent);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobiFixDataSet.EmployeesDirectory". При необходимости она может быть перемещена или удалена.
            this.employeesDirectoryTableAdapter.Fill(this.mobiFixDataSet.EmployeesDirectory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobiFixDataSet.MobilePhones". При необходимости она может быть перемещена или удалена.
            this.mobilePhonesTableAdapter.Fill(this.mobiFixDataSet.MobilePhones);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobiFixDataSet.OfeersDirectory". При необходимости она может быть перемещена или удалена.
            this.ofeersDirectoryTableAdapter.Fill(this.mobiFixDataSet.OfeersDirectory);
         
            LimitationText();
            //InsertTextInOffers();
            
        }


        private void LimitationText()
        {
            NameText.MaxLength = 15;
            LastNameText.MaxLength = 30;
            SurnameText.MaxLength = 15;
            EmailText.MaxLength = 30;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            ActiveForm.Close();

        }
        
        private void AcceptButton_Click(object sender, EventArgs e)
        {
            int idcustomer = 0;
            idcustomer += random.Next(100000000, 999999999);
            UnicIdCustomer.Text = idcustomer.ToString();
            
            int OrderNumber =0 ;
            OrderNumber += random.Next(1, 999);

            if (NameText.Text != ""
                && LastNameText.Text != ""
                && SurnameText.Text != ""
                && PhoneNumberText.Text != ""
                && EmailText.Text != ""
                )
            {
                string sqlcommandCustomers = "INSERT INTO [MobiFix].[CustomersDirectory] (IdCustomers,Name,SurName,LastName,PhoneNumber,Email) VALUES (N'" + idcustomer + "',N'" + NameText.Text + "',N'" + SurnameText.Text + "',N'" + LastNameText.Text + "',N'" + PhoneNumberText.Text + "',N'" + EmailText.Text + "'  )";
                
                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(sqlcommandCustomers, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Перевірте правильність введених данних",ex.Message, MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                    
                }
                string sqlcommandInsertOrders = "INSERT INTO [MobiFix].[Orders] (GetOrder,OrderNumber,IdCustomers,IdEmployees,IdMobilePhone,PayDate) VALUES ('"+OrderTime.Value +"','"+OrderNumber +"','"+UnicIdCustomer.Text+"',N'"+ ReliableEmployee.SelectedValue + "','"+IDMobilePhones.SelectedValue+"','"+PayDateText.Value+"')";
                
                try
                {
                    
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(sqlcommandInsertOrders, sqlConnection);
                        sqlCommand.ExecuteNonQuery();
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }

                string sqlcommandInsertOrdersContent = "INSERT INTO [MobiFix].[OrderContent] (OrderNumber,IdOffer,PerformDate) VALUES ('"+OrderNumber+"','" + IDoffer.SelectedValue + "','" + PayDateText.Value + "')";

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                    {
                        sqlConnection.Open();
                        SqlCommand sqlCommand = new SqlCommand(sqlcommandInsertOrdersContent, sqlConnection);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                
                
                
            }
            else
            {
                MessageBox.Show("Не всі поля заповнені","Увага",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            }
            
            DataLoad();
            form1.FindInfo();
            this.Close();


        }
        private void DataLoad()
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            dataAdapter = new SqlDataAdapter("SELECT * FROM [MobiFix].[Orders]", sqlConnection);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            orders.OrderContent.DataSource = dataTable;
            sqlConnection.Close();
        }
    }
}
