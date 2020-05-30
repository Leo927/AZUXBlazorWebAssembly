using AzuxUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AzuxUI.Shared.DataAccess
{
    public static class GenericDataAccess
    {
        public async static Task<T> GetAsync<T>(string databaseName, int id)
        {
            string url = $"api/{databaseName}/{ id }";
            if (id <= 0) throw new ArgumentOutOfRangeException("Id must be postive");

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    T databaseEntry = await response.Content.ReadAsAsync<T>();
                    return databaseEntry;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }

        public async static Task<List<T>> GetAsync<T>(string databaseName)
        {
            string url = $"api/{databaseName}/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<T> databaseEntries = await response.Content.ReadAsAsync<List<T>>();
                    return databaseEntries;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }

        public async static Task<T> AddAsync<T>(string databaseName, IModel item)
        {
            string url = $"api/{ databaseName }/";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PostAsJsonAsync(url, item))
            {
                if (response.IsSuccessStatusCode)
                {
                    T databaseEntry = await response.Content.ReadAsAsync<T>();
                    return databaseEntry;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }

        public async static Task<T> UpdateAsync<T>(string databasename, int id, IModel item)
        {
            if (id <= 0) throw new Exception("id must be a positive number");
            string url = $"api/{ databasename}/{ id }";
            item.Id = id;

            using (HttpResponseMessage response = await ApiHelper.ApiClient.PutAsJsonAsync(url, item))
            {
                if (response.IsSuccessStatusCode)
                {
                    T databaseEntry = await response.Content.ReadAsAsync<T>();
                    return databaseEntry;
                }
                else
                    throw new Exception(response.ReasonPhrase);
            }
        }

    }
}
