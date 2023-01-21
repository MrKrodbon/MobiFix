namespace MobiFix_KR_
{
    partial class Employees
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EmployeesContent = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesContent)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeesContent
            // 
            this.EmployeesContent.BackgroundColor = System.Drawing.Color.White;
            this.EmployeesContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeesContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.GhostWhite;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeesContent.DefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeesContent.GridColor = System.Drawing.Color.Indigo;
            this.EmployeesContent.Location = new System.Drawing.Point(3, 3);
            this.EmployeesContent.MultiSelect = false;
            this.EmployeesContent.Name = "EmployeesContent";
            this.EmployeesContent.ReadOnly = true;
            this.EmployeesContent.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.EmployeesContent.Size = new System.Drawing.Size(821, 269);
            this.EmployeesContent.TabIndex = 2;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EmployeesContent);
            this.Name = "Employees";
            this.Size = new System.Drawing.Size(827, 325);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView EmployeesContent;
    }
}
