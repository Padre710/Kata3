using System;


//Complete the solution so that it returns true if the first argument(string) 
//passed in ends with the 2nd argument (also a string).

//Examples:

//solution('abc', 'bc') // returns true
//solution('abc', 'd') // returns false

namespace Kata3

{
    public class Kata
    {
        
        public static bool Solution(string str, string ending)
        {
              bool n = true;
           
            // TODO: complete
            for (int i = str.Length - 1, j = ending.Length - 1; i >= 0 && j >= 0 ; i--, j--)
            {
                if (ending.Length > str.Length)
                    n = false;
                else
                {
                    if (str[i] != ending[j])
                    {
                        n = false;
                        break;
                    }
                    else
                        n = true;
                }
            }

            return n;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          //BECAUSE I HAVE CHECKED CODE IN  CODEWARS KATA AND IT WORKED PERFECTLY,
          // WE CAN ALWAYS CALL THE CODE LATER. AT LEAST, WE KNOW IT WORKS.


        }
    }
}
