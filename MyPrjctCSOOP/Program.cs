using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrjctCSOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.GetEncoding(866);

            Console.WriteLine("Это строка,\n\tиначе –\"стринг\",\n\t\tиначе – \"строковый литерал\"");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Это звуковой \nсигнал!\a");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Это строка?\n\"Да!\"");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\" – это двойные кавычки \n' – это апостроф");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Это “строка”?\nЭто “строка”!\b ");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Это строка?\nЭто строка!\r Да");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\\\\Это комментарий?\n//Нет, это комментарий");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("C:\\Program Files\\Far\nD:\\Program Files\\Far\rF");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\x0426\x0435\x043D\x0430\x003D\x000A\x003D\x0031\x0030\x0030\x0024");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\u0426\u0435\u043D\u0430\u003D\n\u003D\u0031\u0030\u0030\u0024");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
