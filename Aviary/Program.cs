using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviary
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.Run(new GUIFormMain());
            //////Import Analytical results file (.csv)
            //Analytical Samples = new Analytical();
            
            //////Import remedial objectives file (.csv)
            //Objectives RemObjs = new Objectives();
            
            //////Perform comparison and output comparison assessment
            //Comparison myComparison = new Comparison(Samples, RemObjs);

            //////Output in report format
            //Output.Report(myComparison);

        }
    }
}
