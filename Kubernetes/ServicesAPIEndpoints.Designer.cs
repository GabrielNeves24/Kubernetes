namespace Kubernetes
{
    partial class ServicesAPIEndpoints
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
            this.gridApi2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridApi2)).BeginInit();
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
            this.label12.TabIndex = 86;
            this.label12.Text = "Api Endepoints";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridApi2
            // 
            this.gridApi2.BackgroundColor = System.Drawing.Color.Azure;
            this.gridApi2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridApi2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridApi2.Location = new System.Drawing.Point(16, 46);
            this.gridApi2.Name = "gridApi2";
            this.gridApi2.Size = new System.Drawing.Size(610, 507);
            this.gridApi2.TabIndex = 91;
            this.gridApi2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridApi2_CellContentClick);
            // 
            // ServicesAPIEndpoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(638, 565);
            this.Controls.Add(this.gridApi2);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServicesAPIEndpoints";
            this.Text = "ServicesAPIEndpoints";
            this.Load += new System.EventHandler(this.ServicesAPIEndpoints_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridApi2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridApi2;
    }
}