using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Task1.NewtonRootLogic;

namespace Task1.Tests
{
    [TestFixture]
    public class NewtonRootLogicTests
    {
        [TestCase(2, 8, 0.1, ExpectedResult = 2.8)]
        [TestCase(2, 8, 1, ExpectedResult = 3)]
        [TestCase(3, 8, 0.0000001, ExpectedResult = 2)]
        public double SqrtN_СalculationSqrtRootOfNumberWithAccuracy(int power, double number, double accuracy)
        {
            return SqrtN(power, number, accuracy);
        }

        [TestCase(2, 8, 124.1)]
        [TestCase(0, 8, 0.0000001)]
        public void SqrtN_TestForArgumentOutOfRangeException(int power, double number, double accuracy)
        {
            Assert.That(() => SqrtN(power, number, accuracy) , Throws.TypeOf<ArgumentOutOfRangeException>());
        }


    }
}
