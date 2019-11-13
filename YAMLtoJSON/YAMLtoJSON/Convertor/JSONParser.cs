using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace YAMLtoJSON.Convertor
{
    internal class JSONParser
    {
        internal object ParseJsonString(string json)
        {
            object jObject = JsonConvert.DeserializeObject(json);
            return jObject;
        }
        internal string ParseJsonObject(object json)
        {
            string result = "";
            result = JsonConvert.SerializeObject(json);
            return result;
        }
    }
}
