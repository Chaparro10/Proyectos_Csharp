
namespace Biblioteca.Front
{
    partial class frmConsultarPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarPrestamos));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgvTodosPresta = new System.Windows.Forms.DataGridView();
            this.btnGeneraPdf = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPresta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTodosPresta
            // 
            this.dgvTodosPresta.AllowUserToAddRows = false;
            this.dgvTodosPresta.AllowUserToDeleteRows = false;
            this.dgvTodosPresta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodosPresta.Location = new System.Drawing.Point(0, 0);
            this.dgvTodosPresta.Name = "dgvTodosPresta";
            this.dgvTodosPresta.ReadOnly = true;
            this.dgvTodosPresta.Size = new System.Drawing.Size(681, 379);
            this.dgvTodosPresta.TabIndex = 0;
            // 
            // btnGeneraPdf
            // 
            this.btnGeneraPdf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGeneraPdf.Image = ((System.Drawing.Image)(resources.GetObject("btnGeneraPdf.Image")));
            this.btnGeneraPdf.Location = new System.Drawing.Point(696, 12);
            this.btnGeneraPdf.Name = "btnGeneraPdf";
            this.btnGeneraPdf.Size = new System.Drawing.Size(40, 43);
            this.btnGeneraPdf.TabIndex = 4;
            this.btnGeneraPdf.UseVisualStyleBackColor = false;
            this.btnGeneraPdf.Click += new System.EventHandler(this.btnGeneraPdf_Click);
            // 
            // grafico
            // 
            chartArea2.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.grafico.Legends.Add(legend2);
            this.grafico.Location = new System.Drawing.Point(751, 12);
            this.grafico.Name = "grafico";
            this.grafico.Size = new System.Drawing.Size(232, 201);
            this.grafico.TabIndex = 5;
            this.grafico.Text = "grafico";
            // 
            // frmConsultarPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 379);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.btnGeneraPdf);
            this.Controls.Add(this.dgvTodosPresta);
            this.Name = "frmConsultarPrestamos";
            this.Text = "frmConsultarPrestamos";
            this.Load += new System.EventHandler(this.frmConsultarPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodosPresta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodosPresta;
        private System.Windows.Forms.Button btnGeneraPdf;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
    }
}