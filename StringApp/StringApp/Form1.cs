using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Настройка подсказок
            txtResult.Text = "Ожидание ввода...";
        }

        // ========== МЕТОД 1: Подсчет символа ==========
        private void btnCountSymbol_Click(object sender, EventArgs e)
        {
            // Проверка наличия входных данных
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
                // Создаем экземпляр класса Stroka
                Stroka stroka = new Stroka(txtInput.Text);

                // Получаем символ
                char symbol = txtSymbol.Text[0];

                // Вызываем метод подсчета
                int count = stroka.CountSymbol(symbol);

                // Выводим результат
                txtResult.Text = $"Результат подсчета символа '{symbol}':\n" +
                                $"Символ '{symbol}' встречается {count} раз(а) в строке.\n\n" +
                                $"Исходная строка:\n{txtInput.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ========== МЕТОД 2: Разделение и реверсирование ==========
        private void btnSplitReverse_Click(object sender, EventArgs e)
        {
            // Проверка наличия входных данных
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
                // Создаем экземпляр класса Stroka
                Stroka stroka = new Stroka(txtInput.Text);

                // Получаем границу разделения
                int border = int.Parse(txtBorder.Text);

                // Вызываем метод разделения и реверсирования
                string result = stroka.SplitAndReverse(border);

                // Выводим результат
                txtResult.Text = $"Результат разделения и реверсирования:\n" +
                                $"{result}\n\n" +
                                $"Исходная строка:\n{txtInput.Text}\n" +
                                $"Граница разделения: {border}";
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

        // ========== МЕТОД 3: Подсчет гласных ==========
        private void btnCountVowels_Click(object sender, EventArgs e)
        {
            // Проверка наличия входных данных
            if (string.IsNullOrWhiteSpace(txtInput.Text))
            {
                MessageBox.Show("Пожалуйста, введите строку!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Создаем экземпляр класса Stroka
                Stroka stroka = new Stroka(txtInput.Text);

                // Вызываем метод подсчета гласных
                int count = stroka.CountVowels();

                // Выводим результат
                txtResult.Text = $"Результат подсчета гласных букв:\n" +
                                $"В строке {count} гласных букв.\n\n" +
                                $"Исходная строка:\n{txtInput.Text}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
