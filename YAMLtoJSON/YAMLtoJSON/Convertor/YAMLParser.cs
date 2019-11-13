using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using YamlDotNet;
using YamlDotNet.RepresentationModel;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace YAMLtoJSON.Convertor
{
    internal class YAMLParser
    {
        internal object ParseYamlString(string yamlStr)
        {
            var input = new StringReader(yamlStr);
            //var yaml = new YamlStream();
            //yaml.Load(input);
            var deserializer = new DeserializerBuilder().WithNamingConvention(new CamelCaseNamingConvention()).Build();
            var result = deserializer.Deserialize<object>(input);
            return result;
        }
        internal string ParseYamlObject(object yaml)
        {
            string result ="";
            return result;
        }
        internal string ToJson(string yaml)
        {
            var r = new StringReader(@"
            scalar: a scalar
            sequence:
              - one
              - two
            ");
            var deserializer = new DeserializerBuilder().Build();
            var yamlObject = deserializer.Deserialize(r);
            var serializer = new SerializerBuilder()
                .JsonCompatible()
                .Build();
            var json = serializer.Serialize(yamlObject);
            return json;
        }
    }
}
