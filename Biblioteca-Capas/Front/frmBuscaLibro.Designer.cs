
namespace Biblioteca.Front
{
    partial class frmBuscaLibro
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
            this.dgvBLibro = new System.Windows.Forms.DataGridView();
            this.txtNomBuscarL = new System.Windows.Forms.TextBox();
            this.btnBuscarL = new System.Windows.Forms.Button();
            this.lblNomLibro = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBLibro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBLibro
            // 
            this.dgvBLibro.AllowUserToAddRows = false;
            this.dgvBLibro.AllowUserToDeleteRows = false;
            this.dgvBLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBLibro.Location = new System.Drawing.Point(-1, 103);
            this.dgvBLibro.Name = "dgvBLibro";
            this.dgvBLibro.ReadOnly = true;
            this.dgvBLibro.Size = new System.Drawing.Size(803, 251);
            this.dgvBLibro.TabIndex = 0;
            this.dgvBLibro.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBLibro_CellDoubleClick);
            // 
            // txtNomBuscarL
            // 
            this.txtNomBuscarL.Location = new System.Drawing.Point(12, 49);
            this.txtNomBuscarL.Name = "txtNomBuscarL";
            this.txtNomBuscarL.Size = new System.Drawing.Size(343, 20);
            this.txtNomBuscarL.TabIndex = 1;
            this.txtNomBuscarL.TextChanged += new System.EventHandler(this.txtNomBuscarL_TextChanged);
            // 
            // btnBuscarL
            // 
            this.btnBuscarL.Location = new System.Drawing.Point(375, 46);
            this.btnBuscarL.Name = "btnBuscarL";
            this.btnBuscarL.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarL.TabIndex = 2;
            this.btnBuscarL.Text = "BUSCAR";
            this.btnBuscarL.UseVisualStyleBackColor = true;
            this.btnBuscarL.Click += new System.EventHandler(this.btnBuscarL_Click);
            // 
            // lblNomLibro
            // 
            this.lblNomLibro.AutoSize = true;
            this.lblNomLibro.Location = new System.Drawing.Point(13, 30);
            this.lblNomLibro.Name = "lblNomLibro";
            this.lblNomLibro.Size = new System.Drawing.Size(180, 13);
            this.lblNomLibro.TabIndex = 3;
            this.lblNomLibro.Text = "INGRESA EL NOMBRE DEL LIBRO";
            // 
            // frmBuscaLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNomLibro);
            this.Controls.Add(this.btnBuscarL);
            this.Controls.Add(this.txtNomBuscarL);
            this.Controls.Add(this.dgvBLibro);
            this.Name = "frmBuscaLibro";
            this.Text = "frmBuscaLibro";
            this.Load += new System.EventHandler(this.frmBuscaLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBLibro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBLibro;
        private System.Windows.Forms.TextBox txtNomBuscarL;
        private System.Windows.Forms.Button btnBuscarL;
        private System.Windows.Forms.Label lblNomLibro;
    }
}