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
    public partial class ClusterNodes : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public ClusterNodes()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void ClusterNodes_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/nodes");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                gridNodes.Columns.Add("nome", "Nome");
                gridNodes.Columns.Add("uid", "Uid");
                gridNodes.Columns.Add("status", "Status");
                gridNodes.Columns.Add("address", "Address");
                gridNodes.Columns.Add("osImage", "OsImage");
                gridNodes.Columns.Add("os", "Os");
                gridNodes.Columns.Add("hostname", "Hostname");
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            string name = item["metadata"]["name"].ToString();
                            string status = item["status"]["conditions"][3]["status"].ToString();
                            string address = item["status"]["addresses"][0]["address"].ToString();
                            string osImage = item["status"]["nodeInfo"]["osImage"].ToString();
                            string uid = item["metadata"]["uid"].ToString();
                            DateTime data = DateTime.Parse(item["metadata"]["creationTimestamp"].ToString());
                            string os = item["metadata"]["labels"]["beta.kubernetes.io/os"].ToString();
                            string hostname = item["metadata"]["labels"]["kubernetes.io/hostname"].ToString();
                            gridNodes.Rows.Add(name, uid,status, address,osImage, os,hostname);
                        }
                    }
                }
                gridNodes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os Nodes: {ex.Message}");
            }
        }

        private void btnCriarEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }

        private void gridNodes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
