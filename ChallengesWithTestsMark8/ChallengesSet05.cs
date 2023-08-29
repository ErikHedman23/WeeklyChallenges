using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading;
using System.Xml.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {

            for (int i = startNumber + 1; i <= startNumber + n; i++)
            {
                if (i % n == 0)
                {
                    return i;
                }

            }
            return 0;


        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            //if (numbers == null) return false;
            //if (numbers.Length == 1) return true;
            //bool result = false;
            //for(int i = 1; i < numbers.Length; i++)
            //{
            //    if (numbers[i] >= numbers[i - 1])
            //    {
            //        result = true;
            //    }

            //    else
            //    {
            //        result = false;
            //        break;
            //    }

            //}
            //return result;

            return (numbers == null || numbers.Length == 0) ? false : numbers.SequenceEqual(numbers.OrderBy(x => x).ToArray());
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            var list = new List<int>();
            if (numbers == null)
            {
                return 0;
            }
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    list.Add(numbers[i + 1]);

                }
            }
            return list.Sum();
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            var sentenceList = new List<string>();

            if (words == null)
            {
                return "";
            }

            foreach (var item in words)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    sentenceList.Add(item.Trim());
                }
            }

            if (sentenceList.Count > 0)
            {
                sentenceList[sentenceList.Count - 1] += ".";
            }

            return string.Join(" ", sentenceList);
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            var list = new List<double>();
            if (elements == null)
            {
                return new double[0]; //In order to have it return nothing for if elements == null, create something that holds nothing, i.e.; a double array with a Length of 0 
            }
            
            for(int i = 3; i < elements.Count; i += 4) //Since you are adding every fourth element to a new list, start your for loop at the fourth element "3" and count up to the last element, i < elements.Count
            {
                list.Add(elements[i]);
            }
            return list.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            for(int i = 0; i < nums.Length; i++)
            {
                var num1 = nums[i];
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var num2 = nums[j];
                    if (num1 + num2 == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
