using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadePattern
{
    public class WorkoutFacade
    {
        private Diet diet;
        private Conditioning condition;
        private Lifting lift;

        public WorkoutFacade(Diet diet1, Conditioning condition1, Lifting lift1)     //Constructor for the facade
        {
            diet = diet1;
            condition = condition1;
            lift = lift1;
        }


        public void toning()        //Sets the qualifications for toning muscle
        {
            diet.toneDiet();
            condition.toneConiditioning();
            lift.toneLifting();
        }

        public void bulking()      //Sets the qualifications for bulking muscle         
        {
            diet.bulkDiet();
            condition.bulkConditioning();
            lift.bulkLifting();
        }

    }
}
