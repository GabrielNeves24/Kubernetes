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

namespace Kubernetes
{
    public partial class ClusterRules : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public ClusterRules()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void ClusterRules_Load(object sender, EventArgs e)
        {

            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}s/rbac.authorization.k8s.io/v1/clusterroles");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                gridRegras.Columns.Add("nome", "Nome");
                gridRegras.Columns.Add("uid", "Uid");
                gridRegras.Columns.Add("manager", "Manager");
                gridRegras.Columns.Add("dataCriacao", "DataCriacao");
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            string name = item["metadata"]["name"].ToString();
                            string uid = item["metadata"]["uid"].ToString();
                            string manager = item["metadata"]["managedFields"][0]["manager"].ToString();
                            DateTime data = DateTime.Parse(item["metadata"]["creationTimestamp"].ToString());
                            gridRegras.Rows.Add(name, uid,manager,data);
                        }
                    }
                }
                gridRegras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter as Regras: {ex.Message}");
            }
        }

        private void gridRegras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
