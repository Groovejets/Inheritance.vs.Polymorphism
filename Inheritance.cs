using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Sample
{
    public class InheritanceSampleBaseClass
    { 
        public string HelloMessage = "Hello, World!";
    }

    public class InheritanceSampleSubClass : InheritanceSampleBaseClass
    {
        public string ArbitraryMessage = "Uh, Hi!";
    }
}
