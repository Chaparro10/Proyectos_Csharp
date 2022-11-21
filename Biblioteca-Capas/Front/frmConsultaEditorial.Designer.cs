
namespace Biblioteca.Front
{
    partial class frmConsultaEditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEditorial));
            this.dgvConsultaEdi = new System.Windows.Forms.DataGridView();
            this.btnGeneraPdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEdi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsultaEdi
            // 
            this.dgvConsultaEdi.AllowUserToAddRows = false;
            this.dgvConsultaEdi.AllowUserToDeleteRows = false;
            this.dgvConsultaEdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultaEdi.Location = new System.Drawing.Point(0, 0);
            this.dgvConsultaEdi.Name = "dgvConsultaEdi";
            this.dgvConsultaEdi.ReadOnly = true;
            this.dgvConsultaEdi.Size = new System.Drawing.Size(693, 351);
            this.dgvConsultaEdi.TabIndex = 0;
            // 
            // btnGeneraPdf
            // 
            this.btnGeneraPdf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeneraPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneraPdf.Image")));
            this.btnGeneraPdf.Location = new System.Drawing.Point(714, 12);
            this.btnGeneraPdf.Name = "btnGeneraPdf";
            this.btnGeneraPdf.Size = new System.Drawing.Size(40, 43);
            this.btnGeneraPdf.TabIndex = 3;
            this.btnGeneraPdf.UseVisualStyleBackColor = false;
            this.btnGeneraPdf.Click += new System.EventHandler(this.btnGeneraPdf_Click);
            // 
            // frmConsultaEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 351);
            this.Controls.Add(this.btnGeneraPdf);
            this.Controls.Add(this.dgvConsultaEdi);
            this.Name = "frmConsultaEditorial";
            this.Text = "frmConsultaEditorial";
            this.Load += new System.EventHandler(this.frmConsultaEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultaEdi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsultaEdi;
        private System.Windows.Forms.Button btnGeneraPdf;
    }
}