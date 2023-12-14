using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int i = startNumber;
            bool div = false;
            do
            {
                i++;
                if (i % n == 0)
                {
                    div = true;
                }

                

            } while (div == false);
            return i;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(var i = 0; i < businesses.Length; i++)
            { 
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for (int i = 1; i < numbers.Length; i++)
            {
                
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }
            int x = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {

                if (numbers[i] % 2 == 0)
                {
                    x += numbers[i + 1];
                }
            }
            return x;
        }
        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }
            string sentence = "";
            foreach (string i in words)
            {
                if (i.Trim().Length > 0)
                {
                    sentence += i.Trim() + " ";
                }
            }
            if (sentence.Length == 0)
            {
                return "";
            }
            
            sentence = sentence.Trim();
            sentence += ".";
            return sentence; 
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            List<double> goFour = new List<double>();

            for(var i = 3; i < elements.Count; i += 4)
            {
                goFour.Add(elements[i]);
            }
            return goFour.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            int total;

            for (int i = 0; i < nums.Length; i++)
            {

                for (int j = i + 1; j < nums.Length; j++)
                {

                        total = nums[i] + nums[j];
                        
                        if (total == targetNumber)
                        {
                            return true;
                        }
                }
            }

            return false;

        }
    }
}
