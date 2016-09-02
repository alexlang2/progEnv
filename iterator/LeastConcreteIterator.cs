using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public class LeastConcreteIterator : Iterator
    {
        Aggregate aggregate;             //creates instance for aggregate
        int currIndex;

        public LeastConcreteIterator(Aggregate agg)            
        {
            aggregate = agg;
        }
        public override object currItem()             //retrieves the current item of the elements list
        {
            if (isDone())                             //If the iterator is done going through the list, return null, else, return the value
                return null;
            return aggregate.Elements[currIndex];
        }

        public override object first()                //Since this is decreasing, the index starts at 14.
        {
            currIndex = 14;
            return currItem();
        }

        public override bool isDone()                //If the index goes below 0, the iterator is done
        {
            return (currIndex < 0);
        }

        public override object next()                //If the iterator isn't done, go backwards in the array. Return the value.
        {
            if (!isDone())
                currIndex--;
            return currItem();

        }
    }
}