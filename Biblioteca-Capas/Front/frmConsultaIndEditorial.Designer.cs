
namespace Biblioteca.Front
{
    partial class frmConsultaIndEditorial
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
            this.cmbClaveEdi = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.gbEditorial = new System.Windows.Forms.GroupBox();
            this.gbEditorial.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbClaveEdi
            // 
            this.cmbClaveEdi.FormattingEnabled = true;
            this.cmbClaveEdi.Location = new System.Drawing.Point(12, 32);
            this.cmbClaveEdi.Name = "cmbClaveEdi";
            this.cmbClaveEdi.Size = new System.Drawing.Size(121, 21);
            this.cmbClaveEdi.TabIndex = 0;
            this.cmbClaveEdi.SelectedIndexChanged += new System.EventHandler(this.cmbClaveEdi_SelectedIndexChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(113, 29);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(275, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(113, 77);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(275, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Location = new System.Drawing.Point(146, 128);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(242, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(40, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(30, 84);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(64, 13);
            this.lblTelefono.TabIndex = 5;
            this.lblTelefono.Text = "TELEFONO";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(22, 131);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(112, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "CORREO/OPCIONAL";
            // 
            // gbEditorial
            // 
            this.gbEditorial.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbEditorial.Controls.Add(this.lblNombre);
            this.gbEditorial.Controls.Add(this.lblCorreo);
            this.gbEditorial.Controls.Add(this.txtNombre);
            this.gbEditorial.Controls.Add(this.lblTelefono);
            this.gbEditorial.Controls.Add(this.txtTelefono);
            this.gbEditorial.Controls.Add(this.txtCorreo);
            this.gbEditorial.Location = new System.Drawing.Point(12, 79);
            this.gbEditorial.Name = "gbEditorial";
            this.gbEditorial.Size = new System.Drawing.Size(459, 207);
            this.gbEditorial.TabIndex = 7;
            this.gbEditorial.TabStop = false;
            this.gbEditorial.Text = "DATOS";
            // 
            // frmConsultaIndEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 307);
            this.Controls.Add(this.gbEditorial);
            this.Controls.Add(this.cmbClaveEdi);
            this.Name = "frmConsultaIndEditorial";
            this.Text = "CONSULTA EDITORIAL";
            this.Load += new System.EventHandler(this.ConsultaIndEditorial_Load);
            this.gbEditorial.ResumeLayout(false);
            this.gbEditorial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClaveEdi;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.GroupBox gbEditorial;
    }
}