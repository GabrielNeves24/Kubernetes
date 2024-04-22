namespace Kubernetes
{
    partial class ClusterRules
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
            this.label12 = new System.Windows.Forms.Label();
            this.gridRegras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegras)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(638, 27);
            this.label12.TabIndex = 87;
            this.label12.Text = "Roles";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridRegras
            // 
            this.gridRegras.BackgroundColor = System.Drawing.Color.Azure;
            this.gridRegras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridRegras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegras.Location = new System.Drawing.Point(13, 46);
            this.gridRegras.Name = "gridRegras";
            this.gridRegras.Size = new System.Drawing.Size(613, 507);
            this.gridRegras.TabIndex = 86;
            this.gridRegras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRegras_CellContentClick);
            // 
            // ClusterRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(638, 565);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridRegras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClusterRules";
            this.Text = "ClusterRules";
            this.Load += new System.EventHandler(this.ClusterRules_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridRegras;
    }
}