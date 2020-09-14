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

            Console.WriteLine("Rotate Array : ");
            Console.WriteLine(new RotateArray().rotateArray(2));
            Console.ReadLine();
        }
    }

    public class RotateArray
    {
        int[] arrElements = { 3, 4, 2, 1 };
        int rotateNumber = 2;

        public RotateArray()
        {

        }

        public int[] rotateArray(int rotationCount)
        {
            #region Approach using Array Copy 
            while (rotationCount > 0)
            {
                //rotate array
                int firstElement = arrElements[0];
                Array.Copy(arrElements, 1, arrElements, 0, arrElements.Length - 1);
                arrElements[arrElements.Length - 1] = firstElement;

                //reduce rotate count
                rotationCount--;
            }

            #endregion


            #region Using Stacks
            //var stack = new Stack();

            //foreach (var item in arrElements)
            //{
            //    stack.Push(item);
            //}

            #endregion


            return arrElements;
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
