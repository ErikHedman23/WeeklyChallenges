using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null)
            {
                return false;
            }
            foreach (var item in words)
            {

                if (string.Equals(item, word, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal)) //if ignoreCase in the test unit is true, this ternary statement will call StringComparison.OrdinalIgnoreCase, which means, it will ignore the need to be case sensitive. If ignoreCase is false in the test, it will go to check StringComparison.Ordinal, which will check for case sensitive solutions.  
                {
                    return true;
                }
            }


            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 0)
            {
                return false;
            }
            if (num % num == 0 && num > 1 && num % 4 != 0 && num % 3 != 0 && num + 1 % 2 != 0 || num == 3)
            {
                return true;
            }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            //if (string.IsNullOrEmpty(str))
            //{
            //    return -1;
            //}
           for (int i = str.Length - 1; i >= 0; i--) //This for loop has to iterate from the last to the first element in order to find the LAST unique letter, not the first unique letter.  If we were trying to find the first unique letter, we would want to start at the beginning of the string and work to the end of it.
            {
                char currentChar = str[i];
                if (str.IndexOf(currentChar) == str.LastIndexOf(currentChar)) //IndexOf(currentChar) is displaying the index of the current char being looped through.  LastIndexOf(currentChar) is showing the last index of the given char.  If the IndexOf and the LastIndexOf the char are the same, we display that current index i.
                {
                    return i;
                }
            }
            return -1; //if there is no value in the string, return a negative index of -1, indicating there is nothing in the list.
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var maxCount = 1;
            var currentCount = 1;
            for (int i = 1; i < numbers.Length; i++) //i is starting at index 1 because of the if statement checking the number prior to the current number.  If we started the loop at zero, it would throw an out of bounds exception because there is nothing to check before the first number in the array.
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1; //as the loop moves through the array, if the number is not equal to the previous number, the currentCount gets reset back to zero.  
                }
                if (currentCount > maxCount) 
                {
                    maxCount = currentCount; //maxCount is storing the data of currentCount everytime currentCount is greater than maxCount. maxCount only changes when currentCount becomes greater than maxCount
                }
                
            }
            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 1 || n > elements.Count - 1  && elements.Count > 1)
            {
                return new double[0];
            }
            if (elements.Count == 1)
            {
                return elements.ToArray();
            }
           
            var result = new List<double>();

            for(int i = n - 1; i < elements.Count; i += n)
            {

                result.Add(elements[i]);
                
            }
            return result.ToArray();
        }
    }
}
