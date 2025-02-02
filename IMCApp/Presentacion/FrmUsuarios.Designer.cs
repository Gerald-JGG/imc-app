namespace Presentacion
{
    partial class FrmUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lbnFecha = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.lbnDireccion = new System.Windows.Forms.Label();
            this.lbnGenero = new System.Windows.Forms.Label();
            this.lbnNombre = new System.Windows.Forms.Label();
            this.lbnCedula = new System.Windows.Forms.Label();
            this.grbMostrar = new System.Windows.Forms.GroupBox();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIMC = new System.Windows.Forms.TextBox();
            this.txtGenero1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAltura1 = new System.Windows.Forms.TextBox();
            this.txtPeso1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.txtCedula1 = new System.Windows.Forms.TextBox();
            this.grbMostrar1 = new System.Windows.Forms.GroupBox();
            this.dtgUsuarios1 = new System.Windows.Forms.DataGridView();
            this.tcUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.grbMostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.grbMostrar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios1)).BeginInit();
            this.SuspendLayout();
            // 
            // tcUsuarios
            // 
            this.tcUsuarios.Controls.Add(this.tabPage1);
            this.tcUsuarios.Controls.Add(this.tabPage2);
            this.tcUsuarios.Location = new System.Drawing.Point(-1, 0);
            this.tcUsuarios.Name = "tcUsuarios";
            this.tcUsuarios.SelectedIndex = 0;
            this.tcUsuarios.Size = new System.Drawing.Size(588, 360);
            this.tcUsuarios.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grbDatos);
            this.tabPage1.Controls.Add(this.grbMostrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(580, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grbDatos
            // 
            this.grbDatos.Controls.Add(this.txtAltura);
            this.grbDatos.Controls.Add(this.cmbGenero);
            this.grbDatos.Controls.Add(this.btnLimpiar);
            this.grbDatos.Controls.Add(this.lbnFecha);
            this.grbDatos.Controls.Add(this.btnEliminar);
            this.grbDatos.Controls.Add(this.txtPeso);
            this.grbDatos.Controls.Add(this.btnModificar);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.btnInsertar);
            this.grbDatos.Controls.Add(this.txtCedula);
            this.grbDatos.Controls.Add(this.lbnDireccion);
            this.grbDatos.Controls.Add(this.lbnGenero);
            this.grbDatos.Controls.Add(this.lbnNombre);
            this.grbDatos.Controls.Add(this.lbnCedula);
            this.grbDatos.Location = new System.Drawing.Point(7, 6);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(566, 159);
            this.grbDatos.TabIndex = 6;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos del Estudiante";
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(88, 130);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(142, 20);
            this.txtAltura.TabIndex = 12;
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbGenero.Location = new System.Drawing.Point(88, 77);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(142, 21);
            this.cmbGenero.TabIndex = 11;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(478, 113);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // lbnFecha
            // 
            this.lbnFecha.AutoSize = true;
            this.lbnFecha.Location = new System.Drawing.Point(45, 133);
            this.lbnFecha.Name = "lbnFecha";
            this.lbnFecha.Size = new System.Drawing.Size(37, 13);
            this.lbnFecha.TabIndex = 9;
            this.lbnFecha.Text = "Altura:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(478, 79);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 28);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(88, 104);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(142, 20);
            this.txtPeso.TabIndex = 7;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(478, 46);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 28);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 51);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(142, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(478, 15);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 28);
            this.btnInsertar.TabIndex = 1;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(88, 24);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(142, 20);
            this.txtCedula.TabIndex = 4;
            // 
            // lbnDireccion
            // 
            this.lbnDireccion.AutoSize = true;
            this.lbnDireccion.Location = new System.Drawing.Point(48, 107);
            this.lbnDireccion.Name = "lbnDireccion";
            this.lbnDireccion.Size = new System.Drawing.Size(34, 13);
            this.lbnDireccion.TabIndex = 3;
            this.lbnDireccion.Text = "Peso:";
            // 
            // lbnGenero
            // 
            this.lbnGenero.AutoSize = true;
            this.lbnGenero.Location = new System.Drawing.Point(37, 80);
            this.lbnGenero.Name = "lbnGenero";
            this.lbnGenero.Size = new System.Drawing.Size(45, 13);
            this.lbnGenero.TabIndex = 2;
            this.lbnGenero.Text = "Genero:";
            // 
            // lbnNombre
            // 
            this.lbnNombre.AutoSize = true;
            this.lbnNombre.Location = new System.Drawing.Point(35, 54);
            this.lbnNombre.Name = "lbnNombre";
            this.lbnNombre.Size = new System.Drawing.Size(47, 13);
            this.lbnNombre.TabIndex = 1;
            this.lbnNombre.Text = "Nombre:";
            // 
            // lbnCedula
            // 
            this.lbnCedula.AutoSize = true;
            this.lbnCedula.Location = new System.Drawing.Point(39, 26);
            this.lbnCedula.Name = "lbnCedula";
            this.lbnCedula.Size = new System.Drawing.Size(43, 13);
            this.lbnCedula.TabIndex = 0;
            this.lbnCedula.Text = "Cédula:";
            // 
            // grbMostrar
            // 
            this.grbMostrar.Controls.Add(this.dtgUsuarios);
            this.grbMostrar.Location = new System.Drawing.Point(7, 170);
            this.grbMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.grbMostrar.Name = "grbMostrar";
            this.grbMostrar.Padding = new System.Windows.Forms.Padding(2);
            this.grbMostrar.Size = new System.Drawing.Size(566, 159);
            this.grbMostrar.TabIndex = 5;
            this.grbMostrar.TabStop = false;
            this.grbMostrar.Text = "Usuarios Registrados";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(5, 18);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgUsuarios.Size = new System.Drawing.Size(555, 136);
            this.dtgUsuarios.TabIndex = 5;
            this.dtgUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios_CellClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIMC);
            this.tabPage2.Controls.Add(this.txtGenero1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.txtAltura1);
            this.tabPage2.Controls.Add(this.txtPeso1);
            this.tabPage2.Controls.Add(this.txtNombre1);
            this.tabPage2.Controls.Add(this.txtCedula1);
            this.tabPage2.Controls.Add(this.grbMostrar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(580, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "IMC Usuarios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIMC
            // 
            this.txtIMC.Location = new System.Drawing.Point(279, 6);
            this.txtIMC.Multiline = true;
            this.txtIMC.Name = "txtIMC";
            this.txtIMC.ReadOnly = true;
            this.txtIMC.Size = new System.Drawing.Size(295, 125);
            this.txtIMC.TabIndex = 29;
            // 
            // txtGenero1
            // 
            this.txtGenero1.Location = new System.Drawing.Point(61, 59);
            this.txtGenero1.Name = "txtGenero1";
            this.txtGenero1.ReadOnly = true;
            this.txtGenero1.Size = new System.Drawing.Size(203, 20);
            this.txtGenero1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Altura:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Peso:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Genero:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cedula:";
            // 
            // txtAltura1
            // 
            this.txtAltura1.Location = new System.Drawing.Point(61, 111);
            this.txtAltura1.Name = "txtAltura1";
            this.txtAltura1.ReadOnly = true;
            this.txtAltura1.Size = new System.Drawing.Size(203, 20);
            this.txtAltura1.TabIndex = 21;
            // 
            // txtPeso1
            // 
            this.txtPeso1.Location = new System.Drawing.Point(61, 85);
            this.txtPeso1.Name = "txtPeso1";
            this.txtPeso1.ReadOnly = true;
            this.txtPeso1.Size = new System.Drawing.Size(203, 20);
            this.txtPeso1.TabIndex = 20;
            // 
            // txtNombre1
            // 
            this.txtNombre1.Location = new System.Drawing.Point(61, 32);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.ReadOnly = true;
            this.txtNombre1.Size = new System.Drawing.Size(203, 20);
            this.txtNombre1.TabIndex = 19;
            // 
            // txtCedula1
            // 
            this.txtCedula1.Location = new System.Drawing.Point(61, 6);
            this.txtCedula1.Name = "txtCedula1";
            this.txtCedula1.ReadOnly = true;
            this.txtCedula1.Size = new System.Drawing.Size(203, 20);
            this.txtCedula1.TabIndex = 18;
            // 
            // grbMostrar1
            // 
            this.grbMostrar1.Controls.Add(this.dtgUsuarios1);
            this.grbMostrar1.Location = new System.Drawing.Point(7, 144);
            this.grbMostrar1.Margin = new System.Windows.Forms.Padding(2);
            this.grbMostrar1.Name = "grbMostrar1";
            this.grbMostrar1.Padding = new System.Windows.Forms.Padding(2);
            this.grbMostrar1.Size = new System.Drawing.Size(566, 185);
            this.grbMostrar1.TabIndex = 6;
            this.grbMostrar1.TabStop = false;
            this.grbMostrar1.Text = "Usuarios Registrados";
            // 
            // dtgUsuarios1
            // 
            this.dtgUsuarios1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios1.Location = new System.Drawing.Point(5, 18);
            this.dtgUsuarios1.Name = "dtgUsuarios1";
            this.dtgUsuarios1.Size = new System.Drawing.Size(556, 162);
            this.dtgUsuarios1.TabIndex = 1;
            this.dtgUsuarios1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgUsuarios1_CellContentClick);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 372);
            this.Controls.Add(this.tcUsuarios);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsuarios";
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.FrmEstudiantes_Load);
            this.tcUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.grbMostrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.grbMostrar1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tcUsuarios;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grbMostrar1;
        private System.Windows.Forms.TextBox txtIMC;
        private System.Windows.Forms.TextBox txtGenero1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAltura1;
        private System.Windows.Forms.TextBox txtPeso1;
        private System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.TextBox txtCedula1;
        private System.Windows.Forms.DataGridView dtgUsuarios1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lbnFecha;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label lbnDireccion;
        private System.Windows.Forms.Label lbnGenero;
        private System.Windows.Forms.Label lbnNombre;
        private System.Windows.Forms.Label lbnCedula;
        private System.Windows.Forms.GroupBox grbMostrar;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.TextBox txtAltura;
    }
}

