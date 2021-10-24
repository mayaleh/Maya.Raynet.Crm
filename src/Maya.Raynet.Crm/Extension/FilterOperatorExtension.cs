using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Extension
{
    public static class FilterOperatorExtension
    {
        public static string Map(this Model.FilterOperatorKind operatorKind)
        {
            return operatorKind switch
            {
                Model.FilterOperatorKind.Custom => "",
                Model.FilterOperatorKind.EqaulOrNull => "EQ_OR_NULL",
                Model.FilterOperatorKind.Equal => "EQ",
                Model.FilterOperatorKind.GreaterThan => "GT",
                Model.FilterOperatorKind.GreaterThanOrEqual => "GE",
                Model.FilterOperatorKind.In => "IN",
                Model.FilterOperatorKind.LessThan => "LT",
                Model.FilterOperatorKind.LessThanOrEqual => "LE",
                Model.FilterOperatorKind.Like => "LIKE",
                Model.FilterOperatorKind.LikeNoCase => "LIKE_NOCASE",
                Model.FilterOperatorKind.Not => "NE",
                Model.FilterOperatorKind.NotIn => "NOT_IN",
                Model.FilterOperatorKind.NotOrNull => "NE_OR_NULL",
                _ => throw new NotImplementedException(operatorKind.ToString())
            };
        }

        public static string BuildQueryFilter()
        {
            /* Operátor se zapisuje do hranatých závorek za název atributu. Je tak možné zadat více filtrovacích kritérií nad stejným atributem.
             * http://ww..../?validFrom[GT]="2014-06-01"&validTill[LT]="2014-06-10" Častým scénářem je vyfiltrování všech záznamů,
             * které mají daný atribut prázdný nebo naopak neprázdný.
             * Pro tyto účely lze použít hodnotu prázdný řetězec v kombinaci s operátorem EQ nebo NE. */
            return string.Empty;
        }
    }
}
