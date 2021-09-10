using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AutomationWrapper.Utilities
{
    public class JSONUtils
    {
        public static string GetValueUsingKey(string file,string key)
        {
            var reader = new StreamReader(file);
            dynamic json = JsonConvert.DeserializeObject(reader.ReadToEnd());

            string value = Convert.ToString(json[key]);

            return value;
        }
    }
}
