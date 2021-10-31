using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maya.Raynet.Crm.Attribute
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class RaynetUriParam : System.Attribute
    {
        private readonly string name;

        public RaynetUriParam(string name)
        {
            this.name = name;
        }

        public virtual string Name
        {
            get { return this.name; }
        }
    }
}
