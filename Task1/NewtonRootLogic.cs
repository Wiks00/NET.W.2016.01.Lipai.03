using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class NewtonRootLogic
    {

        /// <summary>
        /// Calculate Newton root of number whith predetermined power and accuracy 
        /// </summary>
        /// <param name="power">Power of root</param>
        /// <param name="number">Number what we will root</param>
        /// <param name="accuracy">Accuracy of calculating</param>
        /// <returns>Double number with accuracy</returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static double SqrtN(double power, double number, double accuracy = 0.0001)
        {
            if (power <= 0)
                throw new ArgumentOutOfRangeException();
            if (accuracy > 1)
                throw new ArgumentOutOfRangeException();


            double x0 = number / power;
            double x1 = 1 / power * ((power - 1) * x0 + number / Math.Pow(x0, power - 1));

            while (Math.Abs(x1 - x0) > accuracy)
            {
                x0 = x1;
                x1 = 1 / power * ((power - 1) * x0 + number / Math.Pow(x0, power - 1));
            }

            var acc = accuracy.ToString().Split(',');

            return Math.Round(x1, acc.Length == 1 ? 1 : acc[1].Length);

        }

    }
}
