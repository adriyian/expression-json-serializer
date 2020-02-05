using System;
using System.Linq.Expressions;

namespace Ad.ExpressionJsonSerializer.Core
{
    partial class Serializer
    {
        private bool DebugInfoExpression(Expression expr)
        {
            var expression = expr as ConditionalExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
