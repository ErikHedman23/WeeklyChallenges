using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            var a = char.ToLower(c);
            var alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v','w', 'x', 'y', 'z' };
            for(int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == char.ToLower(c))
                {
                    return true;
               }

            }
            return false;

            //return char.IsLetter(c);
            
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

                    
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Min() + numbers.Max();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {

            return (str1.Length < str2.Length) ? str1.Length : str2.Length;
            //if (str1.Length < str2.Length)
            //{
            //    return str1.Length;
            //}
            //else
            //{
            //    return str2.Length;
            //}
        }

        public int Sum(int[] numbers)
        {
            
            {
                if (numbers == null || numbers.Length == 0)
                {
                    return 0;
                }
            }
            
            
            return numbers.Sum();
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if(numbers == null)
            {
                return 0;
            }

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                } 
                
              
            }
            return sum;
            //return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            return (numbers == null) ? false : (numbers.Sum() % 2 != 0);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;
            for (long i = number - 1; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;

            
        }
    }
}
