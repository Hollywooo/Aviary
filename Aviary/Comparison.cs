using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aviary
{
    class Comparison
    {
        public Analytical AnalyticalComp;
        public Objectives ObjectivesComp;
        //public string ObjectivesName; //identifier of the name of the objectives used in the comparison (future addition)
        public List<ROResultPair> ComparisonResult;

        public Comparison(Analytical ana, Objectives obj)
        {
            AnalyticalComp = ana;
            ObjectivesComp = obj;
            ComparisonResult = CompareObjs(AnalyticalComp, ObjectivesComp);
        }

        public static List<ROResultPair> CompareObjs(Analytical ana, Objectives obj)  //20181019: JS - convert to list of type ROResultPair
        {
            
            List<ROResultPair> comparisonCompiled = new List<ROResultPair>();
            int iter, casCounter = 0;

            for(iter = 0; iter < ana.SampleID.Length; iter++)
            {
                for(casCounter = 0; casCounter < obj.CASNum.Length; casCounter++)
                {
                    ROResultPair pair = new ROResultPair(-9999, "NO RESULT");
                    if (ana.CASNum[iter] == obj.CASNum[casCounter] && ana.Units[iter].ToLower() == obj.Units[casCounter].ToLower())
                    {
                        if (ana.Result[iter] > obj.Objective[casCounter])
                        {
                            pair.Result = "Exceedance";
                            pair.ROUsed = obj.Objective[casCounter];
                            comparisonCompiled.Add(pair);
                            break;
                        }

                        else if (ana.Result[iter] <= obj.Objective[casCounter])
                        {
                            pair.Result = "No Exceedance";
                            pair.ROUsed = obj.Objective[casCounter];
                            comparisonCompiled.Add(pair);
                            break;
                        }

                        else
                        {
                            pair.Result = "ERROR - Invalid Comparison";
                            pair.ROUsed = -9999;
                            comparisonCompiled.Add(pair);
                            break;
                        }

                        //comparisonCompiled.Add(pair);
                    }

                    else if (casCounter == obj.CASNum.Length - 1)
                    {
                        pair.Result = "ERROR - Invalid Comparison";
                        pair.ROUsed = -9999;
                        comparisonCompiled.Add(pair);
                    }

                    else { } 

                }
                
            }
            
            return comparisonCompiled;
        }

    }
}
