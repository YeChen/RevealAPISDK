using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;

using System.Net.Http;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http.Headers;

using RevealAPI.Sdk.Models.Resources;

namespace TestHarness2
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private async void btTest_Click(object sender, EventArgs e)
        {
            try
            {

                var url = "https://consulting.us-east-1.reveal11.cloud/rest/api/login?username=xxx&password=aaabbb";
                          
                var client = new HttpClient();

                client.DefaultRequestHeaders.Add("authority", "consulting.us-east-1.reveal11.cloud");
                client.DefaultRequestHeaders.Add("method", "GET");
                client.DefaultRequestHeaders.Add("path", "/rest/api/login?username=xxx&password=aaabbb");
                client.DefaultRequestHeaders.Add("scheme", "https");
                client.DefaultRequestHeaders.Add("accept", "application/json");
                client.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                client.DefaultRequestHeaders.Add("accept-language", "en-AU,en;q=0.9");
                client.DefaultRequestHeaders.Add("referer", "https://consulting.us-east-1.reveal11.cloud/rest/api-docs/index.html?urls.primaryName=v1");
                client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"110\", \"Not A(Brand\";v=\"24\", \"Google Chrome\";v=\"110\"");
                client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
                client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
                client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
                client.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
                client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");

                var response = await client.GetAsync(url);

                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            txtPwd.PasswordChar = '*'; 
           
        }

        private async void btV2Login_Click(object sender, EventArgs e)
        {
            try {
                var client = new HttpClient();

                var url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/login";
             
                var loginrequest = new LoginRequest(this.txtUser.Text, this.txtPwd.Text);

                var json = JsonConvert.SerializeObject(loginrequest);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                //client.DefaultRequestHeaders.Add("authority", "consulting.us-east-1.reveal11.cloud");
                //client.DefaultRequestHeaders.Add("method", "POST");
                //client.DefaultRequestHeaders.Add("path", "/rest/api/v2/login");
                //client.DefaultRequestHeaders.Add("scheme", "https");
                //client.DefaultRequestHeaders.Add("accept", "application/json");
                //client.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                //client.DefaultRequestHeaders.Add("accept-language", "en-AU,en;q=0.9");
                ////client.DefaultRequestHeaders.Add("content-length", "60");
                ////client.DefaultRequestHeaders.Add("content-type", "application/json-patch+json");
                //client.DefaultRequestHeaders.Add("origin", "https://consulting.us-east-1.reveal11.cloud");
                //client.DefaultRequestHeaders.Add("referer", "https://consulting.us-east-1.reveal11.cloud/rest/api-docs/index.html?urls.primaryName=v2");
                //client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"110\", \"Not A(Brand\";v=\"24\", \"Google Chrome\";v=\"110\"");
                //client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                //client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
                //client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
                //client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
                //client.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
                //client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");

                addDefaultHeader(client, true);

                var response = await client.PostAsync(url, data);

                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);

                //get login id 
                var loginresponse = JsonConvert.DeserializeObject<LoginResponse>(result.ToString());

                Console.WriteLine(result);

                //get a list of projects
                var client2 = new HttpClient();
                url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/projects?userId=0&filterByExact=true&start=0&count=2147483647";
                addDefaultHeader(client2, false);                
                client2.DefaultRequestHeaders.Add("incontrolauthtoken", loginresponse.loginSessionId);
                response = await client2.GetAsync(url);
                result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);

                var projectResponse = JsonConvert.DeserializeObject<PaginatedOfIEnumerableOfProject>(result.ToString());
                foreach(RevealAPI.Sdk.Models.Resources.Project p in projectResponse.Results){
                    this.txtProjects.Text += "Project name: " + p.ProjectName + "\r\n";
                }

                //read search job 8 results 
                RevealAPI.Sdk.Models.Resources.DocumentCriteria doccriteria = new DocumentCriteria();
                doccriteria.FieldProfileId = 8;
                doccriteria.Start = 0;
                doccriteria.Count = 25;

                RevealAPI.Sdk.Models.Resources.SearchCriteria criteria = new SearchCriteria();
                criteria.CaseId = 170;
                criteria.QueryType = SearchQueryType.SearchJobId;

                criteria.DocumentCriteria = doccriteria;

                var json3 = JsonConvert.SerializeObject(criteria);
                var data3 = new StringContent(json, Encoding.UTF8, "application/json");
                url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/170/search";
                var client3 = new HttpClient();              
                addDefaultHeader(client3, false);
                client2.DefaultRequestHeaders.Add("incontrolauthtoken", loginresponse.loginSessionId);

                var response3 = await client3.PostAsync(url, data3);
                var result3 = await response3.Content.ReadAsStringAsync();
                Console.WriteLine(result3);              
                var docresponse = JsonConvert.DeserializeObject<SearchResults>(result3.ToString());
                Console.WriteLine(result3);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void addDefaultHeader(HttpClient client, bool isPostRequest)
        {
            if (isPostRequest)
            {
                client.DefaultRequestHeaders.Add("method", "POST");
            }
            else
            {
                client.DefaultRequestHeaders.Add("method", "GET");
            }

            client.DefaultRequestHeaders.Add("authority", "consulting.us-east-1.reveal11.cloud");        
            client.DefaultRequestHeaders.Add("path", "/rest/api/v2/login");
            client.DefaultRequestHeaders.Add("scheme", "https");
            client.DefaultRequestHeaders.Add("accept", "application/json");
            client.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
            client.DefaultRequestHeaders.Add("accept-language", "en-AU,en;q=0.9");
            //client.DefaultRequestHeaders.Add("content-length", "60");
            //client.DefaultRequestHeaders.Add("content-type", "application/json-patch+json");
            client.DefaultRequestHeaders.Add("origin", "https://consulting.us-east-1.reveal11.cloud");
            client.DefaultRequestHeaders.Add("referer", "https://consulting.us-east-1.reveal11.cloud/rest/api-docs/index.html?urls.primaryName=v2");
            client.DefaultRequestHeaders.Add("sec-ch-ua", "\"Chromium\";v=\"110\", \"Not A(Brand\";v=\"24\", \"Google Chrome\";v=\"110\"");
            client.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
            client.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
            client.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
            client.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
            client.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
            client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110.0.0.0 Safari/537.36");


        }
    }
}
