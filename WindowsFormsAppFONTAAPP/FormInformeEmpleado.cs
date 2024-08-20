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
    public partial class FormInformeEmpleado : Form
    {
        public FormInformeEmpleado()
        {
            InitializeComponent();
        }

        private void FormInformeEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'database1DataSet.Empleados' Puede moverla o quitarla según sea necesario.
            this.empleadosTableAdapter.Fill(this.database1DataSet.Empleados);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Rol":
                    empleadosBindingSource.Filter = "Rol= " + "'" + textBox1.Text + "'";
                    break;
            }
            reportViewer1.RefreshReport();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox1.Text = "";
            empleadosBindingSource.Filter = "";
            reportViewer1.RefreshReport();
        }
    }
}
