using System;
using System.Linq.Expressions;

namespace Ad.ExpressionJsonSerializer.Core
{
    partial class Serializer
    {
        private bool GotoExpression(Expression expr)
        {
            var expression = expr as GotoExpression;
            if (expression == null) { return false; }

            throw new NotImplementedException();
        }
    }
}
