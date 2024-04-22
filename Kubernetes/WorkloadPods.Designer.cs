namespace Kubernetes
{
    partial class WorkloadPods
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboImage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textContainerName = new System.Windows.Forms.TextBox();
            this.Container = new System.Windows.Forms.Label();
            this.btnLimparPods = new System.Windows.Forms.Button();
            this.btnApagarPods = new System.Windows.Forms.Button();
            this.btnCriarPods = new System.Windows.Forms.Button();
            this.textPods = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboNamespacePods = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gridPods = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPods)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textPorta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboImage);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textContainerName);
            this.panel1.Controls.Add(this.Container);
            this.panel1.Controls.Add(this.btnLimparPods);
            this.panel1.Controls.Add(this.btnApagarPods);
            this.panel1.Controls.Add(this.btnCriarPods);
            this.panel1.Controls.Add(this.textPods);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 115);
            this.panel1.TabIndex = 90;
            // 
            // textPorta
            // 
            this.textPorta.Location = new System.Drawing.Point(393, 38);
            this.textPorta.Name = "textPorta";
            this.textPorta.Size = new System.Drawing.Size(108, 20);
            this.textPorta.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "Porta:";
            // 
            // comboImage
            // 
            this.comboImage.BackColor = System.Drawing.Color.Azure;
            this.comboImage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboImage.FormattingEnabled = true;
            this.comboImage.Location = new System.Drawing.Point(145, 38);
            this.comboImage.Name = "comboImage";
            this.comboImage.Size = new System.Drawing.Size(121, 21);
            this.comboImage.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Imagem:";
            // 
            // textContainerName
            // 
            this.textContainerName.Location = new System.Drawing.Point(279, 38);
            this.textContainerName.Name = "textContainerName";
            this.textContainerName.Size = new System.Drawing.Size(108, 20);
            this.textContainerName.TabIndex = 58;
            // 
            // Container
            // 
            this.Container.AutoSize = true;
            this.Container.Location = new System.Drawing.Point(311, 15);
            this.Container.Name = "Container";
            this.Container.Size = new System.Drawing.Size(55, 13);
            this.Container.TabIndex = 57;
            this.Container.Text = "Container:";
            // 
            // btnLimparPods
            // 
            this.btnLimparPods.Location = new System.Drawing.Point(236, 85);
            this.btnLimparPods.Name = "btnLimparPods";
            this.btnLimparPods.Size = new System.Drawing.Size(108, 23);
            this.btnLimparPods.TabIndex = 50;
            this.btnLimparPods.Text = "Limpar";
            this.btnLimparPods.UseVisualStyleBackColor = true;
            this.btnLimparPods.Click += new System.EventHandler(this.btnLimparPods_Click);
            // 
            // btnApagarPods
            // 
            this.btnApagarPods.Location = new System.Drawing.Point(122, 85);
            this.btnApagarPods.Name = "btnApagarPods";
            this.btnApagarPods.Size = new System.Drawing.Size(108, 23);
            this.btnApagarPods.TabIndex = 49;
            this.btnApagarPods.Text = "Apagar";
            this.btnApagarPods.UseVisualStyleBackColor = true;
            this.btnApagarPods.Click += new System.EventHandler(this.btnApagarPods_Click);
            // 
            // btnCriarPods
            // 
            this.btnCriarPods.Location = new System.Drawing.Point(8, 85);
            this.btnCriarPods.Name = "btnCriarPods";
            this.btnCriarPods.Size = new System.Drawing.Size(108, 23);
            this.btnCriarPods.TabIndex = 46;
            this.btnCriarPods.Text = "Criar";
            this.btnCriarPods.UseVisualStyleBackColor = true;
            this.btnCriarPods.Click += new System.EventHandler(this.btnCriarPods_Click);
            // 
            // textPods
            // 
            this.textPods.Location = new System.Drawing.Point(16, 39);
            this.textPods.Name = "textPods";
            this.textPods.Size = new System.Drawing.Size(108, 20);
            this.textPods.TabIndex = 43;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.comboNamespacePods);
            this.panel3.Controls.Add(this.labelID);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 72);
            this.panel3.TabIndex = 89;
            // 
            // comboNamespacePods
            // 
            this.comboNamespacePods.BackColor = System.Drawing.Color.Azure;
            this.comboNamespacePods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNamespacePods.FormattingEnabled = true;
            this.comboNamespacePods.Location = new System.Drawing.Point(122, 26);
            this.comboNamespacePods.Name = "comboNamespacePods";
            this.comboNamespacePods.Size = new System.Drawing.Size(121, 21);
            this.comboNamespacePods.TabIndex = 53;
            this.comboNamespacePods.SelectedIndexChanged += new System.EventHandler(this.comboNamespacePods_SelectedIndexChanged);
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
            this.label12.TabIndex = 88;
            this.label12.Text = "Pods";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridPods
            // 
            this.gridPods.BackgroundColor = System.Drawing.Color.Azure;
            this.gridPods.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPods.Location = new System.Drawing.Point(16, 232);
            this.gridPods.Name = "gridPods";
            this.gridPods.Size = new System.Drawing.Size(613, 369);
            this.gridPods.TabIndex = 87;
            this.gridPods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPods_CellClick);
            this.gridPods.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPods_CellContentClick);
            // 
            // WorkloadPods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(654, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridPods);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkloadPods";
            this.Text = "WorkloadPods";
            this.Load += new System.EventHandler(this.WorkloadPods_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimparPods;
        private System.Windows.Forms.Button btnApagarPods;
        private System.Windows.Forms.Button btnCriarPods;
        private System.Windows.Forms.TextBox textPods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboNamespacePods;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridPods;
        private System.Windows.Forms.ComboBox comboImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textContainerName;
        private System.Windows.Forms.Label Container;
        private System.Windows.Forms.TextBox textPorta;
        private System.Windows.Forms.Label label1;
    }
}