namespace MobiFix_KR_
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CintrolButtons = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FindIDC = new System.Windows.Forms.RadioButton();
            this.FindIDE = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AppExit = new System.Windows.Forms.Button();
            this.IdCustomersText = new System.Windows.Forms.ComboBox();
            this.customersDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobiFixDataSet = new MobiFix_KR_.MobiFixDataSet();
            this.IdEmployeesText = new System.Windows.Forms.ComboBox();
            this.employeesDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FindButton = new System.Windows.Forms.Button();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.MainField = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrdersButton = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.EmployeesButton = new System.Windows.Forms.Button();
            this.CustomersButton = new System.Windows.Forms.Button();
            this.customersDirectoryTableAdapter = new MobiFix_KR_.MobiFixDataSetTableAdapters.CustomersDirectoryTableAdapter();
            this.employeesDirectoryTableAdapter = new MobiFix_KR_.MobiFixDataSetTableAdapters.EmployeesDirectoryTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.CintrolButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiFixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDirectoryBindingSource)).BeginInit();
            this.MainField.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // CintrolButtons
            // 
            this.CintrolButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.CintrolButtons.Controls.Add(this.pictureBox2);
            this.CintrolButtons.Controls.Add(this.FindIDC);
            this.CintrolButtons.Controls.Add(this.FindIDE);
            this.CintrolButtons.Controls.Add(this.label2);
            this.CintrolButtons.Controls.Add(this.label1);
            this.CintrolButtons.Controls.Add(this.AppExit);
            this.CintrolButtons.Controls.Add(this.IdCustomersText);
            this.CintrolButtons.Controls.Add(this.IdEmployeesText);
            this.CintrolButtons.Controls.Add(this.FindButton);
            this.CintrolButtons.Controls.Add(this.AddOrderButton);
            this.CintrolButtons.Location = new System.Drawing.Point(196, 0);
            this.CintrolButtons.Name = "CintrolButtons";
            this.CintrolButtons.Size = new System.Drawing.Size(842, 119);
            this.CintrolButtons.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(24, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // FindIDC
            // 
            this.FindIDC.AutoSize = true;
            this.FindIDC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindIDC.ForeColor = System.Drawing.Color.White;
            this.FindIDC.Location = new System.Drawing.Point(516, 24);
            this.FindIDC.Name = "FindIDC";
            this.FindIDC.Size = new System.Drawing.Size(14, 13);
            this.FindIDC.TabIndex = 10;
            this.FindIDC.TabStop = true;
            this.FindIDC.UseVisualStyleBackColor = true;
            // 
            // FindIDE
            // 
            this.FindIDE.AutoSize = true;
            this.FindIDE.Location = new System.Drawing.Point(329, 24);
            this.FindIDE.Name = "FindIDE";
            this.FindIDE.Size = new System.Drawing.Size(14, 13);
            this.FindIDE.TabIndex = 9;
            this.FindIDE.TabStop = true;
            this.FindIDE.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(536, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пошук по ID Клієнта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(349, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Пошук по ID Працівника";
            // 
            // AppExit
            // 
            this.AppExit.BackColor = System.Drawing.Color.Transparent;
            this.AppExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppExit.BackgroundImage")));
            this.AppExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AppExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AppExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AppExit.Location = new System.Drawing.Point(787, 0);
            this.AppExit.Name = "AppExit";
            this.AppExit.Size = new System.Drawing.Size(41, 37);
            this.AppExit.TabIndex = 6;
            this.AppExit.UseVisualStyleBackColor = false;
            this.AppExit.Click += new System.EventHandler(this.AppExit_Click);
            // 
            // IdCustomersText
            // 
            this.IdCustomersText.DataSource = this.customersDirectoryBindingSource;
            this.IdCustomersText.DisplayMember = "IdCustomers";
            this.IdCustomersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdCustomersText.FormattingEnabled = true;
            this.IdCustomersText.Location = new System.Drawing.Point(516, 58);
            this.IdCustomersText.Name = "IdCustomersText";
            this.IdCustomersText.Size = new System.Drawing.Size(150, 24);
            this.IdCustomersText.TabIndex = 5;
            this.IdCustomersText.ValueMember = "IdCustomers";
            this.IdCustomersText.SelectedIndexChanged += new System.EventHandler(this.IdCustomersText_SelectedIndexChanged);
            // 
            // customersDirectoryBindingSource
            // 
            this.customersDirectoryBindingSource.DataMember = "CustomersDirectory";
            this.customersDirectoryBindingSource.DataSource = this.mobiFixDataSet;
            // 
            // mobiFixDataSet
            // 
            this.mobiFixDataSet.DataSetName = "MobiFixDataSet";
            this.mobiFixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IdEmployeesText
            // 
            this.IdEmployeesText.DataSource = this.employeesDirectoryBindingSource;
            this.IdEmployeesText.DisplayMember = "IdEmployees";
            this.IdEmployeesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdEmployeesText.FormattingEnabled = true;
            this.IdEmployeesText.Location = new System.Drawing.Point(329, 58);
            this.IdEmployeesText.Name = "IdEmployeesText";
            this.IdEmployeesText.Size = new System.Drawing.Size(150, 24);
            this.IdEmployeesText.TabIndex = 4;
            this.IdEmployeesText.ValueMember = "IdEmployees";
            // 
            // employeesDirectoryBindingSource
            // 
            this.employeesDirectoryBindingSource.DataMember = "EmployeesDirectory";
            this.employeesDirectoryBindingSource.DataSource = this.mobiFixDataSet;
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.White;
            this.FindButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FindButton.BackgroundImage")));
            this.FindButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FindButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindButton.Location = new System.Drawing.Point(682, 45);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(47, 37);
            this.FindButton.TabIndex = 3;
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddOrderButton.FlatAppearance.BorderSize = 0;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.ForeColor = System.Drawing.Color.White;
            this.AddOrderButton.Location = new System.Drawing.Point(79, 37);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(134, 37);
            this.AddOrderButton.TabIndex = 1;
            this.AddOrderButton.Text = "+ Замовлення";
            this.AddOrderButton.UseVisualStyleBackColor = true;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // MainField
            // 
            this.MainField.Controls.Add(this.pictureBox1);
            this.MainField.Location = new System.Drawing.Point(206, 125);
            this.MainField.Name = "MainField";
            this.MainField.Size = new System.Drawing.Size(827, 380);
            this.MainField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(166, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OrdersButton
            // 
            this.OrdersButton.FlatAppearance.BorderSize = 0;
            this.OrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrdersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersButton.ForeColor = System.Drawing.Color.White;
            this.OrdersButton.Location = new System.Drawing.Point(3, 146);
            this.OrdersButton.Name = "OrdersButton";
            this.OrdersButton.Size = new System.Drawing.Size(194, 74);
            this.OrdersButton.TabIndex = 0;
            this.OrdersButton.Text = "Замовлення";
            this.OrdersButton.UseVisualStyleBackColor = true;
            this.OrdersButton.Click += new System.EventHandler(this.OrdersButton_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.ColumnCount = 1;
            this.panelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.panelMenu.Controls.Add(this.PanelLogo, 0, 0);
            this.panelMenu.Controls.Add(this.EmployeesButton, 0, 3);
            this.panelMenu.Controls.Add(this.CustomersButton, 0, 2);
            this.panelMenu.Controls.Add(this.OrdersButton, 0, 1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.RowCount = 5;
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.panelMenu.Size = new System.Drawing.Size(200, 505);
            this.panelMenu.TabIndex = 3;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.Controls.Add(this.label3);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(3, 3);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(194, 113);
            this.PanelLogo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "MobiFix";
            // 
            // EmployeesButton
            // 
            this.EmployeesButton.FlatAppearance.BorderSize = 0;
            this.EmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmployeesButton.ForeColor = System.Drawing.Color.White;
            this.EmployeesButton.Location = new System.Drawing.Point(3, 310);
            this.EmployeesButton.Name = "EmployeesButton";
            this.EmployeesButton.Size = new System.Drawing.Size(194, 68);
            this.EmployeesButton.TabIndex = 5;
            this.EmployeesButton.Text = "Працівники";
            this.EmployeesButton.UseVisualStyleBackColor = true;
            this.EmployeesButton.Click += new System.EventHandler(this.EmployeesButton_Click_1);
            // 
            // CustomersButton
            // 
            this.CustomersButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CustomersButton.FlatAppearance.BorderSize = 0;
            this.CustomersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersButton.ForeColor = System.Drawing.Color.White;
            this.CustomersButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomersButton.Location = new System.Drawing.Point(3, 226);
            this.CustomersButton.Name = "CustomersButton";
            this.CustomersButton.Size = new System.Drawing.Size(194, 69);
            this.CustomersButton.TabIndex = 1;
            this.CustomersButton.Text = "Клієнти";
            this.CustomersButton.UseVisualStyleBackColor = true;
            this.CustomersButton.Click += new System.EventHandler(this.CustomersButton_Click);
            // 
            // customersDirectoryTableAdapter
            // 
            this.customersDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // employeesDirectoryTableAdapter
            // 
            this.employeesDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1042, 505);
            this.ControlBox = false;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.MainField);
            this.Controls.Add(this.CintrolButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MobiFix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.CintrolButtons.ResumeLayout(false);
            this.CintrolButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiFixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDirectoryBindingSource)).EndInit();
            this.MainField.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel CintrolButtons;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Panel MainField;
        private System.Windows.Forms.Button OrdersButton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TableLayoutPanel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MobiFixDataSet mobiFixDataSet;
        private System.Windows.Forms.BindingSource customersDirectoryBindingSource;
        private MobiFixDataSetTableAdapters.CustomersDirectoryTableAdapter customersDirectoryTableAdapter;
        private System.Windows.Forms.BindingSource employeesDirectoryBindingSource;
        private MobiFixDataSetTableAdapters.EmployeesDirectoryTableAdapter employeesDirectoryTableAdapter;
        private System.Windows.Forms.ComboBox IdEmployeesText;
        private System.Windows.Forms.ComboBox IdCustomersText;
        private System.Windows.Forms.Button AppExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton FindIDC;
        private System.Windows.Forms.RadioButton FindIDE;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button EmployeesButton;
        private System.Windows.Forms.Button CustomersButton;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}

