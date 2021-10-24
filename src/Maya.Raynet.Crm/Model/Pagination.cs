using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Model
{
    /// <summary>
    /// Max list size is 1000 items
    /// </summary>
    public class Pagination
    {
        public int Limit { get; set; }
        public int Offset { get; set; }
    }
}
