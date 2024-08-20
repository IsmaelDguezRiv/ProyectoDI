namespace WindowsFormsAppFONTAAPP
{
    partial class FormCompras
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
            System.Windows.Forms.Label id_ProveedorLabel;
            System.Windows.Forms.Label proveedorLabel;
            System.Windows.Forms.Label direccion_ProveedorLabel;
            System.Windows.Forms.Label poblacion_ProveedorLabel;
            System.Windows.Forms.Label telefono_ProveedorLabel;
            System.Windows.Forms.Label cIF_DNILabel;
            System.Windows.Forms.Label fecha_RelaizacionLabel;
            System.Windows.Forms.Label id_CompraLabel;
            System.Windows.Forms.Label totalLabel;
            System.Windows.Forms.Label id_CompraLabel2;
            System.Windows.Forms.Label id_ProductoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label unidadesLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label importeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCompras));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.buttonAvanzarDetail = new System.Windows.Forms.Button();
            this.buttonRetrocederDetail = new System.Windows.Forms.Button();
            this.buttonBackDetail = new System.Windows.Forms.Button();
            this.buttonRemoveDetail = new System.Windows.Forms.Button();
            this.buttonAddDetail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.totalLabel1 = new System.Windows.Forms.Label();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsAppFONTAAPP.Database1DataSet();
            this.importeLabel1 = new System.Windows.Forms.Label();
            this.comprasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_CompraLabel3 = new System.Windows.Forms.Label();
            this.id_ProductoComboBox = new System.Windows.Forms.ComboBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.unidadesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.comprasDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCancelDetail = new System.Windows.Forms.Button();
            this.buttonAcceptDetail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_CompraLabel1 = new System.Windows.Forms.Label();
            this.fecha_RelaizacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cIF_DNITextBox = new System.Windows.Forms.TextBox();
            this.telefono_ProveedorTextBox = new System.Windows.Forms.TextBox();
            this.poblacion_ProveedorTextBox = new System.Windows.Forms.TextBox();
            this.direccion_ProveedorTextBox = new System.Windows.Forms.TextBox();
            this.proveedorTextBox = new System.Windows.Forms.TextBox();
            this.id_ProveedorComboBox = new System.Windows.Forms.ComboBox();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonFinal = new System.Windows.Forms.Button();
            this.buttonAvanzar = new System.Windows.Forms.Button();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.comprasTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ComprasTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager();
            this.comprasDetalleTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ComprasDetalleTableAdapter();
            this.proveedoresTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ProveedoresTableAdapter();
            this.productosTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ProductosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_ProveedorLabel = new System.Windows.Forms.Label();
            proveedorLabel = new System.Windows.Forms.Label();
            direccion_ProveedorLabel = new System.Windows.Forms.Label();
            poblacion_ProveedorLabel = new System.Windows.Forms.Label();
            telefono_ProveedorLabel = new System.Windows.Forms.Label();
            cIF_DNILabel = new System.Windows.Forms.Label();
            fecha_RelaizacionLabel = new System.Windows.Forms.Label();
            id_CompraLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            id_CompraLabel2 = new System.Windows.Forms.Label();
            id_ProductoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            unidadesLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            importeLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetalleDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ProveedorLabel
            // 
            id_ProveedorLabel.AutoSize = true;
            id_ProveedorLabel.Location = new System.Drawing.Point(70, 16);
            id_ProveedorLabel.Name = "id_ProveedorLabel";
            id_ProveedorLabel.Size = new System.Drawing.Size(62, 13);
            id_ProveedorLabel.TabIndex = 27;
            id_ProveedorLabel.Text = "Proveedor :";
            // 
            // proveedorLabel
            // 
            proveedorLabel.AutoSize = true;
            proveedorLabel.Location = new System.Drawing.Point(7, 43);
            proveedorLabel.Name = "proveedorLabel";
            proveedorLabel.Size = new System.Drawing.Size(97, 13);
            proveedorLabel.TabIndex = 28;
            proveedorLabel.Text = "Nombre Completo :";
            // 
            // direccion_ProveedorLabel
            // 
            direccion_ProveedorLabel.AutoSize = true;
            direccion_ProveedorLabel.Location = new System.Drawing.Point(7, 69);
            direccion_ProveedorLabel.Name = "direccion_ProveedorLabel";
            direccion_ProveedorLabel.Size = new System.Drawing.Size(58, 13);
            direccion_ProveedorLabel.TabIndex = 29;
            direccion_ProveedorLabel.Text = "Dirección :";
            // 
            // poblacion_ProveedorLabel
            // 
            poblacion_ProveedorLabel.AutoSize = true;
            poblacion_ProveedorLabel.Location = new System.Drawing.Point(5, 95);
            poblacion_ProveedorLabel.Name = "poblacion_ProveedorLabel";
            poblacion_ProveedorLabel.Size = new System.Drawing.Size(60, 13);
            poblacion_ProveedorLabel.TabIndex = 30;
            poblacion_ProveedorLabel.Text = "Población :";
            // 
            // telefono_ProveedorLabel
            // 
            telefono_ProveedorLabel.AutoSize = true;
            telefono_ProveedorLabel.Location = new System.Drawing.Point(381, 95);
            telefono_ProveedorLabel.Name = "telefono_ProveedorLabel";
            telefono_ProveedorLabel.Size = new System.Drawing.Size(55, 13);
            telefono_ProveedorLabel.TabIndex = 31;
            telefono_ProveedorLabel.Text = "Teléfono :";
            // 
            // cIF_DNILabel
            // 
            cIF_DNILabel.AutoSize = true;
            cIF_DNILabel.Location = new System.Drawing.Point(427, 16);
            cIF_DNILabel.Name = "cIF_DNILabel";
            cIF_DNILabel.Size = new System.Drawing.Size(53, 13);
            cIF_DNILabel.TabIndex = 32;
            cIF_DNILabel.Text = "CIF/DNI :";
            // 
            // fecha_RelaizacionLabel
            // 
            fecha_RelaizacionLabel.AutoSize = true;
            fecha_RelaizacionLabel.Location = new System.Drawing.Point(419, 25);
            fecha_RelaizacionLabel.Name = "fecha_RelaizacionLabel";
            fecha_RelaizacionLabel.Size = new System.Drawing.Size(98, 13);
            fecha_RelaizacionLabel.TabIndex = 62;
            fecha_RelaizacionLabel.Text = "Fecha Relaizacion:";
            // 
            // id_CompraLabel
            // 
            id_CompraLabel.AutoSize = true;
            id_CompraLabel.Location = new System.Drawing.Point(93, 25);
            id_CompraLabel.Name = "id_CompraLabel";
            id_CompraLabel.Size = new System.Drawing.Size(104, 13);
            id_CompraLabel.TabIndex = 63;
            id_CompraLabel.Text = "Número de Compra :";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(19, 49);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(48, 13);
            totalLabel.TabIndex = 100;
            totalLabel.Text = "TOTAL :";
            // 
            // id_CompraLabel2
            // 
            id_CompraLabel2.AutoSize = true;
            id_CompraLabel2.Location = new System.Drawing.Point(67, 30);
            id_CompraLabel2.Name = "id_CompraLabel2";
            id_CompraLabel2.Size = new System.Drawing.Size(112, 13);
            id_CompraLabel2.TabIndex = 69;
            id_CompraLabel2.Text = "Compra Relacionada :";
            // 
            // id_ProductoLabel
            // 
            id_ProductoLabel.AutoSize = true;
            id_ProductoLabel.Location = new System.Drawing.Point(42, 209);
            id_ProductoLabel.Name = "id_ProductoLabel";
            id_ProductoLabel.Size = new System.Drawing.Size(129, 13);
            id_ProductoLabel.TabIndex = 71;
            id_ProductoLabel.Text = "Identificador de Producto:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(102, 251);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(50, 13);
            nombreLabel.TabIndex = 73;
            nombreLabel.Text = "Nombre :";
            // 
            // unidadesLabel
            // 
            unidadesLabel.AutoSize = true;
            unidadesLabel.Location = new System.Drawing.Point(99, 277);
            unidadesLabel.Name = "unidadesLabel";
            unidadesLabel.Size = new System.Drawing.Size(58, 13);
            unidadesLabel.TabIndex = 75;
            unidadesLabel.Text = "Unidades :";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(288, 277);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(43, 13);
            precioLabel.TabIndex = 77;
            precioLabel.Text = "Precio :";
            // 
            // importeLabel
            // 
            importeLabel.AutoSize = true;
            importeLabel.Location = new System.Drawing.Point(19, 21);
            importeLabel.Name = "importeLabel";
            importeLabel.Size = new System.Drawing.Size(62, 13);
            importeLabel.TabIndex = 79;
            importeLabel.Text = "IMPORTE :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "label1";
            // 
            // buttonFinish
            // 
            this.buttonFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinish.Location = new System.Drawing.Point(300, 670);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(487, 50);
            this.buttonFinish.TabIndex = 17;
            this.buttonFinish.Text = "TERMINAR";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
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
            this.buttonAvanzarDetail.TabIndex = 13;
            this.buttonAvanzarDetail.UseVisualStyleBackColor = true;
            this.buttonAvanzarDetail.Click += new System.EventHandler(this.buttonAvanzarDetail_Click);
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
            this.buttonRetrocederDetail.TabIndex = 12;
            this.buttonRetrocederDetail.UseVisualStyleBackColor = true;
            this.buttonRetrocederDetail.Click += new System.EventHandler(this.buttonRetrocederDetail_Click);
            // 
            // buttonBackDetail
            // 
            this.buttonBackDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_arrow_left_12459;
            this.buttonBackDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBackDetail.Location = new System.Drawing.Point(134, 509);
            this.buttonBackDetail.Name = "buttonBackDetail";
            this.buttonBackDetail.Size = new System.Drawing.Size(75, 68);
            this.buttonBackDetail.TabIndex = 16;
            this.buttonBackDetail.UseVisualStyleBackColor = true;
            this.buttonBackDetail.Click += new System.EventHandler(this.buttonBackDetail_Click);
            // 
            // buttonRemoveDetail
            // 
            this.buttonRemoveDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_delete_delete_12489;
            this.buttonRemoveDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemoveDetail.Location = new System.Drawing.Point(134, 435);
            this.buttonRemoveDetail.Name = "buttonRemoveDetail";
            this.buttonRemoveDetail.Size = new System.Drawing.Size(75, 68);
            this.buttonRemoveDetail.TabIndex = 15;
            this.buttonRemoveDetail.UseVisualStyleBackColor = true;
            this.buttonRemoveDetail.Click += new System.EventHandler(this.buttonRemoveDetail_Click);
            // 
            // buttonAddDetail
            // 
            this.buttonAddDetail.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_insert_append_12490;
            this.buttonAddDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAddDetail.Location = new System.Drawing.Point(134, 361);
            this.buttonAddDetail.Name = "buttonAddDetail";
            this.buttonAddDetail.Size = new System.Drawing.Size(75, 68);
            this.buttonAddDetail.TabIndex = 14;
            this.buttonAddDetail.UseVisualStyleBackColor = true;
            this.buttonAddDetail.Click += new System.EventHandler(this.buttonAddDetail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(id_CompraLabel2);
            this.groupBox2.Controls.Add(this.id_CompraLabel3);
            this.groupBox2.Controls.Add(id_ProductoLabel);
            this.groupBox2.Controls.Add(this.id_ProductoComboBox);
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(this.nombreTextBox);
            this.groupBox2.Controls.Add(unidadesLabel);
            this.groupBox2.Controls.Add(this.unidadesNumericUpDown);
            this.groupBox2.Controls.Add(precioLabel);
            this.groupBox2.Controls.Add(this.precioTextBox);
            this.groupBox2.Controls.Add(this.comprasDetalleDataGridView);
            this.groupBox2.Controls.Add(this.buttonCancelDetail);
            this.groupBox2.Controls.Add(this.buttonAcceptDetail);
            this.groupBox2.Location = new System.Drawing.Point(230, 331);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(734, 322);
            this.groupBox2.TabIndex = 92;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DETALLE COMPRA";
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
            this.groupBox4.TabIndex = 81;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio ";
            // 
            // totalLabel1
            // 
            this.totalLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Total", true));
            this.totalLabel1.Location = new System.Drawing.Point(82, 49);
            this.totalLabel1.Name = "totalLabel1";
            this.totalLabel1.Size = new System.Drawing.Size(100, 23);
            this.totalLabel1.TabIndex = 101;
            this.totalLabel1.Text = "label2";
            // 
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.database1DataSet;
            this.comprasBindingSource.PositionChanged += new System.EventHandler(this.comprasBindingSource_PositionChanged);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // importeLabel1
            // 
            this.importeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasDetalleBindingSource, "Importe", true));
            this.importeLabel1.Location = new System.Drawing.Point(82, 21);
            this.importeLabel1.Name = "importeLabel1";
            this.importeLabel1.Size = new System.Drawing.Size(121, 23);
            this.importeLabel1.TabIndex = 80;
            this.importeLabel1.Text = "label2";
            // 
            // comprasDetalleBindingSource
            // 
            this.comprasDetalleBindingSource.DataMember = "FK_ComprasDetalle";
            this.comprasDetalleBindingSource.DataSource = this.comprasBindingSource;
            this.comprasDetalleBindingSource.PositionChanged += new System.EventHandler(this.comprasDetalleBindingSource_PositionChanged);
            // 
            // id_CompraLabel3
            // 
            this.id_CompraLabel3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasDetalleBindingSource, "Id_Compra", true));
            this.id_CompraLabel3.Location = new System.Drawing.Point(185, 30);
            this.id_CompraLabel3.Name = "id_CompraLabel3";
            this.id_CompraLabel3.Size = new System.Drawing.Size(121, 23);
            this.id_CompraLabel3.TabIndex = 70;
            this.id_CompraLabel3.Text = "label2";
            // 
            // id_ProductoComboBox
            // 
            this.id_ProductoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasDetalleBindingSource, "Id_Producto", true));
            this.id_ProductoComboBox.DataSource = this.productosBindingSource;
            this.id_ProductoComboBox.DisplayMember = "Nombre";
            this.id_ProductoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_ProductoComboBox.FormattingEnabled = true;
            this.id_ProductoComboBox.Location = new System.Drawing.Point(177, 206);
            this.id_ProductoComboBox.Name = "id_ProductoComboBox";
            this.id_ProductoComboBox.Size = new System.Drawing.Size(86, 21);
            this.id_ProductoComboBox.TabIndex = 0;
            this.id_ProductoComboBox.ValueMember = "Id_Producto";
            this.id_ProductoComboBox.SelectedIndexChanged += new System.EventHandler(this.id_ProductoComboBox_SelectedIndexChanged);
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.database1DataSet;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasDetalleBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(160, 248);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(274, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // unidadesNumericUpDown
            // 
            this.unidadesNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.comprasDetalleBindingSource, "Unidades", true));
            this.unidadesNumericUpDown.Location = new System.Drawing.Point(160, 275);
            this.unidadesNumericUpDown.Name = "unidadesNumericUpDown";
            this.unidadesNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.unidadesNumericUpDown.TabIndex = 2;
            this.unidadesNumericUpDown.ValueChanged += new System.EventHandler(this.unidadesNumericUpDown_ValueChanged);
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasDetalleBindingSource, "Precio", true));
            this.precioTextBox.Enabled = false;
            this.precioTextBox.Location = new System.Drawing.Point(334, 275);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(100, 20);
            this.precioTextBox.TabIndex = 3;
            this.precioTextBox.TextChanged += new System.EventHandler(this.precioTextBox_TextChanged);
            // 
            // comprasDetalleDataGridView
            // 
            this.comprasDetalleDataGridView.AllowUserToAddRows = false;
            this.comprasDetalleDataGridView.AllowUserToDeleteRows = false;
            this.comprasDetalleDataGridView.AllowUserToResizeColumns = false;
            this.comprasDetalleDataGridView.AllowUserToResizeRows = false;
            this.comprasDetalleDataGridView.AutoGenerateColumns = false;
            this.comprasDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.comprasDetalleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.comprasDetalleDataGridView.DataSource = this.comprasDetalleBindingSource;
            this.comprasDetalleDataGridView.Location = new System.Drawing.Point(49, 54);
            this.comprasDetalleDataGridView.Name = "comprasDetalleDataGridView";
            this.comprasDetalleDataGridView.Size = new System.Drawing.Size(646, 143);
            this.comprasDetalleDataGridView.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Compra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Compra";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_Producto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Id_Producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unidades";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unidades";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Precio";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Importe";
            this.dataGridViewTextBoxColumn6.HeaderText = "Importe";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // buttonCancelDetail
            // 
            this.buttonCancelDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelDetail.Location = new System.Drawing.Point(653, 293);
            this.buttonCancelDetail.Name = "buttonCancelDetail";
            this.buttonCancelDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelDetail.TabIndex = 5;
            this.buttonCancelDetail.Text = "Cancelar ";
            this.buttonCancelDetail.UseVisualStyleBackColor = true;
            this.buttonCancelDetail.Click += new System.EventHandler(this.buttonCancelDetail_Click);
            // 
            // buttonAcceptDetail
            // 
            this.buttonAcceptDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAcceptDetail.Location = new System.Drawing.Point(572, 293);
            this.buttonAcceptDetail.Name = "buttonAcceptDetail";
            this.buttonAcceptDetail.Size = new System.Drawing.Size(75, 23);
            this.buttonAcceptDetail.TabIndex = 4;
            this.buttonAcceptDetail.Text = "Aceptar ";
            this.buttonAcceptDetail.UseVisualStyleBackColor = true;
            this.buttonAcceptDetail.Click += new System.EventHandler(this.buttonAcceptDetail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(id_CompraLabel);
            this.groupBox1.Controls.Add(this.id_CompraLabel1);
            this.groupBox1.Controls.Add(fecha_RelaizacionLabel);
            this.groupBox1.Controls.Add(this.fecha_RelaizacionDateTimePicker);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonAccept);
            this.groupBox1.Location = new System.Drawing.Point(134, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(830, 224);
            this.groupBox1.TabIndex = 90;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COMPRA";
            // 
            // id_CompraLabel1
            // 
            this.id_CompraLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Id_Compra", true));
            this.id_CompraLabel1.Location = new System.Drawing.Point(195, 25);
            this.id_CompraLabel1.Name = "id_CompraLabel1";
            this.id_CompraLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_CompraLabel1.TabIndex = 64;
            this.id_CompraLabel1.Text = "label2";
            // 
            // fecha_RelaizacionDateTimePicker
            // 
            this.fecha_RelaizacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.comprasBindingSource, "Fecha_Relaizacion", true));
            this.fecha_RelaizacionDateTimePicker.Location = new System.Drawing.Point(526, 19);
            this.fecha_RelaizacionDateTimePicker.Name = "fecha_RelaizacionDateTimePicker";
            this.fecha_RelaizacionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fecha_RelaizacionDateTimePicker.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(cIF_DNILabel);
            this.groupBox3.Controls.Add(this.cIF_DNITextBox);
            this.groupBox3.Controls.Add(telefono_ProveedorLabel);
            this.groupBox3.Controls.Add(this.telefono_ProveedorTextBox);
            this.groupBox3.Controls.Add(poblacion_ProveedorLabel);
            this.groupBox3.Controls.Add(this.poblacion_ProveedorTextBox);
            this.groupBox3.Controls.Add(direccion_ProveedorLabel);
            this.groupBox3.Controls.Add(this.direccion_ProveedorTextBox);
            this.groupBox3.Controls.Add(proveedorLabel);
            this.groupBox3.Controls.Add(this.proveedorTextBox);
            this.groupBox3.Controls.Add(id_ProveedorLabel);
            this.groupBox3.Controls.Add(this.id_ProveedorComboBox);
            this.groupBox3.Location = new System.Drawing.Point(11, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(805, 121);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Cliente";
            // 
            // cIF_DNITextBox
            // 
            this.cIF_DNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "CIF_DNI", true));
            this.cIF_DNITextBox.Location = new System.Drawing.Point(486, 13);
            this.cIF_DNITextBox.Name = "cIF_DNITextBox";
            this.cIF_DNITextBox.Size = new System.Drawing.Size(100, 20);
            this.cIF_DNITextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cIF_DNITextBox, "Añadir el que corresponda");
            // 
            // telefono_ProveedorTextBox
            // 
            this.telefono_ProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Telefono_Proveedor", true));
            this.telefono_ProveedorTextBox.Location = new System.Drawing.Point(442, 92);
            this.telefono_ProveedorTextBox.Name = "telefono_ProveedorTextBox";
            this.telefono_ProveedorTextBox.Size = new System.Drawing.Size(349, 20);
            this.telefono_ProveedorTextBox.TabIndex = 5;
            // 
            // poblacion_ProveedorTextBox
            // 
            this.poblacion_ProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Poblacion_Proveedor", true));
            this.poblacion_ProveedorTextBox.Location = new System.Drawing.Point(110, 92);
            this.poblacion_ProveedorTextBox.Name = "poblacion_ProveedorTextBox";
            this.poblacion_ProveedorTextBox.Size = new System.Drawing.Size(261, 20);
            this.poblacion_ProveedorTextBox.TabIndex = 4;
            // 
            // direccion_ProveedorTextBox
            // 
            this.direccion_ProveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Direccion_Proveedor", true));
            this.direccion_ProveedorTextBox.Location = new System.Drawing.Point(110, 66);
            this.direccion_ProveedorTextBox.Name = "direccion_ProveedorTextBox";
            this.direccion_ProveedorTextBox.Size = new System.Drawing.Size(681, 20);
            this.direccion_ProveedorTextBox.TabIndex = 3;
            // 
            // proveedorTextBox
            // 
            this.proveedorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comprasBindingSource, "Proveedor", true));
            this.proveedorTextBox.Location = new System.Drawing.Point(110, 40);
            this.proveedorTextBox.Name = "proveedorTextBox";
            this.proveedorTextBox.Size = new System.Drawing.Size(681, 20);
            this.proveedorTextBox.TabIndex = 2;
            // 
            // id_ProveedorComboBox
            // 
            this.id_ProveedorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comprasBindingSource, "Id_Proveedor", true));
            this.id_ProveedorComboBox.DataSource = this.proveedoresBindingSource;
            this.id_ProveedorComboBox.DisplayMember = "Nombre";
            this.id_ProveedorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_ProveedorComboBox.FormattingEnabled = true;
            this.id_ProveedorComboBox.Location = new System.Drawing.Point(138, 13);
            this.id_ProveedorComboBox.Name = "id_ProveedorComboBox";
            this.id_ProveedorComboBox.Size = new System.Drawing.Size(121, 21);
            this.id_ProveedorComboBox.TabIndex = 0;
            this.id_ProveedorComboBox.ValueMember = "Id_Proveedor";
            this.id_ProveedorComboBox.SelectedIndexChanged += new System.EventHandler(this.id_ProveedorComboBox_SelectedIndexChanged);
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.database1DataSet;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(749, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancelar ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.Location = new System.Drawing.Point(668, 195);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Aceptar ";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
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
            this.buttonFinal.TabIndex = 5;
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
            this.buttonAvanzar.TabIndex = 4;
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
            this.buttonRetroceder.TabIndex = 3;
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
            this.buttonInicio.TabIndex = 2;
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
            this.buttonSave.TabIndex = 11;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(198, 28);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(325, 20);
            this.textBoxSearch.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(529, 28);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(202, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Buscar por Número de Compra";
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
            this.buttonBack.TabIndex = 10;
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
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
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasDetalleTableAdapter = this.comprasDetalleTableAdapter;
            this.tableAdapterManager.ComprasTableAdapter = this.comprasTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.InstalacionesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasDetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // comprasDetalleTableAdapter
            // 
            this.comprasDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluefilefolder_azul_archivo_12582;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(244, 670);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 727);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 106;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Ayuda.chm";
            // 
            // FormCompras
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
            this.helpProvider1.SetHelpKeyword(this, "3");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCompras";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FontaApp - Compras";
            this.Activated += new System.EventHandler(this.FormCompras_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compras_FormClosing);
            this.Load += new System.EventHandler(this.FormCompras_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetalleDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFinish;
        private System.Windows.Forms.Button buttonAvanzarDetail;
        private System.Windows.Forms.Button buttonRetrocederDetail;
        private System.Windows.Forms.Button buttonBackDetail;
        private System.Windows.Forms.Button buttonRemoveDetail;
        private System.Windows.Forms.Button buttonAddDetail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancelDetail;
        private System.Windows.Forms.Button buttonAcceptDetail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonFinal;
        private System.Windows.Forms.Button buttonAvanzar;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private Database1DataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox id_ProveedorComboBox;
        private System.Windows.Forms.Label id_CompraLabel1;
        private System.Windows.Forms.DateTimePicker fecha_RelaizacionDateTimePicker;
        private System.Windows.Forms.TextBox cIF_DNITextBox;
        private System.Windows.Forms.TextBox telefono_ProveedorTextBox;
        private System.Windows.Forms.TextBox poblacion_ProveedorTextBox;
        private System.Windows.Forms.TextBox direccion_ProveedorTextBox;
        private System.Windows.Forms.TextBox proveedorTextBox;
        private Database1DataSetTableAdapters.ComprasDetalleTableAdapter comprasDetalleTableAdapter;
        private System.Windows.Forms.BindingSource comprasDetalleBindingSource;
        private System.Windows.Forms.DataGridView comprasDetalleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Database1DataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private System.Windows.Forms.Label id_CompraLabel3;
        private System.Windows.Forms.ComboBox id_ProductoComboBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.NumericUpDown unidadesNumericUpDown;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label importeLabel1;
        private System.Windows.Forms.Label totalLabel1;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Database1DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}