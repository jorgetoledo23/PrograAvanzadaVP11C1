namespace DesktopApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void MenuItemVerEmpleados_Click(object sender, EventArgs e)
        {
            //Mostrar Empleados 
            VerEmpleados verEmp = new VerEmpleados();
            verEmp.ShowDialog();
        }

        private void MenuItemAgregarEmpleado_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Se produjo el evento Click del MenuItem");
            frmAgregarEmpleado frmAE = new frmAgregarEmpleado();
            frmAE.ShowDialog();
            //frmAE.Show();
        }
    }
}