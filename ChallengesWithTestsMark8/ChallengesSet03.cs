using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            foreach (bool tf in vals)
            {
                if (tf == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int n in numbers)
            {
                if (n % 2 != 0)
                {
                    sum += n;
                }

            }
            if (sum % 2 == 0)
            {
                return false;
            }
            return true;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            var check = password.Any(char.IsLower);
            var check_1 = password.Any(char.IsUpper);
            var check_2 = password.Any(char.IsNumber);
            return check && check_1 && check_2;



        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];

        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            int sum = 0;
            if (nums == null)
            {
                return 0;
            }
            else
            {
                sum += nums[nums.Length - 1] - nums[0];
            }
            return sum;
        }

        public int[] GetOddsBelow100()
        {
            var odds = new List<int> { };
            odds.ToList();
            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }
            var oddsToArray = odds.ToArray();
            return oddsToArray;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            
            for (int i = 0; i < words.Length; i++)
            {
               words[i] = words[i].ToUpper();
            }


        }
    }
}
