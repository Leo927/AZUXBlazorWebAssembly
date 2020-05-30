using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace AZUXUI.Data
{
    public static class DataAccessAPIs
    {
        public static string BaseAddress { get => "https://localhost:"; }
        private static string GetServerAddress(string port = "44368")
        {
            return $"{BaseAddress}{port}/api/";
        }

        public static string Category(int id = -1)
        {
            return id < 0 ? 
                GetServerAddress() + nameof(Category) : 
                GetServerAddress() + nameof(Category) + "/" + id.ToString();
        }
    }
}
