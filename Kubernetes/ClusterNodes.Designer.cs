namespace Kubernetes
{
    partial class ClusterNodes
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
            this.gridNodes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridNodes)).BeginInit();
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
            this.label12.Size = new System.Drawing.Size(654, 27);
            this.label12.TabIndex = 84;
            this.label12.Text = "Nodes";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridNodes
            // 
            this.gridNodes.BackgroundColor = System.Drawing.Color.Azure;
            this.gridNodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNodes.Location = new System.Drawing.Point(16, 30);
            this.gridNodes.Name = "gridNodes";
            this.gridNodes.Size = new System.Drawing.Size(626, 568);
            this.gridNodes.TabIndex = 83;
            this.gridNodes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNodes_CellContentClick);
            // 
            // ClusterNodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(654, 604);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridNodes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClusterNodes";
            this.Text = "ClusterNodes";
            this.Load += new System.EventHandler(this.ClusterNodes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNodes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridNodes;
    }
}