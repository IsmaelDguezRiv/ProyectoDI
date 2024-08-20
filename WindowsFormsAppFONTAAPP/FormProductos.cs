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
    public partial class FormProductos : Form
    {
        public static FormProductos productos;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Productos_FormClosed(object sender, FormClosingEventArgs e)//FORMCLOSING
        {
            FormMenu.menu.Visible = true;
            productos = null;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.ComprasDetalle' Puede moverla o quitarla según sea necesario.
            this.comprasDetalleTableAdapter.Fill(this.database1DataSet.ComprasDetalle);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.VentasDetalle' Puede moverla o quitarla según sea necesario.
            this.ventasDetalleTableAdapter.Fill(this.database1DataSet.VentasDetalle);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.database1DataSet.Productos);
            groupBox1.Enabled = false;
            productos = this;
            toolStripStatusLabel1.Text = "";

            if (categoriaComboBox.Text == "Tubería ")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Grifería de paso")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Latiguillo")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Grifería")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Sifón")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Termo")
            {
                groupBoxTermo.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Calentador")
            {
                groupBoxTermo.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Tubos válvulas y reguladores de gas")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "WC")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Reparación e instalación WC")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Lavabo")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Bañera")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Plato Ducha")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Mampara Ducha")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Columna Ducha")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Accesorios")
            {
                groupBoxWC.Visible = false;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else
            {
                groupBoxWC.Visible = false;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            if (productosBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            if (productosBindingSource.Count > 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
            if (imagenPictureBox.Image == null)
            {
                imagenPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
          
            buttonAvanzar.Enabled = (productosBindingSource.Position < productosBindingSource.Count - 1);
            buttonRetroceder.Enabled = (productosBindingSource.Position > 0);
            buttonInicio.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position > 0);
            buttonFinal.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position < productosBindingSource.Count - 1);
            label2.Text = "Instalación " + (productosBindingSource.Position + 1) + " de " + (productosBindingSource.Count);
        }

        private void descripcionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            productos.Hide();
            FormMenu.menu.Visible = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            productosBindingSource.AddNew();
            toolStripStatusLabel1.Text = "Añadiendo Producto";
            groupBox1.Enabled = true;
            if (imagenPictureBox.Image == null)
            {
                imagenPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
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

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                errorProvider1.SetError(nombreTextBox, "Debe figurar el nombre del producto");
            }
            else if (string.IsNullOrEmpty(precioTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(precioTextBox, "Es necesario introducir un precio");
            }
            else if (cantidad_DisponibleNumericUpDown == null )
            {
                errorProvider1.Clear();
                errorProvider1.SetError(cantidad_DisponibleNumericUpDown, "Ingrese una cantidad válida");
            }          
            else if (string.IsNullOrEmpty(categoriaComboBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(categoriaComboBox, "Debe figurar una categoría");
            }
            else if (string.IsNullOrEmpty(marcaTextBox.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(marcaTextBox, "Es necesario introducir una marca");
            }
            else
            {
                toolStripStatusLabel1.Text = "";
                errorProvider1.Clear();
                productosBindingSource.EndEdit();

                groupBox1.Enabled = false;
                button1.Enabled = true;
                textBoxSearch.Enabled = true;
                buttonAdd.Enabled = true;
                buttonModify.Enabled = true;
                buttonRemove.Enabled = true;
                buttonSearch.Enabled = true;
                buttonSave.Enabled = true;
                buttonBack.Enabled = true;
                buttonAvanzar.Enabled = (productosBindingSource.Position < productosBindingSource.Count - 1);
                buttonRetroceder.Enabled = (productosBindingSource.Position > 0);
                buttonInicio.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position > 0);
                buttonFinal.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position < productosBindingSource.Count - 1);
            }
        }

        private void categoriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoriaComboBox.Text == "Tubería ")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Grifería de paso")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Latiguillo")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Grifería")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Sifón")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Termo")
            {
                groupBoxTermo.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Calentador")
            {
                groupBoxTermo.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Tubos válvulas y reguladores de gas")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "WC")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Reparación e instalación WC")
            {
                groupBoxTuberia.Visible = true;
                groupBoxTermo.Visible = false;
                groupBoxWC.Visible = false;
            }
            else if (categoriaComboBox.Text == "Lavabo")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Bañera")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Plato Ducha")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Mampara Ducha")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Columna Ducha")
            {
                groupBoxWC.Visible = true;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else if (categoriaComboBox.Text == "Accesorios")
            {
                groupBoxWC.Visible = false;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
            else
            {
                groupBoxWC.Visible = false;
                groupBoxTuberia.Visible = false;
                groupBoxTermo.Visible = false;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            errorProvider1.Clear();
            productosBindingSource.CancelEdit();

            groupBox1.Enabled = false;

            if (productosBindingSource.Count == 0)
            {
                buttonRemove.Enabled = false;
                buttonModify.Enabled = false;
            }
            else
            {
                buttonRemove.Enabled = true;
                buttonModify.Enabled = true;
            }
            if (productosBindingSource.Count > 0)
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
            buttonAvanzar.Enabled = (productosBindingSource.Position < productosBindingSource.Count - 1);
            buttonRetroceder.Enabled = (productosBindingSource.Position > 0);
            buttonInicio.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position > 0);
            buttonFinal.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position < productosBindingSource.Count - 1);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Modificando Producto";

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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de que quieres borrar este producto?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (comprasDetalleBindingSource.Find("Id_Producto", id_ProductoLabel1.Text) != -1 || ventasDetalleBindingSource.Find("Id_Producto", id_ProductoLabel1.Text) != -1)
                {
                    MessageBox.Show("Existen operaciones relacionadas con este producto, elimínelas para no comprometer la integridad del sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (productosBindingSource.Count > 0)
                    {
                        productosBindingSource.RemoveCurrent();
                    }
                    else
                    {
                        MessageBox.Show("No existe ningun producto que se pueda eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    if (productosBindingSource.Count == 0)
                    {
                        buttonRemove.Enabled = false;
                        buttonModify.Enabled = false;
                    }
                    else
                    {
                        buttonRemove.Enabled = true;
                        buttonModify.Enabled = true;
                    }
                    if (productosBindingSource.Count > 0)
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            tableAdapterManager.UpdateAll(database1DataSet);
            MessageBox.Show("La información se ha guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("") || productosBindingSource.Find("Id_Producto", textBoxSearch.Text) == -1)
            {
                MessageBox.Show("No existe producto con ese Identificador");
                textBoxSearch.Clear();
            }
            else
            {
                productosBindingSource.Position = productosBindingSource.Find("Id_Producto", textBoxSearch.Text);
            }
        }

        private void buttonInicio_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveFirst();
        }

        private void buttonRetroceder_Click(object sender, EventArgs e)
        {
            productosBindingSource.MovePrevious();
        }

        private void buttonAvanzar_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveNext();
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            productosBindingSource.MoveLast();
        }

        private void productosBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if (imagenPictureBox.Image == null)
            {
                imagenPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
            buttonAvanzar.Enabled = (productosBindingSource.Position < productosBindingSource.Count - 1);
            buttonRetroceder.Enabled = (productosBindingSource.Position > 0);
            buttonInicio.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position > 0);
            buttonFinal.Enabled = (productosBindingSource.Count > 1 && productosBindingSource.Position < productosBindingSource.Count - 1);
            label2.Text = "Producto " + (productosBindingSource.Position + 1) + " de " + (productosBindingSource.Count);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormInformeProducto ventprin = new FormInformeProducto();
            ventprin.Show();
        }

        private void imagenPictureBox_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*|" + "Archivos gráficos|*.bmp;*.gif;*.jpg;*.png";
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imagenPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
                imagenPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                imagenPictureBox.Image = Properties.Resources.photo_album_icon_image_symbol_or_no_image_flat_design_on_a_white_background_vector;
            }
        }

        private void FormProductos_Activated(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.ComprasDetalle' Puede moverla o quitarla según sea necesario.
            this.comprasDetalleTableAdapter.Fill(this.database1DataSet.ComprasDetalle);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.VentasDetalle' Puede moverla o quitarla según sea necesario.
            this.ventasDetalleTableAdapter.Fill(this.database1DataSet.VentasDetalle);
        }
    }
}
