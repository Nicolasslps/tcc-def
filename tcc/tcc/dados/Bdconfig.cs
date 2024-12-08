using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace tcc.dados
{
    internal class Bdconfig : DbContext
    {
        public static string GetConnectionString()
        {
            var json = File.ReadAllText("appsettings.json");
            var jObject = JObject.Parse(json);
            return jObject["ConnectionStrings"]["MySQL"].ToString();
        }
    }
}
