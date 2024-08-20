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
    public partial class FormInformeProveedor : Form
    {
        public FormInformeProveedor()
        {
            InitializeComponent();
        }

        private void FormInformeProveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.database1DataSet.Proveedores);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Provincia":
                    proveedoresBindingSource.Filter = "Provincia= " + "'" + textBox1.Text + "'";
                    break;
                case "País":
                    proveedoresBindingSource.Filter = "Pais= " + "'" + textBox1.Text + "'";
                    break;

            }
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            proveedoresBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
