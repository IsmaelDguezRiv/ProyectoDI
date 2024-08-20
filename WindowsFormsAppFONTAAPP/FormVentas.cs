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
    public partial class FormVentas : Form
    {
        public static FormVentas ventas;
        private bool botonModificado = false;
        private bool botonAnadido = false;
        public FormVentas()
        {
            InitializeComponent();
        }

        private void ventasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ventasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }
        private void Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormMenu.menu.Visible = true;
            ventas = null;
        }
        private void FormVentas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.VentasDetalle' Puede moverla o quitarla según sea necesario.
            this.ventasDetalleTableAdapter.Fill(this.database1DataSet.VentasDetalle);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.Fill(this.database1DataSet.Ventas);
            ventas = this;
            toolStripStatusLabel1.Text = "";

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            buttonAddDetail.Enabled = false;
            buttonRemoveDetail.Enabled = false;
            buttonBackDetail.Enabled = false;
            buttonFinish.Enabled = false;
            if (ventasBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }

            botonModificado = false;
            botonAnadido = false;
            if (ventasBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
          
            buttonAvanzar.Enabled = (ventasBindingSource.Position < ventasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (ventasBindingSource.Position > 0);
            buttonInicio.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position > 0);
            buttonFinal.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position < ventasBindingSource.Count - 1);
            label1.Text = "Venta " + (ventasBindingSource.Position + 1) + " de " + (ventasBindingSource.Count);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(this.database1DataSet);
            MessageBox.Show("Datos Guardados");

        }

        private void id_ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database1DataSet.ClientesRow filaCliente;
            if (id_ClienteComboBox.SelectedIndex != -1)
            {
                filaCliente = database1DataSet.Clientes[id_ClienteComboBox.SelectedIndex];

               
                if (filaCliente.IsNombreNull())
                { clienteTextBox.Text = ""; }
                else
                { clienteTextBox.Text = filaCliente.Nombre; }


                if (filaCliente.IsDireccionNull())
                { direccion_ClienteTextBox.Text = ""; }
                else
                { direccion_ClienteTextBox.Text = filaCliente.Direccion; }

                if (filaCliente.IsPoblacionNull())
                { poblacion_ClienteTextBox.Text = ""; }
                else
                { poblacion_ClienteTextBox.Text = filaCliente.Poblacion; }

                if (filaCliente.IsTelefonoNull())
                { telefono_ClienteTextBox.Text = ""; }
                else
                { telefono_ClienteTextBox.Text = filaCliente.Telefono; }

            }
        }

        private void id_ProductoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database1DataSet.ProductosRow filaProducto;
            if (id_ProductoComboBox.SelectedIndex != -1)
            {
                filaProducto = database1DataSet.Productos[id_ProductoComboBox.SelectedIndex];


                if (filaProducto.IsNombreNull())
                { nombreTextBox.Text = ""; }
                else
                { nombreTextBox.Text = filaProducto.Nombre; }


                if (filaProducto.IsCantidad_DisponibleNull())
                { unidadesNumericUpDown.Value = 0;
                unidadesNumericUpDown.Enabled = false;
                }
                else
                { unidadesNumericUpDown.Value = filaProducto.Cantidad_Disponible; }

                if (filaProducto.IsPesoNull())
                { precioTextBox.Text = "0,00"; }
                else
                { precioTextBox.Text = filaProducto.Precio.ToString() ; }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Añadiendo Venta";
            botonAnadido = true;
            textBoxSearch.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSave.Enabled = false;
            buttonBack.Enabled = false;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;  
            buttonModify.Enabled = false;
            ventasBindingSource.AddNew();
            buttonAvanzar.Enabled = false;
            buttonRetroceder.Enabled = false;
            buttonFinal.Enabled = false;
            buttonInicio.Enabled = false;
            button1.Enabled = false;
            groupBox1.Enabled = true;

        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_ClienteComboBox.Text))
            {
                errorProvider1.SetError(id_ClienteComboBox, "Debe figurar un Cliente valido");
            }
            else if (string.IsNullOrEmpty(clienteTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(clienteTextBox, "Debe figurar el Nombre Completo");
            }
            else if (string.IsNullOrEmpty(direccion_ClienteTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(direccion_ClienteTextBox, "Es necesario introducir una Dirección");
            }
            else if (string.IsNullOrEmpty(telefono_ClienteTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(telefono_ClienteTextBox, "Introduzca el teléfono");
            }
            else
            {
                errorProvider1.Clear();
                groupBox1.Enabled = false;
                buttonAddDetail.Enabled = true;
                if (ventasDetalleBindingSource.Count > 0)
                {
                    buttonRemoveDetail.Enabled = true;
                }
                else
                {
                    buttonRemoveDetail.Enabled = false;
                }
                buttonBackDetail.Enabled = true;
                buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
                buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
                if (ventasDetalleBindingSource.Count > 0)
                {
                    buttonFinish.Enabled = true;
                }
                else
                {
                    buttonFinish.Enabled = false;
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (botonModificado == true)
            {
                botonModificado = false;
            }
            if (botonAnadido == true)
            {
               
                 while (ventasDetalleBindingSource.Count > 0)
                {
                    ventasDetalleBindingSource.RemoveCurrent();
                }
                botonAnadido = false;
            }
            toolStripStatusLabel1.Text = "";
            ventasBindingSource.CancelEdit();
            textBoxSearch.Enabled = true;
            groupBox1.Enabled = false;
            buttonSearch.Enabled = true;
            buttonSave.Enabled = true;
            buttonBack.Enabled = true;
            buttonAdd.Enabled = true;
            if (ventasBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonModify.Enabled = true;
            }
            if (ventasBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
            buttonAvanzar.Enabled = (ventasBindingSource.Position < ventasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (ventasBindingSource.Position > 0);
            buttonInicio.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position > 0);
            buttonFinal.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position < ventasBindingSource.Count - 1);
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
          
            ventasDetalleBindingSource.AddNew();
            groupBox2.Enabled = true;
            buttonAddDetail.Enabled = false;
            buttonRemoveDetail.Enabled = false;
            buttonBackDetail.Enabled = false;
            buttonAvanzarDetail.Enabled = false;
            buttonRetrocederDetail.Enabled = false;
            buttonFinish.Enabled = false;
        }
        private void buttonRemoveDetail_Click(object sender, EventArgs e)
        {
            ventasDetalleBindingSource.RemoveCurrent();
            if (ventasDetalleBindingSource.Count > 0)
            {
                buttonRemoveDetail.Enabled = true;
            }
            else
            {
                buttonRemoveDetail.Enabled = false;
            }
            //GUARDADO CLAVE DUAL MODIFY( metodo en save que compruebe si hay duplicidad en PK y anteponga la nueva entrada, deshabilitar combobox opcion de duplicidad)
            if (botonModificado == true)
            {
                tableAdapterManager.UpdateAll(this.database1DataSet);
            }
        }
        private bool ProductoExistente(string nuevoIdProducto, int filaActual)
        {
            foreach (DataGridViewRow fila in ventasDetalleDataGridView.Rows)
            {
                if (fila.Index != filaActual && fila.Cells[1].Value != null && fila.Cells[1].Value.ToString() == nuevoIdProducto)
                {
                    return true;
                }
            }

            return false;
        }

        private void buttonAcceptDetail_Click(object sender, EventArgs e)
        {
            string nuevoIdProducto = id_ProductoComboBox.SelectedValue?.ToString();
            int filaActual = ventasDetalleDataGridView.CurrentCell?.RowIndex ?? -1;

            if (filaActual >= 0 && ProductoExistente(nuevoIdProducto, filaActual))
            {
                MessageBox.Show("El producto ya existe en la lista.");
                return;
            }

            if (string.IsNullOrEmpty(id_ProductoComboBox.Text))
                {
                    errorProvider1.SetError(id_ProductoComboBox, "Debe figurar un producto");
                }
                else if (string.IsNullOrEmpty(nombreTextBox.Text))
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(nombreTextBox, "Debe figurar el nombre del producto");
                }
                else
                {
                    errorProvider1.Clear();
                    ventasDetalleBindingSource.EndEdit();
                    groupBox2.Enabled = false;
                    buttonAddDetail.Enabled = true;
                    if (ventasDetalleBindingSource.Count > 0)
                    {
                        buttonRemoveDetail.Enabled = true;
                    }
                    else
                    {
                        buttonRemoveDetail.Enabled = false;
                    }
                    buttonBackDetail.Enabled = true;
                    buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
                    buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
                    buttonFinish.Enabled = true;
                }
            
        }

        private void buttonCancelDetail_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ventasDetalleBindingSource.CancelEdit();
            groupBox2.Enabled=false;
            buttonAddDetail.Enabled = true;
            if (ventasDetalleBindingSource.Count > 0)
            {
                buttonRemoveDetail.Enabled = true;
            }
            else
            {
                buttonRemoveDetail.Enabled = false;
            }
            buttonBackDetail.Enabled = true;
            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
            if (ventasDetalleBindingSource.Count > 0)
            {
                buttonFinish.Enabled = true;
            }
            else
            {
                buttonFinish.Enabled = false;
            }
        }
        private void buttonBackDetail_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonAddDetail.Enabled = false;
            buttonRemoveDetail.Enabled = false;            
            buttonBackDetail.Enabled = false;
            buttonAvanzarDetail.Enabled = false;
            buttonRetrocederDetail.Enabled = false;
            buttonFinish.Enabled = false;            
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            if (botonModificado = true)
            {
                botonModificado = false;
            }
            if (botonAnadido = true)
            {
                botonAnadido = false;
            }
            toolStripStatusLabel1.Text = "";
            sumaTotal();
            ventasBindingSource.EndEdit();
            textBoxSearch.Enabled = true;
            buttonAddDetail.Enabled = false;
            buttonRemoveDetail.Enabled = false;
            buttonBackDetail.Enabled = false;
            buttonFinish.Enabled=false;
            groupBox2.Enabled = false;
            buttonSearch.Enabled = true;
            buttonSave.Enabled = true;
            buttonBack.Enabled = true;
            buttonAdd.Enabled = true;
            buttonRemove.Enabled = true;
            buttonModify.Enabled = true;
            buttonAvanzar.Enabled = (ventasBindingSource.Position < ventasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (ventasBindingSource.Position > 0);
            buttonInicio.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position > 0);
            buttonFinal.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position < ventasBindingSource.Count - 1);
            if (ventasBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Modificando Venta";
            buttonSearch.Enabled = false;
            buttonSave.Enabled = false;
            buttonBack.Enabled = false;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
            buttonModify.Enabled = false;
            buttonAvanzarDetail.Enabled = false;
            buttonRetrocederDetail.Enabled = false;
            buttonAvanzar.Enabled = false;
            buttonRetroceder.Enabled = false;
            buttonFinal.Enabled = false;
            buttonInicio.Enabled = false;
            button1.Enabled = false;
            groupBox1.Enabled = true;
            botonModificado = true;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de que quieres borrar esta venta?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                while (ventasDetalleBindingSource.Count > 0)
                {
                    ventasDetalleBindingSource.RemoveCurrent();
                }
                ventasBindingSource.RemoveCurrent();
                if (ventasBindingSource.Count == 0)
                {
                    buttonRemove.Enabled = false;
                    buttonModify.Enabled = false;
                }
                else
                {
                    buttonRemove.Enabled = true;
                    buttonModify.Enabled = true;
                }
                if (ventasBindingSource.Count > 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button1.Enabled = false;
                }
            }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveFirst();
            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MovePrevious();
            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveNext();
            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            ventasBindingSource.MoveLast();
            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
        }

        private void ventasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            buttonAvanzar.Enabled = (ventasBindingSource.Position < ventasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (ventasBindingSource.Position > 0);
            buttonInicio.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position > 0);
            buttonFinal.Enabled = (ventasBindingSource.Count > 1 && ventasBindingSource.Position < ventasBindingSource.Count - 1);
            label1.Text = "Venta " + (ventasBindingSource.Position + 1) + " de " + (ventasBindingSource.Count);
        }

        private void buttonRetrocederDetail_Click(object sender, EventArgs e)
        {
            ventasDetalleBindingSource.MovePrevious();
        }

        private void buttonAvanzarDetail_Click(object sender, EventArgs e)
        {
            ventasDetalleBindingSource.MoveNext();
        }

        private void ventasDetalleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            buttonAvanzarDetail.Enabled = (ventasDetalleBindingSource.Position < ventasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (ventasDetalleBindingSource.Position > 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IdVenta = int.Parse(id_VentaLabel1.Text);
            FormInformeVenta ventprin = new FormInformeVenta();
            ventprin.Show();
          
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || ventasBindingSource.Find("Id_Venta", textBoxSearch.Text) == -1)
            {
                MessageBox.Show("No existe venta con ese Número");
                textBoxSearch.Clear();
            }
            else
            {
                productosBindingSource.Position = productosBindingSource.Find("Id_Venta", textBoxSearch.Text);
            }
        }

        private void sumaTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow fila in ventasDetalleDataGridView.Rows)
            {
                if (fila.Cells[5].Value != DBNull.Value) //!valores null 
                {
                    total += Convert.ToDecimal(fila.Cells[5].Value);
                }
            }
            totalLabel1.Text = total.ToString();
        }

        private void sumaImporte()
        {
            if (!string.IsNullOrEmpty(precioTextBox.Text))
            {
                importeLabel1.Text = ((decimal.Parse(precioTextBox.Text) * unidadesNumericUpDown.Value)).ToString("0.00");
            }
        }

        private void unidadesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sumaImporte();
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            sumaImporte();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ventas.Hide();
            FormMenu.menu.Visible = true;
        }

        private void FormVentas_Activated(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);
        }

        private void ventasDetalleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
