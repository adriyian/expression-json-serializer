using System;
using System.Linq.Expressions;
using Newtonsoft.Json.Linq;
using Expr = System.Linq.Expressions.Expression;

namespace Ad.ExpressionJsonSerializer.Core
{
    partial class Deserializer
    {
        private DebugInfoExpression DebugInfoExpression(
            ExpressionType nodeType, System.Type type, JObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
