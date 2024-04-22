namespace Kubernetes
{
    partial class ClusterNamespacesForm
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
            this.textLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCriarEditar = new System.Windows.Forms.Button();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gridNamespaces = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNamespaces)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textLabel);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.labelID);
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Controls.Add(this.btnApagar);
            this.panel3.Controls.Add(this.btnCriarEditar);
            this.panel3.Controls.Add(this.textNome);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 140);
            this.panel3.TabIndex = 82;
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(144, 39);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(108, 20);
            this.textLabel.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Label:";
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
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(236, 85);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(108, 23);
            this.btnLimpar.TabIndex = 50;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
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
            // btnCriarEditar
            // 
            this.btnCriarEditar.Location = new System.Drawing.Point(8, 85);
            this.btnCriarEditar.Name = "btnCriarEditar";
            this.btnCriarEditar.Size = new System.Drawing.Size(108, 23);
            this.btnCriarEditar.TabIndex = 46;
            this.btnCriarEditar.Text = "Criar";
            this.btnCriarEditar.UseVisualStyleBackColor = true;
            this.btnCriarEditar.Click += new System.EventHandler(this.btnCriarEditar_Click);
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(16, 39);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(108, 20);
            this.textNome.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(48, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "Nome:";
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
            this.label12.TabIndex = 81;
            this.label12.Text = "NameSpaces";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridNamespaces
            // 
            this.gridNamespaces.BackgroundColor = System.Drawing.Color.Azure;
            this.gridNamespaces.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNamespaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNamespaces.Location = new System.Drawing.Point(16, 200);
            this.gridNamespaces.Name = "gridNamespaces";
            this.gridNamespaces.Size = new System.Drawing.Size(613, 391);
            this.gridNamespaces.TabIndex = 80;
            this.gridNamespaces.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridNamespaces_CellClick);
            // 
            // ClusterNamespacesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(654, 604);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.gridNamespaces);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClusterNamespacesForm";
            this.Text = "ClusterNamespaces";
            this.Load += new System.EventHandler(this.ClusterNamespacesForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNamespaces)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCriarEditar;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridNamespaces;
        private System.Windows.Forms.TextBox textLabel;
        private System.Windows.Forms.Label label1;
    }
}