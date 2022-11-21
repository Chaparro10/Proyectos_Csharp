
namespace Biblioteca.Front
{
    partial class frmModificarLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarLibro));
            this.gbLibros = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblNombreLibro = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.gbPrestar = new System.Windows.Forms.GroupBox();
            this.chkMaestros = new System.Windows.Forms.CheckBox();
            this.chkAlumnos = new System.Windows.Forms.CheckBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.gbUso = new System.Windows.Forms.GroupBox();
            this.rdInterno = new System.Windows.Forms.RadioButton();
            this.rdGeneral = new System.Windows.Forms.RadioButton();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbLibros.SuspendLayout();
            this.gbPrestar.SuspendLayout();
            this.gbUso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLibros
            // 
            this.gbLibros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbLibros.Controls.Add(this.btnLimpiar);
            this.gbLibros.Controls.Add(this.btnEliminar);
            this.gbLibros.Controls.Add(this.btnSalir);
            this.gbLibros.Controls.Add(this.btnModificar);
            this.gbLibros.Controls.Add(this.btnBuscar);
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
            this.gbLibros.Location = new System.Drawing.Point(23, 38);
            this.gbLibros.Name = "gbLibros";
            this.gbLibros.Size = new System.Drawing.Size(557, 328);
            this.gbLibros.TabIndex = 34;
            this.gbLibros.TabStop = false;
            this.gbLibros.Text = "MODIFICAR LIBROS";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(424, 134);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(121, 42);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(424, 273);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 49);
            this.btnSalir.TabIndex = 35;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(424, 80);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(121, 45);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(424, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 49);
            this.btnBuscar.TabIndex = 33;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(26, 22);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(32, 13);
            this.lblISBN.TabIndex = 18;
            this.lblISBN.Text = "ISBN";
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
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(10, 76);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(64, 13);
            this.lblEditorial.TabIndex = 24;
            this.lblEditorial.Text = "EDITORIAL";
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
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Location = new System.Drawing.Point(252, 93);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(158, 20);
            this.txtAutor.TabIndex = 22;
            this.txtAutor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAutor_KeyPress);
            this.txtAutor.Validated += new System.EventHandler(this.txtAutor_Validated);
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(10, 92);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(73, 21);
            this.cmbEditorial.TabIndex = 23;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(293, 77);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(62, 13);
            this.lblAutor.TabIndex = 21;
            this.lblAutor.Text = "AUTOR(es)";
            // 
            // txtISBN
            // 
            this.txtISBN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(10, 38);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(74, 20);
            this.txtISBN.TabIndex = 17;
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
            // txtExistencia
            // 
            this.txtExistencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExistencia.Location = new System.Drawing.Point(146, 93);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(67, 20);
            this.txtExistencia.TabIndex = 25;
            this.txtExistencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistencia_KeyPress);
            this.txtExistencia.Validated += new System.EventHandler(this.txtExistencia_Validated);
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
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(424, 187);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(121, 42);
            this.btnLimpiar.TabIndex = 37;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmModificarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 377);
            this.Controls.Add(this.gbLibros);
            this.Name = "frmModificarLibro";
            this.Text = "MODIFICAR LIBRO";
            this.Load += new System.EventHandler(this.frmModificarLibro_Load);
            this.gbLibros.ResumeLayout(false);
            this.gbLibros.PerformLayout();
            this.gbPrestar.ResumeLayout(false);
            this.gbPrestar.PerformLayout();
            this.gbUso.ResumeLayout(false);
            this.gbUso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLibros;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblNombreLibro;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.GroupBox gbPrestar;
        private System.Windows.Forms.CheckBox chkMaestros;
        private System.Windows.Forms.CheckBox chkAlumnos;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.GroupBox gbUso;
        private System.Windows.Forms.RadioButton rdInterno;
        private System.Windows.Forms.RadioButton rdGeneral;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ErrorProvider errorP;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}