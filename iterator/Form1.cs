using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iterator
{
    public partial class Form1 : Form
    {

        Aggregate agg = new ConcreteAggregate();                 //Creates new instance of ConcreteAggregate()
        Iterator mostIterator;
        Iterator leastIterator;                                  //Creates the two iterators most and least
        public Form1()
        {
            InitializeComponent();
            prepareAggWithIter();                                //Inserts the aggragate information into the most and least iterator.
        }


        private void prepareAggWithIter()
        {
            agg.Elements.Add("Lebron James              1920");
            agg.Elements.Add("Kevin Love                  1234");
            agg.Elements.Add("Kyrie Irving                   1041");
            agg.Elements.Add("J.R. Smith                      955");
            agg.Elements.Add("Tristan Thompson         643");
            agg.Elements.Add("Matthew Dellavedova   569");
            agg.Elements.Add("Timofey Mozgov            475");
            agg.Elements.Add("Channing Frye               425");
            agg.Elements.Add("Richard Jefferson          410");
            agg.Elements.Add("Mo Williams                   338");
            agg.Elements.Add("Iman Shumpert              311");
            agg.Elements.Add("James Jones                 178");
            agg.Elements.Add("Jordan McRae                99");
            agg.Elements.Add("Sasha Kaun                    23");
            agg.Elements.Add("Dahntay Jones                13");
            mostIterator = agg.createMostIterator();
            leastIterator = agg.createLeastIterator();
        }

        private void iterateLeastBtn_Click(object sender, EventArgs e)
        {
            iterateList.Items.Clear();

            for (leastIterator.first(); !leastIterator.isDone(); leastIterator.next())
            {
                iterateList.Items.Add(leastIterator.currItem());
            }
        }

        private void iterateMostButton_Click(object sender, EventArgs e)
        {
            iterateList.Items.Clear();

            for (mostIterator.first(); !mostIterator.isDone(); mostIterator.next())
            {
                iterateList.Items.Add(mostIterator.currItem());
            }
            
        }
    }
}
