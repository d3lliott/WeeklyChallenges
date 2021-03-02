using System;
using System.Collections.Generic;


namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            int y = 1;
            foreach(bool x in vals)
            {
                
                    if (x == false)
                    {
                        y++;
                    }
                    else
                    {
                        y = y + 0;
                    }
            }
            if (y >= 2)
                return true;
            else
                return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int x = 0;
            if (numbers == null)
                return false;

            foreach (int z in numbers)
            {
                if (z % 2 != 0)
                    x += z;
                else
                    x += 0;
            }

            if (x % 2 != 0)
                return true;
            else
                return false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool x = false;
            bool y = false;
            bool z = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsUpper(password[i]))
                    x = true;

                if (char.IsLower(password[i]))
                    y = true;
                if (char.IsNumber(password[i]))
                    z = true;

            }
            if (x == true && y == true && z == true)
                return true;
            else
                return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] arr = val.ToCharArray();
            char y = arr[0];
            return y; ;
        }

        public char GetLastLetterOfString(string val)
        {
            char[] arr = val.ToCharArray();
            char y = arr[arr.Length - 1];
            return y;
           ;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            decimal x;
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                x = dividend / divisor;
            }
            return x;
        }

        public int LastMinusFirst(int[] nums)
        {
            var x = nums[nums.Length - 1] - nums[0];
                return x;
        }

        public int[] GetOddsBelow100()
        {
            int x = 2;
            int z = 0;
            int[] y = new int[50];
            do
            {
                y[z++] = (z * x) - 1;
            } while (z < 50);
            return y;
            
            
            
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {

            // for (int i = 0; i < words.Length; i++)
            //   words[i]= words[i].ToUpper();
            int x = 0;
            foreach (string i in words)
            {
                words[x] = words[x].ToUpper();
                x++;
            }   
            
           
        }
    }
}
