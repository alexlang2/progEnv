using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facadePattern
{
    public class Diet
    {
        public enum Vegetables { low, medium, high}             //Declaring all the possible diet options
        public enum Protein { low, medium, high}
        public enum Fat { low, medium, high}

        public Vegetables vegAmt;
        public Protein proAmt;
        public Fat fatAmt;


        public void toneDiet()                                 //Tone muscle diet specifications
        {
            vegAmt = Vegetables.high;
            proAmt = Protein.medium;
            fatAmt = Fat.low;
        }

        public void bulkDiet()                                 // Bulking diet specifications
        {
            vegAmt = Vegetables.medium;
            proAmt = Protein.high;
            fatAmt = Fat.high;
        }

    }
}
