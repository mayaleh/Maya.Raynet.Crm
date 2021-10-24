using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Model
{
    public class Sorting
    {
        public string Column { get; set; }

        public Model.SortDirectionKind Direction { get; set; }
    }
}
