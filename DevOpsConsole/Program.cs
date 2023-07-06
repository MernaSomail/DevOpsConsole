using System;

namespace DevOpsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Enter First number : ");
                var num1 = Console.ReadLine();
                Console.WriteLine("Enter Operation : ");
                var op = Console.ReadLine();
                Console.WriteLine("Enter Second Number : ");
                var num2 = Console.ReadLine();

                try
                {
                    if (op == "+")
                    {
                        int res = int.Parse(num1) + int.Parse(num2);
                        Console.WriteLine("REsult : " +res.ToString());
                    }
                    else if (op == "-")
                    {
                        int res = int.Parse(num1) - int.Parse(num2);
                        Console.WriteLine("REsult : " + res.ToString());
                    }
                    else if (op == "*")
                    {
                        int res = int.Parse(num1) * int.Parse(num2);
                        Console.WriteLine("REsult : " + res.ToString());
                    }
                    else if (op == "/")
                    {
                        int res = int.Parse(num1) / int.Parse(num2);
                        Console.WriteLine("REsult : " + res.ToString());
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Please enter correct data");
                }
            }
           

        }
    }
}
