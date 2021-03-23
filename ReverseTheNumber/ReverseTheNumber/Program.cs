using System;

namespace ReverseTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number you want to reverse: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            //save the number in to the variable and convert it to string
            string number = inputNumber.ToString();
            //converted string splitted in to chars and saved in to the array
            char[] myStr = number.ToCharArray();

            Console.WriteLine("The reversed number will be: ");
            //In the cycle we we print out the characters from the end
            for(int i = myStr.Length; i > 0; i--)
            {
                Console.Write(myStr[i - 1]);
            }
        }
    }
}
