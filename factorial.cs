using System;

namespace Factorial
{
    class Progam
    {
        static void Main(string[] args)
        {
            int a = Factorial(5); // ����� �����
            Console.WriteLine(a);
            Console.ReadKey();
        }
        static int Factorial(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            else
            {
                return x * Factorial(x - 1);
            }
        }
    }

    
};