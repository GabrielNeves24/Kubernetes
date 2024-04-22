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
using System.Net.NetworkInformation;

namespace Kubernetes
{
    public partial class ConfigMaps : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public ConfigMaps()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private async void ConfigMaps_Load(object sender, EventArgs e)
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
                            comboNamespaceConfig.Items.Add(item["metadata"]["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private async void comboNamespaceConfig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNamespaceConfig.SelectedItem.ToString() == "")
                return;
            string namespace1 = comboNamespaceConfig.SelectedItem.ToString();
            HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces/{namespace1}/configmaps");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject configMaps = JObject.Parse(responseBody);
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Namespace");
            dt.Columns.Add("DataCriação");
            dt.Columns.Add("Key");
            dt.Columns.Add("Value");
            foreach (JProperty jp in configMaps.Properties())
            {
                if (jp.Name == "items")
                {
                    foreach (JObject item in jp.Values())
                    {
                        string name = item["metadata"]["name"].ToString();
                        string namespaces = item["metadata"]["namespace"].ToString();
                        string creationTimestamp = item["metadata"]["creationTimestamp"].ToString();
                        JObject data = item["data"] as JObject;
                        if (data != null)
                        {
                            foreach (JProperty keyValue in data.Properties())
                            {
                                string key = keyValue.Name;
                                string value = keyValue.Value.ToString();
                                dt.Rows.Add(name, namespaces, creationTimestamp, key, value);
                            }
                        }
                    }
                }
            }
            gridConfigMaps.DataSource = dt;
        }
    }
}
