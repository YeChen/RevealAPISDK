﻿using System;
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
using RevealAPI.V1.Models.Resources;

namespace TestHarness2
{
    public partial class frmTest : Form
    {

        private string _token = ""; 

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
             
                addDefaultHeader(client, true, "");

                var response = await client.PostAsync(url, data);

                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);

                //get login id 
                var loginresponse = JsonConvert.DeserializeObject<LoginResponse>(result.ToString());

                _token = loginresponse.loginSessionId;

                MessageBox.Show("Login Successful"); 

                /*
                Console.WriteLine(result);

                //get a list of projects
                var client2 = new HttpClient();
                url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/projects?userId=0&filterByExact=true&start=0&count=2147483647";
                addDefaultHeader(client2, false, "");                
                client2.DefaultRequestHeaders.Add("incontrolauthtoken", loginresponse.loginSessionId);
                response = await client2.GetAsync(url);
                result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);

                var projectResponse = JsonConvert.DeserializeObject<PaginatedOfIEnumerableOfProject>(result.ToString());
                foreach(RevealAPI.Sdk.Models.Resources.Project p in projectResponse.Results){
                    this.txtProjects.Text += "Project name: " + p.ProjectName + "\r\n";
                }

                //-------------------------------------------------------------------------------------------
                //-------------------------------------------------------------------------------------------
                //read search job 8 results 
                RevealAPI.Sdk.Models.Resources.DocumentCriteria doccriteria = new DocumentCriteria();
                doccriteria.FieldNames = new List<string>();
                doccriteria.FieldNames.Add("BEGDOC");
                doccriteria.FieldProfileId = 1;
                doccriteria.Start = 0;
                doccriteria.Count = 25;
                doccriteria.GetFields = true;
                doccriteria.GetMandatoryFields = true;
                //doccriteria.GetSpecialIconFields = true;

                RevealAPI.Sdk.Models.Resources.SearchCriteria criteria = new SearchCriteria();
                criteria.CaseId = 0;
                criteria.UserId = 0;
                //criteria.QueryType = SearchQueryType.SearchJobId;
                criteria.QueryType = "SearchJobId";
                criteria.QueryString = "10";
                criteria.GetDocumentBodyTerms = true;
                criteria.IgnoreDocumentSecurity = true;
                criteria.SearchProfileIds = new List<int?>();
                criteria.SearchProfileIds.Add(0);
                criteria.SortByString = "BEGDOC asc";

                criteria.DocumentCriteria = doccriteria;
                //criteria.AggregationCriteria = new List<AggregationCriteria>();
                //criteria.DocumentFieldFillRateCriteria = new List<DocumentFieldsFillRateCriteria>();
                //criteria.DateHistogramCriteria = new List<DateHistogramCriteria>();
                //criteria.NumberHistogramCriteria = new List<NumberHistogramCriteria>();

                var json3 = JsonConvert.SerializeObject(criteria);
                //var json3 = txtinput.Text; 

                var data3 = new StringContent(json3, Encoding.UTF8, "application/json-patch+json");
                data3.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                //data3.Headers.ContentLength = 600; 

                url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/170/search";
                var client3 = new HttpClient();
                //addDefaultHeader(client3, true);
                client3.DefaultRequestHeaders.Add("method", "POST");
                client3.DefaultRequestHeaders.Add("authority", "consulting.us-east-1.reveal11.cloud");
                client3.DefaultRequestHeaders.Add("path", "/rest/api/v2/170/search");
                client3.DefaultRequestHeaders.Add("scheme", "https");
                client3.DefaultRequestHeaders.Add("accept", "application/json");
                client3.DefaultRequestHeaders.Add("accept-encoding", "gzip, deflate, br");
                client3.DefaultRequestHeaders.Add("accept-language", "en-AU,en;q=0.9");
                //client.DefaultRequestHeaders.Add("content-length", "600");
                //client.DefaultRequestHeaders.Add("content-type", "application/json-patch+json");
                
                client3.DefaultRequestHeaders.Add("origin", "https://consulting.us-east-1.reveal11.cloud");
                client3.DefaultRequestHeaders.Add("referer", "https://consulting.us-east-1.reveal11.cloud/rest/api-docs/index.html");
                client3.DefaultRequestHeaders.Add("sec-ch-ua", "\"Google Chrome\";v=\"111\", \"Not(A: Brand\";v=\"8\", \"Chromium\";v=\"111\"");
                client3.DefaultRequestHeaders.Add("sec-ch-ua-mobile", "?0");
                client3.DefaultRequestHeaders.Add("sec-ch-ua-platform", "\"Windows\"");
                client3.DefaultRequestHeaders.Add("sec-fetch-dest", "empty");
                client3.DefaultRequestHeaders.Add("sec-fetch-mode", "cors");
                client3.DefaultRequestHeaders.Add("sec-fetch-site", "same-origin");
                client3.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/111.0.0.0 Safari/537.36");

                ////cookie
                //HttpClientHandler handler = new HttpClientHandler();
                //handler.CookieContainer = new CookieContainer();

                //handler.CookieContainer.Add(uri, new Cookie("name", "value")); // Adding a Cookie
                //HttpClient client = new HttpClient(handler);
                //HttpResponseMessage response = await client.GetAsync(uri);
                //CookieCollection collection = handler.CookieContainer.GetCookies(uri); // Retrieving a Cookie

                client3.DefaultRequestHeaders.Add("incontrolauthtoken", loginresponse.loginSessionId);
                client3.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                var response3 = await client3.PostAsync(url, data3);
                var result3 = await response3.Content.ReadAsStringAsync();
                Console.WriteLine(result3);              
                var docresponse = JsonConvert.DeserializeObject<SearchResults>(result3.ToString());
                Console.WriteLine(result3);

                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btListProjects_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new HttpClient();
                var url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/projects?userId=0&filterByExact=true&start=0&count=2147483647";
                addDefaultHeader(client, false, "");
                client.DefaultRequestHeaders.Add("incontrolauthtoken", _token);
               
                Task<string> result = runHTTPClient(client, false, url, null);
                string resultstr = await result; 

                var projectResponse = JsonConvert.DeserializeObject<PaginatedOfIEnumerableOfProject>(resultstr);
                foreach (RevealAPI.Sdk.Models.Resources.Project p in projectResponse.Results)
                {
                    this.txtProjects.Text += "Project name: " + p.ProjectName + "\r\n";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void addDefaultHeader(HttpClient client, bool isPostRequest, string path)
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
            //client.DefaultRequestHeaders.Add("path", "/rest/api/v2/login");
            client.DefaultRequestHeaders.Add("path", path);
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
        private async Task<string> runHTTPClient(HttpClient client, bool isPostRequest, string url, object payload)
        {
            string resultstr = "";
            if (isPostRequest)
            {
                var json = JsonConvert.SerializeObject(payload);
                var data = new StringContent(json, Encoding.UTF8, "application/json-patch+json");
                data.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var response = await client.PostAsync(url, data);
                //var result = await response.Content.ReadAsStringAsync();
                //resultstr = result.ToString();
                resultstr = await response.Content.ReadAsStringAsync();
            }
            else
            {
                var response = await client.GetAsync(url);
                //var result = await response.Content.ReadAsStringAsync();
                //resultstr = result.ToString();
                resultstr = await response.Content.ReadAsStringAsync();
            }
            return resultstr; 
        }

        private async void btRunSearch_Click(object sender, EventArgs e)
        {
            try
            {
                RevealAPI.Sdk.Models.Resources.DocumentCriteria doccriteria = new DocumentCriteria();
                doccriteria.FieldNames = new List<string>();
                doccriteria.FieldNames.Add("BEGDOC");
                doccriteria.FieldProfileId = 1;
                doccriteria.Start = 0;
                doccriteria.Count = 25;
                doccriteria.GetFields = true;
                doccriteria.GetMandatoryFields = true;
                //doccriteria.GetSpecialIconFields = true;

                RevealAPI.Sdk.Models.Resources.SearchCriteria criteria = new SearchCriteria();
                criteria.CaseId = 0;
                criteria.UserId = 0;
                criteria.QueryType = SearchQueryType.SearchJobId;
                //criteria.QueryType = "SearchJobId";
                criteria.QueryString = "10";
                criteria.GetDocumentBodyTerms = true;
                criteria.IgnoreDocumentSecurity = true;
                criteria.SearchProfileIds = new List<int?>();
                criteria.SearchProfileIds.Add(0);
                criteria.SortByString = "BEGDOC asc";

                criteria.DocumentCriteria = doccriteria;
                //criteria.AggregationCriteria = new List<AggregationCriteria>();
                //criteria.DocumentFieldFillRateCriteria = new List<DocumentFieldsFillRateCriteria>();
                //criteria.DateHistogramCriteria = new List<DateHistogramCriteria>();
                //criteria.NumberHistogramCriteria = new List<NumberHistogramCriteria>();

                string url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/170/search";
                var client = new HttpClient();
                addDefaultHeader(client, true, "/rest/api/v2/170/search");
                client.DefaultRequestHeaders.Add("incontrolauthtoken", _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<string> result = runHTTPClient(client, true, url, criteria);
                string resultstr = await result;
               
                var docresponse = JsonConvert.DeserializeObject<SearchResults>(resultstr);

                foreach (RevealAPI.Sdk.Models.Resources.Document d in docresponse.DocumentResults.Documents)
                {
                    this.txtProjects.Text += "DocID: " +  d.Id + "\r\n";
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btReadText_Click(object sender, EventArgs e)
        {
            try
            {
                RevealAPI.V1.Models.Resources.DocumentsRequest docrequest = new RevealAPI.V1.Models.Resources.DocumentsRequest();
                docrequest.DocumentFields = new List<string>();
                docrequest.DocumentFields.Add("Body Text");
                docrequest.DocumentIds = new List<string>();
                docrequest.DocumentIds.Add("78");
                docrequest.DocumentIds.Add("73");
                docrequest.FieldProfileName = "Default";

                docrequest.CombineDateTimeFields = true;
                docrequest.KeyField = "ItemID";
                docrequest.UseFieldNames = false;
                docrequest.MaxTextLength = 0;

                string url = "https://consulting.us-east-1.reveal11.cloud/rest/api/document?caseId=170&userId=23";
                var client = new HttpClient();
                addDefaultHeader(client, true, "/rest/api/document?caseId=170&userId=23");
                client.DefaultRequestHeaders.Add("incontrolauthtoken", _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<string> result = runHTTPClient(client, true, url, docrequest);
                string resultstr = await result;

                var docresponse = JsonConvert.DeserializeObject<List<RevealAPI.V1.Models.Resources.Document>>(resultstr);

                foreach (RevealAPI.V1.Models.Resources.Document d in docresponse)
                {

                    foreach (RevealAPI.V1.Models.Resources.DocumentField f in d.Fields)
                    {
                        this.txtProjects.Text += "Field: " + f.FieldName + "\r\n" + "Value: " + f.FieldValue + "\r\n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void btCreateField_Click(object sender, EventArgs e)
        {
            try
            {                                
                RevealAPI.Sdk.Models.Resources.Field fieldrequest = new Field();
                fieldrequest.FieldId = 0;
                fieldrequest.FieldName = txtFieldName.Text;
                fieldrequest.DisplayName = txtFieldName.Text;
                //Valid values are bit, date, datetime, decimal, float, bigint, numeric, nvarchar, time
                fieldrequest.DataType = "nvarchar";
                fieldrequest.DataTypeDesc = "API created field";                
                fieldrequest.MaxLength = 2000;
                fieldrequest.IsUpdatable = true;
                fieldrequest.IsSearchable = true;
                fieldrequest.IsSortable = true;
                fieldrequest.IsNativeFileField = false;
                fieldrequest.IsUpdatable = true;
                fieldrequest.HasExactText = true;
                fieldrequest.Indexed = true;
                fieldrequest.Pinned = true;
                fieldrequest.Stored = true; 
                fieldrequest.Type = "Text";                 

                string url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/170/fields";
                var client = new HttpClient();
                addDefaultHeader(client, true, "/rest/api/v2/170/fields");
                client.DefaultRequestHeaders.Add("incontrolauthtoken", _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<string> result = runHTTPClient(client, true, url, fieldrequest);
                string resultstr = await result;

                var response = JsonConvert.DeserializeObject<RevealAPI.Sdk.Models.Resources.Field>(resultstr);
                if (response.FieldId > 0)
                {
                    MessageBox.Show("Filed " + response.FieldName + " was created successfully. FieldID: " + response.FieldId);
                }
                else
                {
                    MessageBox.Show("Filed creation failed");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btUpdateText_Click(object sender, EventArgs e)
        {
            //v1, set text set for a document: Document, /api/document/SetDocumentText, 
            //v2, use bulktag, https://consulting.us-east-1.reveal11.cloud/rest/api/v2/170/jobs/bulkTag

            try
            {
                RevealAPI.Sdk.Models.Resources.BulkTagJobCreate job = new BulkTagJobCreate();
                job.SelectedDocumentItemIds = new List<long?>();
                job.SelectedDocumentItemIds.Add(73);
                job.SelectedDocumentItemIds.Add(78);
                job.DocumentSelectionType = DocumentSelection.Subset;
                job.UpdateFieldsEntry = new UpdateFieldEntry();
                job.UpdateFieldsEntry.UpdateOption = BulkFieldUpdateOption.Replace;
                job.UpdateFieldsEntry.VariableSets = new List<FieldUpdateVariableSet>();
                FieldUpdateVariableSet updateset = new FieldUpdateVariableSet();
                updateset.FieldId = 350;
                updateset.Variables = new List<SlipsheetVariables>();
                SlipsheetVariables var = new SlipsheetVariables();
                var.Category = SlipsheetProfileVariableCategory.UserText;
                var.DisplayOrder = 0;
                var.Value = txtFieldValue.Text;
                updateset.Variables.Add(var); 

                string url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/170/jobs/bulkTag";
                var client = new HttpClient();
                addDefaultHeader(client, true, "/rest/api/v2/170/jobs/bulkTag");
                client.DefaultRequestHeaders.Add("incontrolauthtoken", _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<string> result = runHTTPClient(client, true, url, job);
                string resultstr = await result;

                var response = JsonConvert.DeserializeObject<RevealAPI.Sdk.Models.Resources.BulkTagJob>(resultstr);
                if (response.Id > 0)
                {
                    MessageBox.Show("Job " + response.Id + " was created successfully.");
                }
                else
                {
                    MessageBox.Show("bulk tag job creation failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private async void btReindex_Click(object sender, EventArgs e)
        {
            //v1, /api/Indexing
            try
            {
                RevealAPI.V1.Models.Resources.IndexJobCreate job = new IndexJobCreate();
               
                string url = "https://consulting.us-east-1.reveal11.cloud/rest/api/v2/170/jobs/bulkTag";
                var client = new HttpClient();
                addDefaultHeader(client, true, "/rest/api/v2/170/jobs/bulkTag");
                client.DefaultRequestHeaders.Add("incontrolauthtoken", _token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                Task<string> result = runHTTPClient(client, true, url, job);
                string resultstr = await result;

                var response = JsonConvert.DeserializeObject<RevealAPI.Sdk.Models.Resources.BulkTagJob>(resultstr);
                if (response.Id > 0)
                {
                    MessageBox.Show("Job " + response.Id + " was created successfully.");
                }
                else
                {
                    MessageBox.Show("bulk tag job creation failed");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
