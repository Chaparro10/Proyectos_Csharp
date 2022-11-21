namespace Biblioteca.Front
{
    partial class frmAgregarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarLibro));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.gbPrestar = new System.Windows.Forms.GroupBox();
            this.chkMaestros = new System.Windows.Forms.CheckBox();
            this.chkAlumnos = new System.Windows.Forms.CheckBox();
            this.gbUso = new System.Windows.Forms.GroupBox();
            this.rdInterno = new System.Windows.Forms.RadioButton();
            this.rdGeneral = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblDatosLibro = new System.Windows.Forms.Label();
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbPrestar.SuspendLayout();
            this.gbUso.SuspendLayout();
            this.gbLibros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(254, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(146, 45);
            this.btnSalir.TabIndex = 30;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(254, 304);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(146, 51);
            this.btnConsultar.TabIndex = 28;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(454, 304);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(146, 45);
            this.btnLimpiar.TabIndex = 29;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardar.Location = new System.Drawing.Point(60, 306);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(146, 49);
            this.btnGuardar.TabIndex = 27;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(10, 92);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(73, 21);
            this.cmbEditorial.TabIndex = 23;
            // 
            // gbPrestar
            // 
            this.gbPrestar.Controls.Add(this.chkMaestros);
            this.gbPrestar.Controls.Add(this.chkAlumnos);
            this.gbPrestar.Location = new System.Drawing.Point(154, 144);
            this.gbPrestar.Name = "gbPrestar";
            this.gbPrestar.Size = new System.Drawing.Size(127, 73);
            this.gbPrestar.TabIndex = 32;
            this.gbPrestar.TabStop = false;
            this.gbPrestar.Text = "Prestar a";
            // 
            // chkMaestros
            // 
            this.chkMaestros.AutoSize = true;
            this.chkMaestros.Location = new System.Drawing.Point(6, 20);
            this.chkMaestros.Name = "chkMaestros";
            this.chkMaestros.Size = new System.Drawing.Size(86, 17);
            this.chkMaestros.TabIndex = 7;
            this.chkMaestros.Text = "MAESTROS";
            this.chkMaestros.UseVisualStyleBackColor = true;
            // 
            // chkAlumnos
            // 
            this.chkAlumnos.AutoSize = true;
            this.chkAlumnos.Checked = true;
            this.chkAlumnos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlumnos.Location = new System.Drawing.Point(6, 43);
            this.chkAlumnos.Name = "chkAlumnos";
            this.chkAlumnos.Size = new System.Drawing.Size(79, 17);
            this.chkAlumnos.TabIndex = 14;
            this.chkAlumnos.Text = "ALUMNOS";
            this.chkAlumnos.UseVisualStyleBackColor = true;
            // 
            // gbUso
            // 
            this.gbUso.Controls.Add(this.rdInterno);
            this.gbUso.Controls.Add(this.rdGeneral);
            this.gbUso.Location = new System.Drawing.Point(10, 144);
            this.gbUso.Name = "gbUso";
            this.gbUso.Size = new System.Drawing.Size(128, 73);
            this.gbUso.TabIndex = 31;
            this.gbUso.TabStop = false;
            this.gbUso.Text = "Para Uso";
            // 
            // rdInterno
            // 
            this.rdInterno.AutoSize = true;
            this.rdInterno.Checked = true;
            this.rdInterno.Location = new System.Drawing.Point(12, 19);
            this.rdInterno.Name = "rdInterno";
            this.rdInterno.Size = new System.Drawing.Size(74, 17);
            this.rdInterno.TabIndex = 6;
            this.rdInterno.TabStop = true;
            this.rdInterno.Text = "INTERNO";
            this.rdInterno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rdInterno.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.rdInterno.UseVisualStyleBackColor = true;
            // 
            // rdGeneral
            // 
            this.rdGeneral.AutoSize = true;
            this.rdGeneral.Location = new System.Drawing.Point(9, 42);
            this.rdGeneral.Name = "rdGeneral";
            this.rdGeneral.Size = new System.Drawing.Size(76, 17);
            this.rdGeneral.TabIndex = 11;
            this.rdGeneral.Text = "GENERAL";
            this.rdGeneral.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(146, 38);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 20);
            this.txtNombre.TabIndex = 20;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Location = new System.Drawing.Point(421, 38);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(158, 20);
            this.txtAutor.TabIndex = 22;
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            this.txtAutor.Validated += new System.EventHandler(this.txtAutor_Validated);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(146, 93);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(67, 20);
            this.txtExistencia.TabIndex = 25;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            this.txtExistencia.Validated += new System.EventHandler(this.txtExistencia_Validated);
            // 
            // txtISBN
            // 
            this.txtISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtISBN.Location = new System.Drawing.Point(10, 38);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(74, 20);
            this.txtISBN.TabIndex = 17;
            this.txtISBN.Validated += new System.EventHandler(this.txtISBN_Validated);
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(143, 76);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(70, 13);
            this.lblExistencia.TabIndex = 26;
            this.lblExistencia.Text = "EXISTENCIA";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(10, 76);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(64, 13);
            this.lblEditorial.TabIndex = 24;
            this.lblEditorial.Text = "EDITORIAL";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(463, 22);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(62, 13);
            this.lblAutor.TabIndex = 21;
            this.lblAutor.Text = "AUTOR(es)";
            // 
            // lblNombreLibro
            // 
            this.lblNombreLibro.AutoSize = true;
            this.lblNombreLibro.Location = new System.Drawing.Point(249, 22);
            this.lblNombreLibro.Name = "lblNombreLibro";
            this.lblNombreLibro.Size = new System.Drawing.Size(54, 13);
            this.lblNombreLibro.TabIndex = 19;
            this.lblNombreLibro.Text = "NOMBRE";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(26, 22);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN";
            // 
            // lblDatosLibro
            // 
            this.lblDatosLibro.AutoSize = true;
            this.lblDatosLibro.Location = new System.Drawing.Point(270, 9);
            this.lblDatosLibro.Name = "lblDatosLibro";
            this.lblDatosLibro.Size = new System.Drawing.Size(103, 13);
            this.lblDatosLibro.TabIndex = 16;
            this.lblDatosLibro.Text = "DATOS DEL LIBRO";
            // 
            // gbLibros
            // 
            this.gbLibros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbLibros.Controls.Add(this.txtNombre);
            this.gbLibros.Controls.Add(this.lblISBN);
            this.gbLibros.Controls.Add(this.lblNombreLibro);
            this.gbLibros.Controls.Add(this.lblEditorial);
            this.gbLibros.Controls.Add(this.lblExistencia);
            this.gbLibros.Controls.Add(this.txtAutor);
            this.gbLibros.Controls.Add(this.cmbEditorial);
            this.gbLibros.Controls.Add(this.lblAutor);
            this.gbLibros.Controls.Add(this.txtISBN);
            this.gbLibros.Controls.Add(this.gbPrestar);
            this.gbLibros.Controls.Add(this.txtExistencia);
            this.gbLibros.Controls.Add(this.gbUso);
            this.gbLibros.Location = new System.Drawing.Point(21, 34);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Size = new System.Drawing.Size(642, 262);
            this.gbLibros.TabIndex = 33;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "DATOS LIBROS";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 408);
            this.Controls.Add(this.gbLibros);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblDatosLibro);
            this.Name = "frmAgregarLibro";
            this.Text = "AGREGAR LIBRO";
            this.Load += new System.EventHandler(this.frmAgregarLibro_Load);
            this.gbPrestar.ResumeLayout(false);
            this.gbPrestar.PerformLayout();
            this.gbUso.ResumeLayout(false);
            this.gbUso.PerformLayout();
            this.gbLibros.ResumeLayout(false);
            this.gbLibros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.GroupBox gbPrestar;
        private System.Windows.Forms.CheckBox chkMaestros;
        private System.Windows.Forms.CheckBox chkAlumnos;
        private System.Windows.Forms.GroupBox gbUso;
        private System.Windows.Forms.RadioButton rdInterno;
        private System.Windows.Forms.RadioButton rdGeneral;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblDatosLibro;
        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}