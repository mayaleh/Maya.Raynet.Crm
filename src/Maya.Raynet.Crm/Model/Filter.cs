using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Model
{
    public class Filter
    {
        public string Property { get; set; }

        public Model.FilterOperatorKind Operator { get; set; }
        
        public object Value { get; set; }
    }

    public class Filter<TVal>
    {
        public string Property { get; set; }

        public Model.FilterOperatorKind Operator { get; set; }
        
        public TVal Value { get; set; }
    }
}
