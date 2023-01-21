namespace MobiFix_KR_
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FIOtext = new System.Windows.Forms.GroupBox();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ContactDateText = new System.Windows.Forms.GroupBox();
            this.PhoneNumberText = new System.Windows.Forms.MaskedTextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.labeltext2 = new System.Windows.Forms.Label();
            this.labeltext = new System.Windows.Forms.Label();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.IDoffer = new System.Windows.Forms.ComboBox();
            this.ofeersDirectoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mobiFixDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mobiFixDataSet = new MobiFix_KR_.MobiFixDataSet();
            this.ofeersDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.IDMobilePhones = new System.Windows.Forms.ComboBox();
            this.mobilePhonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfferComboBox = new System.Windows.Forms.Label();
            this.PhoneComboBox = new System.Windows.Forms.Label();
            this.ofeersDirectoryTableAdapter = new MobiFix_KR_.MobiFixDataSetTableAdapters.OfeersDirectoryTableAdapter();
            this.mobilePhonesTableAdapter = new MobiFix_KR_.MobiFixDataSetTableAdapters.MobilePhonesTableAdapter();
            this.OrderTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ReliableEmployee = new System.Windows.Forms.ComboBox();
            this.employeesDirectoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDirectoryTableAdapter = new MobiFix_KR_.MobiFixDataSetTableAdapters.EmployeesDirectoryTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.UnicIdCustomer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.PayDateText = new System.Windows.Forms.DateTimePicker();
            this.OrderNumberText = new System.Windows.Forms.Label();
            this.ofeersDirectoryOrderContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderContentTableAdapter = new MobiFix_KR_.MobiFixDataSetTableAdapters.OrderContentTableAdapter();
            this.FIOtext.SuspendLayout();
            this.ContactDateText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofeersDirectoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiFixDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiFixDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofeersDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilePhonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDirectoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofeersDirectoryOrderContentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FIOtext
            // 
            this.FIOtext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FIOtext.Controls.Add(this.LastNameText);
            this.FIOtext.Controls.Add(this.NameText);
            this.FIOtext.Controls.Add(this.label3);
            this.FIOtext.Controls.Add(this.label2);
            this.FIOtext.Controls.Add(this.label1);
            this.FIOtext.Controls.Add(this.SurnameText);
            this.FIOtext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOtext.Location = new System.Drawing.Point(12, 12);
            this.FIOtext.Name = "FIOtext";
            this.FIOtext.Size = new System.Drawing.Size(506, 155);
            this.FIOtext.TabIndex = 0;
            this.FIOtext.TabStop = false;
            this.FIOtext.Text = "ПІБ";
            // 
            // LastNameText
            // 
            this.LastNameText.Location = new System.Drawing.Point(166, 103);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(219, 26);
            this.LastNameText.TabIndex = 7;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(166, 71);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(219, 26);
            this.NameText.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "По батькові";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Прізвище";
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(166, 36);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(219, 26);
            this.SurnameText.TabIndex = 2;
            // 
            // ContactDateText
            // 
            this.ContactDateText.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ContactDateText.Controls.Add(this.PhoneNumberText);
            this.ContactDateText.Controls.Add(this.EmailText);
            this.ContactDateText.Controls.Add(this.labeltext2);
            this.ContactDateText.Controls.Add(this.labeltext);
            this.ContactDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactDateText.Location = new System.Drawing.Point(12, 183);
            this.ContactDateText.Name = "ContactDateText";
            this.ContactDateText.Size = new System.Drawing.Size(506, 151);
            this.ContactDateText.TabIndex = 1;
            this.ContactDateText.TabStop = false;
            this.ContactDateText.Text = "Контактні дані";
            // 
            // PhoneNumberText
            // 
            this.PhoneNumberText.Location = new System.Drawing.Point(166, 41);
            this.PhoneNumberText.Mask = "(999) 000-0000";
            this.PhoneNumberText.Name = "PhoneNumberText";
            this.PhoneNumberText.Size = new System.Drawing.Size(219, 26);
            this.PhoneNumberText.TabIndex = 13;
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(167, 96);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(218, 26);
            this.EmailText.TabIndex = 12;
            // 
            // labeltext2
            // 
            this.labeltext2.AutoSize = true;
            this.labeltext2.Location = new System.Drawing.Point(16, 96);
            this.labeltext2.Name = "labeltext2";
            this.labeltext2.Size = new System.Drawing.Size(48, 20);
            this.labeltext2.TabIndex = 10;
            this.labeltext2.Text = "Email";
            // 
            // labeltext
            // 
            this.labeltext.AutoSize = true;
            this.labeltext.Location = new System.Drawing.Point(4, 47);
            this.labeltext.Name = "labeltext";
            this.labeltext.Size = new System.Drawing.Size(140, 20);
            this.labeltext.TabIndex = 9;
            this.labeltext.Text = "Номер телефону";
            // 
            // AcceptButton
            // 
            this.AcceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AcceptButton.Location = new System.Drawing.Point(760, 503);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(100, 35);
            this.AcceptButton.TabIndex = 13;
            this.AcceptButton.Text = "Додати";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(8, 503);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 35);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Назад";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // IDoffer
            // 
            this.IDoffer.DataSource = this.ofeersDirectoryBindingSource1;
            this.IDoffer.DisplayMember = "OrderName";
            this.IDoffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDoffer.FormattingEnabled = true;
            this.IDoffer.Location = new System.Drawing.Point(687, 9);
            this.IDoffer.Name = "IDoffer";
            this.IDoffer.Size = new System.Drawing.Size(224, 28);
            this.IDoffer.TabIndex = 15;
            this.IDoffer.ValueMember = "IdOffer";
            // 
            // ofeersDirectoryBindingSource1
            // 
            this.ofeersDirectoryBindingSource1.DataMember = "OfeersDirectory";
            this.ofeersDirectoryBindingSource1.DataSource = this.mobiFixDataSetBindingSource;
            // 
            // mobiFixDataSetBindingSource
            // 
            this.mobiFixDataSetBindingSource.DataSource = this.mobiFixDataSet;
            this.mobiFixDataSetBindingSource.Position = 0;
            // 
            // mobiFixDataSet
            // 
            this.mobiFixDataSet.DataSetName = "MobiFixDataSet";
            this.mobiFixDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ofeersDirectoryBindingSource
            // 
            this.ofeersDirectoryBindingSource.DataMember = "OfeersDirectory";
            this.ofeersDirectoryBindingSource.DataSource = this.mobiFixDataSet;
            // 
            // IDMobilePhones
            // 
            this.IDMobilePhones.DataSource = this.mobilePhonesBindingSource;
            this.IDMobilePhones.DisplayMember = "SerialNumberAndPhoneName";
            this.IDMobilePhones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDMobilePhones.FormattingEnabled = true;
            this.IDMobilePhones.Location = new System.Drawing.Point(687, 56);
            this.IDMobilePhones.Name = "IDMobilePhones";
            this.IDMobilePhones.Size = new System.Drawing.Size(224, 28);
            this.IDMobilePhones.TabIndex = 16;
            this.IDMobilePhones.ValueMember = "IdMobilePhone";
            // 
            // mobilePhonesBindingSource
            // 
            this.mobilePhonesBindingSource.DataMember = "MobilePhones";
            this.mobilePhonesBindingSource.DataSource = this.mobiFixDataSet;
            // 
            // OfferComboBox
            // 
            this.OfferComboBox.AutoSize = true;
            this.OfferComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OfferComboBox.Location = new System.Drawing.Point(544, 12);
            this.OfferComboBox.Name = "OfferComboBox";
            this.OfferComboBox.Size = new System.Drawing.Size(71, 20);
            this.OfferComboBox.TabIndex = 13;
            this.OfferComboBox.Text = "Послуга";
            // 
            // PhoneComboBox
            // 
            this.PhoneComboBox.AutoSize = true;
            this.PhoneComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneComboBox.Location = new System.Drawing.Point(544, 64);
            this.PhoneComboBox.Name = "PhoneComboBox";
            this.PhoneComboBox.Size = new System.Drawing.Size(131, 20);
            this.PhoneComboBox.TabIndex = 17;
            this.PhoneComboBox.Text = "Серія телефону";
            // 
            // ofeersDirectoryTableAdapter
            // 
            this.ofeersDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // mobilePhonesTableAdapter
            // 
            this.mobilePhonesTableAdapter.ClearBeforeFill = true;
            // 
            // OrderTime
            // 
            this.OrderTime.CustomFormat = "yyyy-MM-dd ";
            this.OrderTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderTime.Location = new System.Drawing.Point(697, 219);
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.Size = new System.Drawing.Size(170, 22);
            this.OrderTime.TabIndex = 18;
            this.OrderTime.Value = new System.DateTime(2021, 4, 15, 15, 9, 22, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(544, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата Замовлення";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(544, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Відповідальний";
            // 
            // ReliableEmployee
            // 
            this.ReliableEmployee.DataSource = this.employeesDirectoryBindingSource;
            this.ReliableEmployee.DisplayMember = "Name";
            this.ReliableEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReliableEmployee.FormattingEnabled = true;
            this.ReliableEmployee.Location = new System.Drawing.Point(687, 144);
            this.ReliableEmployee.Name = "ReliableEmployee";
            this.ReliableEmployee.Size = new System.Drawing.Size(224, 28);
            this.ReliableEmployee.TabIndex = 22;
            this.ReliableEmployee.ValueMember = "IdEmployees";
            // 
            // employeesDirectoryBindingSource
            // 
            this.employeesDirectoryBindingSource.DataMember = "EmployeesDirectory";
            this.employeesDirectoryBindingSource.DataSource = this.mobiFixDataSet;
            // 
            // employeesDirectoryTableAdapter
            // 
            this.employeesDirectoryTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(544, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Id Замовника";
            // 
            // UnicIdCustomer
            // 
            this.UnicIdCustomer.Location = new System.Drawing.Point(687, 183);
            this.UnicIdCustomer.Multiline = true;
            this.UnicIdCustomer.Name = "UnicIdCustomer";
            this.UnicIdCustomer.ReadOnly = true;
            this.UnicIdCustomer.Size = new System.Drawing.Size(122, 20);
            this.UnicIdCustomer.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(544, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Дата Сплати";
            // 
            // PayDateText
            // 
            this.PayDateText.CustomFormat = "yyyy-MM-dd";
            this.PayDateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayDateText.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PayDateText.Location = new System.Drawing.Point(697, 260);
            this.PayDateText.Name = "PayDateText";
            this.PayDateText.Size = new System.Drawing.Size(170, 22);
            this.PayDateText.TabIndex = 25;
            // 
            // OrderNumberText
            // 
            this.OrderNumberText.AutoSize = true;
            this.OrderNumberText.Location = new System.Drawing.Point(569, 340);
            this.OrderNumberText.Name = "OrderNumberText";
            this.OrderNumberText.Size = new System.Drawing.Size(35, 13);
            this.OrderNumberText.TabIndex = 27;
            this.OrderNumberText.Text = "label8";
            this.OrderNumberText.Visible = false;
            // 
            // ofeersDirectoryOrderContentBindingSource
            // 
            this.ofeersDirectoryOrderContentBindingSource.DataMember = "OfeersDirectory_OrderContent";
            this.ofeersDirectoryOrderContentBindingSource.DataSource = this.ofeersDirectoryBindingSource1;
            // 
            // orderContentTableAdapter
            // 
            this.orderContentTableAdapter.ClearBeforeFill = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 546);
            this.ControlBox = false;
            this.Controls.Add(this.OrderNumberText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.PayDateText);
            this.Controls.Add(this.UnicIdCustomer);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ReliableEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderTime);
            this.Controls.Add(this.PhoneComboBox);
            this.Controls.Add(this.OfferComboBox);
            this.Controls.Add(this.IDMobilePhones);
            this.Controls.Add(this.IDoffer);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ContactDateText);
            this.Controls.Add(this.FIOtext);
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Створення Замовлення";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.FIOtext.ResumeLayout(false);
            this.FIOtext.PerformLayout();
            this.ContactDateText.ResumeLayout(false);
            this.ContactDateText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ofeersDirectoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiFixDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobiFixDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofeersDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobilePhonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDirectoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofeersDirectoryOrderContentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox FIOtext;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameText;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox ContactDateText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label labeltext2;
        private System.Windows.Forms.Label labeltext;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox IDoffer;
        private System.Windows.Forms.ComboBox IDMobilePhones;
        private System.Windows.Forms.Label OfferComboBox;
        private System.Windows.Forms.Label PhoneComboBox;
        private MobiFixDataSet mobiFixDataSet;
        private System.Windows.Forms.BindingSource ofeersDirectoryBindingSource;
        private MobiFixDataSetTableAdapters.OfeersDirectoryTableAdapter ofeersDirectoryTableAdapter;
        private MobiFixDataSetTableAdapters.MobilePhonesTableAdapter mobilePhonesTableAdapter;
        private System.Windows.Forms.MaskedTextBox PhoneNumberText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ReliableEmployee;
        private System.Windows.Forms.BindingSource employeesDirectoryBindingSource;
        private MobiFixDataSetTableAdapters.EmployeesDirectoryTableAdapter employeesDirectoryTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox UnicIdCustomer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker PayDateText;
        private System.Windows.Forms.Label OrderNumberText;
        private System.Windows.Forms.BindingSource mobilePhonesBindingSource;
        private System.Windows.Forms.DateTimePicker OrderTime;
        private System.Windows.Forms.BindingSource ofeersDirectoryBindingSource1;
        private System.Windows.Forms.BindingSource mobiFixDataSetBindingSource;
        private System.Windows.Forms.BindingSource ofeersDirectoryOrderContentBindingSource;
        private MobiFixDataSetTableAdapters.OrderContentTableAdapter orderContentTableAdapter;
    }
}