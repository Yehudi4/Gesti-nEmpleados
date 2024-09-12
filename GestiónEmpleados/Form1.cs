namespace GestiónEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridViewEmployeeList.ColumnCount = 3;
            dataGridViewEmployeeList.Columns[0].Name = "Name";
            dataGridViewEmployeeList.Columns[1].Name = "Age";
            dataGridViewEmployeeList.Columns[2].Name = "Department";

            dataGridViewEmployeeList.DefaultCellStyle.Font = new Font("Arial", 12);
            dataGridViewEmployeeList.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNameEmployee.Text) && !string.IsNullOrEmpty(txtDepartmentEmployee.Text))
            {
                string name = txtNameEmployee.Text;
                int age = (int)numEmployeeAge.Value;
                string department = txtDepartmentEmployee.Text;

                dataGridViewEmployeeList.Rows.Add(name, age, department);

                txtNameEmployee.Clear();
                txtDepartmentEmployee.Clear();
                numEmployeeAge.Value = 18;
            }
            else
            {
                MessageBox.Show("Please complete all fields.");
            }
        }

        private void lblDepartment_Click(object sender, EventArgs e)
        {

        }
    }
}
