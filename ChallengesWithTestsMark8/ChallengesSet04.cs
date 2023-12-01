using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0;
            }
            int total = 0;
            foreach(int i in numbers)
            {
                if (i % 2 != 0)
                {
                    total -= i;
                }
                else
                {
                    total += i;
                }
            }
            return total;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] lengths = { str1.Length, str2.Length, str3.Length, str4.Length };
            return lengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
           
            return;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
          if(sideLength1 + sideLength2 > sideLength3
                && sideLength1 + sideLength3 > sideLength2
                && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            var isNum = double.TryParse(input,out _);
            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = objs.Count(x => x == null);
            int nonNull = objs.Count(x => x != null);

            if(nullCount > nonNull)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            

            if (numbers == null) 
            {
                return 0;
            }

            var evens = numbers.Where(x => (x % 2) == 0);
            if (evens.Count() != 0)
            {
                return evens.Average();
            }
            else
            {
                return 0;
            }
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();   
            }

            int num = 1;
            if (num == 0)
            {
                return 1;
            }

            for(int i = 1; i < number + 1; i++)
            {
                num *= i;
            }
            return num;
        }
    }
}
