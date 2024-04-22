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
    public partial class ConfigsSecrets : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public ConfigsSecrets()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private async void ConfigsSecrets_Load(object sender, EventArgs e)
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
                            comboNamespaceSecrets.Items.Add(item["metadata"]["name"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro Não foi possivel obter os namespaces: {ex.Message}");
            }
        }

        private async void comboNamespaceSecrets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboNamespaceSecrets.SelectedItem.ToString() == "")
                return;
            string namespace1 = comboNamespaceSecrets.SelectedItem.ToString();
            HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/namespaces/{namespace1}/secrets");
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            JObject secrets = JObject.Parse(responseBody);
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("NameSpace");
            dt.Columns.Add("DataCriação");
            dt.Columns.Add("key");
            dt.Columns.Add("value");

            foreach (JProperty jp in secrets.Properties())
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
                                string value = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(keyValue.Value.ToString()));
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
