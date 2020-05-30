using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using AzuxUI.Shared.Models;

namespace AzuxUI.Shared.DataAccess
{
    public static class CategoryDataAccess
    {
        public async static Task<Category> GetCategoryAsync(int id)
        {
            return await GenericDataAccess.GetAsync<Category>(Category.DatabaseName, id);
        }

        

        public async static Task<List<Category>> GetCategoryAsync()
        {
            return await GenericDataAccess.GetAsync<Category>(Category.DatabaseName);
        }



    }
}
