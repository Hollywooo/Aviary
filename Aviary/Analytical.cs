using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Aviary
{
    class Analytical
    {
        public string AnalyticalSource;
        public string[] SampleID;
        public string[] CASNum;
        public double[] Result;
        public string[] Units;

        public Analytical()
        {
            //import objectives from .csv file
            List<string> listCASNum = new List<string>();
            List<string> listSampleID = new List<string>();
            List<double> listResult = new List<double>();
            List<string> listUnits = new List<string>();

            //get the file location
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = "C:\\Users\\jsirk\\Dropbox\\GB Files\\C#\\Aviary\\";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(OFD.OpenFile()))
                {
                    //Store the file location for future reference
                    AnalyticalSource = Convert.ToString(OFD);

                    //use Streamreader to pull in each line of the .csv
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        listSampleID.Add(values[0]);
                        listCASNum.Add(values[1]);
                        listResult.Add(Convert.ToDouble(values[2]));
                        listUnits.Add(values[3]);

                    }
                    reader.Close();
                }

                int x = 0;
                //assign dimensions to the arrays
                SampleID = new string[listSampleID.Count];
                CASNum = new string[listCASNum.Count];
                Result = new double[listResult.Count];
                Units = new string[listUnits.Count];

                //populate the arrays
                foreach (string ID in listSampleID)
                {
                    SampleID[x] = ID;
                    x++;
                }
                x = 0;
                foreach (string CAS in listCASNum)
                {
                    CASNum[x] = CAS;
                    x++;
                }
                x = 0;
                foreach (double res in listResult)
                {
                    Result[x] = res;
                    x++;
                }
                x = 0;
                foreach (string unit in listUnits)
                {
                    Units[x] = unit;
                    x++;
                }

            }
            else { }
            
        }
        
    }
}
