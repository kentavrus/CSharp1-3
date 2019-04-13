using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp13.Exceptions
{
    internal class Birth : Exception
    {
        public Birth()
            : base("You are not born") { }
    }
}
