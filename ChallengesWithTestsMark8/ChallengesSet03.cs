using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            int arrayLength = vals.Length;

            for (int i = 0; i < arrayLength; i++)
                if (vals[i] == false)
                {
                    return true;
                }

            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int counter = 0;
            int listSize = numbers.Count();
            if (listSize == 0)
            {
                return false;
            }
            if (numbers == null)
            {
                return false;
            }

            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    counter = counter + i;
                }
            }

            if (counter % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = password.Any(char.IsUpper);
            bool lower = password.Any(char.IsLower);
            bool number = password.Any(char.IsNumber);

            if (password.Length == 0)
            {
                return false;
            }

            if (upper && lower && number == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            int valLength = val.Length;
            return val[valLength - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }

        }

        public int LastMinusFirst(int[] nums)
        {
            int numsLength = nums.Length;
            return nums[numsLength - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    numbers.Add(i);
                }
            }

            return numbers.ToArray();
        }

        public void ChangeAllElementsToUppercase1(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }

        public void ChangeAllElementsToUppercase(string[] values)
        {
            throw new NotImplementedException();
        }
    }
}
