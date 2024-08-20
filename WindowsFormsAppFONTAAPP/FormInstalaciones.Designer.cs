namespace WindowsFormsAppFONTAAPP
{
    partial class FormInstalaciones
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
            System.Windows.Forms.Label id_InstalacionLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label código_PostalLabel;
            System.Windows.Forms.Label contacto_ClienteLabel;
            System.Windows.Forms.Label descripcion_ProyectoLabel;
            System.Windows.Forms.Label nombreLabel;
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
            this.instalacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.instalacionesTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.InstalacionesTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager();
            this.id_InstalacionLabel1 = new System.Windows.Forms.Label();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.código_PostalTextBox = new System.Windows.Forms.TextBox();
            this.contacto_ClienteTextBox = new System.Windows.Forms.TextBox();
            this.descripcion_ProyectoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonAccept = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.clientesTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ClientesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_InstalacionLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            código_PostalLabel = new System.Windows.Forms.Label();
            contacto_ClienteLabel = new System.Windows.Forms.Label();
            descripcion_ProyectoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.instalacionesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_InstalacionLabel
            // 
            id_InstalacionLabel.AutoSize = true;
            id_InstalacionLabel.Location = new System.Drawing.Point(74, 40);
            id_InstalacionLabel.Name = "id_InstalacionLabel";
            id_InstalacionLabel.Size = new System.Drawing.Size(119, 13);
            id_InstalacionLabel.TabIndex = 20;
            id_InstalacionLabel.Text = "Número de Instalación :";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(9, 65);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(58, 13);
            direccionLabel.TabIndex = 24;
            direccionLabel.Text = "Dirección :";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(9, 91);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(46, 13);
            ciudadLabel.TabIndex = 26;
            ciudadLabel.Text = "Ciudad :";
            // 
            // código_PostalLabel
            // 
            código_PostalLabel.AutoSize = true;
            código_PostalLabel.Location = new System.Drawing.Point(295, 91);
            código_PostalLabel.Name = "código_PostalLabel";
            código_PostalLabel.Size = new System.Drawing.Size(78, 13);
            código_PostalLabel.TabIndex = 28;
            código_PostalLabel.Text = "Código Postal :";
            // 
            // contacto_ClienteLabel
            // 
            contacto_ClienteLabel.AutoSize = true;
            contacto_ClienteLabel.Location = new System.Drawing.Point(518, 91);
            contacto_ClienteLabel.Name = "contacto_ClienteLabel";
            contacto_ClienteLabel.Size = new System.Drawing.Size(56, 13);
            contacto_ClienteLabel.TabIndex = 30;
            contacto_ClienteLabel.Text = "Contacto :";
            // 
            // descripcion_ProyectoLabel
            // 
            descripcion_ProyectoLabel.AutoSize = true;
            descripcion_ProyectoLabel.Location = new System.Drawing.Point(14, 210);
            descripcion_ProyectoLabel.Name = "descripcion_ProyectoLabel";
            descripcion_ProyectoLabel.Size = new System.Drawing.Size(131, 13);
            descripcion_ProyectoLabel.TabIndex = 32;
            descripcion_ProyectoLabel.Text = "Descripción del Proyecto :";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(70, 25);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 33;
            nombreLabel.Text = "Nombre:";
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_refuse_remove_delete_12601;
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemove.Location = new System.Drawing.Point(12, 301);
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
            this.buttonModify.Location = new System.Drawing.Point(12, 202);
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
            this.buttonAdd.Location = new System.Drawing.Point(12, 103);
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
            this.buttonSearch.Size = new System.Drawing.Size(217, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Buscar por Número de Instalación";
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
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // instalacionesBindingSource
            // 
            this.instalacionesBindingSource.DataMember = "Instalaciones";
            this.instalacionesBindingSource.DataSource = this.database1DataSet;
            this.instalacionesBindingSource.PositionChanged += new System.EventHandler(this.instalacionesBindingSource_PositionChanged);
            // 
            // instalacionesTableAdapter
            // 
            this.instalacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasDetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.InstalacionesTableAdapter = this.instalacionesTableAdapter;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasDetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // id_InstalacionLabel1
            // 
            this.id_InstalacionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instalacionesBindingSource, "Id_Instalacion", true));
            this.id_InstalacionLabel1.Location = new System.Drawing.Point(199, 40);
            this.id_InstalacionLabel1.Name = "id_InstalacionLabel1";
            this.id_InstalacionLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_InstalacionLabel1.TabIndex = 21;
            this.id_InstalacionLabel1.Text = "label1";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instalacionesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(73, 62);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(734, 20);
            this.direccionTextBox.TabIndex = 1;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instalacionesBindingSource, "Ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(73, 88);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(218, 20);
            this.ciudadTextBox.TabIndex = 2;
            // 
            // código_PostalTextBox
            // 
            this.código_PostalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instalacionesBindingSource, "Código_Postal", true));
            this.código_PostalTextBox.Location = new System.Drawing.Point(379, 88);
            this.código_PostalTextBox.Name = "código_PostalTextBox";
            this.código_PostalTextBox.Size = new System.Drawing.Size(133, 20);
            this.código_PostalTextBox.TabIndex = 3;
            // 
            // contacto_ClienteTextBox
            // 
            this.contacto_ClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instalacionesBindingSource, "Contacto_Cliente", true));
            this.contacto_ClienteTextBox.Location = new System.Drawing.Point(580, 88);
            this.contacto_ClienteTextBox.Name = "contacto_ClienteTextBox";
            this.contacto_ClienteTextBox.Size = new System.Drawing.Size(227, 20);
            this.contacto_ClienteTextBox.TabIndex = 4;
            // 
            // descripcion_ProyectoTextBox
            // 
            this.descripcion_ProyectoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.instalacionesBindingSource, "Descripcion_Proyecto", true));
            this.descripcion_ProyectoTextBox.Location = new System.Drawing.Point(151, 207);
            this.descripcion_ProyectoTextBox.Multiline = true;
            this.descripcion_ProyectoTextBox.Name = "descripcion_ProyectoTextBox";
            this.descripcion_ProyectoTextBox.Size = new System.Drawing.Size(664, 84);
            this.descripcion_ProyectoTextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.descripcion_ProyectoTextBox, "Apartado dedica desde como va el proyecto, hasta notas");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(id_InstalacionLabel);
            this.groupBox1.Controls.Add(this.id_InstalacionLabel1);
            this.groupBox1.Controls.Add(this.buttonAccept);
            this.groupBox1.Controls.Add(this.descripcion_ProyectoTextBox);
            this.groupBox1.Controls.Add(descripcion_ProyectoLabel);
            this.groupBox1.Location = new System.Drawing.Point(134, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 338);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INSTALACIÓN";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(740, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancelar ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(nombreLabel);
            this.groupBox2.Controls.Add(this.nombreComboBox);
            this.groupBox2.Controls.Add(direccionLabel);
            this.groupBox2.Controls.Add(this.contacto_ClienteTextBox);
            this.groupBox2.Controls.Add(contacto_ClienteLabel);
            this.groupBox2.Controls.Add(ciudadLabel);
            this.groupBox2.Controls.Add(this.direccionTextBox);
            this.groupBox2.Controls.Add(this.código_PostalTextBox);
            this.groupBox2.Controls.Add(this.ciudadTextBox);
            this.groupBox2.Controls.Add(código_PostalLabel);
            this.groupBox2.Location = new System.Drawing.Point(8, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 118);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Cliente";
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.instalacionesBindingSource, "Nombre", true));
            this.nombreComboBox.DataSource = this.clientesBindingSource;
            this.nombreComboBox.DisplayMember = "Nombre";
            this.nombreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(123, 22);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(331, 21);
            this.nombreComboBox.TabIndex = 0;
            this.nombreComboBox.ValueMember = "Id_Cliente";
            this.nombreComboBox.SelectedIndexChanged += new System.EventHandler(this.nombreComboBox_SelectedIndexChanged);
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.database1DataSet;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.Location = new System.Drawing.Point(659, 309);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 1;
            this.buttonAccept.Text = "Aceptar ";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.bluefilefolder_azul_archivo_12582;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(508, 444);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 505);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(976, 22);
            this.statusStrip1.TabIndex = 108;
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
            // FormInstalaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 527);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
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
            this.helpProvider1.SetHelpKeyword(this, "5");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this, "");
            this.Name = "FormInstalaciones";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FontaApp - Instalaciones";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Instalaciones_FormClosing);
            this.Load += new System.EventHandler(this.FormInstalaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.instalacionesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource instalacionesBindingSource;
        private Database1DataSetTableAdapters.InstalacionesTableAdapter instalacionesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_InstalacionLabel1;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox código_PostalTextBox;
        private System.Windows.Forms.TextBox contacto_ClienteTextBox;
        private System.Windows.Forms.TextBox descripcion_ProyectoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private Database1DataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}