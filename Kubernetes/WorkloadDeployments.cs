using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes
{
    public partial class WorkloadDeployments : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public WorkloadDeployments()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void WorkloadDeployments_Load(object sender, EventArgs e)
        {
            try
            {
                string[] image = { "nginx", "ubuntu" , "busybox" , "fedora" , "debian" , "alpine" ,
                                   "postgres" , "redis" , "python" , "mysql" , "openjdk" , "mongo" ,
                                   " php" , "centos" , "perl" , "pypy" };
                foreach (string img in image)
                {
                    comboImage.Items.Add(img);
                }
                comboImage.SelectedIndex = 0;
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces");
                response.EnsureSuccessStatusCode();
                gridDeployments.Rows.Clear();
                gridDeployments.Columns.Add("nome", "Nome");
                gridDeployments.Columns.Add("namespace", "Namespace");
                gridDeployments.Columns.Add("creationTimestamp", "DataCriacao");
                gridDeployments.Columns.Add("k8s-app", "k8s-app");
                gridDeployments.Columns.Add("replicas", "replicas");
                gridDeployments.Columns.Add("labelsApp", "LabelsApp");
                gridDeployments.Columns.Add("specImagem", "specImagem");
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            comboNamespace.Items.Add(item["metadata"]["name"].ToString());
                        }
                    }
                }
                comboNamespace.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private async void comboNamespace_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridDeployments.Rows.Clear();
            
            try
            {
                string namespace1 = comboNamespace.SelectedItem.ToString();
                HttpResponseMessage response = await client.GetAsync($"{apiURL}s/apps/v1/namespaces/{namespace1}/deployments");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        
                        foreach (JObject item in jp.Values())
                        {
                            string nome = item["metadata"]["name"]?.ToString();
                            string namespace2 = item["metadata"]["namespace"]?.ToString();
                            string creationTimestamp = item["metadata"]["creationTimestamp"]?.ToString();
                            string k8sApp = item["metadata"]["labels"]["k8s-app"]?.ToString();
                            string replicas = item["spec"]["replicas"]?.ToString();
                            string labelsApp = item["spec"]["selector"]["matchLabels"]["k8s-app"]?.ToString();
                            string specImagem = "";
                            JArray containers = (JArray)item["spec"]["template"]["spec"]["containers"];
                            foreach (JObject container in containers)
                            {
                                specImagem += container["image"].ToString() + ",";
                            }
                            gridDeployments.Rows.Add(nome, namespace2, creationTimestamp, k8sApp, replicas, labelsApp, specImagem);
                            gridDeployments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os deployments: {ex.Message}");
            }

        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "")
            {
                MessageBox.Show("Selecione um deployment para eleminar");
                return;
            }
            try
            {
                string deploymentName = textNome.Text;
                string namespace1 = comboNamespace.SelectedItem.ToString();
                string url = $"{apiURL}s/apps/v1/namespaces/{namespace1}/deployments/{deploymentName}";
                HttpResponseMessage response = await client.DeleteAsync(url);
                response.EnsureSuccessStatusCode();

                MessageBox.Show("Deployment excluído com sucesso.");
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: Não foi possível excluir o deployment ({ex.Message})");
            }
        }

        private void gridDeployments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridDeployments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < gridDeployments.Rows.Count)
            {
                string nome = "";
                if (gridDeployments.Rows[rowIndex].Cells["nome"].Value != null)
                    nome = gridDeployments.Rows[rowIndex].Cells["nome"].Value.ToString();
                else
                    nome = "";
                textNome.Text = nome;
            }
            
        }
        private async void reload()
        {
            textLabel.Text = string.Empty;
            textNome.Text = string.Empty;
            gridDeployments.Rows.Clear();
            try
            {
                string namespace1 = comboNamespace.SelectedItem.ToString();
                HttpResponseMessage response = await client.GetAsync($"{apiURL}s/apps/v1/namespaces/{namespace1}/deployments");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {

                        foreach (JObject item in jp.Values())
                        {
                            string nome = item["metadata"]["name"]?.ToString();
                            string namespace2 = item["metadata"]["namespace"]?.ToString();
                            string creationTimestamp = item["metadata"]["creationTimestamp"]?.ToString();
                            string k8sApp = item["metadata"]["labels"]["k8s-app"]?.ToString();
                            string replicas = item["spec"]["replicas"]?.ToString();
                            string labelsApp = item["spec"]["selector"]["matchLabels"]["k8s-app"]?.ToString();
                            string specImagem = "";
                            JArray containers = (JArray)item["spec"]["template"]["spec"]["containers"];
                            foreach (JObject container in containers)
                            {
                                specImagem += container["image"].ToString() + ",";
                            }
                            gridDeployments.Rows.Add(nome, namespace2, creationTimestamp, k8sApp, replicas, labelsApp, specImagem);
                            gridDeployments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os deployments: {ex.Message}");
            }
        }

        private async void btnCriar_Click_1(object sender, EventArgs e)
        {
            if (textLabel.Text == "" || textNome.Text == "" || textReplicas.Text == "" || comboImage.SelectedIndex < 0)
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            try
            {
                string jsonString = string.Format(@"
            {{
                ""apiVersion"": ""apps/v1"",
                ""kind"": ""Deployment"",
                ""metadata"": {{
                    ""name"": ""{0}"",
                    ""namespace"": ""{1}"",
                    ""labels"": {{
                        ""app"": ""{2}""
                    }}
                }},
                ""spec"": {{
                    ""replicas"": {7},
                    ""selector"": {{
                        ""matchLabels"": {{
                            ""app"": ""{3}""
                        }}
                    }},
                    ""template"": {{
                        ""metadata"": {{
                            ""labels"": {{
                                ""app"": ""{4}""
                            }}
                        }},
                        ""spec"": {{
                            ""containers"": [
                                {{
                                    ""name"": ""{5}"",
                                    ""image"": ""{6}"",
                                    ""ports"": [
                                        {{
                                            ""containerPort"": 80
                                        }}
                                    ],
                                    ""resources"": {{
                                        ""limits"": {{
                                            ""cpu"": ""250m"",
                                            ""memory"": ""256Mi""
                                        }}
                                    }}
                                }}
                            ]
                        }}
                    }}
                }}
            }}",
            textNome.Text,
            comboNamespace.SelectedItem.ToString(),
            textLabel.Text,
            textNome.Text,
            textNome.Text,
            textNome.Text,
            comboImage.SelectedItem.ToString(),
            textReplicas.Text);
                var content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");
                string namespace1 = comboNamespace.SelectedItem.ToString();
                HttpResponseMessage response = await client.PostAsync($"{apiURL}s/apps/v1/namespaces/{namespace1}/deployments", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Deployment Criado com Sucesso");
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: Não foi criar o deployment ({ex.Message})");
            }
        }
    }
}
