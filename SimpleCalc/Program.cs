using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expression in format 'a operator b' ");
            while (true)
            {
                string s = Console.ReadLine();
                string[] divided = s.Split(new char[0]);
                double a = 0;
                double b = 0;
                char o = new char();
                try
                {
                    a = Convert.ToDouble(divided[0]);
                    o = Convert.ToChar(divided[1]);
                    b = Convert.ToDouble(divided[2]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                switch (o)
                {
                    case '+': Console.WriteLine(Operations.Summ(a, b)); break;
                    case '-': Console.WriteLine(Operations.Subtraction(a, b)); break;
                    case '*': Console.WriteLine(Operations.Multiplication(a, b)); break;
                    case '/':
                        double res = Operations.Division(a, b);
                        Console.WriteLine((res==Double.PositiveInfinity || res == Double.NegativeInfinity)?"Infinity":res.ToString());
                        break;
                    default: Console.WriteLine("Wrong operator"); break;
                }
            }
        }
    }
}
