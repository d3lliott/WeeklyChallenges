﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;
            if (string.Equals (words, null) || words.Contains(null))
            {
                return false;
            }
            if (ignoreCase == true)
            {
                word = word.ToLower();
                List<string> lc = words.Select(x => x.ToLower()).ToList();
                containsWord = lc.Contains(word);
            }
            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);
            }
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num == 1 || num <= 0)
                return false;
            if (num == 2 || num == 3 || num == 5)
                return true;
            if (num % 2 != 0 && num % 3 != 0 && num % 5 != 0 && num % 7 != 0 && num % 11 != 0 && num % 13 != 0)
                return true;
            else
                return false;
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;
                for(int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    {
                        uIndex = false;
                    }
                }
                if (uIndex == true)
                {
                    index = i;
                }
                    
            }
            return index;

            //str.IndexOf();
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int x = 0;
            int y = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    x += 1;
                    if (x > y)
                    {
                        y = x;
                    }

                }
                else
                    x = 0;
            }
            return y + 1;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            double[] x = new double[0];
            if (elements == null || n <= 0)
                return x;
            List<double> y = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                y.Add(elements[i]);
            }
            return y.ToArray();
        }
    }
}
