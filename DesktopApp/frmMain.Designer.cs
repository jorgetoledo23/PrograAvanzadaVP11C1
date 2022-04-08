namespace DesktopApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemVerEmpleados = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAgregarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemArchivarEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.gestionarEmpleadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // gestionarEmpleadosToolStripMenuItem
            // 
            this.gestionarEmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemVerEmpleados,
            this.MenuItemAgregarEmpleado,
            this.MenuItemEditarEmpleado,
            this.MenuItemArchivarEmpleado});
            this.gestionarEmpleadosToolStripMenuItem.Name = "gestionarEmpleadosToolStripMenuItem";
            this.gestionarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.gestionarEmpleadosToolStripMenuItem.Text = "Gestionar Empleados";
            // 
            // MenuItemVerEmpleados
            // 
            this.MenuItemVerEmpleados.Name = "MenuItemVerEmpleados";
            this.MenuItemVerEmpleados.Size = new System.Drawing.Size(265, 26);
            this.MenuItemVerEmpleados.Text = "Ver Empleados";
            this.MenuItemVerEmpleados.Click += new System.EventHandler(this.MenuItemVerEmpleados_Click);
            // 
            // MenuItemAgregarEmpleado
            // 
            this.MenuItemAgregarEmpleado.Name = "MenuItemAgregarEmpleado";
            this.MenuItemAgregarEmpleado.Size = new System.Drawing.Size(265, 26);
            this.MenuItemAgregarEmpleado.Text = "Agregar Nuevo Empleado";
            this.MenuItemAgregarEmpleado.Click += new System.EventHandler(this.MenuItemAgregarEmpleado_Click);
            // 
            // MenuItemEditarEmpleado
            // 
            this.MenuItemEditarEmpleado.Name = "MenuItemEditarEmpleado";
            this.MenuItemEditarEmpleado.Size = new System.Drawing.Size(265, 26);
            this.MenuItemEditarEmpleado.Text = "Editar Empleado";
            // 
            // MenuItemArchivarEmpleado
            // 
            this.MenuItemArchivarEmpleado.Name = "MenuItemArchivarEmpleado";
            this.MenuItemArchivarEmpleado.Size = new System.Drawing.Size(265, 26);
            this.MenuItemArchivarEmpleado.Text = "Archivar Empleado";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Menu Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem gestionarEmpleadosToolStripMenuItem;
        private ToolStripMenuItem MenuItemVerEmpleados;
        private ToolStripMenuItem MenuItemAgregarEmpleado;
        private ToolStripMenuItem MenuItemEditarEmpleado;
        private ToolStripMenuItem MenuItemArchivarEmpleado;
    }
}