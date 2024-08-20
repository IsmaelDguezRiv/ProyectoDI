using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppFONTAAPP
{
    public partial class FormMenu : Form
    {
        public static FormMenu menu;

        public FormMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FormCompras.compras == null)
            {
                FormCompras ventprin = new FormCompras();
                menu.Visible = false;
                ventprin.Show();
            }
            else
            {
                FormCompras.compras.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FormProductos.productos == null)
            {
                FormProductos ventprin = new FormProductos();
                menu.Visible = false;
                ventprin.Show();
            }
            else
            {
                FormProductos.productos.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (FormClientes.clientes == null)
            {
                FormClientes ventprin = new FormClientes();
                menu.Visible = false;
                ventprin.Show();
            }
            else
            {
                FormClientes.clientes.Visible = true;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            label1.Text = Properties.Settings.Default.Rol;
            if (Properties.Settings.Default.Rol == "INSTALADOR"){
                button7.Visible = false;
                button4.Visible = true;
                button5.Visible = false;
                button6.Visible = false;
            } else if (Properties.Settings.Default.Rol == "GERENTE")
            {
                button7.Visible = false;
                button4.Visible = false;
                button5.Visible = true;
                button6.Visible = true;
            } else if (Properties.Settings.Default.Rol == "ADMINISTRADOR")
            {
                button7.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
            }

            menu = this;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (FormInstalaciones.instalaciones == null)
            {
                FormInstalaciones ventprin = new FormInstalaciones();
                menu.Visible = false;
                ventprin.Show();
            }
            else
            {
                FormInstalaciones.instalaciones.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (FormVentas.ventas == null)
            {
                FormVentas ventprin = new FormVentas();
                menu.Visible = false;
                ventprin.Show();
            }
            else
            {
                FormVentas.ventas.Visible = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (FormProveedores.proveedores == null)
            {
                FormProveedores ventprin = new FormProveedores();
                menu.Visible = false;
                ventprin.Show();
            }
            else
            {
                FormProveedores.proveedores.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (FormEmpleados.empleados == null)
            {
                FormEmpleados ventprin = new FormEmpleados();
                menu.Visible = false;
                ventprin.Show();
            }
            else
            {
                FormEmpleados.empleados.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (FormCalculadora.calculadora == null) { 
            FormCalculadora ventprin = new FormCalculadora();
            ventprin.Show();
        }
               else
            {
                FormCalculadora.calculadora.Visible = true;
            }
        }

        private void FormMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormLogin.login.Visible = true;
            menu = null;
        }
    }
}
