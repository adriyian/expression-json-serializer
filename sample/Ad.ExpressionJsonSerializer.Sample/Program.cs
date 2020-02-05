using System;
using System.Linq.Expressions;

namespace Ad.ExpressionJsonSerializer.Core.Sample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write expression");
            Expression<Func<int, int>> exp = (c => c * c);

            Console.WriteLine("Serialize expression to json");
            var json = JsonExpression.Serialize(exp);
            // var json = JsonExpression.Serialize((Expression<Func<int, int>>)(c => c * c));
            Console.WriteLine(json);

            Console.WriteLine("Deserialize json to expression");
            var jsonExp = JsonExpression.Deserialize(json);
            Console.WriteLine(jsonExp);
        }
    }
}
