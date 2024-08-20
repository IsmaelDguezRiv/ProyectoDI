using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppFONTAAPP
{
    public partial class FormCompras : Form
    {
        public static FormCompras compras;
        private bool botonModificado = false;
        private bool botonAnadido = false;
       
        public FormCompras()
        {
            InitializeComponent();
        }

        private void Compras_FormClosing(object sender, FormClosingEventArgs e)//FORMCLOSING
        {
            FormMenu.menu.Visible = true;
            compras = null;
        }
        private void FormCompras_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.database1DataSet.Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.ComprasDetalle' Puede moverla o quitarla según sea necesario.
            this.comprasDetalleTableAdapter.Fill(this.database1DataSet.ComprasDetalle);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.database1DataSet.Compras);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.database1DataSet.Proveedores);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.ComprasDetalle' Puede moverla o quitarla según sea necesario.
            this.comprasDetalleTableAdapter.Fill(this.database1DataSet.ComprasDetalle);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.database1DataSet.Compras);
            compras = this;
            toolStripStatusLabel1.Text = "";

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            buttonAddDetail.Enabled = false;
            buttonRemoveDetail.Enabled = false;
            buttonBackDetail.Enabled = false;
            buttonFinish.Enabled = false;
            if (comprasBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }

            botonModificado = false;
            botonAnadido = false;

            if (comprasBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }

            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
           
            buttonAvanzar.Enabled = (comprasBindingSource.Position < comprasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (comprasBindingSource.Position > 0);
            buttonInicio.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position > 0);
            buttonFinal.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position < comprasBindingSource.Count - 1);
            label1.Text = "Compra " + (comprasBindingSource.Position + 1) + " de " + (comprasBindingSource.Count);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            compras.Hide();
            FormMenu.menu.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(this.database1DataSet);
            MessageBox.Show("Datos Guardados");
        }

        private void id_ProveedorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database1DataSet.ProveedoresRow filaProveedor;
            if (id_ProveedorComboBox.SelectedIndex != -1)
            {
                filaProveedor = database1DataSet.Proveedores[id_ProveedorComboBox.SelectedIndex];


                if (filaProveedor.IsNombreNull())
                { proveedorTextBox.Text = ""; }
                else
                { proveedorTextBox.Text = filaProveedor.Nombre; }


                if (filaProveedor.IsDireccionNull())
                { direccion_ProveedorTextBox.Text = ""; }
                else
                { direccion_ProveedorTextBox.Text = filaProveedor.Direccion; }

                if (filaProveedor.IsPoblacionNull())
                { poblacion_ProveedorTextBox.Text = ""; }
                else
                { poblacion_ProveedorTextBox.Text = filaProveedor.Poblacion; }

                if (filaProveedor.IsCIF_DNINull())
                { cIF_DNITextBox.Text = ""; }
                else
                { cIF_DNITextBox.Text = filaProveedor.CIF_DNI; }

                if (filaProveedor.IsTelefonoNull())
                { telefono_ProveedorTextBox.Text = ""; }
                else
                { telefono_ProveedorTextBox.Text = filaProveedor.Telefono; }

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
                {
                    unidadesNumericUpDown.Value = 0;
                    unidadesNumericUpDown.Enabled = false;
                }
                else
                { unidadesNumericUpDown.Value = filaProducto.Cantidad_Disponible; }

                if (filaProducto.IsPesoNull())
                { precioTextBox.Text = "0,00"; }
                else
                { precioTextBox.Text = filaProducto.Precio.ToString(); }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Añadiendo Compra";
            botonAnadido = true;
            textBoxSearch.Enabled = false;
            buttonSearch.Enabled = false;
            buttonSave.Enabled = false;
            buttonBack.Enabled = false;
            buttonAdd.Enabled = false;
            buttonRemove.Enabled = false;
            buttonModify.Enabled = false;
            comprasBindingSource.AddNew();
            buttonAvanzar.Enabled = false;
            buttonRetroceder.Enabled = false;
            buttonFinal.Enabled = false;
            buttonInicio.Enabled = false;
            button1.Enabled = false;
            groupBox1.Enabled = true;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_ProveedorComboBox.Text))
            {
                errorProvider1.SetError(id_ProveedorComboBox, "Debe figurar un Cliente valido");
            }
            else if (string.IsNullOrEmpty(proveedorTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(proveedorTextBox, "Debe figurar el Nombre Completo");
            }
            else if (string.IsNullOrEmpty(direccion_ProveedorTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(direccion_ProveedorTextBox, "Es necesario introducir una Dirección");
            }
            else if (string.IsNullOrEmpty(telefono_ProveedorTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(telefono_ProveedorTextBox, "Introduzca el teléfono");
            }
            else
            {
                errorProvider1.Clear();
                groupBox1.Enabled = false;
                buttonAddDetail.Enabled = true;
                if (comprasDetalleBindingSource.Count > 0)
                {
                    buttonRemoveDetail.Enabled = true;
                }
                else
                {
                    buttonRemoveDetail.Enabled = false;
                }
                buttonBackDetail.Enabled = true;
                buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
                buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
                if (comprasDetalleBindingSource.Count > 0)
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

                while (comprasDetalleBindingSource.Count > 0)
                {
                    comprasDetalleBindingSource.RemoveCurrent();
                }
                botonAnadido = false;
            }
            toolStripStatusLabel1.Text = "";
            comprasBindingSource.CancelEdit();
            textBoxSearch.Enabled = true;
            groupBox1.Enabled = false;
            buttonSearch.Enabled = true;
            buttonSave.Enabled = true;
            buttonBack.Enabled = true;
            buttonAdd.Enabled = true;
            if (comprasBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonModify.Enabled = true;
            }
            if (comprasBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
            buttonAvanzar.Enabled = (comprasBindingSource.Position < comprasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (comprasBindingSource.Position > 0);
            buttonInicio.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position > 0);
            buttonFinal.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position < comprasBindingSource.Count - 1);
        }

        private void buttonAddDetail_Click(object sender, EventArgs e)
        {
            
            comprasDetalleBindingSource.AddNew();
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
            comprasDetalleBindingSource.RemoveCurrent();
            if (comprasDetalleBindingSource.Count > 0)
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
            foreach (DataGridViewRow fila in comprasDetalleDataGridView.Rows)
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
            int filaActual = comprasDetalleDataGridView.CurrentCell?.RowIndex ?? -1;

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
                    comprasDetalleBindingSource.EndEdit();
                    groupBox2.Enabled = false;
                    buttonAddDetail.Enabled = true;
                    if (comprasDetalleBindingSource.Count > 0)
                    {
                        buttonRemoveDetail.Enabled = true;
                    }
                    else
                    {
                        buttonRemoveDetail.Enabled = false;
                    }
                    buttonBackDetail.Enabled = true;
                    buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
                    buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
                    buttonFinish.Enabled = true;
                }
            
        }

        private void buttonCancelDetail_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            comprasDetalleBindingSource.CancelEdit();
            groupBox2.Enabled = false;
            buttonAddDetail.Enabled = true;
            if (comprasDetalleBindingSource.Count > 0)
            {
                buttonRemoveDetail.Enabled = true;
            }
            else
            {
                buttonRemoveDetail.Enabled = false;
            }
            buttonBackDetail.Enabled = true;
            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
            if (comprasDetalleBindingSource.Count > 0)
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
            comprasBindingSource.EndEdit();
            textBoxSearch.Enabled = true;
            buttonAddDetail.Enabled = false;
            buttonRemoveDetail.Enabled = false;
            buttonBackDetail.Enabled = false;
            buttonFinish.Enabled = false;
            groupBox2.Enabled = false;
            buttonSearch.Enabled = true;
            buttonSave.Enabled = true;
            buttonBack.Enabled = true;
            buttonAdd.Enabled = true;
            buttonRemove.Enabled = true;
            buttonModify.Enabled = true;
            buttonAvanzar.Enabled = (comprasBindingSource.Position < comprasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (comprasBindingSource.Position > 0);
            buttonInicio.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position > 0);
            buttonFinal.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position < comprasBindingSource.Count - 1);
            if (comprasBindingSource.Count > 0)
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
            toolStripStatusLabel1.Text = "Modificando Compra";
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
                while (comprasDetalleBindingSource.Count > 0)
                {
                    comprasDetalleBindingSource.RemoveCurrent();
                }
                comprasBindingSource.RemoveCurrent();
               
                if (comprasBindingSource.Count == 0)
                {
                    buttonRemove.Enabled = false;
                    buttonModify.Enabled = false;
                }
                else
                {
                    buttonRemove.Enabled = true;
                    buttonModify.Enabled = true;
                }
                if (comprasBindingSource.Count > 0)
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
            comprasBindingSource.MoveFirst();
            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MovePrevious();
            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveNext();
            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            comprasBindingSource.MoveLast();
            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
        }

        private void comprasBindingSource_PositionChanged(object sender, EventArgs e)
        {
            buttonAvanzar.Enabled = (comprasBindingSource.Position < comprasBindingSource.Count - 1);
            buttonRetroceder.Enabled = (comprasBindingSource.Position > 0);
            buttonInicio.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position > 0);
            buttonFinal.Enabled = (comprasBindingSource.Count > 1 && comprasBindingSource.Position < comprasBindingSource.Count - 1);
            label1.Text = "Compra " + (comprasBindingSource.Position + 1) + " de " + (comprasBindingSource.Count);
        }

        private void buttonRetrocederDetail_Click(object sender, EventArgs e)
        {
            comprasDetalleBindingSource.MovePrevious();

        }

        private void buttonAvanzarDetail_Click(object sender, EventArgs e)
        {
            comprasDetalleBindingSource.MoveNext();
        }

        private void comprasDetalleBindingSource_PositionChanged(object sender, EventArgs e)
        {
            buttonAvanzarDetail.Enabled = (comprasDetalleBindingSource.Position < comprasDetalleBindingSource.Count - 1);
            buttonRetrocederDetail.Enabled = (comprasDetalleBindingSource.Position > 0);
        }
    

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || comprasBindingSource.Find("Id_Compra", textBoxSearch.Text) == -1)
            {
                MessageBox.Show("No existe compra con ese Número");
                textBoxSearch.Clear();
            }
            else
            {
                productosBindingSource.Position = productosBindingSource.Find("Id_Compra", textBoxSearch.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IdCompra = int.Parse(id_CompraLabel1.Text);
            FormInformeCompra ventprin = new FormInformeCompra();                
                ventprin.Show();
          
        }

        /*private void restringirIdProducto()
         {
             foreach (DataGridViewRow fila in comprasDetalleDataGridView.Rows)
             {
                if (fila.Cells[1].Value == id_ProductoComboBox.ValueMember)
                 {
                    id_ProductoComboBox.Items[indice].Enabled = false;
                 }
             }

         }*/

        private void sumaImporte()
        {
            if (!string.IsNullOrEmpty(precioTextBox.Text))
            {
                importeLabel1.Text = ((decimal.Parse(precioTextBox.Text) * unidadesNumericUpDown.Value)).ToString("0.00");
            }
        }

            private void sumaTotal() {
            decimal total = 0;
            foreach (DataGridViewRow fila in comprasDetalleDataGridView.Rows)
            {
                if (fila.Cells[5].Value != DBNull.Value) //!valores null 
                {
                    total += Convert.ToDecimal(fila.Cells[5].Value);
                }
            }
            totalLabel1.Text = total.ToString();
        }

        private void unidadesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            sumaImporte();
        }

        private void precioTextBox_TextChanged(object sender, EventArgs e)
        {
            sumaImporte();
        }

        private void FormCompras_Activated(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.database1DataSet.Proveedores);
        }
    }
}
