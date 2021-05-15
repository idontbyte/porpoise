using System;
using Porpoise.Web.Services.Interfaces;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Dynamic;

namespace Porpoise.Web.Services
{
    public class PorpoiseDataFileReader : IPorpoiseDataReader
    {
        const string dataPagesDir = "Data/Pages/";

        public IEnumerable<dynamic> Pages()
        {
            var pages = new List<dynamic>();
            string[] fileEntries = Directory.GetFiles(dataPagesDir);
            foreach (string fileName in fileEntries)
            {
                var fileText = File.ReadAllText(fileName);
                dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject<ExpandoObject>(fileText);
                pages.Add(data);
            }
            return pages;
        }
    }
}
