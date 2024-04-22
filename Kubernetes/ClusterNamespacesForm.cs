using Newtonsoft.Json;
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
using System.Security.Claims;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static Kubernetes.WorkloadReplicaSets;
using static System.Net.Mime.MediaTypeNames;


namespace Kubernetes
{
    public partial class ClusterNamespacesForm : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;

        public ClusterNamespacesForm()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void ClusterNamespacesForm_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                gridNamespaces.Columns.Add("nome", "Nome");
                gridNamespaces.Columns.Add("uid", "Uid");
                gridNamespaces.Columns.Add("status", "Status");
                gridNamespaces.Columns.Add("date", "Data");
                gridNamespaces.Columns.Add("manager", "Manager");
                gridNamespaces.Columns.Add("label", "Label");
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            string name = item["metadata"]["name"].ToString();
                            string uid = item["metadata"]["uid"].ToString();
                            string status = item["status"]["phase"].ToString();
                            string label = item["metadata"]["labels"]["kubernetes.io/metadata.name"].ToString();
                            DateTime date = (DateTime)item["metadata"]["creationTimestamp"];
                            string manager = item["metadata"]["managedFields"][0]["manager"].ToString();
                            gridNamespaces.Rows.Add(name, uid, status, date, manager, label);
                        }
                    }
                }
                gridNamespaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private async void btnCriarEditar_Click(object sender, EventArgs e)
        {
            if (textLabel.Text == "" || textNome.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            try
            {
                string test = string.Format("{{\"name\": \"{0}\",\"label\": \"{1}\"}}",
                        textNome.Text,textLabel.Text);

                string jsonString = string.Format(@"{{""apiVersion"": ""v1"",
                                      ""kind"": ""Namespace"",
                                      ""metadata"": {{
                                          ""name"": ""{0}"",
                                          ""labels"": {{
                                              ""name"": ""{1}""
                                          }}
                                      }}
                                    }}", textNome.Text, textLabel.Text);
                var content = new StringContent(jsonString, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync($"{apiURL}/v1/namespaces", content);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Namespace {textNome.Text} criada com sucesso!");
                reloadValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private void gridNamespaces_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < gridNamespaces.Rows.Count)
            {
                string nome = "";
                if (gridNamespaces.Rows[rowIndex].Cells["nome"].Value != null)
                    nome = gridNamespaces.Rows[rowIndex].Cells["nome"].Value.ToString();
                else
                    nome = "";
                string label = "";
                if (gridNamespaces.Rows[rowIndex].Cells["label"].Value != null)
                    label = gridNamespaces.Rows[rowIndex].Cells["label"].Value.ToString();
                else
                    label = "";
                textLabel.Text = label;
                textNome.Text = nome;
            }
        }

        private async void btnApagar_Click(object sender, EventArgs e)
        {
            if (textLabel.Text == "" || textNome.Text == "")
            {
                MessageBox.Show("Selecione um Namespace da grelha apresentada");
                return;
            }
            try
            {
                string deleteNamespace = String.Format("{0}/v1/namespaces/{1}",apiURL,textNome.Text);
                HttpResponseMessage response = await client.DeleteAsync(deleteNamespace);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                Thread.Sleep(3000);//3segundos
                MessageBox.Show($"Namespace {textNome.Text} eliminado com sucesso!");
                reloadValues();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textNome.Text = "";
            textLabel.Text = "";
        }

        private async void reloadValues()
        {
            textNome.Text = "";
            textLabel.Text = "";
            gridNamespaces.Rows.Clear();
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
                            string name = item["metadata"]["name"].ToString();
                            string uid = item["metadata"]["uid"].ToString();
                            string status = item["status"]["phase"].ToString();
                            string label = item["metadata"]["labels"]["kubernetes.io/metadata.name"].ToString();
                            DateTime date = (DateTime)item["metadata"]["creationTimestamp"];
                            string manager = item["metadata"]["managedFields"][0]["manager"].ToString();
                            gridNamespaces.Rows.Add(name, uid, status, date, manager,label);
                        }
                    }
                }
                gridNamespaces.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }
    }
}
