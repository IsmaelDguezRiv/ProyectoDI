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
    public partial class FormInstalaciones : Form
    {
        public static FormInstalaciones instalaciones;
        public FormInstalaciones()
        {
            InitializeComponent();
        }
        private void Instalaciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu.menu.Visible = true;
            instalaciones = null;
        }
        private void instalacionesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            buttonAvanzar.Enabled = (instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
            buttonRetroceder.Enabled = (instalacionesBindingSource.Position > 0);
            buttonInicio.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position > 0);
            buttonFinal.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
            label1.Text = "Instalación " + (instalacionesBindingSource.Position + 1) + " de " + (instalacionesBindingSource.Count);
        }

        private void FormInstalaciones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);
            groupBox1.Enabled = false;
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Instalaciones' Puede moverla o quitarla según sea necesario.
            this.instalacionesTableAdapter.Fill(this.database1DataSet.Instalaciones);
            instalaciones = this;
            toolStripStatusLabel1.Text = "";
            if (instalacionesBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            if (instalacionesBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            buttonAvanzar.Enabled = (instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
            buttonRetroceder.Enabled = (instalacionesBindingSource.Position > 0);
            buttonInicio.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position > 0);
            buttonFinal.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
            label1.Text = "Instalación " + (instalacionesBindingSource.Position + 1) + " de " + (instalacionesBindingSource.Count);
        }

        private void instalacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instalacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
        //RETROCEDER
        private void buttonBack_Click(object sender, EventArgs e)
        {
            instalaciones.Hide();
            FormMenu.menu.Visible = true;
        }
        //AÑADIR
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            instalacionesBindingSource.AddNew();
            toolStripStatusLabel1.Text = "Añadiendo Instalación";
            groupBox1.Enabled = true;

            button1.Enabled = false;
            textBoxSearch.Enabled = false;
            buttonFinal.Enabled = false;
            buttonInicio.Enabled = false;
            buttonBack.Enabled = false;
            buttonRetroceder.Enabled = false;
            buttonAvanzar.Enabled = false;
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonRemove.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSave.Enabled = false;
        }
        //ACEPTAR
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreComboBox.Text))
            {
                errorProvider1.SetError(nombreComboBox, "Debe figurar el Nombre Completo");
            }
            else if (string.IsNullOrEmpty(direccionTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(direccionTextBox, "Es necesario introducir una dirección");
            }
            else if (string.IsNullOrEmpty(contacto_ClienteTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(contacto_ClienteTextBox, "Introduzca el teléfono como medio de contacto");
            }
            else
            {
                toolStripStatusLabel1.Text = "";
                errorProvider1.Clear();
                instalacionesBindingSource.EndEdit();

                groupBox1.Enabled = false;

                button1.Enabled = true;
                textBoxSearch.Enabled = true;
                buttonAdd.Enabled = true;
                buttonModify.Enabled = true;
                buttonRemove.Enabled = true;
                buttonSearch.Enabled = true;
                buttonSave.Enabled = true;
                buttonBack.Enabled = true;
                buttonAvanzar.Enabled = (instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
                buttonRetroceder.Enabled = (instalacionesBindingSource.Position > 0);
                buttonInicio.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position > 0);
                buttonFinal.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
            }
        }
        //CANCELAR
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            errorProvider1.Clear();
            instalacionesBindingSource.CancelEdit();

            groupBox1.Enabled = false;
            if (instalacionesBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonModify.Enabled = true;
            }
            if (instalacionesBindingSource.Count > 0)
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
            buttonBack.Enabled = true;
            buttonAvanzar.Enabled = (instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
            buttonRetroceder.Enabled = (instalacionesBindingSource.Position > 0);
            buttonInicio.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position > 0);
            buttonFinal.Enabled = (instalacionesBindingSource.Count > 1 && instalacionesBindingSource.Position < instalacionesBindingSource.Count - 1);
        }
        //MODIFICAR
        private void buttonModify_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Modificando Instalación";
            groupBox1.Enabled = true;

            button1.Enabled = false;
            textBoxSearch.Enabled = false;
            buttonFinal.Enabled = false;
            buttonInicio.Enabled = false;
            buttonBack.Enabled = false;
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
            if (MessageBox.Show("¿Estas seguro de que quieres borrar esta instalación?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (instalacionesBindingSource.Count > 0)
                {
                    instalacionesBindingSource.RemoveCurrent();
                }
                else
                {
                    MessageBox.Show("No existe ninguna instalación que se pueda eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (instalacionesBindingSource.Count == 0)
                {
                    buttonRemove.Enabled = false;
                    buttonModify.Enabled = false;
                }
                else
                {
                    buttonRemove.Enabled = true;
                    buttonModify.Enabled = true;
                }
                if (instalacionesBindingSource.Count > 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
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
            if (textBoxSearch.Text.Equals("") || instalacionesBindingSource.Find("Id_Instalacion", textBoxSearch.Text) == -1)
            {
                MessageBox.Show("No existe instalación con ese Número");
                textBoxSearch.Clear();
            }
            else
            {
                instalacionesBindingSource.Position = instalacionesBindingSource.Find("Id_Instalacion", textBoxSearch.Text);
            }
        }
        //MOVIMIENTO
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            instalacionesBindingSource.MoveFirst();
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            instalacionesBindingSource.MovePrevious();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            instalacionesBindingSource.MoveNext();
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            instalacionesBindingSource.MoveLast();
        }

        private void nombreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                Database1DataSet.ClientesRow filaCliente;
                if (nombreComboBox.SelectedIndex != -1)
                {
                    filaCliente = database1DataSet.Clientes[nombreComboBox.SelectedIndex];

                    if (filaCliente.IsDireccionNull())
                    { direccionTextBox.Text = ""; }
                    else
                    { direccionTextBox.Text = filaCliente.Direccion; }

                    if (filaCliente.IsProvinciaNull())
                    { ciudadTextBox.Text = ""; }
                    else
                    { ciudadTextBox.Text = filaCliente.Provincia; }

                    if (filaCliente.IsTelefonoNull())
                    { contacto_ClienteTextBox.Text = ""; }
                    else
                    { contacto_ClienteTextBox.Text = filaCliente.Telefono; }

                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInformeInstalacion ventprin = new FormInformeInstalacion();
            ventprin.Show();
        }
    }
}
