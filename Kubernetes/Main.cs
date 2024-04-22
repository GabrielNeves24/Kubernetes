using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows.Forms;


namespace Kubernetes
{
    public partial class Form1 : Form
    {
        int mov;
        int movX;
        int movY;
        private readonly HttpClient client;
        private string apiURL = Globals.apiURLUsar;
        public static class Globals
        {
            public static string apiURLUsar { get; set; }
        }
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private void customizeDesign()
        {
            panelClusterSubmenu.Visible = false;
            panelWorkloadSubmenu.Visible = false;
            panelServicesSubmenu.Visible = false;
            panelConfigSubmenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelClusterSubmenu.Visible == true)
                panelClusterSubmenu.Visible = false;
            if (panelWorkloadSubmenu.Visible == true)
                panelWorkloadSubmenu.Visible = false;
            if (panelServicesSubmenu.Visible == true)
                panelServicesSubmenu.Visible = false;
            if (panelConfigSubmenu.Visible == true)
                panelConfigSubmenu.Visible = false;
        }
        private void showSubMenu(System.Windows.Forms.Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = dir + @"\IpLogin.txt";

            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Globals.apiURLUsar = fileContent;
                string extractedContent = string.Empty;
                if (fileContent.StartsWith("Https://"))
                {
                    checkBoxHttps.Checked = true;
                    extractedContent = fileContent.Substring(8);
                }
                else if (fileContent.StartsWith("Http://"))
                {
                    checkBoxHttps.Checked = false;
                    extractedContent = fileContent.Substring(7);
                }
                if (extractedContent.EndsWith("/api\r\n"))
                {
                    extractedContent = extractedContent.Substring(0, extractedContent.Length - 6);
                }
                if (extractedContent.EndsWith("/api"))
                {
                    extractedContent = extractedContent.Substring(0, extractedContent.Length - 4);
                }

                textIP.Text = extractedContent;
                this.Refresh();
            }
            else
            {
                textIP.Text = "192.168.xxx.xxx:xxxx";
            }

