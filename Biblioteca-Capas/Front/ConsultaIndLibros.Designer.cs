namespace Biblioteca.Front
{
    partial class frmConsultaIndLibros
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
            this.cmbISBN = new System.Windows.Forms.ComboBox();
            this.dgvIndividualLibro = new System.Windows.Forms.DataGridView();
            this.NombreLibro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consulta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbISBN
            // 
            this.cmbISBN.FormattingEnabled = true;
            this.cmbISBN.Location = new System.Drawing.Point(12, 25);
            this.cmbISBN.Name = "cmbISBN";
            this.cmbISBN.Size = new System.Drawing.Size(94, 21);
            this.cmbISBN.TabIndex = 0;
            this.cmbISBN.SelectedIndexChanged += new System.EventHandler(this.cmbISBN_SelectedIndexChanged);
            // 
            // dgvIndividualLibro
            // 
            this.dgvIndividualLibro.AllowUserToAddRows = false;
            this.dgvIndividualLibro.AllowUserToDeleteRows = false;
            this.dgvIndividualLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIndividualLibro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreLibro,
            this.Autor,
            this.Existencia,
            this.Editorial,
            this.Consulta});
            this.dgvIndividualLibro.Location = new System.Drawing.Point(3, 61);
            this.dgvIndividualLibro.Name = "dgvIndividualLibro";
            this.dgvIndividualLibro.ReadOnly = true;
            this.dgvIndividualLibro.Size = new System.Drawing.Size(645, 150);
            this.dgvIndividualLibro.TabIndex = 1;
            this.dgvIndividualLibro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIndividualLibro_CellContentClick);
            // 
            // NombreLibro
            // 
            this.NombreLibro.HeaderText = "NOMBRE LIBRO";
            this.NombreLibro.Name = "NombreLibro";
            this.NombreLibro.ReadOnly = true;
            this.NombreLibro.Width = 200;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "AUTOR";
            this.Autor.Name = "Autor";
            this.Autor.ReadOnly = true;
            // 
            // Existencia
            // 
            this.Existencia.HeaderText = "EXISTENCIA";
            this.Existencia.Name = "Existencia";
            this.Existencia.ReadOnly = true;
            // 
            // Editorial
            // 
            this.Editorial.HeaderText = "EDITORIAL";
            this.Editorial.Name = "Editorial";
            this.Editorial.ReadOnly = true;
            // 
            // Consulta
            // 
            this.Consulta.HeaderText = "CONSULTA";
            this.Consulta.Name = "Consulta";
            this.Consulta.ReadOnly = true;
            // 
            // frmConsultaIndLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 339);
            this.Controls.Add(this.dgvIndividualLibro);
            this.Controls.Add(this.cmbISBN);
            this.Name = "frmConsultaIndLibros";
            this.Text = "CONSULTA LIBRO";
            this.Load += new System.EventHandler(this.ConsultaIndLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIndividualLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbISBN;
        private System.Windows.Forms.DataGridView dgvIndividualLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLibro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Existencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consulta;
    }
}