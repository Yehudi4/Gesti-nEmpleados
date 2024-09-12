namespace GestiónEmpleados
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBoxEmpleados = new GroupBox();
            txtDepartmentEmployee = new TextBox();
            lblDepartment = new Label();
            btnAddEmployee = new Button();
            numEmployeeAge = new NumericUpDown();
            label2 = new Label();
            txtNameEmployee = new TextBox();
            label1 = new Label();
            groupBoxViewEmployee = new GroupBox();
            dataGridViewEmployeeList = new DataGridView();
            label3 = new Label();
            groupBoxEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEmployeeAge).BeginInit();
            groupBoxViewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // groupBoxEmpleados
            // 
            groupBoxEmpleados.Controls.Add(txtDepartmentEmployee);
            groupBoxEmpleados.Controls.Add(lblDepartment);
            groupBoxEmpleados.Controls.Add(btnAddEmployee);
            groupBoxEmpleados.Controls.Add(numEmployeeAge);
            groupBoxEmpleados.Controls.Add(label2);
            groupBoxEmpleados.Controls.Add(txtNameEmployee);
            groupBoxEmpleados.Controls.Add(label1);
            groupBoxEmpleados.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBoxEmpleados.Location = new Point(43, 44);
            groupBoxEmpleados.Name = "groupBoxEmpleados";
            groupBoxEmpleados.Size = new Size(388, 437);
            groupBoxEmpleados.TabIndex = 0;
            groupBoxEmpleados.TabStop = false;
            groupBoxEmpleados.Text = "Employee Data";
            // 
            // txtDepartmentEmployee
            // 
            txtDepartmentEmployee.Font = new Font("Segoe UI Variable Small", 12F);
            txtDepartmentEmployee.Location = new Point(175, 294);
            txtDepartmentEmployee.Name = "txtDepartmentEmployee";
            txtDepartmentEmployee.Size = new Size(207, 34);
            txtDepartmentEmployee.TabIndex = 6;
            txtDepartmentEmployee.TextChanged += textBox1_TextChanged;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI Variable Small", 12F);
            lblDepartment.Location = new Point(6, 294);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(127, 27);
            lblDepartment.TabIndex = 5;
            lblDepartment.Text = "Department:";
            lblDepartment.Click += lblDepartment_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Font = new Font("Segoe UI Variable Small", 12F);
            btnAddEmployee.Location = new Point(97, 381);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(180, 41);
            btnAddEmployee.TabIndex = 4;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // numEmployeeAge
            // 
            numEmployeeAge.Font = new Font("Segoe UI Variable Small", 12F);
            numEmployeeAge.Location = new Point(175, 202);
            numEmployeeAge.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            numEmployeeAge.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            numEmployeeAge.Name = "numEmployeeAge";
            numEmployeeAge.Size = new Size(207, 34);
            numEmployeeAge.TabIndex = 3;
            numEmployeeAge.Value = new decimal(new int[] { 18, 0, 0, 0 });
            numEmployeeAge.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Small", 12F);
            label2.Location = new Point(6, 204);
            label2.Name = "label2";
            label2.Size = new Size(53, 27);
            label2.TabIndex = 2;
            label2.Text = "Age:";
            label2.Click += label2_Click;
            // 
            // txtNameEmployee
            // 
            txtNameEmployee.Font = new Font("Segoe UI Variable Small", 12F);
            txtNameEmployee.Location = new Point(175, 108);
            txtNameEmployee.Name = "txtNameEmployee";
            txtNameEmployee.Size = new Size(207, 34);
            txtNameEmployee.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Small", 12F);
            label1.Location = new Point(6, 115);
            label1.Name = "label1";
            label1.Size = new Size(163, 27);
            label1.TabIndex = 0;
            label1.Text = "Employee name:";
            // 
            // groupBoxViewEmployee
            // 
            groupBoxViewEmployee.Controls.Add(dataGridViewEmployeeList);
            groupBoxViewEmployee.Controls.Add(label3);
            groupBoxViewEmployee.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold);
            groupBoxViewEmployee.Location = new Point(437, 44);
            groupBoxViewEmployee.Name = "groupBoxViewEmployee";
            groupBoxViewEmployee.Size = new Size(497, 437);
            groupBoxViewEmployee.TabIndex = 1;
            groupBoxViewEmployee.TabStop = false;
            groupBoxViewEmployee.Text = "View employee";
            // 
            // dataGridViewEmployeeList
            // 
            dataGridViewEmployeeList.BackgroundColor = SystemColors.Menu;
            dataGridViewEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmployeeList.Location = new Point(42, 108);
            dataGridViewEmployeeList.Name = "dataGridViewEmployeeList";
            dataGridViewEmployeeList.RowHeadersWidth = 51;
            dataGridViewEmployeeList.Size = new Size(411, 314);
            dataGridViewEmployeeList.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Small", 12F);
            label3.Location = new Point(17, 60);
            label3.Name = "label3";
            label3.Size = new Size(137, 27);
            label3.TabIndex = 0;
            label3.Text = "Employee list:";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 592);
            Controls.Add(groupBoxViewEmployee);
            Controls.Add(groupBoxEmpleados);
            Name = "Form1";
            Text = "Form1";
            groupBoxEmpleados.ResumeLayout(false);
            groupBoxEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEmployeeAge).EndInit();
            groupBoxViewEmployee.ResumeLayout(false);
            groupBoxViewEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmployeeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxEmpleados;
        private GroupBox groupBoxViewEmployee;
        private Label label2;
        private TextBox txtNameEmployee;
        private Label label1;
        private NumericUpDown numEmployeeAge;
        private Button btnAddEmployee;
        private Label lblDepartment;
        private TextBox txtDepartmentEmployee;
        private Label label3;
        private DataGridView dataGridViewEmployeeList;
    }
}
