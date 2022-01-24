namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeName = txtEmployeeName.Text;
            employee.EmployeeAge = Convert.ToInt32(txtEmployeeAge.Text);
            employee.EmployeePosition = txtEmployeePosition.Text;

            FrmDetails frmDetails = new FrmDetails();
            frmDetails.lblEmployeeName.Text = employee.EmployeeName;
            frmDetails.lblEmployeePostion.Text= employee.EmployeePosition.ToString();
            frmDetails.lblEmployeeAge.Text = employee.EmployeeAge.ToString();

            frmDetails.ShowDialog();
        }
    }
}