using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace تشکیل_تصاعد_حسابی
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, e1, e2;
            Console.Write("Please enter the first number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the second number : ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Please enter the third number : ");
            num3 = int.Parse(Console.ReadLine());
            e1 = num1 - num2;
            e2 = num2 - num3;
            if (e1 == e2)
                Console.WriteLine("These three numbers are an arithmetic progression !");
            else
                Console.WriteLine("These three numbers are not an arithmetic progression !");
            Console.ReadKey();
        }
    }
}
