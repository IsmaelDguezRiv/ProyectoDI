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
    public partial class FormLogin : Form
    {
        public static FormLogin login;
        public FormLogin()
        {
            InitializeComponent();
            label_contrasenaVisible.Visible = false;
        }

        private void checkBox_mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_mostrar.Checked)
            {
                textBox2.PasswordChar = '\0';
                label_contrasenaVisible.Visible = true;
            }
            else
            {
                textBox2.PasswordChar = '*';
                label_contrasenaVisible.Visible = false;
            }
        }

        private void button_acceder_Click(object sender, EventArgs e)
        {
            Database1DataSet.EmpleadosRow fila;
            if (empleadosBindingSource.Find("Usuario", textBox1.Text) != -1)
            {
                fila = (Database1DataSet.EmpleadosRow)database1DataSet.Empleados.Rows[empleadosBindingSource.Find("Usuario", textBox1.Text)];
                if (fila.Password == textBox2.Text)
                {
                    Properties.Settings.Default.Rol = fila.Rol;
                    Properties.Settings.Default.Usuario = fila.Usuario;
                    Properties.Settings.Default.Nombre = fila.Nombre;
                    FormMenu ventprin = new FormMenu();
                    this.Visible = false;
                    ventprin.Show();
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Usario incorrecto");
            }
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.database1DataSet.Empleados);
            login = this;
        }
    }
}
