using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Reflection;

namespace Ad.ExpressionJsonSerializer.Core
{
    public static class JsonExpression
    {
        public static string Serialize(LambdaExpression source)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ExpressionJsonConverter(
                Assembly.GetAssembly(typeof(JsonExpression))
            ));

            return JsonConvert.SerializeObject(source, settings);
        }

        public static LambdaExpression Deserialize(string json)
        {
            var settings = new JsonSerializerSettings();
            settings.Converters.Add(new ExpressionJsonConverter(
                Assembly.GetAssembly(typeof(JsonExpression))
            ));

            return JsonConvert.DeserializeObject<LambdaExpression>(json, settings);
        }
    }
}
