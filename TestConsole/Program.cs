using AzuxUI.Shared.DataAccess;
using AzuxUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ApiHelper.InitializeClient();
            List<Category> category;
            category = GenericDataAccess.GetAsync<Category>(Category.DatabaseName).Result;
            category.ForEach(x => Console.WriteLine(x.CategoryName));
        }
        

    }
}
