using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Column
    {
        public static string Coder(string str, string Key)
        {
            int Height = 1 + (int)Math.Ceiling((float)str.Length / Key.Length);
            char[,] Table = new char[Height, Key.Length];


            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Key.Length; i++)
                    Table[j, i] = '#';

            for (int i = 0; i < Key.Length; i++)
                Table[0, i] = Key[i];

            for (int i = 0; i < str.Length; i++)
                Table[i / Key.Length + 1, i % Key.Length] = str[i];

            string result = "";
            for (int i = 0; i < 33; i++)
                for (int j = 0; j < Key.Length; j++)
                    if (Table[0, j] == ('А' + i))
                        for (int k = 1; k < Height; k++)
                            if (Table[k, j] != '#')
                                result += Table[k, j];


            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Key.Length; j++)
                    Console.Write($"{Table[i, j]} | ");

                Console.WriteLine();
            }
            return result;
        }

        public static string DeCoder(string str, string Key)
        {
            int Height = 1 + (int)Math.Ceiling((float)str.Length / Key.Length);
            char[,] Table = new char[Height, Key.Length];

            for (int j = 0; j < Height; j++)
                for (int i = 0; i < Key.Length; i++)
                    Table[j, i] = '#';

            for (int i = 0; i < Key.Length; i++)
                Table[0, i] = Key[i];

            int LeftPart = str.Length % Key.Length;
            int strNumber = 0;

            for (int i = 0; i < 33; i++)
                for (int j = 0; j < Key.Length; j++)
                    if (Table[0, j] == ('А' + i))
                    {
                        if (j >= LeftPart)
                        {
                            for (int k = 1; k < Height - 1; k++)
                            {
                                Table[k, j] = str[strNumber];
                                strNumber++;
                            }
                        }
                        else
                        {
                            for (int k = 1; k < Height; k++)
                            {
                                Table[k, j] = str[strNumber];
                                strNumber++;
                            }
                        }

                    }

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Key.Length; j++)
                    Console.Write($"{Table[i, j]} | ");

                Console.WriteLine();
            }


            string result = "";
            for (int i = 1; i < Height; i++)
                for (int j = 0; j < Key.Length; j++)
                    if (Table[i, j] != '#')
                        result = result + Table[i, j];
            
            return result;
        }

    }
}
