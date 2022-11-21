namespace Biblioteca.Front
{
    partial class frmConsultaLibro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaLibro));
            this.dgvConsultaLibro = new System.Windows.Forms.DataGridView();
            this.btnGeneraPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaLibro
            // 
            this.dgvConsultaLibro.AllowUserToAddRows = false;
            this.dgvConsultaLibro.AllowUserToDeleteRows = false;
            this.dgvConsultaLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaLibro.Location = new System.Drawing.Point(0, 1);
            this.dgvConsultaLibro.Name = "dgvConsultaLibro";
            this.dgvConsultaLibro.ReadOnly = true;
            this.dgvConsultaLibro.Size = new System.Drawing.Size(970, 351);
            this.dgvConsultaLibro.TabIndex = 0;
            // 
            // btnGeneraPdf
            // 
            this.btnGeneraPdf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeneraPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneraPdf.Image")));
            this.btnGeneraPdf.Location = new System.Drawing.Point(976, 1);
            this.btnGeneraPdf.Name = "btnGeneraPdf";
            this.btnGeneraPdf.Size = new System.Drawing.Size(52, 55);
            this.btnGeneraPdf.TabIndex = 2;
            this.btnGeneraPdf.UseVisualStyleBackColor = false;
            this.btnGeneraPdf.Click += new System.EventHandler(this.btnGeneraPdf_Click);
            // 
            // frmConsultaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 353);
            this.Controls.Add(this.btnGeneraPdf);
            this.Controls.Add(this.dgvConsultaLibro);
            this.Name = "frmConsultaLibro";
            this.Text = "CONSULTA LIBROS";
            this.Load += new System.EventHandler(this.frmConsultaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaLibro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaLibro;
        private System.Windows.Forms.Button btnGeneraPdf;
    }
}