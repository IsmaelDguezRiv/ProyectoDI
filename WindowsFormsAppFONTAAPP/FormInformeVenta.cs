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
    public partial class FormInformeVenta : Form
    {
        public FormInformeVenta()
        {
            InitializeComponent();
        }

        private void FormInformeVenta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.VentasDetalle' Puede moverla o quitarla según sea necesario.
            this.ventasDetalleTableAdapter.FillByIdVenta(this.database1DataSet.VentasDetalle, Properties.Settings.Default.IdVenta);
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Ventas' Puede moverla o quitarla según sea necesario.
            this.ventasTableAdapter.FillByVenta(this.database1DataSet.Ventas, Properties.Settings.Default.IdVenta);

            this.reportViewer1.RefreshReport();
        }
    }
}
