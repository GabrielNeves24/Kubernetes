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
    public partial class WorkloadPods : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public WorkloadPods()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void WorkloadPods_Load(object sender, EventArgs e)
        {
            string[] images = { "nginx4", "mysql", "redis", "mongo", "postgres" };
            comboImage.Items.AddRange(images);
            comboImage.SelectedIndex = 0;
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);

                gridPods.Rows.Clear();
                gridPods.Columns.Add("nome", "Nome");
                gridPods.Columns.Add("image", "Image");
                gridPods.Columns.Add("creationTimestamp", "DataCriacao");
                gridPods.Columns.Add("hostIP", "hostIP");
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            comboNamespacePods.Items.Add(item["metadata"]["name"].ToString());
                        }
                    }
                }
                comboNamespacePods.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private void gridPods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private async void comboNamespacePods_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                gridPods.Rows.Clear();
                string namespace1 = comboNamespacePods.SelectedItem.ToString();
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces/{namespace1}/pods");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            JArray containerStatuses = (JArray)item["status"]["containerStatuses"];
                            string images = "";

                            if (containerStatuses != null && containerStatuses.Count > 0)
                            {
                                foreach (JObject containerStatus in containerStatuses)
                                {
                                    string image = containerStatus["image"].ToString();
                                    images += image + "; ";
                                }
                            }

                            gridPods.Rows.Add(
                                item["metadata"]["name"].ToString(),
                                images.TrimEnd(' ', ';'),
                                item["metadata"]["creationTimestamp"].ToString(),
                                item["status"]["hostIP"].ToString()
                            );
                        }
                    }
                }
                gridPods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os pods: {ex.Message}");
            }
        }

        private async void btnCriarPods_Click(object sender, EventArgs e)
        {
            if (textPods.Text == "" || textContainerName.Text == "" || textPorta.Text == "" || comboImage.SelectedIndex<0 )
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            try
            {
                string jsonString = string.Format(@"
                {{
                    ""apiVersion"": ""v1"",
                    ""kind"": ""Pod"",
                    ""metadata"": {{
                        ""name"": ""{0}"",
                        ""namespace"": ""{1}"",
                        ""labels"": {{
                            ""name"": ""nginx4""
                        }}
                    }},
                    ""spec"": {{
                        ""containers"": [
                            {{
                                ""name"": ""{2}"",
                                ""image"": ""{3}"",
                                ""ports"": [ {{
                                    ""containerPort"": {4}
                                }} ],
                                ""resources"": {{
                                    ""limits"": {{
                                        ""cpu"": ""500m"",
                                        ""memory"": ""256Mi""
                                    }}
                                }}
                            }}
                        ]
                    }}
                }}",
                textPods.Text,
                comboNamespacePods.SelectedItem.ToString(),
                textContainerName.Text,
                comboImage.SelectedItem.ToString(),
                textPorta.Text);

                var content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");
                string namespace1 = comboNamespacePods.SelectedItem.ToString();
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/v1/namespaces/{namespace1}/pods",content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show("Pod Criado com Sucesso");
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os pods: {ex.Message}");
            }
        }
        private async void reload()
        {
            textPods.Text = "";
            try
            {
                gridPods.Rows.Clear();
                string namespace1 = comboNamespacePods.SelectedItem.ToString();
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces/{namespace1}/pods ");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            gridPods.Rows.Add(item["metadata"]["name"].ToString(),
                                item["metadata"]["namespace"].ToString(),
                                item["metadata"]["creationTimestamp"].ToString(),
                                item["status"]["hostIP"].ToString());
                        }
                    }
                }
                gridPods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os pods: {ex.Message}");
            }
        }

        private async void btnApagarPods_Click(object sender, EventArgs e)
        {
            if (textPods.Text == "")
            {
                MessageBox.Show("Selecione um Pods para eliminar");
                return;
            }
            try { 
                string namespaceName = comboNamespacePods.SelectedItem.ToString();
                string podName = textPods.Text;
                HttpResponseMessage response = await client.DeleteAsync($"{apiURL}/v1/namespaces/{namespaceName}/pods/{podName}");
                response.EnsureSuccessStatusCode();
                MessageBox.Show("Pod elimidado com sucesso!");
                reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel eliminar o Pod: {ex.Message}");
            }
        }

        private void gridPods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textPods.Text = "";
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < gridPods.Rows.Count)
            {
                string nome = "";
                if (gridPods.Rows[rowIndex].Cells["nome"].Value != null)
                    nome = gridPods.Rows[rowIndex].Cells["nome"].Value.ToString();
                else
                    nome = "";
                textPods.Text = nome;
            }
        }

        private void btnLimparPods_Click(object sender, EventArgs e)
        {
            textPods.Text = "";
            textPorta.Text = "";
            textContainerName.Text = "";

        }
    }
}
