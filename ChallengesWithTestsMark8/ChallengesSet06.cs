using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            if(string.Equals(null, words) || words.Contains(null))
            {
                return false;
            }
            bool hasWord = false;
  
            if (ignoreCase == true)
            {
                words = words.Select(x => x.ToLower());
                word = word.ToLower();
                hasWord = words.Contains(word);
            }

            if (ignoreCase == false)
            {
                hasWord = words.Contains(word);
            }
            return hasWord;

        }


        public bool IsPrimeNumber(int num)
        {
           if(num is <= 0 || (num % 2 == 0 && num != 2) || num == 1)
            {
                return false;
            }

           for(int i = 2; i < num; i++)
            {
                if(num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            string distinct = new string(str.Distinct().ToArray());
            int size = distinct.Length;
            int place = -1;
            for(int i = 0; i < distinct.Length; i++)
            {
                var count = str.Count(x => x == distinct[i]);
                if(count == 1)
                {
                    place = str.IndexOf(distinct[i]);
                }
            }

            return place;

        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 1;
            int newCount = 1;
            for (int i = 0; i < numbers.Length - 1 ; i++)
            {

                if (numbers[i] == numbers[i + 1])
                {
                    newCount += 1;
                    if (newCount > count)
                    {
                        count+=1;
                    }
                }
                else
                    {
                    newCount = 1;
                    }
               
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var nth = new List<double>();
            if (elements == null|| n <= 0 || n > elements.Count)
            {
                return nth.ToArray();
            }
 
            for(var i = n - 1; i < elements.Count ; i += n)
            {
                nth.Add(elements[i]);
            }
            return nth.ToArray();
        }
    }
}
