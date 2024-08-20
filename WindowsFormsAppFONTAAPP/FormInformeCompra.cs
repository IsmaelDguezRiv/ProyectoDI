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
    public partial class FormInformeCompra : Form
    {
        public FormInformeCompra()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void FormInformeCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.ComprasDetalle' Puede moverla o quitarla según sea necesario.
            this.comprasDetalleTableAdapter.FillByIdCompra(this.database1DataSet.ComprasDetalle, Properties.Settings.Default.IdCompra);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.FillByCompra(this.database1DataSet.Compras, Properties.Settings.Default.IdCompra);

            this.reportViewer1.RefreshReport();
        }
    }
}
