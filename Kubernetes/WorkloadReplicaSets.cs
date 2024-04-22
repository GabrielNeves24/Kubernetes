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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kubernetes
{
    public partial class WorkloadReplicaSets : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public WorkloadReplicaSets()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void WorkloadReplicaSets_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject namespaces = JObject.Parse(responseBody);
                gridReplicasSets.Rows.Clear();
                foreach (JProperty jp in namespaces.Properties())
                {
                    if (jp.Name == "items")
                    {
                        foreach (JObject item in jp.Values())
                        {
                            comboNamespaceReplicasSet.Items.Add(item["metadata"]["name"].ToString());
                        }
                    }
                }
                comboNamespaceReplicasSet.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }

        }

        private async void gridReplicasSets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private async void comboNamespaceReplicasSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            string namespaceName = comboNamespaceReplicasSet.SelectedItem.ToString();
            var response = await client.GetAsync($"{apiURL}s/apps/v1/namespaces/{namespaceName}/replicasets");
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Namespace");
            dt.Columns.Add("Creation Timestamp");
            dt.Columns.Add("Replicas");
            dt.Columns.Add("Ready Replicas");
            dt.Columns.Add("Images");

            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            dynamic replicasets = Newtonsoft.Json.JsonConvert.DeserializeObject(responseBody);
            foreach (var item in replicasets.items)
            {
                string name = item.metadata.name;
                string @namespace = item.metadata.@namespace;
                string creationTimestamp = item.metadata.creationTimestamp;
                int replicas = item.spec.replicas ?? 0;
                int readyReplicas = item.status.readyReplicas ?? 0;
                string images = string.Empty;
                foreach (var container in item.spec.template.spec.containers)
                {
                    images += $"{container.image}, ";
                }
                images = images.TrimEnd(',', ' ');


                dt.Rows.Add(name, @namespace, creationTimestamp, replicas, readyReplicas, images);
            }
            gridReplicasSets.DataSource = dt;
            gridReplicasSets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}
