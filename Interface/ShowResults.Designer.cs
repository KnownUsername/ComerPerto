namespace Interface
{
    partial class ShowResults
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
            this.RestaurantsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // RestaurantsGrid
            // 
            this.RestaurantsGrid.AllowUserToOrderColumns = true;
            this.RestaurantsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.RestaurantsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RestaurantsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.RestaurantsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RestaurantsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RestaurantsGrid.Location = new System.Drawing.Point(0, 0);
            this.RestaurantsGrid.Name = "RestaurantsGrid";
            this.RestaurantsGrid.RowTemplate.Height = 24;
            this.RestaurantsGrid.Size = new System.Drawing.Size(800, 450);
            this.RestaurantsGrid.TabIndex = 0;
            this.RestaurantsGrid.VirtualMode = true;
            this.RestaurantsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RestaurantsGrid_CellContentClick);
            // 
            // ShowResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RestaurantsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ShowResults";
            this.Text = "Results of search";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RestaurantsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView RestaurantsGrid;
    }
}