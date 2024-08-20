namespace WindowsFormsAppFONTAAPP
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label_contrasenaVisible = new System.Windows.Forms.Label();
            this.button_acceder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_mostrar = new System.Windows.Forms.CheckBox();
            this.label_contrasena = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.database1DataSet = new WindowsFormsAppFONTAAPP.Database1DataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_contrasenaVisible
            // 
            this.label_contrasenaVisible.AutoSize = true;
            this.label_contrasenaVisible.Location = new System.Drawing.Point(360, 230);
            this.label_contrasenaVisible.Name = "label_contrasenaVisible";
            this.label_contrasenaVisible.Size = new System.Drawing.Size(19, 13);
            this.label_contrasenaVisible.TabIndex = 15;
            this.label_contrasenaVisible.Text = "👁";
            // 
            // button_acceder
            // 
            this.button_acceder.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_acceder.Location = new System.Drawing.Point(129, 267);
            this.button_acceder.Name = "button_acceder";
            this.button_acceder.Size = new System.Drawing.Size(123, 35);
            this.button_acceder.TabIndex = 3;
            this.button_acceder.Text = "Acceder";
            this.button_acceder.UseVisualStyleBackColor = false;
            this.button_acceder.Click += new System.EventHandler(this.button_acceder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // checkBox_mostrar
            // 
            this.checkBox_mostrar.AutoSize = true;
            this.checkBox_mostrar.Location = new System.Drawing.Point(293, 253);
            this.checkBox_mostrar.Name = "checkBox_mostrar";
            this.checkBox_mostrar.Size = new System.Drawing.Size(61, 17);
            this.checkBox_mostrar.TabIndex = 2;
            this.checkBox_mostrar.Text = "Mostrar";
            this.checkBox_mostrar.UseVisualStyleBackColor = true;
            this.checkBox_mostrar.CheckedChanged += new System.EventHandler(this.checkBox_mostrar_CheckedChanged);
            // 
            // label_contrasena
            // 
            this.label_contrasena.AutoSize = true;
            this.label_contrasena.Location = new System.Drawing.Point(33, 211);
            this.label_contrasena.Name = "label_contrasena";
            this.label_contrasena.Size = new System.Drawing.Size(64, 13);
            this.label_contrasena.TabIndex = 13;
            this.label_contrasena.Text = "Contraseña:";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Location = new System.Drawing.Point(33, 169);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(49, 13);
            this.label_usuario.TabIndex = 11;
            this.label_usuario.Text = "Usuario :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(36, 227);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(318, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(36, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.database1DataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.ComprasDetalleTableAdapter = null;
            this.tableAdapterManager.ComprasTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.InstalacionesTableAdapter = null;
            this.tableAdapterManager.ProductosTableAdapter = null;
            this.tableAdapterManager.ProveedoresTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsAppFONTAAPP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VentasDetalleTableAdapter = null;
            this.tableAdapterManager.VentasTableAdapter = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsAppFONTAAPP.Properties.Resources._167621660_fugas_o_tubería_rota_vector_icono_de_color_de_plomería_removebg_preview;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(105, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 167);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "Ayuda.chm";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(403, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_contrasenaVisible);
            this.Controls.Add(this.button_acceder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_mostrar);
            this.Controls.Add(this.label_contrasena);
            this.Controls.Add(this.label_usuario);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.helpProvider1.SetHelpKeyword(this, "0");
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.TopicId);
            this.helpProvider1.SetHelpString(this, "");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "FontaApp - Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_contrasenaVisible;
        private System.Windows.Forms.Button button_acceder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_mostrar;
        private System.Windows.Forms.Label label_contrasena;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private Database1DataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}