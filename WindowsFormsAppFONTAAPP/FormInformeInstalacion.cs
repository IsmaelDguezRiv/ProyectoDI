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
    public partial class FormInformeInstalacion : Form
    {
        public FormInformeInstalacion()
        {
            InitializeComponent();
        }

        private void FormInformeInstalacion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Instalaciones' Puede moverla o quitarla según sea necesario.
            this.instalacionesTableAdapter.Fill(this.database1DataSet.Instalaciones);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            switch (comboBox1.Text)
            {
                case "Ciudad":
                    instalacionesBindingSource.Filter = "Ciudad= " + "'" + textBox1.Text + "'";
                    break;
                case "Código Postal":
                    instalacionesBindingSource.Filter = "Código_Postal= " + "'" + textBox1.Text + "'";
                    break;

            }
            reportViewer1.RefreshReport();
        }

        private void instalacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.instalacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            instalacionesBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
