using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsAppFONTAAPP
{
    public partial class FormInformeCliente : Form
    {
        public FormInformeCliente()
        {
            InitializeComponent();
        }

        private void FormInformeCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.database1DataSet.Clientes);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Provincia":
                    clientesBindingSource.Filter = "Provincia= " + "'" + textBox1.Text + "'";
                    break;
                case "País":
                    clientesBindingSource.Filter = "Pais= " + "'" + textBox1.Text + "'";
                    break;
                case "Tipo Cliente":
                    clientesBindingSource.Filter = "Tipo_Cliente= " + "'" + textBox1.Text + "'";
                    break;

            }
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            clientesBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
