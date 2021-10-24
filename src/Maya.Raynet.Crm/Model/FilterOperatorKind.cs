using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Model
{
    public enum FilterOperatorKind
    {
        Equal,
        EqaulOrNull,
        Not,
        NotOrNull,
        LessThan,
        LessThanOrEqual,
        GreaterThan,
        GreaterThanOrEqual,
        Like,
        LikeNoCase,
        In,
        NotIn,
        Custom,
    }
}
