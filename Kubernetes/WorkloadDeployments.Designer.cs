namespace Kubernetes
{
    partial class WorkloadDeployments
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboNamespace = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gridDeployments = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textReplicas = new System.Windows.Forms.TextBox();
            this.Replicas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboImage = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeployments)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboNamespace);
            this.panel3.Controls.Add(this.labelID);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 93);
            this.panel3.TabIndex = 85;
            // 
            // comboNamespace
            // 
            this.comboNamespace.BackColor = System.Drawing.Color.Azure;
            this.comboNamespace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNamespace.FormattingEnabled = true;
            this.comboNamespace.Location = new System.Drawing.Point(122, 26);
            this.comboNamespace.Name = "comboNamespace";
            this.comboNamespace.Size = new System.Drawing.Size(121, 21);
            this.comboNamespace.TabIndex = 53;
            this.comboNamespace.SelectedIndexChanged += new System.EventHandler(this.comboNamespace_SelectedIndexChanged);
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
            this.label12.Text = "Deployments";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridDeployments
            // 
            this.gridDeployments.BackgroundColor = System.Drawing.Color.Azure;
            this.gridDeployments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDeployments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeployments.Location = new System.Drawing.Point(16, 359);
            this.gridDeployments.Name = "gridDeployments";
            this.gridDeployments.Size = new System.Drawing.Size(613, 246);
            this.gridDeployments.TabIndex = 86;
            this.gridDeployments.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeployments_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboImage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textReplicas);
            this.panel1.Controls.Add(this.Replicas);
            this.panel1.Controls.Add(this.textLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.btnCriar);
            this.panel1.Controls.Add(this.textNome);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 120);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 115);
            this.panel1.TabIndex = 91;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(236, 85);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(122, 85);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(108, 23);
            this.btnApagar.TabIndex = 49;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(8, 85);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(108, 23);
            this.btnCriar.TabIndex = 46;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click_1);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(16, 39);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(108, 20);
            this.textNome.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Nome:";
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(147, 39);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(108, 20);
            this.textLabel.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Label:";
            // 
            // textReplicas
            // 
            this.textReplicas.Location = new System.Drawing.Point(403, 39);
            this.textReplicas.Name = "textReplicas";
            this.textReplicas.Size = new System.Drawing.Size(108, 20);
            this.textReplicas.TabIndex = 54;
            // 
            // Replicas
            // 
            this.Replicas.AutoSize = true;
            this.Replicas.Location = new System.Drawing.Point(435, 16);
            this.Replicas.Name = "Replicas";
            this.Replicas.Size = new System.Drawing.Size(51, 13);
            this.Replicas.TabIndex = 53;
            this.Replicas.Text = "Replicas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Nome:";
            // 
            // comboImage
            // 
            this.comboImage.BackColor = System.Drawing.Color.Azure;
            this.comboImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImage.FormattingEnabled = true;
            this.comboImage.Location = new System.Drawing.Point(269, 39);
            this.comboImage.Name = "comboImage";
            this.comboImage.Size = new System.Drawing.Size(121, 21);
            this.comboImage.TabIndex = 56;
            // 
            // WorkloadDeployments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(654, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridDeployments);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkloadDeployments";
            this.Text = "WorkloadDeployments";
            this.Load += new System.EventHandler(this.WorkloadDeployments_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeployments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboNamespace;
        private System.Windows.Forms.DataGridView gridDeployments;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textReplicas;
        private System.Windows.Forms.Label Replicas;
        private System.Windows.Forms.TextBox textLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label4;
    }
}