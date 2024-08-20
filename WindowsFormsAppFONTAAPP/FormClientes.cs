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
    public partial class FormClientes : Form
    {
        public static FormClientes clientes;
        public FormClientes()
        {
            InitializeComponent();
        }
        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu.menu.Visible = true;
            clientes = null;
        }
        private void clientesBindingSource_PositionChanged(object sender, EventArgs e)
        {
            buttonAvanzar.Enabled = (clientesBindingSource.Position < clientesBindingSource.Count - 1);
            buttonRetroceder.Enabled = (clientesBindingSource.Position > 0);
            buttonInicio.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position > 0);
            buttonFinal.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position < clientesBindingSource.Count - 1);
            label1.Text = "Cliente " + (clientesBindingSource.Position + 1) + " de " + (clientesBindingSource.Count);
        }
        private void FormClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.database1DataSet.Ventas);
            groupBox1.Enabled = false;
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);
            clientes = this;
            toolStripStatusLabel1.Text = "";

            if (clientesBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            if (clientesBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            buttonAvanzar.Enabled = (clientesBindingSource.Position < clientesBindingSource.Count - 1);
            buttonRetroceder.Enabled = (clientesBindingSource.Position > 0);
            buttonInicio.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position > 0);
            buttonFinal.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position < clientesBindingSource.Count - 1);
            label1.Text = "Cliente " + (clientesBindingSource.Position + 1) + " de " + (clientesBindingSource.Count);
        }
        //RETROCEDER
        private void buttonBack_Click(object sender, EventArgs e)
        {
            clientes.Hide();
            FormMenu.menu.Visible = true;
        }
        //AÑADIR
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            clientesBindingSource.AddNew();
            toolStripStatusLabel1.Text = "Añadiendo Cliente";
            groupBox1.Enabled = true;
            button1.Enabled = false;
            textBoxSearch.Enabled = false;
            buttonFinal.Enabled = false;
            buttonBack.Enabled = false;
            buttonInicio.Enabled = false;
            buttonRetroceder.Enabled = false;
            buttonAvanzar.Enabled = false;
            buttonAdd.Enabled = false;
            buttonModify.Enabled = false;
            buttonRemove.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSave.Enabled = false;
            button1.Enabled = false;
        }
        //ACEPTAR
        private void buttonAccept_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tipo_ClienteComboBox.Text))
            {
                
                errorProvider1.SetError(tipo_ClienteComboBox, "Introduzca de que cliente se trata");
            }
            else if (string.IsNullOrEmpty(cIF_DNITextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cIF_DNITextBox, "Es necesario introducir un NIF ó CIF");
            }
            else if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(nombreTextBox, "Debe figurar el Nombre Completo");
            }
            else if (string.IsNullOrEmpty(direccionTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(direccionTextBox, "Introduzca una dirección");
            }
            else if (string.IsNullOrEmpty(provinciaTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(provinciaTextBox, "Es necesario introducir una Provincia");
            }
            else if (string.IsNullOrEmpty(paisTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(paisTextBox, "Debe figurar un País");
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
                clientesBindingSource.EndEdit();

                groupBox1.Enabled = false;
                button1.Enabled = true;
                textBoxSearch.Enabled = true;
                buttonAdd.Enabled = true;
                buttonModify.Enabled = true;
                buttonRemove.Enabled = true;
                buttonSearch.Enabled = true;
                buttonBack.Enabled = true;
                buttonSave.Enabled = true;
                buttonAvanzar.Enabled = (clientesBindingSource.Position < clientesBindingSource.Count - 1);
                buttonRetroceder.Enabled = (clientesBindingSource.Position > 0);
                buttonInicio.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position > 0);
                buttonFinal.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position < clientesBindingSource.Count - 1);
            }
        }
        //CANCELAR
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            errorProvider1.Clear();
            clientesBindingSource.CancelEdit();

            groupBox1.Enabled = false;
            if (clientesBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonModify.Enabled = true;
            }
            if (clientesBindingSource.Count > 0)
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
            buttonBack.Enabled = true;
            buttonSave.Enabled = true;
            buttonAvanzar.Enabled = (clientesBindingSource.Position < clientesBindingSource.Count - 1);
            buttonRetroceder.Enabled = (clientesBindingSource.Position > 0);
            buttonInicio.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position > 0);
            buttonFinal.Enabled = (clientesBindingSource.Count > 1 && clientesBindingSource.Position < clientesBindingSource.Count - 1);
        }
        //MODIFICAR
        private void buttonModify_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Modificando Cliente";
            groupBox1.Enabled = true;
            button1.Enabled = false;
            textBoxSearch.Enabled = false;
            buttonFinal.Enabled = false;
            buttonBack.Enabled = false;
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
            if (MessageBox.Show("¿Estas seguro de que quieres borrar este cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (ventasBindingSource.Find("Id_Cliente",id_ClienteLabel1.Text ) != -1)
                {
                    MessageBox.Show("Existen operaciones relacionadas a este cliente, elimine antes esas ventas para no comprometer la integridad del sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                if (clientesBindingSource.Count > 0) { 
                clientesBindingSource.RemoveCurrent();
                } else
                {
                    MessageBox.Show("No existe ningún cliente que se pueda eliminar","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (clientesBindingSource.Count == 0)
                {
                    buttonRemove.Enabled = false;
                    buttonModify.Enabled = false;
                }
                else
                {
                    buttonRemove.Enabled = true;
                    buttonModify.Enabled = true;
                }
                if (clientesBindingSource.Count > 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
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
            if (textBoxSearch.Text.Equals("") || clientesBindingSource.Find("Id_Cliente", textBoxSearch.Text) == -1)
            {
                MessageBox.Show("No existe cliente con ese Identificador");
                textBoxSearch.Clear();
            }
            else
            {
                clientesBindingSource.Position = clientesBindingSource.Find("Id_Cliente", textBoxSearch.Text);
            }
        }
        //MOVIMIENTO
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveFirst();
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MovePrevious();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveNext();
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            clientesBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInformeCliente ventprin = new FormInformeCliente();
            ventprin.Show();
        }

        private void tipo_ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormClientes_Activated(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.database1DataSet.Ventas);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);
        }
    }
}
