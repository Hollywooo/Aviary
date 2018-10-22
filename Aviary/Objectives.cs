using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Aviary
{
    class Objectives
    {
        public string ObjectivesName;
        public string[] CASNum;
        public double[] Objective;
        public string[] Units;

        public Objectives()
        {
            //import objectives from .csv file
            List<string> listCASNum = new List<string>();
            List<double> listObjective = new List<double>();
            List<string> listUnits = new List<string>();

            //get the file location
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = "C:\\Users\\jsirk\\Dropbox\\GB Files\\C#\\Aviary\\";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                //Store the file location for future reference
                ObjectivesName = Convert.ToString(OFD);

                //use Streamreader to pull in each line of the .csv
                using (var reader = new StreamReader(OFD.OpenFile()))
                {
                    
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        listCASNum.Add(values[0]);
                        listObjective.Add(Convert.ToDouble(values[1]));
                        listUnits.Add(values[2]);
                                                
                    }
                    reader.Close();
                }

                int x = 0;
                //assign dimensions to the arrays
                CASNum = new string[listCASNum.Count];
                Objective = new double[listObjective.Count];
                Units = new string[listUnits.Count];

                //populate the arrays
                foreach (string CAS in listCASNum)
                {
                    CASNum[x] = CAS;
                    x++;
                }
                x = 0;

                foreach(double obj in listObjective)
                {
                    Objective[x] = obj;
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
