using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadePattern
{
    public class Lifting
    {
        public enum Weight { fortyLbs, ninetyLbs }              //Declaring possible lifting options
        public enum Sets { fourSets, threeSets }
        public enum Reps { twelveReps, fiveReps}

        public Weight weightAmt;
        public Sets setAmt;
        public Reps repAmt;

        public void toneLifting()                               //Tone lifting specifications
        {
            weightAmt = Weight.fortyLbs;
            setAmt = Sets.fourSets;
            repAmt = Reps.twelveReps;
        }

        public void bulkLifting()                              //Bulk lifting specifications
        {
            weightAmt = Weight.ninetyLbs;
            setAmt = Sets.threeSets;
            repAmt = Reps.fiveReps;
        }

    }
}
