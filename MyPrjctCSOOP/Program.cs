using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace MyPrjctCSOOP
{
    internal class Program1
    {
        public static void Run()
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

    internal class Program2
    {

        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1 - Определение размера типов данных");
                Console.WriteLine("2 - Деление целых чисел");
                Console.WriteLine("3 - Определение ASCII-кода символа");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        N1();
                        break;
                    case "2":
                        N2();
                        break;
                    case "3":
                        N3();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Недопустимый выбор, попробуйте еще раз.");
                        break;
                }

                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void N1()
        {

            Console.WriteLine($"sizeof(bool) = {sizeof(bool)}");
            Console.WriteLine($"sizeof(char) = {sizeof(char)}");
            Console.WriteLine($"sizeof(sbyte) = {sizeof(sbyte)}");
            Console.WriteLine($"sizeof(byte) = {sizeof(byte)}");
            Console.WriteLine($"sizeof(int) = {sizeof(int)}");
            Console.WriteLine($"sizeof(uint) = {sizeof(uint)}");
            Console.WriteLine($"sizeof(short) = {sizeof(short)}");
            Console.WriteLine($"sizeof(ushort) = {sizeof(ushort)}");
            Console.WriteLine($"sizeof(long) = {sizeof(long)}");
            Console.WriteLine($"sizeof(ulong) = {sizeof(ulong)}");
            Console.WriteLine($"sizeof(float) = {sizeof(float)}");
            Console.WriteLine($"sizeof(double) = {sizeof(double)}");
            Console.WriteLine($"sizeof(decimal) = {sizeof(decimal)}");
            Console.WriteLine($"sizeof(string) = {Marshal.SizeOf<string>()} (размер ссылки)");
            Console.WriteLine($"sizeof(object) = {Marshal.SizeOf<object>()} (размер ссылки)");
            //IntPtr.Size / Marshal.SizeOf - для ссылочных/структур данных
            //структурированный.не структур типы - ? у структурированных есть определенная структура ( определяются с помощью классов, структур и перечислений )

            //object - - Это базовый тип данных в C#, от которого наследуются все другие типы. Он может хранить значения любого типа (включая встроенные типы и пользовательские).
            //Объект типа object может потребовать неявное или явное приведение типов для доступа к специфическим свойствам или методам.

            //Program2 RunP = new Program2();
        }

        static void N2()
        {
            int a = 10;
            int b = 3;

            double result = (double)a / b; //какое приведение ьтпов - явное приведение типов

            Console.WriteLine($"Результат деления {a} на {b} = {result}");
        }

        static void N3()
        {
            char symbol = 'A';

            int asciiCode = symbol;
            char nextChar = (char)(asciiCode + 1);
            char prevChar = (char)(asciiCode - 1);

            Console.WriteLine($"ASCII-код символа '{symbol}' = {asciiCode}");
            Console.WriteLine($"Следующий символ: '{nextChar}'");
            Console.WriteLine($"Предыдущий символ: '{prevChar}'");
        }
        enum week { sunday, monaday, tuesday, wednesday, thursday, friday, saturnday }
    }

    internal class MainProgram
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите класс: ");
                Console.WriteLine("1 - Program1");
                Console.WriteLine("2 - Program2");
                Console.WriteLine("0 - Выход");
                Console.Write("Ваш выбор: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Program1.Run();
                        break;
                    case "2":
                        Program2.Run();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Недопустимый выбор, попробуйте еще раз.");
                        break;
                }
            }
        }
    }
}