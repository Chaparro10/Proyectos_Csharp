
namespace Biblioteca.Front
{
    partial class frmConsultaIndividualPrestamo
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
            this.cmbClavePresta = new System.Windows.Forms.ComboBox();
            this.dgvIndPrestamos = new System.Windows.Forms.DataGridView();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClavePresta
            // 
            this.cmbClavePresta.FormattingEnabled = true;
            this.cmbClavePresta.Location = new System.Drawing.Point(13, 22);
            this.cmbClavePresta.Name = "cmbClavePresta";
            this.cmbClavePresta.Size = new System.Drawing.Size(121, 21);
            this.cmbClavePresta.TabIndex = 0;
            this.cmbClavePresta.SelectedIndexChanged += new System.EventHandler(this.cmbClavePresta_SelectedIndexChanged);
            // 
            // dgvIndPrestamos
            // 
            this.dgvIndPrestamos.AllowUserToAddRows = false;
            this.dgvIndPrestamos.AllowUserToDeleteRows = false;
            this.dgvIndPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.NombreUsuario,
            this.Telefono,
            this.TipoUsuario});
            this.dgvIndPrestamos.Location = new System.Drawing.Point(13, 58);
            this.dgvIndPrestamos.Name = "dgvIndPrestamos";
            this.dgvIndPrestamos.ReadOnly = true;
            this.dgvIndPrestamos.Size = new System.Drawing.Size(553, 197);
            this.dgvIndPrestamos.TabIndex = 1;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.HeaderText = "USUARIO";
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.ReadOnly = true;
            this.NombreUsuario.Width = 200;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "TELEFONO";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.HeaderText = "TIPO USUARIO";
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.ReadOnly = true;
            // 
            // frmConsultaIndividualPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 283);
            this.Controls.Add(this.dgvIndPrestamos);
            this.Controls.Add(this.cmbClavePresta);
            this.Name = "frmConsultaIndividualPrestamo";
            this.Text = "CONSULTA PRESTAMOS";
            this.Load += new System.EventHandler(this.frmConsultaIndividualPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbClavePresta;
        private System.Windows.Forms.DataGridView dgvIndPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoUsuario;
    }
}