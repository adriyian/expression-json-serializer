using System;
using System.Linq.Expressions;

namespace Ad.ExpressionJsonSerializer.Core
{
    partial class Serializer
    {
        private bool DefaultExpression(Expression expr)
        {
            var expression = expr as DefaultExpression;
            if (expression == null) { return false; }

            this.Prop("typeName", "default");

            return true;
        }
    }
}
