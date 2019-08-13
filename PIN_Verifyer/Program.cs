using System;
using System.Linq;

namespace PIN_Check
{
    class Program
    {
        static void Main()
        {
            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

            var pin = Console.ReadLine();

            int[] pinArray = new int[10];
            var year = int.Parse(pin.Substring(0, 2));
            var month = int.Parse(pin.Substring(2, 2));
            var date = int.Parse(pin.Substring(4, 2));
            int sum = 0;

            for (int i = 0; i < pin.Length; i++)
            {
                pinArray[i] = pin[i] - '0';
                
            }
                        
            if (date <= 31 && (month <= 12 || (month >= 41 && month <= 52)) && pin.Length==10) //Check valid date of birth and pin Length
            {
                for (int i = 0; i < weights.Length; i++)
                {
                    sum = sum + weights[i] * pinArray[i];
                }
                
                sum = sum % 11;

                if (sum == 10)
                {
                    sum = 0;
                }

                if (sum == pinArray[9]) //
                {
                    Console.Write($"PIN: {pin} is valid!!!");
                }
                else
                {
                    Console.Write($"PIN: {pin} is Invalid!!!");
                }
            }
            else
            {
                Console.Write($"PIN: {pin} not recognized or incomplete");
            }
            

        }
    }
}
