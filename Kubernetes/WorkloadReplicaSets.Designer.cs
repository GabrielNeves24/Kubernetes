namespace Kubernetes
{
    partial class WorkloadReplicaSets
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
            this.gridReplicasSets = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboNamespaceReplicasSet = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridReplicasSets)).BeginInit();
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
            this.label12.Size = new System.Drawing.Size(654, 27);
            this.label12.TabIndex = 90;
            this.label12.Text = "Replicas Sets";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridReplicasSets
            // 
            this.gridReplicasSets.BackgroundColor = System.Drawing.Color.Azure;
            this.gridReplicasSets.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReplicasSets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReplicasSets.Location = new System.Drawing.Point(12, 164);
            this.gridReplicasSets.Name = "gridReplicasSets";
            this.gridReplicasSets.Size = new System.Drawing.Size(630, 428);
            this.gridReplicasSets.TabIndex = 89;
            this.gridReplicasSets.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReplicasSets_CellClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboNamespaceReplicasSet);
            this.panel3.Controls.Add(this.labelID);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 72);
            this.panel3.TabIndex = 91;
            // 
            // comboNamespaceReplicasSet
            // 
            this.comboNamespaceReplicasSet.BackColor = System.Drawing.Color.Azure;
            this.comboNamespaceReplicasSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNamespaceReplicasSet.FormattingEnabled = true;
            this.comboNamespaceReplicasSet.Location = new System.Drawing.Point(122, 26);
            this.comboNamespaceReplicasSet.Name = "comboNamespaceReplicasSet";
            this.comboNamespaceReplicasSet.Size = new System.Drawing.Size(121, 21);
            this.comboNamespaceReplicasSet.TabIndex = 53;
            this.comboNamespaceReplicasSet.SelectedIndexChanged += new System.EventHandler(this.comboNamespaceReplicasSet_SelectedIndexChanged);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(14, 116);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(0, 12);
            this.labelID.TabIndex = 52;
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
            // WorkloadReplicaSets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(654, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridReplicasSets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkloadReplicaSets";
            this.Text = "WorkloadReplicaSets";
            this.Load += new System.EventHandler(this.WorkloadReplicaSets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReplicasSets)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridReplicasSets;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboNamespaceReplicasSet;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label13;
    }
}