namespace WindowsFormsAppFONTAAPP
{
    partial class FormVentas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_VentaLabel;
            System.Windows.Forms.Label fecha_RealizacionLabel;
            System.Windows.Forms.Label id_ClienteLabel;
            System.Windows.Forms.Label clienteLabel;
            System.Windows.Forms.Label direccion_ClienteLabel;
            System.Windows.Forms.Label poblacion_ClienteLabel;
            System.Windows.Forms.Label telefono_ClienteLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label id_VentaLabel2;
            System.Windows.Forms.Label id_ProductoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label unidadesLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label importeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentas));
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFinal = new System.Windows.Forms.Button();
            this.buttonAvanzar = new System.Windows.Forms.Button();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.database1DataSet = new WindowsFormsAppFONTAAPP.Database1DataSet();
            this.ventasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.VentasTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ClientesTableAdapter();
            this.productosTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ProductosTableAdapter();
            this.ventasDetalleTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.VentasDetalleTableAdapter();
            this.id_VentaLabel1 = new System.Windows.Forms.Label();
            this.fecha_RealizacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.id_ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.direccion_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.poblacion_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.telefono_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.importeLabel1 = new System.Windows.Forms.Label();
            this.ventasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.unidadesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.id_ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_VentaLabel3 = new System.Windows.Forms.Label();
            this.buttonCancelDetail = new System.Windows.Forms.Button();
            this.buttonAcceptDetail = new System.Windows.Forms.Button();
            this.buttonAddDetail = new System.Windows.Forms.Button();
            this.buttonRemoveDetail = new System.Windows.Forms.Button();
            this.buttonBackDetail = new System.Windows.Forms.Button();
            this.buttonRetrocederDetail = new System.Windows.Forms.Button();
            this.buttonAvanzarDetail = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_VentaLabel = new System.Windows.Forms.Label();
            fecha_RealizacionLabel = new System.Windows.Forms.Label();
            id_ClienteLabel = new System.Windows.Forms.Label();
            clienteLabel = new System.Windows.Forms.Label();
            direccion_ClienteLabel = new System.Windows.Forms.Label();
            poblacion_ClienteLabel = new System.Windows.Forms.Label();
            telefono_ClienteLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            id_VentaLabel2 = new System.Windows.Forms.Label();
            id_ProductoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_VentaLabel
            // 
            id_VentaLabel.AutoSize = true;
            id_VentaLabel.Location = new System.Drawing.Point(93, 25);
            id_VentaLabel.Name = "id_VentaLabel";
            id_VentaLabel.Size = new System.Drawing.Size(96, 13);
            id_VentaLabel.TabIndex = 20;
            id_VentaLabel.Text = "Número de Venta :";
            // 
            // fecha_RealizacionLabel
            // 
            fecha_RealizacionLabel.AutoSize = true;
            fecha_RealizacionLabel.Location = new System.Drawing.Point(419, 25);
            fecha_RealizacionLabel.Name = "fecha_RealizacionLabel";
            fecha_RealizacionLabel.Size = new System.Drawing.Size(101, 13);
            fecha_RealizacionLabel.TabIndex = 21;
            fecha_RealizacionLabel.Text = "Fecha Realización :";
            // 
            // id_ClienteLabel
            // 
            id_ClienteLabel.AutoSize = true;
            id_ClienteLabel.Location = new System.Drawing.Point(70, 16);
            id_ClienteLabel.Name = "id_ClienteLabel";
            id_ClienteLabel.Size = new System.Drawing.Size(45, 13);
            id_ClienteLabel.TabIndex = 22;
            id_ClienteLabel.Text = "Cliente :";
            // 
            // clienteLabel
            // 
            clienteLabel.AutoSize = true;
            clienteLabel.Location = new System.Drawing.Point(7, 43);
            clienteLabel.Name = "clienteLabel";
            clienteLabel.Size = new System.Drawing.Size(97, 13);
            clienteLabel.TabIndex = 23;
            clienteLabel.Text = "Nombre Completo :";
            // 
            // direccion_ClienteLabel
            // 
            direccion_ClienteLabel.AutoSize = true;
            direccion_ClienteLabel.Location = new System.Drawing.Point(7, 69);
            direccion_ClienteLabel.Name = "direccion_ClienteLabel";
            direccion_ClienteLabel.Size = new System.Drawing.Size(58, 13);
            direccion_ClienteLabel.TabIndex = 24;
            direccion_ClienteLabel.Text = "Dirección :";
            // 
            // poblacion_ClienteLabel
            // 
            poblacion_ClienteLabel.AutoSize = true;
            poblacion_ClienteLabel.Location = new System.Drawing.Point(5, 95);
            poblacion_ClienteLabel.Name = "poblacion_ClienteLabel";
            poblacion_ClienteLabel.Size = new System.Drawing.Size(60, 13);
            poblacion_ClienteLabel.TabIndex = 25;
            poblacion_ClienteLabel.Text = "Población :";
            // 
            // telefono_ClienteLabel
            // 
            telefono_ClienteLabel.AutoSize = true;
            telefono_ClienteLabel.Location = new System.Drawing.Point(386, 95);
            telefono_ClienteLabel.Name = "telefono_ClienteLabel";
            telefono_ClienteLabel.Size = new System.Drawing.Size(55, 13);
            telefono_ClienteLabel.TabIndex = 26;
            telefono_ClienteLabel.Text = "Teléfono :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(19, 49);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(48, 13);
            totalLabel.TabIndex = 63;
            totalLabel.Text = "TOTAL :";
            // 
            // id_VentaLabel2
            // 
            id_VentaLabel2.AutoSize = true;
            id_VentaLabel2.Location = new System.Drawing.Point(67, 30);
            id_VentaLabel2.Name = "id_VentaLabel2";
            id_VentaLabel2.Size = new System.Drawing.Size(104, 13);
            id_VentaLabel2.TabIndex = 63;
            id_VentaLabel2.Text = "Venta Relacionada :";
            // 
            // id_ProductoLabel
            // 
            id_ProductoLabel.AutoSize = true;
            id_ProductoLabel.Location = new System.Drawing.Point(42, 209);
            id_ProductoLabel.Name = "id_ProductoLabel";
            id_ProductoLabel.Size = new System.Drawing.Size(132, 13);
            id_ProductoLabel.TabIndex = 64;
            id_ProductoLabel.Text = "Identificador de Producto :";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(102, 251);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(50, 13);
            nombreLabel.TabIndex = 65;
            nombreLabel.Text = "Nombre :";
            // 
            // unidadesLabel
            // 
            unidadesLabel.AutoSize = true;
            unidadesLabel.Location = new System.Drawing.Point(99, 277);
            unidadesLabel.Name = "unidadesLabel";
            unidadesLabel.Size = new System.Drawing.Size(58, 13);
            unidadesLabel.TabIndex = 66;
            unidadesLabel.Text = "Unidades :";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(288, 277);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(43, 13);
            precioLabel.TabIndex = 67;
            precioLabel.Text = "Precio :";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(19, 21);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(62, 13);
            importeLabel.TabIndex = 68;
            importeLabel.Text = "IMPORTE :";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_refuse_remove_delete_12601;
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemove.Location = new System.Drawing.Point(12, 299);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(102, 93);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluepencil_azul_12512;
            this.buttonModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonModify.Location = new System.Drawing.Point(12, 200);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(102, 93);
            this.buttonModify.TabIndex = 7;
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluepaper_azu_12590;
            this.buttonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAdd.Location = new System.Drawing.Point(12, 101);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 93);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonFinal
            // 
            this.buttonFinal.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.fast_forward_button_icon_icons_com_72760;
            this.buttonFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonFinal.FlatAppearance.BorderSize = 0;
            this.buttonFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinal.Location = new System.Drawing.Point(589, 67);
            this.buttonFinal.Name = "buttonFinal";
            this.buttonFinal.Size = new System.Drawing.Size(75, 23);
            this.buttonFinal.TabIndex = 19;
            this.buttonFinal.UseVisualStyleBackColor = true;
            this.buttonFinal.Click += new System.EventHandler(this.buttonFinal_Click);
            // 
            // buttonAvanzar
            // 
            this.buttonAvanzar.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.start_button_icon_icons_com_53873;
            this.buttonAvanzar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAvanzar.FlatAppearance.BorderSize = 0;
            this.buttonAvanzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvanzar.Location = new System.Drawing.Point(508, 67);
            this.buttonAvanzar.Name = "buttonAvanzar";
            this.buttonAvanzar.Size = new System.Drawing.Size(75, 23);
            this.buttonAvanzar.TabIndex = 18;
            this.buttonAvanzar.UseVisualStyleBackColor = true;
            this.buttonAvanzar.Click += new System.EventHandler(this.buttonAvanzar_Click);
            // 
            // buttonRetroceder
            // 
            this.buttonRetroceder.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.start_button_icon_icons_com_53873___copia;
            this.buttonRetroceder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRetroceder.FlatAppearance.BorderSize = 0;
            this.buttonRetroceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetroceder.Location = new System.Drawing.Point(217, 67);
            this.buttonRetroceder.Name = "buttonRetroceder";
            this.buttonRetroceder.Size = new System.Drawing.Size(75, 23);
            this.buttonRetroceder.TabIndex = 17;
            this.buttonRetroceder.UseVisualStyleBackColor = true;
            this.buttonRetroceder.Click += new System.EventHandler(this.buttonRetroceder_Click);
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.media_skip_backward_icon_238849;
            this.buttonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Location = new System.Drawing.Point(136, 67);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(75, 23);
            this.buttonInicio.TabIndex = 16;
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluediskserver_azul_disc_12555;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Location = new System.Drawing.Point(894, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 70);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(198, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(325, 20);
            this.textBoxSearch.TabIndex = 14;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(529, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(190, 23);
            this.buttonSearch.TabIndex = 13;
            this.buttonSearch.Text = "Buscar por Número de Venta";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_arrow_left_12428;
            this.buttonBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBack.Location = new System.Drawing.Point(810, 12);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(70, 70);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ventasBindingSource
            // 
            this.ventasBindingSource.DataMember = "Ventas";
            this.ventasBindingSource.DataSource = this.database1DataSet;
            this.ventasBindingSource.PositionChanged += new System.EventHandler(this.ventasBindingSource_PositionChanged);
            // 
            // ventasTableAdapter
            // 
            this.ventasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.ComprasDetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.InstalacionesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasDetalleTableAdapter = this.ventasDetalleTableAdapter;
            this.tableAdapterManager.VentasTableAdapter = this.ventasTableAdapter;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // ventasDetalleTableAdapter
            // 
            this.ventasDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // id_VentaLabel1
            // 
            this.id_VentaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Id_Venta", true));
            this.id_VentaLabel1.Location = new System.Drawing.Point(190, 25);
            this.id_VentaLabel1.Name = "id_VentaLabel1";
            this.id_VentaLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_VentaLabel1.TabIndex = 21;
            this.id_VentaLabel1.Text = "label1";
            // 
            // fecha_RealizacionDateTimePicker
            // 
            this.fecha_RealizacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasBindingSource, "Fecha_Realizacion", true));
            this.fecha_RealizacionDateTimePicker.Location = new System.Drawing.Point(526, 19);
            this.fecha_RealizacionDateTimePicker.Name = "fecha_RealizacionDateTimePicker";
            this.fecha_RealizacionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_RealizacionDateTimePicker.TabIndex = 22;
            // 
            // id_ClienteComboBox
            // 
            this.id_ClienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasBindingSource, "Id_Cliente", true));
            this.id_ClienteComboBox.DataSource = this.clientesBindingSource;
            this.id_ClienteComboBox.DisplayMember = "Nombre";
            this.id_ClienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_ClienteComboBox.FormattingEnabled = true;
            this.id_ClienteComboBox.Location = new System.Drawing.Point(130, 13);
            this.id_ClienteComboBox.Name = "id_ClienteComboBox";
            this.id_ClienteComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_ClienteComboBox.TabIndex = 23;
            this.id_ClienteComboBox.ValueMember = "Id_Cliente";
            this.id_ClienteComboBox.SelectedIndexChanged += new System.EventHandler(this.id_ClienteComboBox_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.database1DataSet;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Cliente", true));
            this.clienteTextBox.Location = new System.Drawing.Point(110, 40);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(681, 20);
            this.clienteTextBox.TabIndex = 24;
            // 
            // direccion_ClienteTextBox
            // 
            this.direccion_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Direccion_Cliente", true));
            this.direccion_ClienteTextBox.Location = new System.Drawing.Point(110, 66);
            this.direccion_ClienteTextBox.Name = "direccion_ClienteTextBox";
            this.direccion_ClienteTextBox.Size = new System.Drawing.Size(681, 20);
            this.direccion_ClienteTextBox.TabIndex = 25;
            // 
            // poblacion_ClienteTextBox
            // 
            this.poblacion_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Poblacion_Cliente", true));
            this.poblacion_ClienteTextBox.Location = new System.Drawing.Point(110, 92);
            this.poblacion_ClienteTextBox.Name = "poblacion_ClienteTextBox";
            this.poblacion_ClienteTextBox.Size = new System.Drawing.Size(261, 20);
            this.poblacion_ClienteTextBox.TabIndex = 26;
            // 
            // telefono_ClienteTextBox
            // 
            this.telefono_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Telefono_Cliente", true));
            this.telefono_ClienteTextBox.Location = new System.Drawing.Point(446, 92);
            this.telefono_ClienteTextBox.Name = "telefono_ClienteTextBox";
            this.telefono_ClienteTextBox.Size = new System.Drawing.Size(345, 20);
            this.telefono_ClienteTextBox.TabIndex = 27;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(749, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 61;
            this.buttonCancel.Text = "Cancelar ❌";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.Location = new System.Drawing.Point(668, 195);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 60;
            this.buttonAccept.Text = "Aceptar ✔";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(fecha_RealizacionLabel);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.id_VentaLabel1);
            this.groupBox1.Controls.Add(this.buttonAccept);
            this.groupBox1.Controls.Add(id_VentaLabel);
            this.groupBox1.Controls.Add(this.fecha_RealizacionDateTimePicker);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 224);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENTA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(id_ClienteLabel);
            this.groupBox3.Controls.Add(this.direccion_ClienteTextBox);
            this.groupBox3.Controls.Add(clienteLabel);
            this.groupBox3.Controls.Add(direccion_ClienteLabel);
            this.groupBox3.Controls.Add(this.clienteTextBox);
            this.groupBox3.Controls.Add(telefono_ClienteLabel);
            this.groupBox3.Controls.Add(this.poblacion_ClienteTextBox);
            this.groupBox3.Controls.Add(poblacion_ClienteLabel);
            this.groupBox3.Controls.Add(this.telefono_ClienteTextBox);
            this.groupBox3.Controls.Add(this.id_ClienteComboBox);
            this.groupBox3.Location = new System.Drawing.Point(11, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 121);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.ventasDetalleDataGridView);
            this.groupBox2.Controls.Add(precioLabel);
            this.groupBox2.Controls.Add(this.precioTextBox);
            this.groupBox2.Controls.Add(unidadesLabel);
            this.groupBox2.Controls.Add(this.unidadesNumericUpDown);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Controls.Add(id_ProductoLabel);
            this.groupBox2.Controls.Add(this.id_ProductoComboBox);
            this.groupBox2.Controls.Add(id_VentaLabel2);
            this.groupBox2.Controls.Add(this.id_VentaLabel3);
            this.groupBox2.Controls.Add(this.buttonCancelDetail);
            this.groupBox2.Controls.Add(this.buttonAcceptDetail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(230, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 322);
            this.groupBox2.TabIndex = 63;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE VENTA";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(importeLabel);
            this.groupBox4.Controls.Add(this.totalLabel1);
            this.groupBox4.Controls.Add(totalLabel);
            this.groupBox4.Controls.Add(this.importeLabel1);
            this.groupBox4.Location = new System.Drawing.Point(498, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(197, 84);
            this.groupBox4.TabIndex = 70;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio ";
            // 
            // totalLabel1
            // 
            this.totalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasBindingSource, "Total", true));
            this.totalLabel1.Location = new System.Drawing.Point(82, 49);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(100, 23);
            this.totalLabel1.TabIndex = 64;
            this.totalLabel1.Text = "label1";
            // 
            // importeLabel1
            // 
            this.importeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasDetalleBindingSource, "Importe", true));
            this.importeLabel1.Location = new System.Drawing.Point(82, 21);
            this.importeLabel1.Name = "importeLabel1";
            this.importeLabel1.Size = new System.Drawing.Size(100, 23);
            this.importeLabel1.TabIndex = 69;
            this.importeLabel1.Text = "label1";
            // 
            // ventasDetalleBindingSource
            // 
            this.ventasDetalleBindingSource.DataMember = "FK_VentasDetalle";
            this.ventasDetalleBindingSource.DataSource = this.ventasBindingSource;
            this.ventasDetalleBindingSource.PositionChanged += new System.EventHandler(this.ventasDetalleBindingSource_PositionChanged);
            // 
            // ventasDetalleDataGridView
            // 
            this.ventasDetalleDataGridView.AllowUserToAddRows = false;
            this.ventasDetalleDataGridView.AllowUserToDeleteRows = false;
            this.ventasDetalleDataGridView.AllowUserToResizeColumns = false;
            this.ventasDetalleDataGridView.AllowUserToResizeRows = false;
            this.ventasDetalleDataGridView.AutoGenerateColumns = false;
            this.ventasDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventasDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.ventasDetalleDataGridView.DataSource = this.ventasDetalleBindingSource;
            this.ventasDetalleDataGridView.Location = new System.Drawing.Point(49, 54);
            this.ventasDetalleDataGridView.Name = "ventasDetalleDataGridView";
            this.ventasDetalleDataGridView.ReadOnly = true;
            this.ventasDetalleDataGridView.Size = new System.Drawing.Size(646, 143);
            this.ventasDetalleDataGridView.TabIndex = 69;
            this.ventasDetalleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ventasDetalleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Venta";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Venta";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unidades";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Importe";
            this.dataGridViewTextBoxColumn6.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasDetalleBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(334, 274);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 68;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // unidadesNumericUpDown
            // 
            this.unidadesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ventasDetalleBindingSource, "Unidades", true));
            this.unidadesNumericUpDown.Location = new System.Drawing.Point(160, 275);
            this.unidadesNumericUpDown.Name = "unidadesNumericUpDown";
            this.unidadesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.unidadesNumericUpDown.TabIndex = 67;
            this.unidadesNumericUpDown.ValueChanged += new System.EventHandler(this.unidadesNumericUpDown_ValueChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasDetalleBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(160, 248);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(274, 20);
            this.nombreTextBox.TabIndex = 66;
            // 
            // id_ProductoComboBox
            // 
            this.id_ProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.ventasDetalleBindingSource, "Id_Producto", true));
            this.id_ProductoComboBox.DataSource = this.productosBindingSource;
            this.id_ProductoComboBox.DisplayMember = "Nombre";
            this.id_ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_ProductoComboBox.FormattingEnabled = true;
            this.id_ProductoComboBox.Location = new System.Drawing.Point(180, 206);
            this.id_ProductoComboBox.Name = "id_ProductoComboBox";
            this.id_ProductoComboBox.Size = new System.Drawing.Size(86, 21);
            this.id_ProductoComboBox.TabIndex = 65;
            this.id_ProductoComboBox.ValueMember = "Id_Producto";
            this.id_ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.id_ProductoComboBox_SelectedIndexChanged);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.database1DataSet;
            // 
            // id_VentaLabel3
            // 
            this.id_VentaLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ventasDetalleBindingSource, "Id_Venta", true));
            this.id_VentaLabel3.Location = new System.Drawing.Point(177, 30);
            this.id_VentaLabel3.Name = "id_VentaLabel3";
            this.id_VentaLabel3.Size = new System.Drawing.Size(100, 23);
            this.id_VentaLabel3.TabIndex = 64;
            this.id_VentaLabel3.Text = "label1";
            // 
            // buttonCancelDetail
            // 
            this.buttonCancelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelDetail.Location = new System.Drawing.Point(653, 293);
            this.buttonCancelDetail.Name = "buttonCancelDetail";
            this.buttonCancelDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelDetail.TabIndex = 63;
            this.buttonCancelDetail.Text = "Cancelar ❌";
            this.buttonCancelDetail.UseVisualStyleBackColor = true;
            this.buttonCancelDetail.Click += new System.EventHandler(this.buttonCancelDetail_Click);
            // 
            // buttonAcceptDetail
            // 
            this.buttonAcceptDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptDetail.Location = new System.Drawing.Point(572, 293);
            this.buttonAcceptDetail.Name = "buttonAcceptDetail";
            this.buttonAcceptDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptDetail.TabIndex = 62;
            this.buttonAcceptDetail.Text = "Aceptar ✔";
            this.buttonAcceptDetail.UseVisualStyleBackColor = true;
            this.buttonAcceptDetail.Click += new System.EventHandler(this.buttonAcceptDetail_Click);
            // 
            // buttonAddDetail
            // 
            this.buttonAddDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_insert_append_12490;
            this.buttonAddDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddDetail.Location = new System.Drawing.Point(134, 361);
            this.buttonAddDetail.Name = "buttonAddDetail";
            this.buttonAddDetail.Size = new System.Drawing.Size(75, 68);
            this.buttonAddDetail.TabIndex = 65;
            this.buttonAddDetail.UseVisualStyleBackColor = true;
            this.buttonAddDetail.Click += new System.EventHandler(this.buttonAddDetail_Click);
            // 
            // buttonRemoveDetail
            // 
            this.buttonRemoveDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_delete_delete_12489;
            this.buttonRemoveDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveDetail.Location = new System.Drawing.Point(134, 435);
            this.buttonRemoveDetail.Name = "buttonRemoveDetail";
            this.buttonRemoveDetail.Size = new System.Drawing.Size(75, 68);
            this.buttonRemoveDetail.TabIndex = 66;
            this.buttonRemoveDetail.UseVisualStyleBackColor = true;
            this.buttonRemoveDetail.Click += new System.EventHandler(this.buttonRemoveDetail_Click);
            // 
            // buttonBackDetail
            // 
            this.buttonBackDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_arrow_left_12459;
            this.buttonBackDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackDetail.Location = new System.Drawing.Point(134, 509);
            this.buttonBackDetail.Name = "buttonBackDetail";
            this.buttonBackDetail.Size = new System.Drawing.Size(75, 68);
            this.buttonBackDetail.TabIndex = 67;
            this.buttonBackDetail.UseVisualStyleBackColor = true;
            this.buttonBackDetail.Click += new System.EventHandler(this.buttonBackDetail_Click);
            // 
            // buttonRetrocederDetail
            // 
            this.buttonRetrocederDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.start_button_icon_icons_com_53873___copia;
            this.buttonRetrocederDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRetrocederDetail.FlatAppearance.BorderSize = 0;
            this.buttonRetrocederDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetrocederDetail.Location = new System.Drawing.Point(134, 334);
            this.buttonRetrocederDetail.Name = "buttonRetrocederDetail";
            this.buttonRetrocederDetail.Size = new System.Drawing.Size(35, 23);
            this.buttonRetrocederDetail.TabIndex = 68;
            this.buttonRetrocederDetail.UseVisualStyleBackColor = true;
            this.buttonRetrocederDetail.Click += new System.EventHandler(this.buttonRetrocederDetail_Click);
            // 
            // buttonAvanzarDetail
            // 
            this.buttonAvanzarDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.start_button_icon_icons_com_53873;
            this.buttonAvanzarDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAvanzarDetail.FlatAppearance.BorderSize = 0;
            this.buttonAvanzarDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAvanzarDetail.Location = new System.Drawing.Point(175, 334);
            this.buttonAvanzarDetail.Name = "buttonAvanzarDetail";
            this.buttonAvanzarDetail.Size = new System.Drawing.Size(35, 23);
            this.buttonAvanzarDetail.TabIndex = 69;
            this.buttonAvanzarDetail.UseVisualStyleBackColor = true;
            this.buttonAvanzarDetail.Click += new System.EventHandler(this.buttonAvanzarDetail_Click);
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.Location = new System.Drawing.Point(300, 670);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(487, 50);
            this.buttonFinish.TabIndex = 70;
            this.buttonFinish.Text = "TERMINAR";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluefilefolder_azul_archivo_12582;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(244, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 103;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 107;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Ayuda.chm";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 749);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonAvanzarDetail);
            this.Controls.Add(this.buttonRetrocederDetail);
            this.Controls.Add(this.buttonBackDetail);
            this.Controls.Add(this.buttonRemoveDetail);
            this.Controls.Add(this.buttonAddDetail);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonFinal);
            this.Controls.Add(this.buttonAvanzar);
            this.Controls.Add(this.buttonRetroceder);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.helpProvider1.SetHelpKeyword(this, "2");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVentas";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FontaApp - Ventas";
            this.Activated += new System.EventHandler(this.FormVentas_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ventas_FormClosing);
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonFinal;
        private System.Windows.Forms.Button buttonAvanzar;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource ventasBindingSource;
        private Database1DataSetTableAdapters.VentasTableAdapter ventasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_VentaLabel1;
        private System.Windows.Forms.DateTimePicker fecha_RealizacionDateTimePicker;
        private System.Windows.Forms.ComboBox id_ClienteComboBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox direccion_ClienteTextBox;
        private System.Windows.Forms.TextBox poblacion_ClienteTextBox;
        private System.Windows.Forms.TextBox telefono_ClienteTextBox;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.Button buttonCancelDetail;
        private System.Windows.Forms.Button buttonAcceptDetail;
        private Database1DataSetTableAdapters.VentasDetalleTableAdapter ventasDetalleTableAdapter;
        private System.Windows.Forms.BindingSource ventasDetalleBindingSource;
        private System.Windows.Forms.DataGridView ventasDetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label importeLabel1;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.NumericUpDown unidadesNumericUpDown;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox id_ProductoComboBox;
        private System.Windows.Forms.Label id_VentaLabel3;
        private Database1DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Database1DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private System.Windows.Forms.Button buttonAddDetail;
        private System.Windows.Forms.Button buttonRemoveDetail;
        private System.Windows.Forms.Button buttonBackDetail;
        private System.Windows.Forms.Button buttonRetrocederDetail;
        private System.Windows.Forms.Button buttonAvanzarDetail;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}