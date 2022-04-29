using DesktopApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class frmAgregarEmpleado : Form
    {
        public frmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Empleado Emp = new Empleado();
            Emp.Name = txtNombre.Text;
            Emp.Rut = txtRut.Text;
            Emp.Correo = txtCorreo.Text;
            Emp.Telefono = txtTelefono.Text;
            Emp.LastName = txtApellidos.Text;
            Emp.TipoEmpleado = TipoEmpleado.Vendedor;

            using (AppDbContext context = new AppDbContext())
            {
                //context.Update(Emp);
                //context.Remove(Emp);


                context.Add(Emp);
                context.SaveChanges();
            }

            MessageBox.Show("Empleado Agregado","INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LimpiarCajas();
        }

        private void LimpiarCajas()
        {
            txtRut.Text = String.Empty;
            txtCorreo.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtApellidos.Text = String.Empty;
            txtTelefono.Text = String.Empty;
        }
    }
}
