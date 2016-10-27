using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task2.RealТumberExpansion;
using NUnit.Framework;

namespace Task2.Tests
{
    [TestFixture]
    public class RealТumberExpansionTests
    {
        [TestCase(Math.PI, ExpectedResult = "0 10000000000 1, 1001001000011111101101010100010001000010110100011000")]
        [TestCase(Math.E, ExpectedResult =  "0 10000000000 1, 0101101111110000101010001011000101000101011101101001")]
        public string BinaryRepresentation_СalculationSqrtRootOfNumberWithAccuracy(double number)
        {
            BitArray array;           
            return number.BinaryRepresentation(out array,true);
        }
    }
}
