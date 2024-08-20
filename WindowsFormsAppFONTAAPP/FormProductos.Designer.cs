namespace WindowsFormsAppFONTAAPP
{
    partial class FormProductos
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label categoriaLabel;
            System.Windows.Forms.Label id_ProductoLabel;
            System.Windows.Forms.Label marcaLabel;
            System.Windows.Forms.Label materialesLabel;
            System.Windows.Forms.Label longitudLabel;
            System.Windows.Forms.Label anchuraLabel;
            System.Windows.Forms.Label alturaLabel;
            System.Windows.Forms.Label diametroLabel;
            System.Windows.Forms.Label tipo_ConexionLabel;
            System.Windows.Forms.Label presion_Label;
            System.Windows.Forms.Label accesoriosLabel;
            System.Windows.Forms.Label imagenLabel;
            System.Windows.Forms.Label precioLabel;
            System.Windows.Forms.Label cantidad_DisponibleLabel;
            System.Windows.Forms.Label garantiaLabel;
            System.Windows.Forms.Label temperatura_MaximaLabel;
            System.Windows.Forms.Label clasificacion_EnergeticaLabel;
            System.Windows.Forms.Label pesoLabel;
            System.Windows.Forms.Label capacidadLabel;
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxTermo = new System.Windows.Forms.GroupBox();
            this.groupBoxWC = new System.Windows.Forms.GroupBox();
            this.capacidadTextBox = new System.Windows.Forms.TextBox();
            this.productosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsAppFONTAAPP.Database1DataSet();
            this.pesoTextBox = new System.Windows.Forms.TextBox();
            this.clasificacion_EnergeticaComboBox = new System.Windows.Forms.ComboBox();
            this.temperatura_MaximaTextBox = new System.Windows.Forms.TextBox();
            this.materialesTextBox = new System.Windows.Forms.TextBox();
            this.marcaTextBox = new System.Windows.Forms.TextBox();
            this.longitudTextBox = new System.Windows.Forms.TextBox();
            this.anchuraTextBox = new System.Windows.Forms.TextBox();
            this.alturaTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxTuberia = new System.Windows.Forms.GroupBox();
            this.tipo_ConexionTextBox = new System.Windows.Forms.TextBox();
            this.diametroTextBox = new System.Windows.Forms.TextBox();
            this.presion_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.accesoriosTextBox = new System.Windows.Forms.TextBox();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.garantiaTextBox = new System.Windows.Forms.TextBox();
            this.cantidad_DisponibleNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.precioTextBox = new System.Windows.Forms.TextBox();
            this.id_ProductoLabel1 = new System.Windows.Forms.Label();
            this.categoriaComboBox = new System.Windows.Forms.ComboBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.productosTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ProductosTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonFinal = new System.Windows.Forms.Button();
            this.buttonAvanzar = new System.Windows.Forms.Button();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.ventasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ventasDetalleTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.VentasDetalleTableAdapter();
            this.comprasDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasDetalleTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ComprasDetalleTableAdapter();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            nombreLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            categoriaLabel = new System.Windows.Forms.Label();
            id_ProductoLabel = new System.Windows.Forms.Label();
            marcaLabel = new System.Windows.Forms.Label();
            materialesLabel = new System.Windows.Forms.Label();
            longitudLabel = new System.Windows.Forms.Label();
            anchuraLabel = new System.Windows.Forms.Label();
            alturaLabel = new System.Windows.Forms.Label();
            diametroLabel = new System.Windows.Forms.Label();
            tipo_ConexionLabel = new System.Windows.Forms.Label();
            presion_Label = new System.Windows.Forms.Label();
            accesoriosLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            precioLabel = new System.Windows.Forms.Label();
            cantidad_DisponibleLabel = new System.Windows.Forms.Label();
            garantiaLabel = new System.Windows.Forms.Label();
            temperatura_MaximaLabel = new System.Windows.Forms.Label();
            clasificacion_EnergeticaLabel = new System.Windows.Forms.Label();
            pesoLabel = new System.Windows.Forms.Label();
            capacidadLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTermo.SuspendLayout();
            this.groupBoxWC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            this.groupBoxTuberia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_DisponibleNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(23, 80);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(50, 13);
            nombreLabel.TabIndex = 2;
            nombreLabel.Text = "Nombre :";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(23, 106);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(69, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripción :";
            // 
            // categoriaLabel
            // 
            categoriaLabel.AutoSize = true;
            categoriaLabel.Location = new System.Drawing.Point(125, 212);
            categoriaLabel.Name = "categoriaLabel";
            categoriaLabel.Size = new System.Drawing.Size(60, 13);
            categoriaLabel.TabIndex = 6;
            categoriaLabel.Text = "Categoría :";
            // 
            // id_ProductoLabel
            // 
            id_ProductoLabel.AutoSize = true;
            id_ProductoLabel.Location = new System.Drawing.Point(65, 34);
            id_ProductoLabel.Name = "id_ProductoLabel";
            id_ProductoLabel.Size = new System.Drawing.Size(134, 13);
            id_ProductoLabel.TabIndex = 7;
            id_ProductoLabel.Text = "Identificador del Producto :";
            // 
            // marcaLabel
            // 
            marcaLabel.AutoSize = true;
            marcaLabel.Location = new System.Drawing.Point(25, 26);
            marcaLabel.Name = "marcaLabel";
            marcaLabel.Size = new System.Drawing.Size(43, 13);
            marcaLabel.TabIndex = 0;
            marcaLabel.Text = "Marca :";
            // 
            // materialesLabel
            // 
            materialesLabel.AutoSize = true;
            materialesLabel.Location = new System.Drawing.Point(25, 52);
            materialesLabel.Name = "materialesLabel";
            materialesLabel.Size = new System.Drawing.Size(61, 13);
            materialesLabel.TabIndex = 2;
            materialesLabel.Text = "Materiales :";
            // 
            // longitudLabel
            // 
            longitudLabel.AutoSize = true;
            longitudLabel.Location = new System.Drawing.Point(25, 78);
            longitudLabel.Name = "longitudLabel";
            longitudLabel.Size = new System.Drawing.Size(54, 13);
            longitudLabel.TabIndex = 4;
            longitudLabel.Text = "Longitud :";
            // 
            // anchuraLabel
            // 
            anchuraLabel.AutoSize = true;
            anchuraLabel.Location = new System.Drawing.Point(207, 78);
            anchuraLabel.Name = "anchuraLabel";
            anchuraLabel.Size = new System.Drawing.Size(53, 13);
            anchuraLabel.TabIndex = 6;
            anchuraLabel.Text = "Anchura :";
            // 
            // alturaLabel
            // 
            alturaLabel.AutoSize = true;
            alturaLabel.Location = new System.Drawing.Point(372, 78);
            alturaLabel.Name = "alturaLabel";
            alturaLabel.Size = new System.Drawing.Size(40, 13);
            alturaLabel.TabIndex = 8;
            alturaLabel.Text = "Altura :";
            // 
            // diametroLabel
            // 
            diametroLabel.AutoSize = true;
            diametroLabel.Location = new System.Drawing.Point(12, 22);
            diametroLabel.Name = "diametroLabel";
            diametroLabel.Size = new System.Drawing.Size(52, 13);
            diametroLabel.TabIndex = 10;
            diametroLabel.Text = "Diametro:";
            // 
            // tipo_ConexionLabel
            // 
            tipo_ConexionLabel.AutoSize = true;
            tipo_ConexionLabel.Location = new System.Drawing.Point(186, 22);
            tipo_ConexionLabel.Name = "tipo_ConexionLabel";
            tipo_ConexionLabel.Size = new System.Drawing.Size(78, 13);
            tipo_ConexionLabel.TabIndex = 12;
            tipo_ConexionLabel.Text = "Tipo Conexion:";
            // 
            // presion_Label
            // 
            presion_Label.AutoSize = true;
            presion_Label.Location = new System.Drawing.Point(363, 26);
            presion_Label.Name = "presion_Label";
            presion_Label.Size = new System.Drawing.Size(48, 13);
            presion_Label.TabIndex = 14;
            presion_Label.Text = "Presión :";
            // 
            // accesoriosLabel
            // 
            accesoriosLabel.AutoSize = true;
            accesoriosLabel.Location = new System.Drawing.Point(168, 156);
            accesoriosLabel.Name = "accesoriosLabel";
            accesoriosLabel.Size = new System.Drawing.Size(65, 13);
            accesoriosLabel.TabIndex = 16;
            accesoriosLabel.Text = "Accesorios :";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(593, 167);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(48, 13);
            imagenLabel.TabIndex = 18;
            imagenLabel.Text = "Imagen :";
            // 
            // precioLabel
            // 
            precioLabel.AutoSize = true;
            precioLabel.Location = new System.Drawing.Point(486, 80);
            precioLabel.Name = "precioLabel";
            precioLabel.Size = new System.Drawing.Size(43, 13);
            precioLabel.TabIndex = 20;
            precioLabel.Text = "Precio :";
            // 
            // cantidad_DisponibleLabel
            // 
            cantidad_DisponibleLabel.AutoSize = true;
            cantidad_DisponibleLabel.Location = new System.Drawing.Point(647, 80);
            cantidad_DisponibleLabel.Name = "cantidad_DisponibleLabel";
            cantidad_DisponibleLabel.Size = new System.Drawing.Size(107, 13);
            cantidad_DisponibleLabel.TabIndex = 21;
            cantidad_DisponibleLabel.Text = "Cantidad Disponible :";
            // 
            // garantiaLabel
            // 
            garantiaLabel.AutoSize = true;
            garantiaLabel.Location = new System.Drawing.Point(23, 156);
            garantiaLabel.Name = "garantiaLabel";
            garantiaLabel.Size = new System.Drawing.Size(55, 13);
            garantiaLabel.TabIndex = 22;
            garantiaLabel.Text = "Garantía :";
            // 
            // temperatura_MaximaLabel
            // 
            temperatura_MaximaLabel.AutoSize = true;
            temperatura_MaximaLabel.Location = new System.Drawing.Point(12, 22);
            temperatura_MaximaLabel.Name = "temperatura_MaximaLabel";
            temperatura_MaximaLabel.Size = new System.Drawing.Size(112, 13);
            temperatura_MaximaLabel.TabIndex = 0;
            temperatura_MaximaLabel.Text = "Temperatura Máxima :";
            // 
            // clasificacion_EnergeticaLabel
            // 
            clasificacion_EnergeticaLabel.AutoSize = true;
            clasificacion_EnergeticaLabel.Location = new System.Drawing.Point(233, 22);
            clasificacion_EnergeticaLabel.Name = "clasificacion_EnergeticaLabel";
            clasificacion_EnergeticaLabel.Size = new System.Drawing.Size(126, 13);
            clasificacion_EnergeticaLabel.TabIndex = 2;
            clasificacion_EnergeticaLabel.Text = "Clasificación Energética :";
            // 
            // pesoLabel
            // 
            pesoLabel.AutoSize = true;
            pesoLabel.Location = new System.Drawing.Point(12, 22);
            pesoLabel.Name = "pesoLabel";
            pesoLabel.Size = new System.Drawing.Size(37, 13);
            pesoLabel.TabIndex = 0;
            pesoLabel.Text = "Peso :";
            // 
            // capacidadLabel
            // 
            capacidadLabel.AutoSize = true;
            capacidadLabel.Location = new System.Drawing.Point(158, 23);
            capacidadLabel.Name = "capacidadLabel";
            capacidadLabel.Size = new System.Drawing.Size(64, 13);
            capacidadLabel.TabIndex = 2;
            capacidadLabel.Text = "Capacidad :";
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
            this.buttonSearch.Size = new System.Drawing.Size(155, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Buscar por Identificador";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonAccept);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(accesoriosLabel);
            this.groupBox1.Controls.Add(this.accesoriosTextBox);
            this.groupBox1.Controls.Add(imagenLabel);
            this.groupBox1.Controls.Add(garantiaLabel);
            this.groupBox1.Controls.Add(this.imagenPictureBox);
            this.groupBox1.Controls.Add(this.garantiaTextBox);
            this.groupBox1.Controls.Add(cantidad_DisponibleLabel);
            this.groupBox1.Controls.Add(this.cantidad_DisponibleNumericUpDown);
            this.groupBox1.Controls.Add(precioLabel);
            this.groupBox1.Controls.Add(this.precioTextBox);
            this.groupBox1.Controls.Add(id_ProductoLabel);
            this.groupBox1.Controls.Add(this.id_ProductoLabel1);
            this.groupBox1.Controls.Add(categoriaLabel);
            this.groupBox1.Controls.Add(this.categoriaComboBox);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Location = new System.Drawing.Point(134, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 468);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PRODUCTO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(747, 430);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 8;
            this.buttonCancel.Text = "Cancelar ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.Location = new System.Drawing.Point(666, 430);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 7;
            this.buttonAccept.Text = "Aceptar ✔";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBoxTermo);
            this.groupBox2.Controls.Add(marcaLabel);
            this.groupBox2.Controls.Add(this.materialesTextBox);
            this.groupBox2.Controls.Add(this.marcaTextBox);
            this.groupBox2.Controls.Add(materialesLabel);
            this.groupBox2.Controls.Add(this.longitudTextBox);
            this.groupBox2.Controls.Add(longitudLabel);
            this.groupBox2.Controls.Add(this.anchuraTextBox);
            this.groupBox2.Controls.Add(anchuraLabel);
            this.groupBox2.Controls.Add(this.alturaTextBox);
            this.groupBox2.Controls.Add(alturaLabel);
            this.groupBox2.Controls.Add(presion_Label);
            this.groupBox2.Controls.Add(this.groupBoxTuberia);
            this.groupBox2.Controls.Add(this.presion_TextBox);
            this.groupBox2.Location = new System.Drawing.Point(31, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 179);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Características";
            // 
            // groupBoxTermo
            // 
            this.groupBoxTermo.Controls.Add(this.groupBoxWC);
            this.groupBoxTermo.Controls.Add(clasificacion_EnergeticaLabel);
            this.groupBoxTermo.Controls.Add(this.clasificacion_EnergeticaComboBox);
            this.groupBoxTermo.Controls.Add(temperatura_MaximaLabel);
            this.groupBoxTermo.Controls.Add(this.temperatura_MaximaTextBox);
            this.groupBoxTermo.Location = new System.Drawing.Point(13, 112);
            this.groupBoxTermo.Name = "groupBoxTermo";
            this.groupBoxTermo.Size = new System.Drawing.Size(502, 52);
            this.groupBoxTermo.TabIndex = 60;
            this.groupBoxTermo.TabStop = false;
            this.groupBoxTermo.Text = "Específicas";
            // 
            // groupBoxWC
            // 
            this.groupBoxWC.Controls.Add(capacidadLabel);
            this.groupBoxWC.Controls.Add(this.capacidadTextBox);
            this.groupBoxWC.Controls.Add(pesoLabel);
            this.groupBoxWC.Controls.Add(this.pesoTextBox);
            this.groupBoxWC.Location = new System.Drawing.Point(0, 0);
            this.groupBoxWC.Name = "groupBoxWC";
            this.groupBoxWC.Size = new System.Drawing.Size(502, 52);
            this.groupBoxWC.TabIndex = 61;
            this.groupBoxWC.TabStop = false;
            this.groupBoxWC.Text = "Específicas";
            // 
            // capacidadTextBox
            // 
            this.capacidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Capacidad", true));
            this.capacidadTextBox.Location = new System.Drawing.Point(225, 19);
            this.capacidadTextBox.Name = "capacidadTextBox";
            this.capacidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.capacidadTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.capacidadTextBox, "Medida en litros (l)");
            // 
            // productosBindingSource
            // 
            this.productosBindingSource.DataMember = "Productos";
            this.productosBindingSource.DataSource = this.database1DataSet;
            this.productosBindingSource.PositionChanged += new System.EventHandler(this.productosBindingSource_PositionChanged);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pesoTextBox
            // 
            this.pesoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Peso", true));
            this.pesoTextBox.Location = new System.Drawing.Point(52, 19);
            this.pesoTextBox.Name = "pesoTextBox";
            this.pesoTextBox.Size = new System.Drawing.Size(100, 20);
            this.pesoTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.pesoTextBox, "Medida en Kilogramos (kg)");
            // 
            // clasificacion_EnergeticaComboBox
            // 
            this.clasificacion_EnergeticaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Clasificacion_Energetica", true));
            this.clasificacion_EnergeticaComboBox.FormattingEnabled = true;
            this.clasificacion_EnergeticaComboBox.Items.AddRange(new object[] {
            "A+++",
            "A++",
            "A+",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.clasificacion_EnergeticaComboBox.Location = new System.Drawing.Point(362, 19);
            this.clasificacion_EnergeticaComboBox.Name = "clasificacion_EnergeticaComboBox";
            this.clasificacion_EnergeticaComboBox.Size = new System.Drawing.Size(121, 21);
            this.clasificacion_EnergeticaComboBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.clasificacion_EnergeticaComboBox, "(A+++,A++,A+,A,B,C,D,E,F)");
            // 
            // temperatura_MaximaTextBox
            // 
            this.temperatura_MaximaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Temperatura_Maxima", true));
            this.temperatura_MaximaTextBox.Location = new System.Drawing.Point(127, 19);
            this.temperatura_MaximaTextBox.Name = "temperatura_MaximaTextBox";
            this.temperatura_MaximaTextBox.Size = new System.Drawing.Size(100, 20);
            this.temperatura_MaximaTextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.temperatura_MaximaTextBox, "Medida en grados Celsius (Cº)");
            // 
            // materialesTextBox
            // 
            this.materialesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Materiales", true));
            this.materialesTextBox.Location = new System.Drawing.Point(91, 49);
            this.materialesTextBox.Name = "materialesTextBox";
            this.materialesTextBox.Size = new System.Drawing.Size(424, 20);
            this.materialesTextBox.TabIndex = 2;
            // 
            // marcaTextBox
            // 
            this.marcaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Marca", true));
            this.marcaTextBox.Location = new System.Drawing.Point(91, 23);
            this.marcaTextBox.Name = "marcaTextBox";
            this.marcaTextBox.Size = new System.Drawing.Size(267, 20);
            this.marcaTextBox.TabIndex = 0;
            // 
            // longitudTextBox
            // 
            this.longitudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Longitud", true));
            this.longitudTextBox.Location = new System.Drawing.Point(91, 75);
            this.longitudTextBox.Name = "longitudTextBox";
            this.longitudTextBox.Size = new System.Drawing.Size(100, 20);
            this.longitudTextBox.TabIndex = 3;
            this.toolTip1.SetToolTip(this.longitudTextBox, "Medida en centimetros (cm)");
            // 
            // anchuraTextBox
            // 
            this.anchuraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Anchura", true));
            this.anchuraTextBox.Location = new System.Drawing.Point(263, 75);
            this.anchuraTextBox.Name = "anchuraTextBox";
            this.anchuraTextBox.Size = new System.Drawing.Size(100, 20);
            this.anchuraTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.anchuraTextBox, "Medida en centimetros (cm)");
            // 
            // alturaTextBox
            // 
            this.alturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Altura", true));
            this.alturaTextBox.Location = new System.Drawing.Point(415, 75);
            this.alturaTextBox.Name = "alturaTextBox";
            this.alturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.alturaTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.alturaTextBox, "Medida en centimetros (cm)");
            // 
            // groupBoxTuberia
            // 
            this.groupBoxTuberia.Controls.Add(tipo_ConexionLabel);
            this.groupBoxTuberia.Controls.Add(this.tipo_ConexionTextBox);
            this.groupBoxTuberia.Controls.Add(diametroLabel);
            this.groupBoxTuberia.Controls.Add(this.diametroTextBox);
            this.groupBoxTuberia.Location = new System.Drawing.Point(13, 112);
            this.groupBoxTuberia.Name = "groupBoxTuberia";
            this.groupBoxTuberia.Size = new System.Drawing.Size(502, 52);
            this.groupBoxTuberia.TabIndex = 9;
            this.groupBoxTuberia.TabStop = false;
            this.groupBoxTuberia.Text = "Específicas";
            // 
            // tipo_ConexionTextBox
            // 
            this.tipo_ConexionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Tipo_Conexion", true));
            this.tipo_ConexionTextBox.Location = new System.Drawing.Point(270, 19);
            this.tipo_ConexionTextBox.Name = "tipo_ConexionTextBox";
            this.tipo_ConexionTextBox.Size = new System.Drawing.Size(224, 20);
            this.tipo_ConexionTextBox.TabIndex = 13;
            this.toolTip1.SetToolTip(this.tipo_ConexionTextBox, "Conexion Hembra a Macho o ambas");
            // 
            // diametroTextBox
            // 
            this.diametroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Diametro", true));
            this.diametroTextBox.Location = new System.Drawing.Point(80, 19);
            this.diametroTextBox.Name = "diametroTextBox";
            this.diametroTextBox.Size = new System.Drawing.Size(100, 20);
            this.diametroTextBox.TabIndex = 11;
            this.toolTip1.SetToolTip(this.diametroTextBox, "Medida en milimetros (mm)");
            // 
            // presion_TextBox
            // 
            this.presion_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Presion", true));
            this.presion_TextBox.Location = new System.Drawing.Point(417, 23);
            this.presion_TextBox.Name = "presion_TextBox";
            this.presion_TextBox.Size = new System.Drawing.Size(98, 20);
            this.presion_TextBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.presion_TextBox, "Se mide en bares (bar)");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(628, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "€";
            // 
            // accesoriosTextBox
            // 
            this.accesoriosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Accesorios", true));
            this.accesoriosTextBox.Location = new System.Drawing.Point(233, 153);
            this.accesoriosTextBox.Multiline = true;
            this.accesoriosTextBox.Name = "accesoriosTextBox";
            this.accesoriosTextBox.Size = new System.Drawing.Size(326, 20);
            this.accesoriosTextBox.TabIndex = 5;
            this.toolTip1.SetToolTip(this.accesoriosTextBox, "Elementos externos, que incluya que no se puedan catalogar en características");
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productosBindingSource, "Imagen", true));
            this.imagenPictureBox.Location = new System.Drawing.Point(596, 183);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(200, 221);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenPictureBox.TabIndex = 19;
            this.imagenPictureBox.TabStop = false;
            this.imagenPictureBox.Click += new System.EventHandler(this.imagenPictureBox_Click);
            // 
            // garantiaTextBox
            // 
            this.garantiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Garantia", true));
            this.garantiaTextBox.Location = new System.Drawing.Point(98, 153);
            this.garantiaTextBox.Name = "garantiaTextBox";
            this.garantiaTextBox.Size = new System.Drawing.Size(64, 20);
            this.garantiaTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.garantiaTextBox, "Debe figurar en años");
            // 
            // cantidad_DisponibleNumericUpDown
            // 
            this.cantidad_DisponibleNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productosBindingSource, "Cantidad_Disponible", true));
            this.cantidad_DisponibleNumericUpDown.Location = new System.Drawing.Point(760, 77);
            this.cantidad_DisponibleNumericUpDown.Name = "cantidad_DisponibleNumericUpDown";
            this.cantidad_DisponibleNumericUpDown.Size = new System.Drawing.Size(62, 20);
            this.cantidad_DisponibleNumericUpDown.TabIndex = 2;
            // 
            // precioTextBox
            // 
            this.precioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Precio", true));
            this.precioTextBox.Location = new System.Drawing.Point(535, 77);
            this.precioTextBox.Name = "precioTextBox";
            this.precioTextBox.Size = new System.Drawing.Size(87, 20);
            this.precioTextBox.TabIndex = 1;
            // 
            // id_ProductoLabel1
            // 
            this.id_ProductoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Id_Producto", true));
            this.id_ProductoLabel1.Location = new System.Drawing.Point(205, 34);
            this.id_ProductoLabel1.Name = "id_ProductoLabel1";
            this.id_ProductoLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_ProductoLabel1.TabIndex = 8;
            this.id_ProductoLabel1.Text = "label1";
            // 
            // categoriaComboBox
            // 
            this.categoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Categoria", true));
            this.categoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoriaComboBox.FormattingEnabled = true;
            this.categoriaComboBox.Items.AddRange(new object[] {
            "Tubería ",
            "Grifería de paso",
            "Latiguillo",
            "Grifería",
            "Sifón",
            "Termo",
            "Calentador",
            "Tubos válvulas y reguladores de gas",
            "Tubos para evacuación de gases y ventilación",
            "WC",
            "Reparación e instalación WC",
            "Lavabo",
            "Bañera",
            "Plato Ducha",
            "Mampara Ducha",
            "Columna Ducha",
            "Accesorios"});
            this.categoriaComboBox.Location = new System.Drawing.Point(191, 208);
            this.categoriaComboBox.Name = "categoriaComboBox";
            this.categoriaComboBox.Size = new System.Drawing.Size(289, 21);
            this.categoriaComboBox.TabIndex = 6;
            this.categoriaComboBox.SelectedIndexChanged += new System.EventHandler(this.categoriaComboBox_SelectedIndexChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(98, 103);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(724, 44);
            this.descripcionTextBox.TabIndex = 3;
            this.descripcionTextBox.TextChanged += new System.EventHandler(this.descripcionTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(98, 77);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(382, 20);
            this.nombreTextBox.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "label2";
            // 
            // productosTableAdapter
            // 
            this.productosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasDetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.InstalacionesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = this.productosTableAdapter;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasDetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 633);
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
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluefilefolder_azul_archivo_12582;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(508, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluediskserver_azul_disc_12555;
            this.buttonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSave.Location = new System.Drawing.Point(894, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(70, 70);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_refuse_remove_delete_12601;
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemove.Location = new System.Drawing.Point(12, 300);
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
            this.buttonModify.Location = new System.Drawing.Point(12, 201);
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
            this.buttonAdd.Location = new System.Drawing.Point(12, 102);
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
            // ventasDetalleBindingSource
            // 
            this.ventasDetalleBindingSource.DataMember = "VentasDetalle";
            this.ventasDetalleBindingSource.DataSource = this.database1DataSet;
            // 
            // ventasDetalleTableAdapter
            // 
            this.ventasDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // comprasDetalleBindingSource
            // 
            this.comprasDetalleBindingSource.DataMember = "ComprasDetalle";
            this.comprasDetalleBindingSource.DataSource = this.database1DataSet;
            // 
            // comprasDetalleTableAdapter
            // 
            this.comprasDetalleTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Ayuda.chm";
            // 
            // FormProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 655);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonFinal);
            this.Controls.Add(this.buttonAvanzar);
            this.Controls.Add(this.buttonRetroceder);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBack);
            this.helpProvider1.SetHelpKeyword(this, "4 ");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this, "");
            this.Name = "FormProductos";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FontaApp - Productos";
            this.Activated += new System.EventHandler(this.FormProductos_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Productos_FormClosed);
            this.Load += new System.EventHandler(this.FormProductos_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTermo.ResumeLayout(false);
            this.groupBoxTermo.PerformLayout();
            this.groupBoxWC.ResumeLayout(false);
            this.groupBoxWC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            this.groupBoxTuberia.ResumeLayout(false);
            this.groupBoxTuberia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_DisponibleNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventasDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comprasDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFinal;
        private System.Windows.Forms.Button buttonAvanzar;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource productosBindingSource;
        private Database1DataSetTableAdapters.ProductosTableAdapter productosTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox categoriaComboBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Label id_ProductoLabel1;
        private System.Windows.Forms.GroupBox groupBoxTuberia;
        private System.Windows.Forms.TextBox accesoriosTextBox;
        private System.Windows.Forms.TextBox presion_TextBox;
        private System.Windows.Forms.TextBox tipo_ConexionTextBox;
        private System.Windows.Forms.TextBox diametroTextBox;
        private System.Windows.Forms.TextBox alturaTextBox;
        private System.Windows.Forms.TextBox anchuraTextBox;
        private System.Windows.Forms.TextBox longitudTextBox;
        private System.Windows.Forms.TextBox materialesTextBox;
        private System.Windows.Forms.TextBox marcaTextBox;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private System.Windows.Forms.TextBox garantiaTextBox;
        private System.Windows.Forms.NumericUpDown cantidad_DisponibleNumericUpDown;
        private System.Windows.Forms.TextBox precioTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBoxTermo;
        private System.Windows.Forms.ComboBox clasificacion_EnergeticaComboBox;
        private System.Windows.Forms.TextBox temperatura_MaximaTextBox;
        private System.Windows.Forms.GroupBox groupBoxWC;
        private System.Windows.Forms.TextBox capacidadTextBox;
        private System.Windows.Forms.TextBox pesoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource ventasDetalleBindingSource;
        private Database1DataSetTableAdapters.VentasDetalleTableAdapter ventasDetalleTableAdapter;
        private System.Windows.Forms.BindingSource comprasDetalleBindingSource;
        private Database1DataSetTableAdapters.ComprasDetalleTableAdapter comprasDetalleTableAdapter;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}