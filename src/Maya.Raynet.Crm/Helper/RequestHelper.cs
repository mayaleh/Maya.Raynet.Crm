using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Maya.AnyHttpClient;
using Maya.AnyHttpClient.Model;

namespace Maya.Raynet.Crm.Helper
{
    internal class RequestHelper
    {
        internal static UriRequest ComposeUri<T>(IEnumerable<string> actions, T uriParameters)
        {
            var _dict = new Dictionary<string, string>();

            var props = uriParameters.GetType().GetProperties();
            foreach (var prop in props)
            {
                var attrs = prop.GetCustomAttributes(true);
                foreach (var attr in attrs)
                {
                    if (attr is Attribute.RaynetUriParam authAttr)
                    {
                        var name = authAttr.Name;
                        var val = prop.GetValue(uriParameters);
                        if (val != null)
                        {
                            _dict.Add(name, val.ToString());
                        }
                    }
                }
            }

            return new UriRequest(actions, _dict.ToArray());
        }
    }
}
