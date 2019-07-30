using System;

namespace PIN_Check
{
    class Program
    {
        static void Main()
        {
            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };

            ulong pin = ulong.Parse(Console.ReadLine());

            ulong[] pinArray = new ulong[10];
            ulong year = 0;
            ulong month = 0;
            ulong date = 0;
            int sum = 0;

            // Make a PIN number to an array
            for (int i = 9; i >= 0; i--)
            {
                ulong result = pin % 10;
                pinArray[i] = result;
                pin = pin / 10;
                if (i == 2)
                {
                    year = pin; //Save Year
                }
                if (i == 4)
                {
                    month = pin % 100; //Saving Month
                }
                if (i == 6)
                {
                    date = pin % 100; //Saving Day
                }
            }


            if (date <= 31 && (month <= 12 || (month >= 41 && month <= 52))) //Check valid date of birth
            {
                for (int i = 0; i < weights.Length; i++)
                {
                    sum = sum + weights[i] * (int)pinArray[i];
                }
                sum = sum % 11;
                if (sum == 10)
                {
                    sum = 0;
                }
                if (sum == (int)pinArray[9]) //
                {
                    Console.Write($"PIN:");
                    for (int i = 0; i < pinArray.Length; i++)
                    {
                        Console.Write(pinArray[i]);
                    }
                    Console.WriteLine(" is valid!!!");
                }
            }
            else
            {
                Console.Write($"PIN:");
                for (int i = 0; i < pinArray.Length; i++)
                {
                    Console.Write(pinArray[i]);
                }
                Console.WriteLine(" is Invalid!!!");
            }


        }
    }
}
