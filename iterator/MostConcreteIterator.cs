using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iterator
{
    public class MostConcreteIterator : Iterator
    { 
        Aggregate aggregate;                               //Creates instance for aggregate
        int currIndex;

        public MostConcreteIterator(Aggregate agg)
        {
            aggregate = agg;
        }

        public override object currItem()                  //retrieves the current item of the elements list
        {
            if (isDone())                                  //If the iterator is done going through the list, return null, else, return the value
                return null;
            return aggregate.Elements[currIndex];
        }

        public override object first()                     //Since this is increasing, the index starts at 0.
        {
            currIndex = 0;
            return currItem();
        }

        public override bool isDone()                      //If the index goes the amount of elements we have, the iterator is done
        {
            return (currIndex > aggregate.Elements.Count - 1);
        }

        public override object next()                      //If the iterator isn't done, go forwards in the array. Return the value.
        { 
            if (!isDone())
                currIndex++;
            return currItem();

        }
    }
}
