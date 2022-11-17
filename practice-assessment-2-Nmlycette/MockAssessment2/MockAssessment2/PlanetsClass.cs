using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment2
{
    public class PlanetsClass
    {
        public static List<string> ConvertPlanets(string[] planetsArray)
        {
            List<string> planetList = planetsArray.Reverse().ToList();
            return planetList;
        }
    }
}