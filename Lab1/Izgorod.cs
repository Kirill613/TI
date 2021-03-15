using System;
using System.Collections.Generic;
using System.Text;

namespace Lab1
{
    public class Izgorod
    {
        public static string Coder(string InPutString, int k)
        {
            string OutPutString = "";
            char[,] MTransp = new char[k, InPutString.Length];

            for (int i = 0; i < k; i++)
                for (int j = 0; j < InPutString.Length; j++)
                    MTransp[i, j] = '#';

            int i1 = 0;
            bool direction = false; //true = bottom;false = top

            for (int i = 0; i < InPutString.Length; i++)
            {
                MTransp[i1, i] = InPutString[i];

                if ((i1 == k - 1) || (i1 == 0))
                    direction = !direction;

                i1 = direction ? (i1 + 1) : (i1 - 1);
            }

            //for (int i = 0; i < k; i++)
            //{
            //    for (int j = 0; j < InPutString.Length; j++)
            //        Console.Write(MTransp[i, j]);

            //    Console.WriteLine();
            //}

            int Index = 0;
            for (int i = 0; i < k; i++)
                for (int j = 0; j < InPutString.Length; j++)
                    if (MTransp[i, j] != '#')
                    {
                        OutPutString = String.Concat(OutPutString, MTransp[i, j]);
                        Index++;
                    }

            return OutPutString;
        }

        public static string DeCoder(string str, int k)
        {
            char[,] MTransp = new char[k, str.Length];

            for (int i = 0; i < k; i++)
                for (int j = 0; j < str.Length; j++)
                    MTransp[i, j] = '\n';

            bool dir_down = true;

            int row = 0;
            int col = 0;

            for (int i = 0; i < str.Length; i++)
            {

                if (row == 0)
                    dir_down = true;
                if (row == k - 1)
                    dir_down = false;

                MTransp[row, col++] = '*';

                row = dir_down ? (row + 1) : (row - 1);
            }

            int index = 0;
            for (int i = 0; i < k; i++)
                for (int j = 0; j < str.Length; j++)
                    if (MTransp[i, j] == '*' && index < str.Length)
                        MTransp[i, j] = str[index++];


            //for (int i = 0; i < k; i++)
            //{
            //    for (int j = 0; j < str.Length; j++)
            //        Console.Write(MTransp[i, j]);

            //    Console.WriteLine();
            //}

            string result = "";

            row = 0;
            col = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (row == 0)
                    dir_down = true;
                if (row == k - 1)
                    dir_down = false;

                if (MTransp[row, col] != '*')
                    result = result + MTransp[row, col++];

                row = dir_down ? (row + 1) : (row - 1);
            }
            return result;
        }

    }
}

