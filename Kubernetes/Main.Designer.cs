namespace Kubernetes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTopoLogin = new System.Windows.Forms.Panel();
            this.checkBoxHttps = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textIP = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sidemenuPanel = new System.Windows.Forms.Panel();
            this.panelConfigSubmenu = new System.Windows.Forms.Panel();
            this.btnSecrets = new System.Windows.Forms.Button();
            this.btnConfigMaps = new System.Windows.Forms.Button();
            this.btnConfigStore = new System.Windows.Forms.Button();
            this.panelServicesSubmenu = new System.Windows.Forms.Panel();
            this.btnAPIEndpoints = new System.Windows.Forms.Button();
            this.btnServices = new System.Windows.Forms.Button();
            this.btnServicesDiscovery = new System.Windows.Forms.Button();
            this.panelWorkloadSubmenu = new System.Windows.Forms.Panel();
            this.btnReplicasets = new System.Windows.Forms.Button();
            this.btnPods = new System.Windows.Forms.Button();
            this.btnDeployments = new System.Windows.Forms.Button();
            this.btnWorkload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelClusterSubmenu = new System.Windows.Forms.Panel();
            this.btnClusterRules = new System.Windows.Forms.Button();
            this.btnNodes = new System.Windows.Forms.Button();
            this.btnNamespaces = new System.Windows.Forms.Button();
            this.btnCluster = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.gridInfoMais = new System.Windows.Forms.DataGridView();
            this.infoLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.panelTopoLogin.SuspendLayout();
            this.sidemenuPanel.SuspendLayout();
            this.panelConfigSubmenu.SuspendLayout();
            this.panelServicesSubmenu.SuspendLayout();
            this.panelWorkloadSubmenu.SuspendLayout();
            this.panelClusterSubmenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfoMais)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopoLogin
            // 
            this.panelTopoLogin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelTopoLogin.Controls.Add(this.checkBoxHttps);
            this.panelTopoLogin.Controls.Add(this.button2);
            this.panelTopoLogin.Controls.Add(this.label2);
            this.panelTopoLogin.Controls.Add(this.textIP);
            this.panelTopoLogin.Controls.Add(this.button1);
            this.panelTopoLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopoLogin.Location = new System.Drawing.Point(0, 0);
            this.panelTopoLogin.Name = "panelTopoLogin";
            this.panelTopoLogin.Size = new System.Drawing.Size(894, 38);
            this.panelTopoLogin.TabIndex = 55;
            this.panelTopoLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopoLogin_MouseDown);
            this.panelTopoLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopoLogin_MouseMove);
            this.panelTopoLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopoLogin_MouseUp);
            // 
            // checkBoxHttps
            // 
            this.checkBoxHttps.AutoSize = true;
            this.checkBoxHttps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBoxHttps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHttps.Location = new System.Drawing.Point(270, 7);
            this.checkBoxHttps.Name = "checkBoxHttps";
            this.checkBoxHttps.Size = new System.Drawing.Size(82, 24);
            this.checkBoxHttps.TabIndex = 5;
            this.checkBoxHttps.Text = "Https?";
            this.checkBoxHttps.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(358, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 22);
            this.button2.TabIndex = 3;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP:PORTA";
            // 
            // textIP
            // 
            this.textIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIP.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textIP.Location = new System.Drawing.Point(75, 9);
            this.textIP.Multiline = true;
            this.textIP.Name = "textIP";
            this.textIP.Size = new System.Drawing.Size(189, 20);
            this.textIP.TabIndex = 1;
            this.textIP.Text = "192.168.xxx.xxx:xxxx";
            this.textIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textIP.TextChanged += new System.EventHandler(this.textIP_TextChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(857, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 38);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sidemenuPanel
            // 
            this.sidemenuPanel.AutoScroll = true;
            this.sidemenuPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.sidemenuPanel.Controls.Add(this.panelConfigSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnConfigStore);
            this.sidemenuPanel.Controls.Add(this.panelServicesSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnServicesDiscovery);
            this.sidemenuPanel.Controls.Add(this.panelWorkloadSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnWorkload);
            this.sidemenuPanel.Controls.Add(this.label1);
            this.sidemenuPanel.Controls.Add(this.panelClusterSubmenu);
            this.sidemenuPanel.Controls.Add(this.btnCluster);
            this.sidemenuPanel.Controls.Add(this.panelLogo);
            this.sidemenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidemenuPanel.Location = new System.Drawing.Point(0, 38);
            this.sidemenuPanel.Name = "sidemenuPanel";
            this.sidemenuPanel.Size = new System.Drawing.Size(240, 604);
            this.sidemenuPanel.TabIndex = 56;
            // 
            // panelConfigSubmenu
            // 
            this.panelConfigSubmenu.Controls.Add(this.btnSecrets);
            this.panelConfigSubmenu.Controls.Add(this.btnConfigMaps);
            this.panelConfigSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfigSubmenu.Location = new System.Drawing.Point(0, 546);
            this.panelConfigSubmenu.Name = "panelConfigSubmenu";
            this.panelConfigSubmenu.Size = new System.Drawing.Size(223, 123);
            this.panelConfigSubmenu.TabIndex = 50;
            // 
            // btnSecrets
            // 
            this.btnSecrets.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSecrets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSecrets.FlatAppearance.BorderSize = 0;
            this.btnSecrets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecrets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSecrets.ForeColor = System.Drawing.Color.Black;
            this.btnSecrets.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnSecrets.Location = new System.Drawing.Point(0, 35);
            this.btnSecrets.Name = "btnSecrets";
            this.btnSecrets.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSecrets.Size = new System.Drawing.Size(223, 35);
            this.btnSecrets.TabIndex = 1;
            this.btnSecrets.Text = "Secrets";
            this.btnSecrets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSecrets.UseVisualStyleBackColor = false;
            this.btnSecrets.Click += new System.EventHandler(this.btnSecrets_Click);
            // 
            // btnConfigMaps
            // 
            this.btnConfigMaps.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfigMaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigMaps.FlatAppearance.BorderSize = 0;
            this.btnConfigMaps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigMaps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnConfigMaps.ForeColor = System.Drawing.Color.Black;
            this.btnConfigMaps.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnConfigMaps.Location = new System.Drawing.Point(0, 0);
            this.btnConfigMaps.Name = "btnConfigMaps";
            this.btnConfigMaps.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConfigMaps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConfigMaps.Size = new System.Drawing.Size(223, 35);
            this.btnConfigMaps.TabIndex = 0;
            this.btnConfigMaps.Text = "Config Maps";
            this.btnConfigMaps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigMaps.UseVisualStyleBackColor = false;
            this.btnConfigMaps.Click += new System.EventHandler(this.btnConfigMaps_Click);
            // 
            // btnConfigStore
            // 
            this.btnConfigStore.AllowDrop = true;
            this.btnConfigStore.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigStore.FlatAppearance.BorderSize = 0;
            this.btnConfigStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnConfigStore.ForeColor = System.Drawing.Color.White;
            this.btnConfigStore.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnConfigStore.Location = new System.Drawing.Point(0, 501);
            this.btnConfigStore.Name = "btnConfigStore";
            this.btnConfigStore.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnConfigStore.Size = new System.Drawing.Size(223, 45);
            this.btnConfigStore.TabIndex = 49;
            this.btnConfigStore.TabStop = false;
            this.btnConfigStore.Text = "Config and Storage";
            this.btnConfigStore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfigStore.UseCompatibleTextRendering = true;
            this.btnConfigStore.UseVisualStyleBackColor = true;
            this.btnConfigStore.Click += new System.EventHandler(this.btnConfigStore_Click);
            // 
            // panelServicesSubmenu
            // 
            this.panelServicesSubmenu.Controls.Add(this.btnAPIEndpoints);
            this.panelServicesSubmenu.Controls.Add(this.btnServices);
            this.panelServicesSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelServicesSubmenu.Location = new System.Drawing.Point(0, 423);
            this.panelServicesSubmenu.Name = "panelServicesSubmenu";
            this.panelServicesSubmenu.Size = new System.Drawing.Size(223, 78);
            this.panelServicesSubmenu.TabIndex = 48;
            // 
            // btnAPIEndpoints
            // 
            this.btnAPIEndpoints.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAPIEndpoints.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAPIEndpoints.FlatAppearance.BorderSize = 0;
            this.btnAPIEndpoints.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAPIEndpoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAPIEndpoints.ForeColor = System.Drawing.Color.Black;
            this.btnAPIEndpoints.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnAPIEndpoints.Location = new System.Drawing.Point(0, 35);
            this.btnAPIEndpoints.Name = "btnAPIEndpoints";
            this.btnAPIEndpoints.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAPIEndpoints.Size = new System.Drawing.Size(223, 35);
            this.btnAPIEndpoints.TabIndex = 1;
            this.btnAPIEndpoints.Text = "API Endpoints";
            this.btnAPIEndpoints.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAPIEndpoints.UseVisualStyleBackColor = false;
            this.btnAPIEndpoints.Click += new System.EventHandler(this.btnAPIEndpoints_Click);
            // 
            // btnServices
            // 
            this.btnServices.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnServices.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServices.FlatAppearance.BorderSize = 0;
            this.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnServices.ForeColor = System.Drawing.Color.Black;
            this.btnServices.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnServices.Location = new System.Drawing.Point(0, 0);
            this.btnServices.Name = "btnServices";
            this.btnServices.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnServices.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnServices.Size = new System.Drawing.Size(223, 35);
            this.btnServices.TabIndex = 0;
            this.btnServices.Text = "Services";
            this.btnServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServices.UseVisualStyleBackColor = false;
            this.btnServices.Click += new System.EventHandler(this.btnServices_Click);
            // 
            // btnServicesDiscovery
            // 
            this.btnServicesDiscovery.AllowDrop = true;
            this.btnServicesDiscovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicesDiscovery.FlatAppearance.BorderSize = 0;
            this.btnServicesDiscovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicesDiscovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnServicesDiscovery.ForeColor = System.Drawing.Color.White;
            this.btnServicesDiscovery.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnServicesDiscovery.Location = new System.Drawing.Point(0, 378);
            this.btnServicesDiscovery.Name = "btnServicesDiscovery";
            this.btnServicesDiscovery.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnServicesDiscovery.Size = new System.Drawing.Size(223, 45);
            this.btnServicesDiscovery.TabIndex = 47;
            this.btnServicesDiscovery.TabStop = false;
            this.btnServicesDiscovery.Text = "Services and Discovery";
            this.btnServicesDiscovery.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicesDiscovery.UseCompatibleTextRendering = true;
            this.btnServicesDiscovery.UseVisualStyleBackColor = true;
            this.btnServicesDiscovery.Click += new System.EventHandler(this.btnServicesDiscovery_Click);
            // 
            // panelWorkloadSubmenu
            // 
            this.panelWorkloadSubmenu.Controls.Add(this.btnReplicasets);
            this.panelWorkloadSubmenu.Controls.Add(this.btnPods);
            this.panelWorkloadSubmenu.Controls.Add(this.btnDeployments);
            this.panelWorkloadSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelWorkloadSubmenu.Location = new System.Drawing.Point(0, 261);
            this.panelWorkloadSubmenu.Name = "panelWorkloadSubmenu";
            this.panelWorkloadSubmenu.Size = new System.Drawing.Size(223, 117);
            this.panelWorkloadSubmenu.TabIndex = 46;
            // 
            // btnReplicasets
            // 
            this.btnReplicasets.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnReplicasets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReplicasets.FlatAppearance.BorderSize = 0;
            this.btnReplicasets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplicasets.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnReplicasets.ForeColor = System.Drawing.Color.Black;
            this.btnReplicasets.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnReplicasets.Location = new System.Drawing.Point(0, 70);
            this.btnReplicasets.Name = "btnReplicasets";
            this.btnReplicasets.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnReplicasets.Size = new System.Drawing.Size(223, 35);
            this.btnReplicasets.TabIndex = 2;
            this.btnReplicasets.Text = "Replica Sets";
            this.btnReplicasets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReplicasets.UseVisualStyleBackColor = false;
            this.btnReplicasets.Click += new System.EventHandler(this.btnReplicasets_Click);
            // 
            // btnPods
            // 
            this.btnPods.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPods.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPods.FlatAppearance.BorderSize = 0;
            this.btnPods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPods.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPods.ForeColor = System.Drawing.Color.Black;
            this.btnPods.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnPods.Location = new System.Drawing.Point(0, 35);
            this.btnPods.Name = "btnPods";
            this.btnPods.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPods.Size = new System.Drawing.Size(223, 35);
            this.btnPods.TabIndex = 1;
            this.btnPods.Text = "Pods";
            this.btnPods.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPods.UseVisualStyleBackColor = false;
            this.btnPods.Click += new System.EventHandler(this.btnPods_Click);
            // 
            // btnDeployments
            // 
            this.btnDeployments.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeployments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeployments.FlatAppearance.BorderSize = 0;
            this.btnDeployments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeployments.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnDeployments.ForeColor = System.Drawing.Color.Black;
            this.btnDeployments.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnDeployments.Location = new System.Drawing.Point(0, 0);
            this.btnDeployments.Name = "btnDeployments";
            this.btnDeployments.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDeployments.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeployments.Size = new System.Drawing.Size(223, 35);
            this.btnDeployments.TabIndex = 0;
            this.btnDeployments.Text = "Deployments";
            this.btnDeployments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeployments.UseVisualStyleBackColor = false;
            this.btnDeployments.Click += new System.EventHandler(this.btnDeployments_Click);
            // 
            // btnWorkload
            // 
            this.btnWorkload.AllowDrop = true;
            this.btnWorkload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkload.FlatAppearance.BorderSize = 0;
            this.btnWorkload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnWorkload.ForeColor = System.Drawing.Color.White;
            this.btnWorkload.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnWorkload.Location = new System.Drawing.Point(0, 216);
            this.btnWorkload.Name = "btnWorkload";
            this.btnWorkload.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnWorkload.Size = new System.Drawing.Size(223, 45);
            this.btnWorkload.TabIndex = 45;
            this.btnWorkload.TabStop = false;
            this.btnWorkload.Text = "WorkLoad";
            this.btnWorkload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkload.UseCompatibleTextRendering = true;
            this.btnWorkload.UseVisualStyleBackColor = true;
            this.btnWorkload.Click += new System.EventHandler(this.btnWorkload_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.label1.Location = new System.Drawing.Point(0, 669);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 43);
            this.label1.TabIndex = 11;
            this.label1.Text = "LTI 2023\r\nAndré Jorge | Gabriel Neves";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelClusterSubmenu
            // 
            this.panelClusterSubmenu.Controls.Add(this.btnClusterRules);
            this.panelClusterSubmenu.Controls.Add(this.btnNodes);
            this.panelClusterSubmenu.Controls.Add(this.btnNamespaces);
            this.panelClusterSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelClusterSubmenu.Location = new System.Drawing.Point(0, 93);
            this.panelClusterSubmenu.Name = "panelClusterSubmenu";
            this.panelClusterSubmenu.Size = new System.Drawing.Size(223, 123);
            this.panelClusterSubmenu.TabIndex = 2;
            // 
            // btnClusterRules
            // 
            this.btnClusterRules.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClusterRules.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClusterRules.FlatAppearance.BorderSize = 0;
            this.btnClusterRules.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClusterRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnClusterRules.ForeColor = System.Drawing.Color.Black;
            this.btnClusterRules.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnClusterRules.Location = new System.Drawing.Point(0, 70);
            this.btnClusterRules.Name = "btnClusterRules";
            this.btnClusterRules.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnClusterRules.Size = new System.Drawing.Size(223, 35);
            this.btnClusterRules.TabIndex = 2;
            this.btnClusterRules.Text = "Roles";
            this.btnClusterRules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClusterRules.UseVisualStyleBackColor = false;
            this.btnClusterRules.Click += new System.EventHandler(this.btnClusterRules_Click);
            // 
            // btnNodes
            // 
            this.btnNodes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNodes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNodes.FlatAppearance.BorderSize = 0;
            this.btnNodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNodes.ForeColor = System.Drawing.Color.Black;
            this.btnNodes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnNodes.Location = new System.Drawing.Point(0, 35);
            this.btnNodes.Name = "btnNodes";
            this.btnNodes.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNodes.Size = new System.Drawing.Size(223, 35);
            this.btnNodes.TabIndex = 1;
            this.btnNodes.Text = "Nodes";
            this.btnNodes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNodes.UseVisualStyleBackColor = false;
            this.btnNodes.Click += new System.EventHandler(this.btnNodes_Click);
            // 
            // btnNamespaces
            // 
            this.btnNamespaces.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNamespaces.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNamespaces.FlatAppearance.BorderSize = 0;
            this.btnNamespaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNamespaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnNamespaces.ForeColor = System.Drawing.Color.Black;
            this.btnNamespaces.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnNamespaces.Location = new System.Drawing.Point(0, 0);
            this.btnNamespaces.Name = "btnNamespaces";
            this.btnNamespaces.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNamespaces.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnNamespaces.Size = new System.Drawing.Size(223, 35);
            this.btnNamespaces.TabIndex = 0;
            this.btnNamespaces.Text = "Namespaces";
            this.btnNamespaces.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNamespaces.UseVisualStyleBackColor = false;
            this.btnNamespaces.Click += new System.EventHandler(this.btnNamespaces_Click);
            // 
            // btnCluster
            // 
            this.btnCluster.AllowDrop = true;
            this.btnCluster.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCluster.FlatAppearance.BorderSize = 0;
            this.btnCluster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCluster.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnCluster.ForeColor = System.Drawing.Color.White;
            this.btnCluster.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnCluster.Location = new System.Drawing.Point(0, 48);
            this.btnCluster.Name = "btnCluster";
            this.btnCluster.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCluster.Size = new System.Drawing.Size(223, 45);
            this.btnCluster.TabIndex = 2;
            this.btnCluster.TabStop = false;
            this.btnCluster.Text = "Cluster";
            this.btnCluster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCluster.UseCompatibleTextRendering = true;
            this.btnCluster.UseVisualStyleBackColor = true;
            this.btnCluster.Click += new System.EventHandler(this.btnCluster_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(223, 48);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.gridInfoMais);
            this.panelMain.Controls.Add(this.infoLabel);
            this.panelMain.Controls.Add(this.dateLabel);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(240, 38);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(654, 604);
            this.panelMain.TabIndex = 57;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dashboard";
            // 
            // gridInfoMais
            // 
            this.gridInfoMais.BackgroundColor = System.Drawing.Color.Azure;
            this.gridInfoMais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridInfoMais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInfoMais.GridColor = System.Drawing.Color.Azure;
            this.gridInfoMais.Location = new System.Drawing.Point(30, 76);
            this.gridInfoMais.Name = "gridInfoMais";
            this.gridInfoMais.Size = new System.Drawing.Size(602, 185);
            this.gridInfoMais.TabIndex = 3;
            this.gridInfoMais.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInfoMais_CellContentClick);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(224, 35);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(0, 13);
            this.infoLabel.TabIndex = 1;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(40, 48);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(100, 13);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "                              .";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(894, 642);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.sidemenuPanel);
            this.Controls.Add(this.panelTopoLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopoLogin.ResumeLayout(false);
            this.panelTopoLogin.PerformLayout();
            this.sidemenuPanel.ResumeLayout(false);
            this.panelConfigSubmenu.ResumeLayout(false);
            this.panelServicesSubmenu.ResumeLayout(false);
            this.panelWorkloadSubmenu.ResumeLayout(false);
            this.panelClusterSubmenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfoMais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopoLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sidemenuPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelClusterSubmenu;
        private System.Windows.Forms.Button btnNodes;
        private System.Windows.Forms.Button btnNamespaces;
        private System.Windows.Forms.Button btnCluster;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textIP;
        private System.Windows.Forms.Button btnClusterRules;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelWorkloadSubmenu;
        private System.Windows.Forms.Button btnReplicasets;
        private System.Windows.Forms.Button btnPods;
        private System.Windows.Forms.Button btnDeployments;
        private System.Windows.Forms.Button btnWorkload;
        private System.Windows.Forms.Panel panelServicesSubmenu;
        private System.Windows.Forms.Button btnAPIEndpoints;
        private System.Windows.Forms.Button btnServices;
        private System.Windows.Forms.Button btnServicesDiscovery;
        private System.Windows.Forms.Panel panelConfigSubmenu;
        private System.Windows.Forms.Button btnSecrets;
        private System.Windows.Forms.Button btnConfigMaps;
        private System.Windows.Forms.Button btnConfigStore;
        private System.Windows.Forms.CheckBox checkBoxHttps;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.DataGridView gridInfoMais;
        private System.Windows.Forms.Label label3;
    }
}

