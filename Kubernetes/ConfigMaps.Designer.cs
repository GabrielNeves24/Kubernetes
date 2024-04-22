namespace Kubernetes
{
    partial class ConfigMaps
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
            this.gridConfigMaps = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboNamespaceConfig = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridConfigMaps)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.label12.TabIndex = 89;
            this.label12.Text = "Config Maps";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridConfigMaps
            // 
            this.gridConfigMaps.BackgroundColor = System.Drawing.Color.Azure;
            this.gridConfigMaps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridConfigMaps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConfigMaps.Location = new System.Drawing.Point(13, 195);
            this.gridConfigMaps.Name = "gridConfigMaps";
            this.gridConfigMaps.Size = new System.Drawing.Size(613, 364);
            this.gridConfigMaps.TabIndex = 88;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboNamespaceConfig);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 90);
            this.panel3.TabIndex = 90;
            // 
            // comboNamespaceConfig
            // 
            this.comboNamespaceConfig.BackColor = System.Drawing.Color.Azure;
            this.comboNamespaceConfig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNamespaceConfig.FormattingEnabled = true;
            this.comboNamespaceConfig.Location = new System.Drawing.Point(122, 26);
            this.comboNamespaceConfig.Name = "comboNamespaceConfig";
            this.comboNamespaceConfig.Size = new System.Drawing.Size(121, 21);
            this.comboNamespaceConfig.TabIndex = 53;
            this.comboNamespaceConfig.SelectedIndexChanged += new System.EventHandler(this.comboNamespaceConfig_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "NameSpace:";
            // 
            // ConfigMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(638, 565);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridConfigMaps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigMaps";
            this.Text = "ConfigMaps";
            this.Load += new System.EventHandler(this.ConfigMaps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridConfigMaps)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridConfigMaps;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboNamespaceConfig;
        private System.Windows.Forms.Label label13;
    }
}