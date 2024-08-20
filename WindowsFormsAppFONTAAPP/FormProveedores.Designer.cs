﻿namespace WindowsFormsAppFONTAAPP
{
    partial class FormProveedores
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label poblacionLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label paisLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cIF_DNILabel;
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFinal = new System.Windows.Forms.Button();
            this.buttonAvanzar = new System.Windows.Forms.Button();
            this.buttonRetroceder = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_ProveedorLabel1 = new System.Windows.Forms.Label();
            this.proveedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new WindowsFormsAppFONTAAPP.Database1DataSet();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.poblacionTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cIF_DNITextBox = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.proveedoresTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ProveedoresTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.comprasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comprasTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.ComprasTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            id_ProveedorLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            poblacionLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cIF_DNILabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_ProveedorLabel
            // 
            id_ProveedorLabel.AutoSize = true;
            id_ProveedorLabel.Location = new System.Drawing.Point(93, 37);
            id_ProveedorLabel.Name = "id_ProveedorLabel";
            id_ProveedorLabel.Size = new System.Drawing.Size(123, 13);
            id_ProveedorLabel.TabIndex = 59;
            id_ProveedorLabel.Text = "Identificador Proveedor :";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(295, 85);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(97, 13);
            nombreLabel.TabIndex = 61;
            nombreLabel.Text = "Nombre Completo :";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(27, 111);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(58, 13);
            direccionLabel.TabIndex = 63;
            direccionLabel.Text = "Dirección :";
            // 
            // poblacionLabel
            // 
            poblacionLabel.AutoSize = true;
            poblacionLabel.Location = new System.Drawing.Point(27, 137);
            poblacionLabel.Name = "poblacionLabel";
            poblacionLabel.Size = new System.Drawing.Size(60, 13);
            poblacionLabel.TabIndex = 65;
            poblacionLabel.Text = "Población :";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(412, 137);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(54, 13);
            provinciaLabel.TabIndex = 67;
            provinciaLabel.Text = "Provincia:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(27, 163);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(35, 13);
            paisLabel.TabIndex = 69;
            paisLabel.Text = "País :";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(27, 231);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 71;
            telefonoLabel.Text = "Telefono:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(27, 205);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 73;
            emailLabel.Text = "Email:";
            // 
            // cIF_DNILabel
            // 
            cIF_DNILabel.AutoSize = true;
            cIF_DNILabel.Location = new System.Drawing.Point(27, 85);
            cIF_DNILabel.Name = "cIF_DNILabel";
            cIF_DNILabel.Size = new System.Drawing.Size(59, 13);
            cIF_DNILabel.TabIndex = 75;
            cIF_DNILabel.Text = "CIF / DNI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 66;
            this.label1.Text = "label1";
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
            this.buttonSearch.Size = new System.Drawing.Size(155, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Buscar por Identificador";
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(id_ProveedorLabel);
            this.groupBox1.Controls.Add(this.id_ProveedorLabel1);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(direccionLabel);
            this.groupBox1.Controls.Add(this.direccionTextBox);
            this.groupBox1.Controls.Add(poblacionLabel);
            this.groupBox1.Controls.Add(this.poblacionTextBox);
            this.groupBox1.Controls.Add(provinciaLabel);
            this.groupBox1.Controls.Add(this.provinciaTextBox);
            this.groupBox1.Controls.Add(paisLabel);
            this.groupBox1.Controls.Add(this.paisTextBox);
            this.groupBox1.Controls.Add(telefonoLabel);
            this.groupBox1.Controls.Add(this.telefonoTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Controls.Add(cIF_DNILabel);
            this.groupBox1.Controls.Add(this.cIF_DNITextBox);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonAccept);
            this.groupBox1.Location = new System.Drawing.Point(134, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 337);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROVEEDOR";
            // 
            // id_ProveedorLabel1
            // 
            this.id_ProveedorLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Id_Proveedor", true));
            this.id_ProveedorLabel1.Location = new System.Drawing.Point(222, 37);
            this.id_ProveedorLabel1.Name = "id_ProveedorLabel1";
            this.id_ProveedorLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_ProveedorLabel1.TabIndex = 60;
            this.id_ProveedorLabel1.Text = "label2";
            // 
            // proveedoresBindingSource
            // 
            this.proveedoresBindingSource.DataMember = "Proveedores";
            this.proveedoresBindingSource.DataSource = this.database1DataSet;
            this.proveedoresBindingSource.PositionChanged += new System.EventHandler(this.proveedoresBindingSource_PositionChanged);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(398, 82);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(402, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(93, 108);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(707, 20);
            this.direccionTextBox.TabIndex = 2;
            // 
            // poblacionTextBox
            // 
            this.poblacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Poblacion", true));
            this.poblacionTextBox.Location = new System.Drawing.Point(93, 134);
            this.poblacionTextBox.Name = "poblacionTextBox";
            this.poblacionTextBox.Size = new System.Drawing.Size(299, 20);
            this.poblacionTextBox.TabIndex = 3;
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Provincia", true));
            this.provinciaTextBox.Location = new System.Drawing.Point(489, 134);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(311, 20);
            this.provinciaTextBox.TabIndex = 4;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(93, 160);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(167, 20);
            this.paisTextBox.TabIndex = 5;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(93, 228);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(299, 20);
            this.telefonoTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(93, 202);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(707, 20);
            this.emailTextBox.TabIndex = 6;
            // 
            // cIF_DNITextBox
            // 
            this.cIF_DNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedoresBindingSource, "CIF_DNI", true));
            this.cIF_DNITextBox.Location = new System.Drawing.Point(93, 82);
            this.cIF_DNITextBox.Name = "cIF_DNITextBox";
            this.cIF_DNITextBox.Size = new System.Drawing.Size(196, 20);
            this.cIF_DNITextBox.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cIF_DNITextBox, "Agreggue elque corresponda de los dos");
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(750, 309);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 9;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccept.Location = new System.Drawing.Point(669, 309);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Aceptar";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources.blue_refuse_remove_delete_12601;
            this.buttonRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRemove.Location = new System.Drawing.Point(12, 294);
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
            this.buttonModify.Location = new System.Drawing.Point(12, 195);
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
            this.buttonAdd.Location = new System.Drawing.Point(12, 96);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 93);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // proveedoresTableAdapter
            // 
            this.proveedoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasDetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.InstalacionesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = this.proveedoresTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasDetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
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
            // comprasBindingSource
            // 
            this.comprasBindingSource.DataMember = "Compras";
            this.comprasBindingSource.DataSource = this.database1DataSet;
            // 
            // comprasTableAdapter
            // 
            this.comprasTableAdapter.ClearBeforeFill = true;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Ayuda.chm";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(976, 527);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFinal);
            this.Controls.Add(this.buttonAvanzar);
            this.Controls.Add(this.buttonRetroceder);
            this.Controls.Add(this.buttonInicio);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonBack);
            this.helpProvider1.SetHelpKeyword(this, "7");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this, "");
            this.Name = "FormProveedores";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FontaApp - Proveedores";
            this.Activated += new System.EventHandler(this.FormProveedores_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Proveedores_FormClosing);
            this.Load += new System.EventHandler(this.FormProveedores_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comprasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFinal;
        private System.Windows.Forms.Button buttonAvanzar;
        private System.Windows.Forms.Button buttonRetroceder;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource proveedoresBindingSource;
        private Database1DataSetTableAdapters.ProveedoresTableAdapter proveedoresTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label id_ProveedorLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox poblacionTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cIF_DNITextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.BindingSource comprasBindingSource;
        private Database1DataSetTableAdapters.ComprasTableAdapter comprasTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}