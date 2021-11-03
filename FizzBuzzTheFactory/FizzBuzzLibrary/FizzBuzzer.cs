using System;

namespace FizzBuzzLibrary
{
    public class FizzBuzzer
    {
        public static string GetValue(int input)
        {

            //if (input % 3 == 0 && input % 5 == 0)
            //    return "FizzBuzz";

            //if (input %  3 ==0)
            //    return "Fizz";

            //if (input % 5 == 0)
            //    return "Buzz";



            //return input.ToString();


            string output = string.Empty;

            if (input % 3 == 0)
                output += "Fizz";

            if (input % 5 == 0)
                output += "Buzz";

            if (string.IsNullOrEmpty(output))
                output = input.ToString();

            return output;
        }

        public string salidadeejemplo(int input)
        {
            if (input % 3 == 0 && input % 5 == 0)
                return "FizzBuzz";

            if (input %  3 ==0)
                return "Fizz";

            if (input % 5 == 0)
                return "Buzz";



            return input.ToString();

        }
    }
}
