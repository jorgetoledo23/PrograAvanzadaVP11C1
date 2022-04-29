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
    public partial class VerEmpleados : Form
    {
        public VerEmpleados()
        {
            InitializeComponent();
            LlenarListView();
        }

        private void LlenarListView()
        {
            listViewEmpleados.Items.Clear();
            using (var context = new AppDbContext())
            {
                var Empleados = context.Empleados.ToList();
                foreach (var item in Empleados)
                {
                    ListViewItem lvItem = new ListViewItem();
                    lvItem.Text = item.Id.ToString();
                    lvItem.SubItems.Add(item.Rut);
                    lvItem.SubItems.Add(item.Name);
                    lvItem.SubItems.Add(item.LastName);
                    lvItem.SubItems.Add(item.Correo);
                    lvItem.SubItems.Add(item.Telefono);
                    lvItem.SubItems.Add(item.TipoEmpleado.ToString());

                    listViewEmpleados.Items.Add(lvItem);
                }
            }
        }
    }

    

}
