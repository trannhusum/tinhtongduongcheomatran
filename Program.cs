using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tinhtongduongcheomatran
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GenerateMatrix(3, 3);
            PrintMatrix(matrix);
            SumSumMainDiagonal(matrix);


            Console.WriteLine("Nhap kich thuoc cua ma tran:");
            Console.Write("So cot: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("So hang: ");
            int columns = int.Parse(Console.ReadLine());

            int[,] userMatrix = GetUserMatrix(rows, columns);
            SumSumMainDiagonal(userMatrix);
            Console.ReadKey();
        }
        static int[,] GenerateMatrix(int rows, int columns)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = random.Next(100);
                }
            }
            return matrix;
        }


        static void SumSumMainDiagonal(int[,] matrix)
        {
            int sum = 0;
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }


        static int[,] GetUserMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("Nhap gia tri tai" + "[{" + i + "},{" + j + "}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}

