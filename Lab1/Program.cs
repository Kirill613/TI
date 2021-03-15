using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите строку для кодировки методом железнодорожной изгороди:");
            //string Input = Console.ReadLine();
            //Console.WriteLine("Введите ключ для кодировки методом железнодорожной изгороди:");
            //int Key = Convert.ToInt32(Console.ReadLine());

            //string Codestr = Izgorod.Coder(Input, Key);
            //Console.WriteLine($"Закодированная: {Codestr}");

            //string Result = Izgorod.DeCoder(Codestr, Key);
            //Console.WriteLine($"Раскодированная: {Result}");



            //Console.WriteLine("Введите строку для кодировки столбцовым методом:");
            //string Input1 = Console.ReadLine();
            //Console.WriteLine("Введите ключ для кодировки столбцовым методом:");
            //string Key1 = Console.ReadLine();

            //string Codestr1 = Column.Coder(Input1, Key1);
            //Console.WriteLine($"Закодированная: {Codestr1}");

            //string Result1 = Column.DeCoder(Codestr1, Key1);
            //Console.WriteLine($"Раскодированная: {Result1}");



            //Console.WriteLine("Введите строку для кодировки методом поворачивающейся решетки (<=16):");
            //string Input2 = Console.ReadLine();

            //string Codestr2 = Turns.Coder(Input2);
            //Console.WriteLine($"Закодированная: {Codestr2}");

            //string Result2 = Turns.DeCoder(Codestr2);
            //Console.WriteLine($"Раскодированная: {Result2}");



            Console.WriteLine("Введите строку для кодировки методом Вижинера:");
            string Input3 = Console.ReadLine();

            Console.WriteLine("Введите ключ для кодировки методом Вижинера:");
            string Key3 = Console.ReadLine();

            string Codestr3 = Viziner.Coder(Input3, Key3);
            Console.WriteLine($"Закодированная: {Codestr3}");

            string Result3 = Viziner.DeCoder(Codestr3, Key3);
            Console.WriteLine($"Раскодированная: {Result3}");
        }
    }
}