            try
            {
                HttpResponseMessage response = await client.GetAsync($"{Globals.apiURLUsar}/v1/nodes");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                    dynamic nodes = data.items;
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.Add("Node Name");
                    dt.Columns.Add("Status");
                    dt.Columns.Add("Pods Count");
                    dt.Columns.Add("IPV4 Address");
                    dt.Columns.Add("Kubelet Version");
                    dt.Columns.Add("Operating System");
                    dt.Columns.Add("Architecture");
                    dt.Columns.Add("Kernel Version");
                    dt.Columns.Add("OS Image");
                    dt.Columns.Add("Container Runtime Version");
                    dt.Columns.Add("CPU Usage (millicores)");
                    dt.Columns.Add("Memory Usage (bytes)");
                    dt.Columns.Add("IP");
                    foreach (var node in nodes)
                    {
                        string nodeName = node.metadata.name ?? "0";
                        string status = node.status.conditions[0].type ?? "0";
                        string statusrunnig = node.status.conditions[4].type ?? "0";
                        string statusrunnig2 = node.status.conditions[4].status ?? "0";
                        if (statusrunnig == "Ready" && statusrunnig2 == "True" )
                            status = "Running";
                        else
                            status = "Not Running";
                        string podsCount = node.status.capacity.pods ?? "0";
                        string ipv4address = node.status.addresses[0].address ?? "0";
                        string kubeletVersion = node.status.nodeInfo.kubeletVersion ?? "0";
                        string operatingSystem = node.status.nodeInfo.operatingSystem ?? "0";
                        string architecture = node.status.nodeInfo.architecture ?? "0";
                        string kernelVersion = node.status.nodeInfo.kernelVersion ?? "0";
                        string osImage = node.status.nodeInfo.osImage ?? "0";
                        string containerRuntimeVersion = node.status.nodeInfo.containerRuntimeVersion ?? "0";
                        string cpuUsage = node.status.capacity.cpu ?? "0"; 
                        string memoryUsage = node.status.capacity.memory ?? "0";
                        string ip = node.status.addresses[0].address ?? "0";

                        dt.Rows.Add(nodeName, status, podsCount, ipv4address, kubeletVersion, operatingSystem, architecture, kernelVersion, osImage, containerRuntimeVersion, cpuUsage, memoryUsage, ip);
                    }
                    gridInfoMais.DataSource = dt;
                    gridInfoMais.BorderStyle = BorderStyle.None;
                    gridInfoMais.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    gridInfoMais.GridColor = Color.LightGray;
                    dateLabel.Text = "Date: " + DateTime.Now.ToString("yyyy-MM-dd");
                    gridInfoMais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    MessageBox.Show("Erro a obter dados da Kubernet, verificar IP/Porta!!: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Configure o IP e Porta no Topo do software");
            }
        }

        private void panelTopoLogin_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panelTopoLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelTopoLogin_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void btnNamespaces_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ClusterNamespacesForm clusterNamespacesForm = new ClusterNamespacesForm();
            clusterNamespacesForm.TopLevel = false;
            panelMain.Controls.Add(clusterNamespacesForm);
            clusterNamespacesForm.Show();
        }

        private void btnCluster_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClusterSubmenu);
        }

        private void btnNodes_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ClusterNodes clusterNodes = new ClusterNodes();
            clusterNodes.TopLevel = false;
            panelMain.Controls.Add(clusterNodes);
            clusterNodes.Show();
        }

        private void btnClusterRules_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ClusterRules clusterRules = new ClusterRules();
            clusterRules.TopLevel = false;
            panelMain.Controls.Add(clusterRules);
            clusterRules.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWorkload_Click(object sender, EventArgs e)
        {
            showSubMenu(panelWorkloadSubmenu);
        }

        private void btnDeployments_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            WorkloadDeployments workloadDeployments = new WorkloadDeployments();
            workloadDeployments.TopLevel = false;
            panelMain.Controls.Add(workloadDeployments);
            workloadDeployments.Show();
        }

        private void btnPods_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            WorkloadPods workloadPods = new WorkloadPods();
            workloadPods.TopLevel = false;
            panelMain.Controls.Add(workloadPods);
            workloadPods.Show();
        }

        private void btnReplicasets_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            WorkloadReplicaSets workloadReplicaSets = new WorkloadReplicaSets();
            workloadReplicaSets.TopLevel = false;
            panelMain.Controls.Add(workloadReplicaSets);
            workloadReplicaSets.Show();
        }

        private void btnServicesDiscovery_Click(object sender, EventArgs e)
        {
            showSubMenu(panelServicesSubmenu);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            Services_Services a = new Services_Services();
            a.TopLevel = false;
            panelMain.Controls.Add(a);
            a.Show();
        }

        private async void panelMain_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnAPIEndpoints_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ServicesAPIEndpoints a = new ServicesAPIEndpoints();
            a.TopLevel = false;
            panelMain.Controls.Add(a);
            a.Show();
        }

        private void btnConfigStore_Click(object sender, EventArgs e)
        {
            showSubMenu(panelConfigSubmenu);
        }

        private void btnConfigMaps_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ConfigMaps a = new ConfigMaps();
            a.TopLevel = false;
            panelMain.Controls.Add(a);
            a.Show();
        }

        private void btnSecrets_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            ConfigsSecrets a = new ConfigsSecrets();
            a.TopLevel = false;
            panelMain.Controls.Add(a);
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textIP == null)
            {
                MessageBox.Show("Introduza todos os dados");
                return;
            }
            string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string filePath = dir + @"\IpLogin.txt";
            string a;
            if (checkBoxHttps.Checked)
                 a = "Https";
            else
                 a = "Http";

            if (File.Exists(filePath))
            {
                MessageBox.Show("A substituir o ficheiro existente");
                File.WriteAllText(filePath, $"{a}://{textIP.Text}/api");
                MessageBox.Show("Substituído e guardado com sucesso");
                string fileContent = File.ReadAllText(filePath);
                Globals.apiURLUsar = fileContent;
            }
            else
            {
                MessageBox.Show("A criar novo ficheiro");
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.Write($"{a}://{textIP.Text}/api");
                    MessageBox.Show("Criado e guardado com sucesso");
                    
                }
                string fileContent = File.ReadAllText(filePath);
                Globals.apiURLUsar = fileContent;
                reload();
            }
        }

        private async void reload()
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{Globals.apiURLUsar}/v1/nodes");
                if (response.IsSuccessStatusCode)
                {
                    string responseBody = await response.Content.ReadAsStringAsync();
                    dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
                    dynamic nodes = data.items;
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.Add("Node Name");
                    dt.Columns.Add("Status");
                    dt.Columns.Add("Pods Count");
                    dt.Columns.Add("IPV4 Address");
                    dt.Columns.Add("Kubelet Version");
                    dt.Columns.Add("Operating System");
                    dt.Columns.Add("Architecture");
                    dt.Columns.Add("Kernel Version");
                    dt.Columns.Add("OS Image");
                    dt.Columns.Add("Container Runtime Version");
                    dt.Columns.Add("CPU Usage (millicores)");
                    dt.Columns.Add("Memory Usage (bytes)");
                    dt.Columns.Add("IP");
                    foreach (var node in nodes)
                    {
                        string nodeName = node.metadata.name ?? "0";
                        string status = node.status.conditions[0].type ?? "0";
                        string statusrunnig = node.status.conditions[4].type ?? "0";
                        string statusrunnig2 = node.status.conditions[4].status ?? "0";
                        if (statusrunnig == "Ready" && statusrunnig2 == "True")
                            status = "Running";
                        else
                            status = "Not Running";
                        string podsCount = node.status.capacity.pods ?? "0";
                        string ipv4address = node.status.addresses[0].address ?? "0";
                        string kubeletVersion = node.status.nodeInfo.kubeletVersion ?? "0";
                        string operatingSystem = node.status.nodeInfo.operatingSystem ?? "0";
                        string architecture = node.status.nodeInfo.architecture ?? "0";
                        string kernelVersion = node.status.nodeInfo.kernelVersion ?? "0";
                        string osImage = node.status.nodeInfo.osImage ?? "0";
                        string containerRuntimeVersion = node.status.nodeInfo.containerRuntimeVersion ?? "0";
                        string cpuUsage = node.status.capacity.cpu ?? "0";
                        string memoryUsage = node.status.capacity.memory ?? "0";
                        string ip = node.status.addresses[0].address ?? "0";

                        dt.Rows.Add(nodeName, status, podsCount, ipv4address, kubeletVersion, operatingSystem, architecture, kernelVersion, osImage, containerRuntimeVersion, cpuUsage, memoryUsage, ip);
                    }
                    gridInfoMais.DataSource = dt;
                    gridInfoMais.BorderStyle = BorderStyle.None;
                    gridInfoMais.CellBorderStyle = DataGridViewCellBorderStyle.None;
                    gridInfoMais.GridColor = Color.LightGray;
                    dateLabel.Text = "Date: " + DateTime.Now.ToString("yyyy-MM-dd");
                    gridInfoMais.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {
                    MessageBox.Show("Erro a obter dados da Kubernet, verificar IP/Porta!!: " + response.StatusCode);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro a obter dados da Kubernet, verificar IP/Porta!!: " + ex.Message);
            }
        }

        private void textIP_TextChanged(object sender, EventArgs e)
        {
        }
        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridInfoMais_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
