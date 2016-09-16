using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadePattern
{
    public class Conditioning
    {
        public enum Running { thirtyMins, tenMins }          //Declaring possible conditioning options
        public enum Sprints { eight, four}

        public Running runAmt;
        public Sprints sprintAmt;



        public void toneConiditioning()                      //Tone conditioning specifications
        {
            runAmt = Running.thirtyMins;
            sprintAmt = Sprints.eight;
        }

        public void bulkConditioning()                       //Bulk conditioning specifications
        {
            runAmt = Running.tenMins;
            sprintAmt = Sprints.four;
        }
    }
}
