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
    public partial class FormProveedores : Form
    {
        public static FormProveedores proveedores;
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
        private void Proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu.menu.Visible = true;
            proveedores = null;
        }
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.database1DataSet.Compras);
            groupBox1.Enabled = false;
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.database1DataSet.Proveedores);
            proveedores = this;
            toolStripStatusLabel1.Text = "";
            if (proveedoresBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            if (proveedoresBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            buttonAvanzar.Enabled = (proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
            buttonRetroceder.Enabled = (proveedoresBindingSource.Position > 0);
            buttonInicio.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position > 0);
            buttonFinal.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
            label1.Text = "Proveedor " + (proveedoresBindingSource.Position + 1) + " de " + (proveedoresBindingSource.Count);
        }
        private void proveedoresBindingSource_PositionChanged(object sender, EventArgs e)
        {
            buttonAvanzar.Enabled = (proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
            buttonRetroceder.Enabled = (proveedoresBindingSource.Position > 0);
            buttonInicio.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position > 0);
            buttonFinal.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
            label1.Text = "Proveedor " + (proveedoresBindingSource.Position + 1) + " de " + (proveedoresBindingSource.Count);
        }

        //RETROCEDER
        private void buttonBack_Click(object sender, EventArgs e)
        {
            proveedores.Hide();
            FormMenu.menu.Visible = true;
        }
        //GUARDAR
        private void buttonSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(database1DataSet);
            MessageBox.Show("La información se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //AÑADIR
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.AddNew();
            toolStripStatusLabel1.Text = "Añadiendo Proveedor";
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
            groupBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Modificando Proveedor";
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
            if (MessageBox.Show("¿Estas seguro de que quieres borrar este proveedor?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (comprasBindingSource.Find("Id_Proveedor", id_ProveedorLabel1.Text) != -1)
                {
                    MessageBox.Show("Existen operaciones relacionadas a este proveedor, elimine antes esas compras para no comprometer la integridad del sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (proveedoresBindingSource.Count > 0)
                    {
                        proveedoresBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show("No existe ningún proveedor que se pueda eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (proveedoresBindingSource.Count == 0)
                    {
                        buttonRemove.Enabled = false;
                        buttonModify.Enabled = false;
                    }
                    else
                    {
                        buttonRemove.Enabled = true;
                        buttonModify.Enabled = true;
                    }
                    if (proveedoresBindingSource.Count > 0)
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
        //ACEPTAR
        private void buttonAccept_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cIF_DNITextBox.Text))
            {
                
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
                proveedoresBindingSource.EndEdit();

                groupBox1.Enabled = false;
                button1.Enabled = true;
                textBoxSearch.Enabled = true;
                buttonAdd.Enabled = true;
                buttonModify.Enabled = true;
                buttonRemove.Enabled = true;
                buttonSearch.Enabled = true;
                buttonSave.Enabled = true;
                buttonAvanzar.Enabled = (proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
                buttonRetroceder.Enabled = (proveedoresBindingSource.Position > 0);
                buttonInicio.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position > 0);
                buttonFinal.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
            }
        }
        //CANCELAR
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            errorProvider1.Clear();
            proveedoresBindingSource.CancelEdit();

            groupBox1.Enabled = false;
            if (proveedoresBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonModify.Enabled = true;
            }
            if (proveedoresBindingSource.Count > 0)
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
            buttonAvanzar.Enabled = (proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
            buttonRetroceder.Enabled = (proveedoresBindingSource.Position > 0);
            buttonInicio.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position > 0);
            buttonFinal.Enabled = (proveedoresBindingSource.Count > 1 && proveedoresBindingSource.Position < proveedoresBindingSource.Count - 1);
        }
        //BUSCAR
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || proveedoresBindingSource.Find("Id_Proveedor", textBoxSearch.Text) == -1)
            {
                MessageBox.Show("No existe proveedor con ese Identificador");
                textBoxSearch.Clear();
            }
            else
            {
                proveedoresBindingSource.Position = proveedoresBindingSource.Find("Id_Proveedor", textBoxSearch.Text);
            }
        }
        //MOVIMIENTO
        private void buttonInicio_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.MoveFirst();
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.MovePrevious();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.MoveNext();
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            proveedoresBindingSource.MoveLast();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInformeProveedor ventprin = new FormInformeProveedor();
            ventprin.Show();
        }

        private void FormProveedores_Activated(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.database1DataSet.Compras);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.database1DataSet.Proveedores);
        }
    }
}
