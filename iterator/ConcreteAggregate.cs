using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public class ConcreteAggregate : Aggregate //ConcreteAggregate Class inherits from aggregate
    {

        public ConcreteAggregate()
        {
            Elements = new List<string>();            //Establishes where our information will be stored, in a list as strings.
        }
        public override Iterator createMostIterator()
        {
            return new MostConcreteIterator(this);   //Creates the information for the most iterator with this aggregate information.
        }

        public override Iterator createLeastIterator() //Creates the information for the least iterator with this aggregate information.
        {
            return new LeastConcreteIterator(this);
        }
    }
}
