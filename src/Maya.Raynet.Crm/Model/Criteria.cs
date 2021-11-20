using System.Collections.Generic;

namespace Maya.Raynet.Crm.Model
{
    public class Criteria
    {
        public List<Filter> Filters { get; } = new List<Filter>();

        public Sorting Sorting { get; private set; }

        public Pagination Pagination { get; private set; }

        public Criteria AddFilter(string property, FilterOperatorKind operatorKind, object value)
        {
            Filters.Add(new Filter
            {
                Operator = operatorKind,
                Property = property,
                Value = value
            });

            return this;
        }

        public Criteria SetSorting(string property, SortDirectionKind sortDirectionKind)
        {
            Sorting = new Sorting
            {
                Column = property,
                Direction = sortDirectionKind
            };

            return this;
        }

        public Criteria SetPagination(int? limit = null, int? offset = null)
        {
            Pagination = new Pagination
            {
                Limit = limit,
                Offset = offset
            };

            return this;
        }
    }
}
