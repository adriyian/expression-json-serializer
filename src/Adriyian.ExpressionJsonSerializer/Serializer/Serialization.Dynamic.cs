using System;
using System.Linq.Expressions;

namespace Ad.ExpressionJsonSerializer.Core
{
    partial class Serializer
    {
        private bool DynamicExpression(Expression expr)
        {
            var expression = expr as DynamicExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
