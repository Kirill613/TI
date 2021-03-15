using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    class Turns
    {
        public static string Coder(string str)
        {
            const int SIZE = 4;
            int[,] grid = new int[SIZE, SIZE]
                         {{1, 0, 0, 0},
                          {0, 0, 0, 1},
                          {0, 0, 1, 0},
                          {0, 1, 0, 0}};

            

            if (str.Length > SIZE*SIZE)
            {
                return null;
            }else if (str.Length < SIZE * SIZE)
            {
                //char rand = 'А';
                int k = SIZE * SIZE - str.Length;
                for (int i = 0;i <= k; i++)
                {
                    //str += rand++;
                    str += ' ';
                }
            }
            Console.WriteLine(str);

            char[,] Table = new char[SIZE, SIZE];

            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    Table[i, j] = '#';

            int Counter = 0;

            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[i, j] == 1)
                    {
                        Table[i, j] = str[Counter];
                        Counter++;
                    }
            // поворот решетки на 90 градусов по часовой стрелке
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - j - 1, i] == 1)
                    {
                        Table[i, j] = str[Counter];
                        Counter++;
                    }
           
            // поворот решетки на 180 градусов по часовой стрелке
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - i - 1, SIZE - j - 1] == 1)
                    {
                        Table[i, j] = str[Counter];
                        Counter++;
                    }
            // поворот решетки на 270 градусов по часовой стрелке
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[j, SIZE - i - 1] == 1)
                    {
                        Table[i, j] = str[Counter];
                        Counter++;
                    }

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                    Console.Write($"{Table[i, j]} ");
                Console.WriteLine();
            }

            string result = "";
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    result += Table[i, j];

            return result;
        }

        public static string DeCoder(string str)
        {
            const int SIZE = 4;
            int[,] grid = new int[SIZE, SIZE]
                         {{1, 0, 0, 0},
                          {0, 0, 0, 1},
                          {0, 0, 1, 0},
                          {0, 1, 0, 0}};

            char[,] Table = new char[SIZE, SIZE];

            int Counter = 0;  

            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                {
                    Table[i, j] = str[Counter];
                    Counter++;
                }

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < SIZE; j++)
                    Console.Write($"{Table[i, j]} ");
                Console.WriteLine();
            }

            string result = "";

            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[i, j] == 1)
                        result += Table[i, j];

            // поворот решетки на 90 градусов по часовой стрелке
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - j - 1, i] == 1)
                        result += Table[i, j];

            // поворот решетки на 180 градусов по часовой стрелке
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - i - 1, SIZE - j - 1] == 1)
                        result += Table[i, j];

            // поворот решетки на 270 градусов по часовой стрелке
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[j, SIZE - i - 1] == 1)
                        result += Table[i, j];


            return result;
        }
    }
}
