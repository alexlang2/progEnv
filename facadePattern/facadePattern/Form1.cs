using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace facadePattern
{
    public partial class Form1 : Form
    {

        WorkoutFacade wf;
        Diet diet;
        Conditioning condition;
        Lifting lift;

        public Form1()
        {
            InitializeComponent();
            diet = new Diet();
            condition = new Conditioning();
            lift = new Lifting();
            wf = new WorkoutFacade(diet, condition, lift);
        }

      

        public void updateText()
        {
            weightTxt.Text = lift.weightAmt.ToString();   //Updates the textboxes based on button click
            setsTxt.Text = lift.setAmt.ToString();
            repsTxt.Text = lift.repAmt.ToString();
            runTxt.Text = condition.runAmt.ToString();
            sprintTxt.Text = condition.sprintAmt.ToString();
            vegTxt.Text = diet.vegAmt.ToString();
            proteinTxt.Text = diet.proAmt.ToString();
            fatTxt.Text = diet.fatAmt.ToString();
        }

        private void toneBtn_Click(object sender, EventArgs e)
        {

            wf.toning();                                  //Facade pattern, changes all textboxes to fit toning options
            updateText();
            
        }

        private void bulkBtn_Click(object sender, EventArgs e)
        {
            wf.bulking();                                 //Facade pattern, changes all textboxes to fit bulking options
            updateText();
        }
    }
}
