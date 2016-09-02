using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public abstract class Iterator     //This is the iterator class, which is inhereted by the Concrete Iterator class
                                       //Does not rely on anything
    {
        public abstract object first();                       //abstract methods being inherited to MostConcreteIterator and LeastConcreteIterator.
        public abstract object next();
        public abstract bool isDone();
        public abstract object currItem();
    }
}
