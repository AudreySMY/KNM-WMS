namespace GuiSAP.MenusUC
{
    partial class UC_ResultMean
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Dv_mean = new System.Windows.Forms.DataGridView();
            this.ClMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLUPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Dv_mean)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dv_mean
            // 
            this.Dv_mean.AllowUserToAddRows = false;
            this.Dv_mean.AllowUserToDeleteRows = false;
            this.Dv_mean.AllowUserToOrderColumns = true;
            this.Dv_mean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dv_mean.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClMaterial,
            this.CLGrid,
            this.CLUPC});
            this.Dv_mean.Location = new System.Drawing.Point(16, 0);
            this.Dv_mean.Name = "Dv_mean";
            this.Dv_mean.ReadOnly = true;
            this.Dv_mean.Size = new System.Drawing.Size(754, 668);
            this.Dv_mean.TabIndex = 21;
            this.Dv_mean.Visible = false;
            this.Dv_mean.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dv_mean_CellContentClick);
            // 
            // ClMaterial
            // 
            this.ClMaterial.HeaderText = "Material";
            this.ClMaterial.Name = "ClMaterial";
            this.ClMaterial.ReadOnly = true;
            // 
            // CLGrid
            // 
            this.CLGrid.HeaderText = "Grid";
            this.CLGrid.Name = "CLGrid";
            this.CLGrid.ReadOnly = true;
            // 
            // CLUPC
            // 
            this.CLUPC.HeaderText = "UPC/EAN";
            this.CLUPC.Name = "CLUPC";
            this.CLUPC.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Dv_mean);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 684);
            this.panel1.TabIndex = 23;
            // 
            // UC_ResultMean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_ResultMean";
            this.Size = new System.Drawing.Size(784, 712);
            this.Load += new System.EventHandler(this.UC_ResultMean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dv_mean)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Dv_mean;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLUPC;
        private System.Windows.Forms.Panel panel1;
    }
}
