using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Reflection.Emit;

namespace Kubernetes
{
    public partial class Services_Services : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public Services_Services()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void Services_Services_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            comboNamespaceServices.Items.Add(item["metadata"]["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private async void comboNamespaceServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNamespaceServices.SelectedItem.ToString() == "")
                return;
            comboNome.Items.Clear();
            string namespace1 = comboNamespaceServices.SelectedItem.ToString();
            HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces/{namespace1}/services");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseBody);
            JArray items = (JArray)json["items"];
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("ClusterIP");
            dt.Columns.Add("Ports");
            foreach (JObject item in items)
            {
                string name = (string)item["metadata"]["name"];
                string type = (string)item["spec"]["type"];
                string clusterIP = (string)item["spec"]["clusterIP"];
                string ports = "";
                JArray portArray = (JArray)item["spec"]["ports"];
                foreach (JObject portObj in portArray)
                {
                    string portName = (string)portObj["name"];
                    int portNumber = (int)portObj["port"];
                    string protocol = (string)portObj["protocol"];
                    string targetPort = (string)portObj["targetPort"];
                    string nodePort = (string)portObj["nodePort"];
                    ports += $"{portName}: {portNumber}/{protocol}:{nodePort}, ";
                }
                if (!string.IsNullOrEmpty(ports))
                {
                    ports = ports.Substring(0, ports.Length - 2);
                }
                dt.Rows.Add(name, type, clusterIP, ports);
            }

            try
            {
                HttpResponseMessage response3 = await client.GetAsync($"{apiURL}s/apps/v1/namespaces/{namespace1}/deployments");
                response.EnsureSuccessStatusCode();
                string responseBody3 = await response3.Content.ReadAsStringAsync();
                JObject namespaces3 = JObject.Parse(responseBody3);
                foreach (JProperty jp in namespaces3.Properties())
                {
                    if (jp.Name == "items")
                    {

                        foreach (JObject item in jp.Values())
                        {
                            string nome = item["metadata"]["name"]?.ToString();
                            comboNome.Items.Add(nome);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os deployments: {ex.Message}");
            }
            gridServices.DataSource = dt;
            gridServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async void reload()
        {
            comboNome.SelectedItem = null;
            textPorta.Text = "";
            textPortaDestino.Text = "";
            if (comboNamespaceServices.SelectedItem.ToString() == "")
                return;
            string namespace1 = comboNamespaceServices.SelectedItem.ToString();
            HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces/{namespace1}/services");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseBody);
            JArray items = (JArray)json["items"];
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Type");
            dt.Columns.Add("ClusterIP");
            dt.Columns.Add("Ports");

            foreach (JObject item in items)
            {
                string name = (string)item["metadata"]["name"];
                string type = (string)item["spec"]["type"];
                string clusterIP = (string)item["spec"]["clusterIP"];
                string ports = "";
                JArray portArray = (JArray)item["spec"]["ports"];
                foreach (JObject portObj in portArray)
                {
                    string portName = (string)portObj["name"];
                    int portNumber = (int)portObj["port"];
                    string protocol = (string)portObj["protocol"];
                    string targetPort = (string)portObj["targetPort"];
                    string nodePort = (string)portObj["nodePort"];
                    ports += $"{portName}: {portNumber}/{protocol}:{nodePort}, ";
                }
                if (!string.IsNullOrEmpty(ports))
                {
                    ports = ports.Substring(0, ports.Length - 2);
                }
                dt.Rows.Add(name, type, clusterIP, ports);
            }
            gridServices.DataSource = dt;
            gridServices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private async void btnCriar_Click(object sender, EventArgs e)
        {
            if (textPorta.Text == "" || textPortaDestino.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            if (comboNome.SelectedIndex<0 || comboTPCUDP.SelectedIndex<0)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            string namespaceName = comboNamespaceServices.SelectedItem.ToString();
            string serviceName = comboNome.SelectedItem.ToString();
            int servicePort = int.Parse(textPorta.Text);
            string targetPort = textPortaDestino.Text;
            string jsonPayload = string.Format(@"{{
                ""apiVersion"": ""v1"",
                ""kind"": ""Service"",
                ""metadata"": {{
                    ""name"": ""{0}"",
                    ""namespace"": ""{1}""
                }},
                ""spec"": {{
                    ""type"": ""NodePort"", 
                    ""ports"": [
                        {{
                            ""name"": ""{2}"",
                            ""port"": {3},
                            ""targetPort"": {4}
                        }}
                    ],
                    ""selector"": {{
                        ""app"": ""{0}""
                    }}
                }}
            }}", serviceName, namespaceName, serviceName, servicePort, targetPort);
            var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync($"{apiURL}/v1/namespaces/{namespaceName}/services", content);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Service created successfully!");
                reload();
            }
            else
            {
                MessageBox.Show($"Failed to create service: {response.ReasonPhrase}");
            }
        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            if (comboNome.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            string namespaceName = comboNamespaceServices.SelectedItem.ToString();
            string serviceName = comboNome.SelectedItem.ToString();
            HttpResponseMessage response = await client.DeleteAsync($"{apiURL}/v1/namespaces/{namespaceName}/services/{serviceName}");
            response.EnsureSuccessStatusCode();

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Service deleted successfully!");
                reload();
            }
            else
            {
                MessageBox.Show($"Failed to deleted service: {response.ReasonPhrase}");
            }
        }

        private void gridServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridServices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            comboNome.SelectedItem = null;
            textPorta.Text = "";
            textPortaDestino.Text = "";
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < gridServices.Rows.Count)
            {
                string nomeServico = "";
                if (gridServices.Rows[rowIndex].Cells["name"].Value != null)
                    nomeServico = gridServices.Rows[rowIndex].Cells["name"].Value.ToString();
                else
                    nomeServico = "";
                comboNome.SelectedItem = nomeServico;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            comboNome.SelectedItem = null;
            textPorta.Text = string.Empty;
            textPortaDestino.Text = string.Empty;
        }
    }
}
