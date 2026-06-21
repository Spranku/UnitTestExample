using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    public class Massiv
    {
        private double[,] matrix; // Исходная матрица

        /// <summary>
        /// Конструктор - принимает двухмерный массив
        /// </summary>
        /// <param name="inputMatrix">Исходная матрица</param>
        public Massiv(double[,] inputMatrix)
        {
            matrix = inputMatrix;
        }

        /// <summary>
        /// Метод 1: Получение столбца из матрицы по его номеру
        /// </summary>
        /// <param name="columnIndex">Номер столбца (начиная с 0)</param>
        /// <returns>Одномерный массив-столбец</returns>
        public double[] GetColumn(int columnIndex)
        {
            // Проверка корректности номера столбца
            if (columnIndex < 0 || columnIndex >= matrix.GetLength(1))
            {
                throw new ArgumentException($"Некорректный номер столбца: {columnIndex}. " +
                    $"Допустимые значения: 0 - {matrix.GetLength(1) - 1}");
            }

            int rows = matrix.GetLength(0);
            double[] column = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                column[i] = matrix[i, columnIndex];
            }

            return column;
        }

        /// <summary>
        /// Метод 2: Умножение матрицы на вектор-столбец
        /// </summary>
        /// <param name="vector">Вектор-столбец</param>
        /// <returns>Результирующий вектор</returns>
        public double[] MultiplyMatrixByVector(double[] vector)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            // Проверка: размерность вектора должна совпадать с числом столбцов матрицы
            if (vector.Length != cols)
            {
                throw new ArgumentException($"Размерность вектора ({vector.Length}) не совпадает " +
                    $"с числом столбцов матрицы ({cols})");
            }

            double[] result = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                double sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j] * vector[j];
                }
                result[i] = sum;
            }

            return result;
        }

        /// <summary>
        /// Вспомогательный метод: получение количества строк
        /// </summary>
        public int GetRowsCount()
        {
            return matrix.GetLength(0);
        }

        /// <summary>
        /// Вспомогательный метод: получение количества столбцов
        /// </summary>
        public int GetColumnsCount()
        {
            return matrix.GetLength(1);
        }

        /// <summary>
        /// Вспомогательный метод: получение всей матрицы (для отображения)
        /// </summary>
        public double[,] GetMatrix()
        {
            return matrix;
        }
    }
}