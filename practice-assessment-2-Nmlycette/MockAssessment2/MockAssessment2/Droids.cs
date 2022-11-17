using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment2
{
    public static class Droids
    {
        public static double AverageDroids(List<int> intListForDroids)
        {
            double droidAvg = 0;
            List<int> evenDroidList = new List<int>();

            foreach (int droid in intListForDroids)
            {
                if (droid % 2 == 0)
                {
                    evenDroidList.Add(droid);
                }
            }
            droidAvg = evenDroidList.Average();
            return droidAvg;
        }
    }
}
