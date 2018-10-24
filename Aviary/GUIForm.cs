using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviary
{
    public partial class GUIFormMain : Form
    {
        private Comparison results { get; set; }
        private Analytical ana { get; set; }
        private Objectives obj { get; set; }

        public GUIFormMain()
        {
            InitializeComponent();
        }

        private void buttonLoadROs_Click(object sender, EventArgs e)
        {
            obj = new Objectives();
        }

        private void buttonLoadAnalytical_Click(object sender, EventArgs e)
        {
            ana = new Analytical();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonPerformComp_Click(object sender, EventArgs e)
        {
            ////Display results in listbox
            results = new Comparison(ana, obj);
            List<string> display = new List<string>();

            int iter = 0;
            var id = "ID";
            var cas = "CAS_NUMBER";
            var result = "RESULT";
            var units = "RESULT_UNITS";
            var ro = "RO";
            var compResult = "COMPARISON_RESULT";
            string reportStart = $"{id}" + "\t" + $"{cas}" + "\t" + $"{result}" + "\t" + $"{units}" + "\t" + $"{ro}" + "\t" + $"{compResult}"; //header text build
            string reportLine = "";

            display.Add(reportStart);

            for (iter = 0; iter < results.AnalyticalComp.SampleID.Length - 1; iter++)
            {
                id = results.AnalyticalComp.SampleID[iter];
                cas = results.AnalyticalComp.CASNum[iter];
                result = Convert.ToString(results.AnalyticalComp.Result[iter]);
                units = results.AnalyticalComp.Units[iter];
                ro = results.ComparisonResult[iter].ROUsed.ToString();
                compResult = results.ComparisonResult[iter].Result.ToString();

                
                reportLine = $"{id}" + "\t" + $"{cas}" + "\t" + $"{result}" + "\t" + $"{units}" + "\t" + $"{ro}" + "\t" + $"{compResult}"; //tab delimited text build
                display.Add(reportLine);

            }

            listBoxDisplayResults.DataSource = display;

        }

        private void buttonExportToCSV_Click(object sender, EventArgs e)
        {
            ////Export a csv            
            Output.Report(results);            
        }

        private void GUIFormMain_Load(object sender, EventArgs e)
        {
            
        }

        private void listBoxDisplayResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
