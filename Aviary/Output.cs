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
        public static void TextReport(Comparison inputComp)
        {
            string textReport = null;
            textReport = "***DRAFT REPORT TEXT***" + "\r\n"
                + $"{DateTime.Now}" + "\r\n"
                + "Analytical File: " + inputComp.AnalyticalComp.AnalyticalSource + "\r\n"
                + "RO File: " + inputComp.ObjectivesComp.ObjectivesName + "\r\n\r\n";

            int iter = 0;
            

            //Build exceedance and non-exceedance strings
            string exceedances = "x";
            string nonexceedances = "x";
                      
            //Find Exceedances and non-exceedances
            for (iter = 0; iter < inputComp.AnalyticalComp.SampleID.Length - 1; iter++)
            {
                var id = "ID";
                var cas = "CAS_NUMBER";
                //var result = "RESULT";
                //var units = "RESULT_UNITS";
                //var ro = "RO";
                var compResult = "COMPARISON_RESULT";

                //pull comparison values and convert to text
                id = inputComp.AnalyticalComp.SampleID[iter].ToString();
                cas = inputComp.AnalyticalComp.CASNum[iter].ToString();
                compResult = inputComp.ComparisonResult[iter].Result.ToString();

                //identify comparison result type
                if (compResult == "Exceedance")
                {
                    if (exceedances.Length > 1)
                    {
                        exceedances = exceedances + ", " + $"{id}" + " (" + $"{cas}" + ")";
                    }
                    else if (!(exceedances.Length > 1))
                    {
                        exceedances = $"{id}" + " (" + $"{cas}" + ")";
                    }
                    else
                    {
                        exceedances = exceedances + " ERROR AT <" + $"{id}" + " " + $"{cas}" + ">";
                    }
                }

                else if (compResult == "No Exceedance")
                {
                    if (nonexceedances.Length > 1)
                    {
                        nonexceedances = nonexceedances + ", " + $"{id}" + " (" + $"{cas}" + ")";
                    }
                    else if (!(nonexceedances.Length > 1))
                    {
                        nonexceedances = $"{id}" + " (" + $"{cas}" + ")";
                    }
                    else
                    {
                        nonexceedances = nonexceedances + " [ERROR AT <" + $"{id}" + " " + $"{cas}" + ">]";
                    }
                }
            }

            //Compile the header and exceedance/nonexceedance text
            textReport = textReport + "The following locations did not exceed for the identified analytes: " + $"{nonexceedances}" + "." + "\r\n"
                + "The following locations exceeded for the identified analytes: " + $"{exceedances}" + ".";
            
            File.WriteAllText("C:\\Users\\jsirk\\Dropbox\\GB Files\\C#\\Aviary\\Output\\TextReport.txt", textReport);

        }

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

        public static List<string> ListBoxHeader()
        {
            List<string> display = new List<string>();
            var id = "ID";
            var cas = "CAS_NUMBER";
            var result = "RESULT";
            var units = "RESULT_UNITS";
            var ro = "RO";
            var compResult = "COMPARISON_RESULT";
            string reportStart = $"{id}" + "\t" + $"{cas}" + "\t" + $"{result}" + "\t" + $"{units}" + "\t" + $"{ro}" + "\t" + $"{compResult}"; //header text build
            display.Add(reportStart);

            return display;
        }

        public static List<string> ListBoxBody(Comparison inputComp, List<string> listIn)
        {
            int iter = 0;
            string reportLine = "";
            var id = "ID";
            var cas = "CAS_NUMBER";
            var result = "RESULT";
            var units = "RESULT_UNITS";
            var ro = "RO";
            var compResult = "COMPARISON_RESULT";

            for (iter = 0; iter < inputComp.AnalyticalComp.SampleID.Length - 1; iter++)
            {
                id = inputComp.AnalyticalComp.SampleID[iter];
                cas = inputComp.AnalyticalComp.CASNum[iter];
                result = Convert.ToString(inputComp.AnalyticalComp.Result[iter]);
                units = inputComp.AnalyticalComp.Units[iter];
                ro = inputComp.ComparisonResult[iter].ROUsed.ToString();
                compResult = inputComp.ComparisonResult[iter].Result.ToString();

                reportLine = $"{id}" + "\t" + $"{cas}" + "\t" + $"{result}" + "\t" + $"{units}" + "\t" + $"{ro}" + "\t" + $"{compResult}"; //tab delimited text build
                listIn.Add(reportLine);
            }

            return listIn;
        }


        public static List<string> ListBoxOutput(Comparison inputComp)
        {
            List<string> display = ListBoxBody(inputComp, ListBoxHeader());
            return display;
        }

        public static List<string> ListBoxOutputXCDOnly(Comparison inputComp)
        {
            List<string> displaySource = ListBoxBody(inputComp, ListBoxHeader());
            List<string> displayXCDOnly = ListBoxHeader();

            foreach (string entry in displaySource)
            {
                if (entry.Contains("Exceedance") && !entry.Contains("No"))
                {
                    displayXCDOnly.Add(entry);
                }
                else { }
            }

            return displayXCDOnly;
        }
    }
}
