using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int count = vals.Length;
            if(count % 2 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsNumberEven(int number)
        {
            if(number % 2 != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0 || num == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if(numbers == null)
            {
                return 0;
            }

            if(numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;

            if (length1 <= length2)
            {
                return length1;
            }
            else
            {
                return length2;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int val = 0;
                foreach (int i in numbers)
                {
                    val = val + i;
                }
                return val;
            }
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                int val = 0;
                foreach (int i in numbers)
                {
                    if (i % 2 == 0)
                    {
                        val = val + i;
                    }
                }
                return val;
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            else
            {
                int val = 0;
                bool b = true;

                foreach (int i in numbers)
                {
                    val = val + i;
                }

                if (val % 2 == 0)
                {
                    b = false;
                }

                return b;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;

            for (int i = 0; i < number ; i++)
            {
                if (i % 2 != 0 && i > 0)
                {
                    count += 1;
                }
                
            }

            return count;
        
        }
    }
}
