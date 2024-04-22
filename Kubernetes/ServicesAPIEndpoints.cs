using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
    public partial class ServicesAPIEndpoints : Form
    {
        private readonly HttpClient client;
        private string apiURL = Kubernetes.Form1.Globals.apiURLUsar;
        public ServicesAPIEndpoints()
        {
            InitializeComponent();
            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            ServicePointManager.ServerCertificateValidationCallback +=
                (sender, certificate, chain, sslPolicyErrors) => true;
            gridApi2.CellContentClick += gridApi2_CellContentClick;
        }

        private async void ServicesAPIEndpoints_Load(object sender, EventArgs e)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync($"{apiURL}/v1/endpoints");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);
                JArray items = (JArray)json["items"];
                DataTable dt = new DataTable();
                dt.Columns.Add("Name");
                dt.Columns.Add("Namespace");
                dt.Columns.Add("Endpoint");
                foreach (JObject item in items)
                {
                    string name = (string)item["metadata"]["name"];
                    string ns = (string)item["metadata"]["namespace"];
                    JArray subsets = (JArray)item["subsets"];
                    if (subsets != null)
                    {
                        foreach (JObject subset in subsets)
                        {
                            JArray addresses = (JArray)subset["addresses"];
                            JArray ports = (JArray)subset["ports"];
                            foreach (JObject address in addresses)
                            {
                                string ip = (string)address["ip"];
                                foreach (JObject port in ports)
                                {
                                    string name1 = (string)port["name"];
                                    int portNumber = (int)port["port"];
                                    string endpoint = $"{name1}://{ip}:{portNumber}";
                                    dt.Rows.Add(name, ns, endpoint);
                                }
                            }
                        }
                    }
                    else
                    {
                        dt.Rows.Add(name, ns, "");
                    }
                }
                gridApi2.DataSource = dt;
                gridApi2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: Não foi possível listar os endpoints ({ex.Message})");
            }
        }

        private async void comboNamespaceAPI_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gridApi2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridApi2.Columns[e.ColumnIndex].Name == "Endpoint" && e.RowIndex >= 0)
            {
                string url = gridApi2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Process.Start(url);
            }
        }
    }
}
