
namespace Biblioteca.Front
{
    partial class frmAgregarPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarPrestamo));
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombrePresta = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombreEd = new System.Windows.Forms.Label();
            this.rdEstudiante = new System.Windows.Forms.RadioButton();
            this.rdMaestro = new System.Windows.Forms.RadioButton();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.Isbn = new System.Windows.Forms.Label();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbAgregarPrestamo = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbUsuario.SuspendLayout();
            this.gbAgregarPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(71, 19);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(58, 24);
            this.txtClave.TabIndex = 0;
            this.txtClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClave_KeyPress);
            this.txtClave.Validated += new System.EventHandler(this.txtClave_Validated);
            // 
            // txtNombrePresta
            // 
            this.txtNombrePresta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombrePresta.Location = new System.Drawing.Point(74, 72);
            this.txtNombrePresta.Multiline = true;
            this.txtNombrePresta.Name = "txtNombrePresta";
            this.txtNombrePresta.Size = new System.Drawing.Size(258, 33);
            this.txtNombrePresta.TabIndex = 1;
            this.txtNombrePresta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombrePresta_KeyPress);
            this.txtNombrePresta.Validated += new System.EventHandler(this.txtNombrePresta_Validated);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(24, 19);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(41, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "CLAVE";
            // 
            // lblNombreEd
            // 
            this.lblNombreEd.AutoSize = true;
            this.lblNombreEd.Location = new System.Drawing.Point(14, 75);
            this.lblNombreEd.Name = "lblNombreEd";
            this.lblNombreEd.Size = new System.Drawing.Size(54, 13);
            this.lblNombreEd.TabIndex = 3;
            this.lblNombreEd.Text = "NOMBRE";
            // 
            // rdEstudiante
            // 
            this.rdEstudiante.AutoSize = true;
            this.rdEstudiante.Checked = true;
            this.rdEstudiante.Location = new System.Drawing.Point(6, 19);
            this.rdEstudiante.Name = "rdEstudiante";
            this.rdEstudiante.Size = new System.Drawing.Size(94, 17);
            this.rdEstudiante.TabIndex = 4;
            this.rdEstudiante.TabStop = true;
            this.rdEstudiante.Text = "ESTUDIANTE";
            this.rdEstudiante.UseVisualStyleBackColor = true;
            // 
            // rdMaestro
            // 
            this.rdMaestro.AutoSize = true;
            this.rdMaestro.Location = new System.Drawing.Point(106, 19);
            this.rdMaestro.Name = "rdMaestro";
            this.rdMaestro.Size = new System.Drawing.Size(78, 17);
            this.rdMaestro.TabIndex = 5;
            this.rdMaestro.Text = "MAESTRO";
            this.rdMaestro.UseVisualStyleBackColor = true;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.rdEstudiante);
            this.gbUsuario.Controls.Add(this.rdMaestro);
            this.gbUsuario.Location = new System.Drawing.Point(27, 148);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(200, 84);
            this.gbUsuario.TabIndex = 6;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "TIPO USUARIO";
            // 
            // Isbn
            // 
            this.Isbn.AutoSize = true;
            this.Isbn.Location = new System.Drawing.Point(144, 27);
            this.Isbn.Name = "Isbn";
            this.Isbn.Size = new System.Drawing.Size(67, 13);
            this.Isbn.TabIndex = 7;
            this.Isbn.Text = "ISBN LIBRO";
            // 
            // cmbLibro
            // 
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(217, 22);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(121, 21);
            this.cmbLibro.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(29, 294);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultar.Image")));
            this.btnConsultar.Location = new System.Drawing.Point(187, 294);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(145, 55);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "CONSULTAR";
            this.btnConsultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(385, 294);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(131, 55);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // gbAgregarPrestamo
            // 
            this.gbAgregarPrestamo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbAgregarPrestamo.Controls.Add(this.txtTelefono);
            this.gbAgregarPrestamo.Controls.Add(this.lblTelefono);
            this.gbAgregarPrestamo.Controls.Add(this.txtClave);
            this.gbAgregarPrestamo.Controls.Add(this.txtNombrePresta);
            this.gbAgregarPrestamo.Controls.Add(this.lblClave);
            this.gbAgregarPrestamo.Controls.Add(this.lblNombreEd);
            this.gbAgregarPrestamo.Controls.Add(this.cmbLibro);
            this.gbAgregarPrestamo.Controls.Add(this.gbUsuario);
            this.gbAgregarPrestamo.Controls.Add(this.Isbn);
            this.gbAgregarPrestamo.Location = new System.Drawing.Point(12, 21);
            this.gbAgregarPrestamo.Name = "gbAgregarPrestamo";
            this.gbAgregarPrestamo.Size = new System.Drawing.Size(515, 263);
            this.gbAgregarPrestamo.TabIndex = 12;
            this.gbAgregarPrestamo.TabStop = false;
            this.gbAgregarPrestamo.Text = "PRESTAMO";
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Location = new System.Drawing.Point(84, 118);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(161, 20);
            this.txtTelefono.TabIndex = 10;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Validated += new System.EventHandler(this.txtTelefono_Validated);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(14, 121);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 13);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(555, 370);
            this.Controls.Add(this.gbAgregarPrestamo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmAgregarPrestamo";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.frmAgregarPrestamo_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbAgregarPrestamo.ResumeLayout(false);
            this.gbAgregarPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombrePresta;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombreEd;
        private System.Windows.Forms.RadioButton rdEstudiante;
        private System.Windows.Forms.RadioButton rdMaestro;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label Isbn;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox gbAgregarPrestamo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}