using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13.Exceptions
{
    internal class Email : Exception
    {
        public Email(string val)
            : base(val) { }
    }
}
