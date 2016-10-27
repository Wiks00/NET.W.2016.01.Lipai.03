using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public static class RealТumberExpansion
    {
        /// <summary>
        /// Extension method that convert double value to binary representation
        /// </summary>
        /// <param name="number">double value</param>
        /// <param name="array">return Bitarray containing binary representation</param>
        /// <param name="converToString">dool value that allows to return string binary representation</param>
        /// <returns>string containing binary representation of number</returns>

        public static string BinaryRepresentation(this double number,out BitArray array,bool converToString = false)
        {
            StringBuilder binaryString = new StringBuilder();
            byte[] byteArray = BitConverter.GetBytes(number);
            BitArray bitArray = new BitArray(byteArray);

            array = bitArray;

            if (converToString != true)
                return null;

            for (int i = bitArray.Length - 1; i >= 0; i--)
            {
                if (i == 62)
                    binaryString.Append(" ");
                if (i == 51)
                    binaryString.Append(" 1, ");
                binaryString.Append(bitArray[i].Equals(false) ? "0" : "1");
            }

            return binaryString.ToString();
        }
    }
}
