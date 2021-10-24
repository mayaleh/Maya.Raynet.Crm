using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Extension
{
    public static class SortDirectionExtension
    {
        public static string Map(this Model.SortDirectionKind sortDirection)
        {
            return sortDirection switch
            {
                Model.SortDirectionKind.Asc => "ASC",
                Model.SortDirectionKind.Desc => "DESC",
                _ => throw new NotImplementedException(sortDirection.ToString())
            };
        }
    }
}
