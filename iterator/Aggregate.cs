using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public abstract class Aggregate //Aggregate Class, the Concrete Aggregate Class inherits this
    {
        public List<string> Elements;      //abstract methods and declaration for the Concrete Aggregate class to use.

        public abstract Iterator createMostIterator();             
        public abstract Iterator createLeastIterator();
    }
}
