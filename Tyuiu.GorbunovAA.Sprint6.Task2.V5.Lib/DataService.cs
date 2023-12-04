using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GorbunovAA.Sprint6.Task2.V5.Lib
{
    public class DataService : ISprint6Task2V5
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res;
            int len = (stopValue - startValue) + 1;
            res = new double[len];
            int count = 0;
            for (int i = startValue; i <= stopValue; ++i)
            {
                if (Math.Cos(i) - 2 * i == 0)
                    {
                    res[count] = 0;
                    count++;
                }
                else
                {
                    double x = (2 * i - 3) / (Math.Cos(i) - 2 * i) + 5 * i - 6;
                    res[count] = Math.Round(x, 2); 
                    count++;

                }

            }
            return res;
        }


    }
}
