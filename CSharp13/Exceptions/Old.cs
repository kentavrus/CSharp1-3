using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13.Exceptions
{
    internal class Old : Exception
    {
       public Old()
            : base("People don't live too long") { }
    }
}
