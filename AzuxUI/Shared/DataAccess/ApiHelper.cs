using AzuxUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AzuxUI.Shared.DataAccess
{
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri(ServerUrl);
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            CategoryUrl = $"{ServerUrl}/api/{Category.DatabaseName}";

        }

        public static readonly string ServerUrl = "https://localhost:5001";

        public static string CategoryUrl { get; private set; }
    }
}
