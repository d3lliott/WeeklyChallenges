using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if (Char.IsLetter(c))
                return true;
            else
                return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var x = vals.Length;
            if (x % 2 == 0)
                return true;
            else
                return false;
               
            
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
                return false;
            else
                return true;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null)
                return 0;
            if (numbers.Count() == 0)
                return 0;
            return numbers.Min() + numbers.Max();


        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var x = str1.Length;
            var y = str2.Length;
            if (x < y)
                return x;
            else
                return y;
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
                return 0;
                
            for (int x = 0; x < numbers.Length; x++)
            {
               
                if (numbers.Length >= 0)
                    sum += numbers[x];
                
                else
                    sum = 0;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
                return 0;
            int sum = 0;
            foreach (int i in numbers)
                if (i % 2 == 0)
                {
                    sum += i;
                }
            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
                return false;
            int res = numbers.AsQueryable().Sum();
          
            if (res % 2 == 0)
                return false;
            else
                return true;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number >= 0)
                return number / 2;
            else
                return 0;

           
        }

    }
}
