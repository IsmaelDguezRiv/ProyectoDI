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
    public partial class FormEmpleados : Form
    {
        public static FormEmpleados empleados;
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void comprasDetalleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
        private void Empleados_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu.menu.Visible = true;
            empleados = null;
        }
        private void empleadosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (fotoPictureBox.Image == null)
            {
                fotoPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
            buttonAvanzar.Enabled = (empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
            buttonRetroceder.Enabled = (empleadosBindingSource.Position > 0);
            buttonInicio.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position > 0);
            buttonFinal.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
            label1.Text = "Empleado " + (empleadosBindingSource.Position + 1) + " de " + (empleadosBindingSource.Count);
        }
        private void FormEmpelados_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.database1DataSet.Empleados);
            empleados = this;
            toolStripStatusLabel1.Text = "";

            if (empleadosBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
          
            if (empleadosBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (fotoPictureBox.Image == null)
            {
                fotoPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
            buttonAvanzar.Enabled = (empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
            buttonRetroceder.Enabled = (empleadosBindingSource.Position > 0);
            buttonInicio.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position > 0);
            buttonFinal.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
            label1.Text = "Empleado " + (empleadosBindingSource.Position + 1) + " de " + (empleadosBindingSource.Count);
        }
        //RETROCEDER
        private void buttonBack_Click(object sender, EventArgs e)
        {
            empleados.Hide();
            FormMenu.menu.Visible = true;
        }
        //AÑADIR
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (fotoPictureBox.Image == null)
            {
                fotoPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
            empleadosBindingSource.AddNew();
            toolStripStatusLabel1.Text = "Añadiendo Empleado";
            groupBox1.Enabled = true;
            button1.Enabled = false;
            textBoxSearch.Enabled = false;
            buttonFinal.Enabled = false;
            buttonInicio.Enabled = false;
            buttonRetroceder.Enabled = false;
            buttonAvanzar.Enabled = false;
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonRemove.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSave.Enabled = false;
        }
        //MODIFICAR
        private void buttonModify_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Modificando Empleado";
            groupBox1.Enabled = true;
            button1.Enabled = false;
            textBoxSearch.Enabled = false;
            buttonFinal.Enabled = false;
            buttonInicio.Enabled = false;
            buttonRetroceder.Enabled = false;
            buttonAvanzar.Enabled = false;
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonRemove.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSave.Enabled = false;
        }
        //ELIMINAR
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de que quieres borrar este empleado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (empleadosBindingSource.Count > 0)
                {
                    empleadosBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("No existe ningún cliente que se pueda empleado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (empleadosBindingSource.Count == 0)
                {
                    buttonRemove.Enabled = false;
                    buttonModify.Enabled = false;
                }
                else
                {
                    buttonRemove.Enabled = true;
                    buttonModify.Enabled = true;
                }
                if (empleadosBindingSource.Count > 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
        }
        //ACEPTAR
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rolComboBox.Text))
            {
                errorProvider1.SetError(rolComboBox, "Debe figurar un Rol valido");
            }
            else if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Debe figurar el Nombre Completo");
            }
            else if (string.IsNullOrEmpty(dNITextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(dNITextBox, "Es necesario introducir un NIF ó CIF");
            }
            else if (string.IsNullOrEmpty(telefonoTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(telefonoTextBox, "Introduzca el teléfono como medio de contacto");
            }
            else
            {
                toolStripStatusLabel1.Text = "";
                errorProvider1.Clear();
                empleadosBindingSource.EndEdit();

                groupBox1.Enabled = false;
                button1.Enabled = true;
                textBoxSearch.Enabled = true;
                buttonAdd.Enabled = true;
                buttonModify.Enabled = true;
                buttonRemove.Enabled = true;
                buttonSearch.Enabled = true;
                buttonSave.Enabled = true;
                if (empleadosBindingSource.Count == 0)
                {
                    buttonRemove.Enabled = false;
                    buttonModify.Enabled = false;
                }
                if (empleadosBindingSource.Count > 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
                buttonAvanzar.Enabled = (empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
                buttonRetroceder.Enabled = (empleadosBindingSource.Position > 0);
                buttonInicio.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position > 0);
                buttonFinal.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
            }
        }
        //CANCELAR
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            errorProvider1.Clear();
            empleadosBindingSource.CancelEdit();

            groupBox1.Enabled = false;
            if (empleadosBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonModify.Enabled = true;
            }
            if (empleadosBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            textBoxSearch.Enabled = true;
            buttonAdd.Enabled = true;
            buttonModify.Enabled = true;
            buttonRemove.Enabled = true;
            buttonSearch.Enabled = true;
            buttonSave.Enabled = true;
            buttonAvanzar.Enabled = (empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
            buttonRetroceder.Enabled = (empleadosBindingSource.Position > 0);
            buttonInicio.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position > 0);
            buttonFinal.Enabled = (empleadosBindingSource.Count > 1 && empleadosBindingSource.Position < empleadosBindingSource.Count - 1);
        }
        //GUARDAR
        private void buttonSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(database1DataSet);
            MessageBox.Show("La información se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //BUSCAR
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || empleadosBindingSource.Find("Id_Empleado", textBoxSearch.Text) == -1)
            {
                MessageBox.Show("No existe empleado con ese Identificador");
                textBoxSearch.Clear();
            }
            else
            {
                empleadosBindingSource.Position = empleadosBindingSource.Find("Id_Empleado", textBoxSearch.Text);
            }
        }
        //MOVIMIENTO
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveFirst();
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MovePrevious();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveNext();
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            empleadosBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInformeEmpleado ventprin = new FormInformeEmpleado();
            ventprin.Show();
        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fotoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                fotoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                fotoPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
        }
    }
}
