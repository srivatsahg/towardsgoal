using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MaxIntegerArray
{
    public class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Maximum element : ");
           Console.WriteLine(new MaximumCalculator().returnMaximumSingleDigitArrayElement());

            Console.WriteLine("Trimming cost : ");
            Console.WriteLine(new StringDeletion().returnTrimmingCost());
            Console.ReadLine();
        }
    }


    public class StringDeletion
    {
        //public int[] costList = { 1, 2, 1, 2, 1, 2 };
        //string sampleString = "aabbcc";

        public int[] costList = { 0, 1, 2, 3, 4, 5 };
        string sampleString = "abccbd";

        public StringDeletion()
        {

        }
        public int returnTrimmingCost()
        {
            int cost = 0;
            char[] characterArray = sampleString.ToCharArray();

            if (costList.Length != characterArray.Length)
            {
                return 0;
            }

            for (int i = 0; i < characterArray.Length - 1; i++)
            {
                if(characterArray[i] == characterArray[i + 1])
                {
                    //cost
                    cost += costList[i];

                    //delete
                    characterArray = characterArray.Where((source, index) => index != i).ToArray();
                    costList = costList.Where((source, index) => index != i).ToArray();
                }
            }
            return cost;
        }


    }


    public class MaximumCalculator 
    {
        //public int[] arrayInput = { -6, -91, 1001, -100, -22, 0, 1, 473 };
        public int[] arrayInput = { -16, -91, 1001, -100, -22, 9, 4, 473 };

        public MaximumCalculator()
        {

        }

        public int returnMaximumSingleDigitArrayElement()
        {
            int max = 0;
            for (int i = 0; i < arrayInput.Length; i++)
            {
                if(arrayInput[i] >= -9 && arrayInput[i] <= 9)
                {
                    max = Math.Max(max, arrayInput[i]);
                }
            }
            return max;
        }
    }

}
