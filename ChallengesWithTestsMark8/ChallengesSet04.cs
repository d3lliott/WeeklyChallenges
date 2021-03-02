using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int x = 0;
            foreach (int i in numbers)
            { if (i % 2 == 0)
                    x += i;
                else
                    x -= i;

            }
            return x;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int x;
            if (str1.Length < str2.Length)
                x = str1.Length;
            else
                x = str2.Length;

            if (str3.Length < x)
                x = str3.Length;

            if (str4.Length < x)
                x = str4.Length;

            return x;

            
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int x;

            if (number1 < number2)
                x = number1;
            else
                x = number2;

            if (number3 < x)
                x = number3;

            if (number4 < x)
                x = number4;

            return x;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            Console.WriteLine(biz.Name);


            
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 || sideLength2 + sideLength3 <= sideLength1 || sideLength1 + sideLength3 <= sideLength2)
                return false;
            else
                return true;
            
          
        }

        public bool IsStringANumber(string input)
        {
            int x = 0;
            if (input == null || input.Length == 0)
                return false;
            foreach (char c in input)
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9' || c == '-' || c == '.')
                    x += 0;
                else
                    x += 1;

            if (x == 0)
                return true;
            else
                return false;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int x = 0;
            int y = 0;
           for(int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                    x += 1;
                else
                    y += 1;
            }
            if (x > y)
                return true;
            else
                return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;
            double y = 0;
            double x = 0;

            foreach (double i in numbers)
                if (i % 2 == 0)
                {
                    x += i;
                    y += 1;
                }
            if (x == 0)
                return 0;

            return x/y;
        }

        public int Factorial(int number)
        {
            int x = number;
            if (number < 0)
                throw new ArgumentOutOfRangeException();
            if (number == 0)
                return 1;
            for (int i = number - 1; i > 0; i--)
                x *= i;

            return x;


                
        }
    }
}
