using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else if (i % 2 != 0)
                {
                    sum -= i;
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //if(str1.Length <= str2.Length && str1.Length <= str3.Length && str1.Length <= str4.Length)
            //{
            //    return str1.Length;
            //}
            //else if (str2.Length <= str1.Length && str2.Length <= str3.Length && str2.Length <= str4.Length)
            //{
            //    return str2.Length;
            //}
            //else if (str3.Length <= str1.Length && str3.Length <= str2.Length && str3.Length < str4.Length)
            //{
            //    return str3.Length;
            //}
            //else
            //{
            //    return str4.Length;
            //}

            var list = new List<string> { str1, str2, str3, str4 };

            return list.Min(str => str.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var list = new List<int> { number1, number2, number3, number4 };

            var smallestNum = list.Min();
            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {

            biz.Name = "TrueCoders";
            Console.WriteLine(biz.Name);
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength2 + sideLength3 <= sideLength1 || sideLength1 + sideLength3 <= sideLength2)
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {

            return double.TryParse(input, out double outPut);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            return objs.Where(x => x == null).Count() > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            var list = new List<int>();
            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    list.Add(numbers[i]);
                }

            }
            if (list.Count() == 0)
            {
                return 0;
            }
            {

            }
            return list.Average();


        }

        public int Factorial(int number)
        {
            var result = 1;
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
