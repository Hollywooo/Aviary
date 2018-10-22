using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Aviary
{
    class Output
    {
        public static void Report(Comparison inputComp)
        {
            string report = null;
            report = "Remedial Objectives Comparison" + "\r\n"
                + $"{DateTime.Now}" + "\r\n"
                + "Analytical File: " + inputComp.AnalyticalComp.AnalyticalSource + "\r\n"
                + "RO File: " + inputComp.ObjectivesComp.ObjectivesName + "\r\n\r\n";

            int iter = 0;
            var id = "ID";
            var cas = "CAS_NUMBER";
            var result = "RESULT";
            var units = "RESULT_UNITS";
            var ro = "RO";
            var compResult = "COMPARISON_RESULT";

            for (iter = 0; iter < inputComp.AnalyticalComp.SampleID.Length - 1 ; iter++)
            {
                id = inputComp.AnalyticalComp.SampleID[iter];
                cas = inputComp.AnalyticalComp.CASNum[iter];
                result = Convert.ToString(inputComp.AnalyticalComp.Result[iter]);
                units = inputComp.AnalyticalComp.Units[iter];
                ro = inputComp.ComparisonResult[iter].ROUsed.ToString();
                compResult = inputComp.ComparisonResult[iter].Result.ToString();

                report = report + $"{id}" + "," + $"{cas}" + "," + $"{result}" + "," + $"{units}" + "," + $"{ro}" + "," + $"{compResult}" + "\r\n"; //and so forth, comma-delimited

            }


            File.WriteAllText("C:\\Users\\jsirk\\Dropbox\\GB Files\\C#\\Aviary\\Output\\Report.txt", report);
        }
    }
}
