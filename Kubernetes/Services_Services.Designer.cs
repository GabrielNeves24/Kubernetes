namespace Kubernetes
{
    partial class Services_Services
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
            this.comboNamespaceServices = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gridServices = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboTPCUDP = new System.Windows.Forms.ComboBox();
            this.comboNome = new System.Windows.Forms.ComboBox();
            this.textPortaDestino = new System.Windows.Forms.TextBox();
            this.Replicas = new System.Windows.Forms.Label();
            this.textPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnCriar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboNamespaceServices);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(654, 90);
            this.panel3.TabIndex = 89;
            // 
            // comboNamespaceServices
            // 
            this.comboNamespaceServices.BackColor = System.Drawing.Color.Azure;
            this.comboNamespaceServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNamespaceServices.FormattingEnabled = true;
            this.comboNamespaceServices.Location = new System.Drawing.Point(122, 26);
            this.comboNamespaceServices.Name = "comboNamespaceServices";
            this.comboNamespaceServices.Size = new System.Drawing.Size(121, 21);
            this.comboNamespaceServices.TabIndex = 53;
            this.comboNamespaceServices.SelectedIndexChanged += new System.EventHandler(this.comboNamespaceServices_SelectedIndexChanged);
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
            this.label12.Text = "Services";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.UseCompatibleTextRendering = true;
            // 
            // gridServices
            // 
            this.gridServices.BackgroundColor = System.Drawing.Color.Azure;
            this.gridServices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridServices.Location = new System.Drawing.Point(12, 321);
            this.gridServices.Name = "gridServices";
            this.gridServices.Size = new System.Drawing.Size(630, 260);
            this.gridServices.TabIndex = 90;
            this.gridServices.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServices_CellClick);
            this.gridServices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridServices_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboTPCUDP);
            this.panel1.Controls.Add(this.comboNome);
            this.panel1.Controls.Add(this.textPortaDestino);
            this.panel1.Controls.Add(this.Replicas);
            this.panel1.Controls.Add(this.textPorta);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnApagar);
            this.panel1.Controls.Add(this.btnCriar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 115);
            this.panel1.TabIndex = 92;
            // 
            // comboTPCUDP
            // 
            this.comboTPCUDP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTPCUDP.FormattingEnabled = true;
            this.comboTPCUDP.Items.AddRange(new object[] {
            "TCP",
            "UDP\t"});
            this.comboTPCUDP.Location = new System.Drawing.Point(402, 39);
            this.comboTPCUDP.Name = "comboTPCUDP";
            this.comboTPCUDP.Size = new System.Drawing.Size(121, 21);
            this.comboTPCUDP.TabIndex = 56;
            // 
            // comboNome
            // 
            this.comboNome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNome.FormattingEnabled = true;
            this.comboNome.Location = new System.Drawing.Point(8, 38);
            this.comboNome.Name = "comboNome";
            this.comboNome.Size = new System.Drawing.Size(121, 21);
            this.comboNome.TabIndex = 55;
            // 
            // textPortaDestino
            // 
            this.textPortaDestino.Location = new System.Drawing.Point(277, 39);
            this.textPortaDestino.Name = "textPortaDestino";
            this.textPortaDestino.Size = new System.Drawing.Size(108, 20);
            this.textPortaDestino.TabIndex = 54;
            // 
            // Replicas
            // 
            this.Replicas.AutoSize = true;
            this.Replicas.Location = new System.Drawing.Point(294, 16);
            this.Replicas.Name = "Replicas";
            this.Replicas.Size = new System.Drawing.Size(74, 13);
            this.Replicas.TabIndex = 53;
            this.Replicas.Text = "Porta Destino:";
            // 
            // textPorta
            // 
            this.textPorta.Location = new System.Drawing.Point(147, 39);
            this.textPorta.Name = "textPorta";
            this.textPorta.Size = new System.Drawing.Size(108, 20);
            this.textPorta.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Porta:";
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
            // btnCriar
            // 
            this.btnCriar.Location = new System.Drawing.Point(8, 85);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.Size = new System.Drawing.Size(108, 23);
            this.btnCriar.TabIndex = 46;
            this.btnCriar.Text = "Criar";
            this.btnCriar.UseVisualStyleBackColor = true;
            this.btnCriar.Click += new System.EventHandler(this.btnCriar_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "TCP/UDP";
            // 
            // Services_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(654, 604);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gridServices);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Services_Services";
            this.Text = "Services_Services";
            this.Load += new System.EventHandler(this.Services_Services_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServices)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox comboNamespaceServices;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView gridServices;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textPortaDestino;
        private System.Windows.Forms.Label Replicas;
        private System.Windows.Forms.TextBox textPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnCriar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboTPCUDP;
        private System.Windows.Forms.ComboBox comboNome;
        private System.Windows.Forms.Label label2;
    }
}