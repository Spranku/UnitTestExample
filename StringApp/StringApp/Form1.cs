using System;
using System.Windows.Forms;

namespace StringApp
{
    public partial class Form1 : Form
    {
        // Храним текущую матрицу
        private double[,] currentMatrix;

        public Form1()
        {
            InitializeComponent();
            txtResultString.Text = "Ожидание ввода...";
            // При запуске сгенерируем матрицу по умолчанию
            GenerateDefaultMatrix();
        }

        // =============================================================
        // МЕТОДЫ ДЛЯ РАБОТЫ СО СТРОКАМИ
        // =============================================================

        private void btnCountSymbol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Пожалуйста, введите строку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSymbol.Text))
            {
                MessageBox.Show("Пожалуйста, введите символ для поиска!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Stroka stroka = new Stroka(txtInput.Text);
                char symbol = txtSymbol.Text[0];
                int count = stroka.CountSymbol(symbol);

                txtResultString.Text = $"Результат подсчета символа '{symbol}':\n" +
                    $"Символ '{symbol}' встречается {count} раз(а) в строке.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSplitReverse_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Пожалуйста, введите строку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtBorder.Text))
            {
                MessageBox.Show("Пожалуйста, введите границу разделения!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Stroka stroka = new Stroka(txtInput.Text);
                int border = int.Parse(txtBorder.Text);
                string result = stroka.SplitAndReverse(border);

                txtResultString.Text = $"Результат разделения и реверсирования:\n{result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целое число для границы разделения!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCountVowels_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Пожалуйста, введите строку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Stroka stroka = new Stroka(txtInput.Text);
                int count = stroka.CountVowels();

                txtResultString.Text = $"Результат подсчета гласных букв:\n" +
                    $"В строке {count} гласных букв.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // =============================================================
        // МЕТОДЫ ДЛЯ РАБОТЫ С МАТРИЦЕЙ
        // =============================================================

        /// <summary>
        /// Генерация матрицы по умолчанию (3x3)
        /// </summary>
        private void GenerateDefaultMatrix()
        {
            double[,] matrix = new double[,]
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            currentMatrix = matrix;
            DisplayMatrix(matrix);
        }

        /// <summary>
        /// Отображение матрицы в текстовом поле
        /// </summary>
        private void DisplayMatrix(double[,] matrix)
        {
            if (matrix == null)
            {
                txtMatrix.Text = "Матрица не создана";
                return;
            }

            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            string result = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result += matrix[i, j].ToString("F2") + "  ";
                }
                result += Environment.NewLine;
            }

            txtMatrix.Text = result;
        }

        /// <summary>
        /// Отображение вектора в текстовом поле
        /// </summary>
        private void DisplayVector(double[] vector, TextBox textBox)
        {
            if (vector == null)
            {
                textBox.Text = "Вектор не создан";
                return;
            }

            string result = "";
            for (int i = 0; i < vector.Length; i++)
            {
                result += vector[i].ToString("F2") + Environment.NewLine;
            }
            textBox.Text = result;
        }

        /// <summary>
        /// Событие: Генерация матрицы
        /// </summary>
        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                int rows = int.Parse(txtRows.Text);
                int cols = int.Parse(txtCols.Text);

                if (rows <= 0 || cols <= 0)
                {
                    MessageBox.Show("Количество строк и столбцов должно быть больше 0!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rows > 20 || cols > 20)
                {
                    MessageBox.Show("Максимальный размер матрицы - 20x20!",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Генерируем матрицу со случайными числами
                Random rand = new Random();
                double[,] matrix = new double[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix[i, j] = Math.Round(rand.NextDouble() * 10, 1);
                    }
                }

                currentMatrix = matrix;
                DisplayMatrix(matrix);

                // Очищаем результаты
                txtColumn.Text = "";
                txtResultMatrix.Text = "";

                // Обновляем подсказку для номера столбца
                labelColumnNumber.Text = $"Номер столбца (0-{cols - 1}):";
                txtColumnNumber.Text = "0";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целые числа!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Событие: Получение столбца из матрицы
        /// </summary>
        private void btnGetColumn_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null)
            {
                MessageBox.Show("Сначала сгенерируйте матрицу!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int columnIndex = int.Parse(txtColumnNumber.Text);
                Massiv massiv = new Massiv(currentMatrix);
                double[] column = massiv.GetColumn(columnIndex);

                DisplayVector(column, txtColumn);

                MessageBox.Show($"Столбец {columnIndex} успешно получен!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите целое число!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Событие: Умножение матрицы на вектор
        /// </summary>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (currentMatrix == null)
            {
                MessageBox.Show("Сначала сгенерируйте матрицу!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверяем, что вектор получен
            if (string.IsNullOrWhiteSpace(txtColumn.Text))
            {
                MessageBox.Show("Сначала получите столбец из матрицы!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Преобразуем текст из txtColumn в массив double
                string[] lines = txtColumn.Text.Split(new[] { Environment.NewLine },
                    StringSplitOptions.RemoveEmptyEntries);
                double[] vector = new double[lines.Length];
                for (int i = 0; i < lines.Length; i++)
                {
                    vector[i] = double.Parse(lines[i]);
                }

                Massiv massiv = new Massiv(currentMatrix);
                double[] result = massiv.MultiplyMatrixByVector(vector);

                DisplayVector(result, txtResultMatrix);

                MessageBox.Show("Умножение выполнено успешно!",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка при чтении вектора!",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}