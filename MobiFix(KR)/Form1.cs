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
using System.Drawing.Drawing2D;

namespace MobiFix_KR_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private Button currentbtn = new Button();
        private Button previousButton = new Button();
        private int tempIndex;
       
        
        string connectionString = @"Data Source=DESKTOP-5GMG8OU\SQLEXPRESS;Initial Catalog=MobiFix;Integrated Security=True";
        
        private Color SelectedThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index=random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            
            if (btnSender!=null)
            {
                if (currentbtn!=(Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectedThemeColor();
                    currentbtn = (Button)btnSender;
                    currentbtn.BackColor = color;
                    currentbtn.ForeColor = Color.White;
                    currentbtn.Font= new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                   
                   CintrolButtons.BackColor = color;
                    CintrolButtons.BackColor= ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousButton in panelMenu.Controls)
            {
                if (previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                }
            }
        }

        private void OrdersButton_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            ActivateButton(sender);
            FindInfo();

            MainControlClass.ShowControl(orders,MainField);
        }

        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            
            
            addForm.ShowDialog();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            Customers customers= new Customers();

            ActivateButton(sender);
            FindInfo();

            MainControlClass.ShowControl(customers, MainField);
        }

        private void FindText_TextChanged(object sender, EventArgs e)
        {

        }
        
        public void FindInfo()
        {
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            DataTable dataTable = null;

            using (sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();
                
                SqlCommand sqlCommandFindEmployees = new SqlCommand("SELECT * FROM MobiFix.EmployeesDirectory WHERE IdEmployees='" + IdEmployeesText.Text + "'", sqlConnection);
                
                SqlCommand sqlCommandFindCustomers = new SqlCommand("SELECT * FROM MobiFix.CustomersDirectory WHERE IdCustomers='" + IdCustomersText.Text + "'", sqlConnection);
                //Ищет работника по в списке Базы Данных по айди
                try
                {
                    if (FindIDE.Checked == true)
                    {
                        Employees employees = new Employees();
                        dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandFindEmployees);
                        dataAdapter.Fill(dataTable);
                        MainControlClass.ShowControl(employees, MainField);

                        employees.EmployeesContent.DataSource = dataTable;
                        
                        sqlConnection.Close();
                    }
                    else if (FindIDC.Checked == true)
                    {
                        Customers customers = new Customers();
                        dataTable = new DataTable();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommandFindCustomers);
                        dataAdapter.Fill(dataTable);
                        MainControlClass.ShowControl(customers, MainField);
                        customers.CustomerContent.DataSource = dataTable;
                        sqlConnection.Close();
                    }

                }
                catch
                {
                    MessageBox.Show("Оберіть параметр пошуку", "Увага", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            FindInfo();
        }

        private void FindInfoText_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        private void IdNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobiFixDataSet.EmployeesDirectory". При необходимости она может быть перемещена или удалена.
            this.employeesDirectoryTableAdapter.Fill(this.mobiFixDataSet.EmployeesDirectory);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mobiFixDataSet.CustomersDirectory". При необходимости она может быть перемещена или удалена.
            this.customersDirectoryTableAdapter.Fill(this.mobiFixDataSet.CustomersDirectory);
            
        }

        

        private void AppExit_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }


        private void EmployeesButton_Click(object sender, EventArgs e)
        {
            
        }
        private int HeightHeader = 28;

        private void Apply()
        {
            Form1 form1 = new Form1();
            form1.FormBorderStyle = FormBorderStyle.None;
            

        }

        private void DrawStyle(Graphics graphics)
        {
            Form1 form1 = new Form1();
            graphics.SmoothingMode = SmoothingMode.HighQuality;
            Rectangle rectangle = new Rectangle(0, 0, form1.Width - 1, HeightHeader);
            Rectangle rectangleBorder = new Rectangle(0, 0, form1.Width - 1, form1.Height - 1);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeesButton_Click_1(object sender, EventArgs e)
        {
            Employees employees = new Employees();
            ActivateButton(sender);
            FindInfo();
            MainControlClass.ShowControl(employees, MainField);
        }

        private void IdCustomersText_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Start();
          
           



            //SqlCommand sqlCommandFindEmployees = new SqlCommand("SELECT IdEmployees FROM MobiFix.EmployeesDirectory ");

            //SqlCommand sqlCommandFindCustomers = new SqlCommand("SELECT IdCustomers FROM MobiFix.CustomersDirectory ");
            //using (sqlConnection = new SqlConnection(connectionString))
            //{
            //    sqlConnection.Open();
            //    Employees employees = new Employees();
            //            dataTable = new DataTable();
            //            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(sqlCommandFindEmployees);
            //            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(sqlCommandFindCustomers);
            //    dataAdapter1.Fill(dataTable);
            //    dataAdapter2.Fill(dataTable);

            //    IdCustomersText.DataSource = dataTable;
            //    IdEmployeesText.DataSource = dataTable;
                
            //}
        }
    }
}
