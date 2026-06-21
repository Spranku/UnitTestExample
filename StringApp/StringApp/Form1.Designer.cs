namespace StringApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            // ===== ЭЛЕМЕНТЫ ДЛЯ РАБОТЫ СО СТРОКАМИ =====
            this.btnCountVowels = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnSplitReverse = new System.Windows.Forms.Button();
            this.btnCountSymbol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBorder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResultString = new System.Windows.Forms.TextBox();

            // ===== ЭЛЕМЕНТЫ ДЛЯ РАБОТЫ С МАТРИЦЕЙ =====
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.labelCols = new System.Windows.Forms.Label();
            this.txtCols = new System.Windows.Forms.TextBox();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.txtMatrix = new System.Windows.Forms.TextBox();
            this.labelColumnNumber = new System.Windows.Forms.Label();
            this.txtColumnNumber = new System.Windows.Forms.TextBox();
            this.btnGetColumn = new System.Windows.Forms.Button();
            this.labelColumn = new System.Windows.Forms.Label();
            this.txtColumn = new System.Windows.Forms.TextBox();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.txtResultMatrix = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            // =========================================================
            // 1. btnCountVowels (Подсчитать гласные)
            // =========================================================
            this.btnCountVowels.Location = new System.Drawing.Point(320, 157);
            this.btnCountVowels.Name = "btnCountVowels";
            this.btnCountVowels.Size = new System.Drawing.Size(160, 40);
            this.btnCountVowels.TabIndex = 0;
            this.btnCountVowels.Text = "Подсчитать гласные";
            this.btnCountVowels.UseVisualStyleBackColor = true;
            this.btnCountVowels.Click += new System.EventHandler(this.btnCountVowels_Click);

            // =========================================================
            // 2. label1 (Заголовок)
            // =========================================================
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Работа со строками";

            // =========================================================
            // 3. label2 (Введите строку)
            // =========================================================
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите строку:";

            // =========================================================
            // 4. txtInput (поле для ввода строки)
            // =========================================================
            this.txtInput.Location = new System.Drawing.Point(15, 79);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(465, 20);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "Изучаем язык программирования С#";

            // =========================================================
            // 5. label3 (Символ для поиска)
            // =========================================================
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Символ для поиска:";

            // =========================================================
            // 6. txtSymbol (поле для ввода символа)
            // =========================================================
            this.txtSymbol.Location = new System.Drawing.Point(127, 117);
            this.txtSymbol.MaxLength = 1;
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(30, 20);
            this.txtSymbol.TabIndex = 5;
            this.txtSymbol.Text = "а";

            // =========================================================
            // 7. label4 (Граница разделения)
            // =========================================================
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Граница разделения:";

            // =========================================================
            // 8. txtBorder (поле для ввода границы)
            // =========================================================
            this.txtBorder.Location = new System.Drawing.Point(301, 117);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.Size = new System.Drawing.Size(40, 20);
            this.txtBorder.TabIndex = 9;
            this.txtBorder.Text = "10";

            // =========================================================
            // 9. btnCountSymbol (Подсчитать символ)
            // =========================================================
            this.btnCountSymbol.Location = new System.Drawing.Point(15, 157);
            this.btnCountSymbol.Name = "btnCountSymbol";
            this.btnCountSymbol.Size = new System.Drawing.Size(146, 40);
            this.btnCountSymbol.TabIndex = 7;
            this.btnCountSymbol.Text = "Подсчитать символ";
            this.btnCountSymbol.UseVisualStyleBackColor = true;
            this.btnCountSymbol.Click += new System.EventHandler(this.btnCountSymbol_Click);

            // =========================================================
            // 10. btnSplitReverse (Разделить и реверсировать)
            // =========================================================
            this.btnSplitReverse.Location = new System.Drawing.Point(175, 157);
            this.btnSplitReverse.Name = "btnSplitReverse";
            this.btnSplitReverse.Size = new System.Drawing.Size(138, 40);
            this.btnSplitReverse.TabIndex = 6;
            this.btnSplitReverse.Text = "Разделить и реверс";
            this.btnSplitReverse.UseVisualStyleBackColor = true;
            this.btnSplitReverse.Click += new System.EventHandler(this.btnSplitReverse_Click);

            // =========================================================
            // 11. label5 (Результат для строк)
            // =========================================================
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат:";

            // =========================================================
            // 12. txtResultString (поле для вывода результата строк)
            // =========================================================
            this.txtResultString.Location = new System.Drawing.Point(15, 230);
            this.txtResultString.Multiline = true;
            this.txtResultString.Name = "txtResultString";
            this.txtResultString.ReadOnly = true;
            this.txtResultString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultString.Size = new System.Drawing.Size(465, 60);
            this.txtResultString.TabIndex = 11;

            // =========================================================
            // 13. groupBoxMatrix (Группа для работы с матрицей)
            // =========================================================
            this.groupBoxMatrix.Location = new System.Drawing.Point(12, 310);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(650, 350);
            this.groupBoxMatrix.TabIndex = 12;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Работа с матрицей";

            // =========================================================
            // 14. labelRows (Количество строк)
            // =========================================================
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(20, 25);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(111, 13);
            this.labelRows.TabIndex = 13;
            this.labelRows.Text = "Количество строк:";
            this.labelRows.Parent = this.groupBoxMatrix;

            // =========================================================
            // 15. txtRows (поле для ввода количества строк)
            // =========================================================
            this.txtRows.Location = new System.Drawing.Point(137, 22);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(40, 20);
            this.txtRows.TabIndex = 14;
            this.txtRows.Text = "3";
            this.txtRows.Parent = this.groupBoxMatrix;

            // =========================================================
            // 16. labelCols (Количество столбцов)
            // =========================================================
            this.labelCols.AutoSize = true;
            this.labelCols.Location = new System.Drawing.Point(200, 25);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(119, 13);
            this.labelCols.TabIndex = 15;
            this.labelCols.Text = "Количество столбцов:";
            this.labelCols.Parent = this.groupBoxMatrix;

            // =========================================================
            // 17. txtCols (поле для ввода количества столбцов)
            // =========================================================
            this.txtCols.Location = new System.Drawing.Point(325, 22);
            this.txtCols.Name = "txtCols";
            this.txtCols.Size = new System.Drawing.Size(40, 20);
            this.txtCols.TabIndex = 16;
            this.txtCols.Text = "3";
            this.txtCols.Parent = this.groupBoxMatrix;

            // =========================================================
            // 18. btnGenerateMatrix (Сгенерировать матрицу)
            // =========================================================
            this.btnGenerateMatrix.Location = new System.Drawing.Point(400, 18);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(160, 27);
            this.btnGenerateMatrix.TabIndex = 17;
            this.btnGenerateMatrix.Text = "Сгенерировать матрицу";
            this.btnGenerateMatrix.UseVisualStyleBackColor = true;
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);
            this.btnGenerateMatrix.Parent = this.groupBoxMatrix;

            // =========================================================
            // 19. labelMatrix (Матрица)
            // =========================================================
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Location = new System.Drawing.Point(20, 60);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(51, 13);
            this.labelMatrix.TabIndex = 18;
            this.labelMatrix.Text = "Матрица:";
            this.labelMatrix.Parent = this.groupBoxMatrix;

            // =========================================================
            // 20. txtMatrix (поле для отображения матрицы)
            // =========================================================
            this.txtMatrix.Location = new System.Drawing.Point(20, 80);
            this.txtMatrix.Multiline = true;
            this.txtMatrix.Name = "txtMatrix";
            this.txtMatrix.ReadOnly = true;
            this.txtMatrix.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMatrix.Size = new System.Drawing.Size(200, 100);
            this.txtMatrix.TabIndex = 19;
            this.txtMatrix.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtMatrix.Parent = this.groupBoxMatrix;

            // =========================================================
            // 21. labelColumnNumber (Номер столбца)
            // =========================================================
            this.labelColumnNumber.AutoSize = true;
            this.labelColumnNumber.Location = new System.Drawing.Point(240, 60);
            this.labelColumnNumber.Name = "labelColumnNumber";
            this.labelColumnNumber.Size = new System.Drawing.Size(148, 13);
            this.labelColumnNumber.TabIndex = 20;
            this.labelColumnNumber.Text = "Номер столбца (0-...):";
            this.labelColumnNumber.Parent = this.groupBoxMatrix;

            // =========================================================
            // 22. txtColumnNumber (поле для ввода номера столбца)
            // =========================================================
            this.txtColumnNumber.Location = new System.Drawing.Point(394, 57);
            this.txtColumnNumber.Name = "txtColumnNumber";
            this.txtColumnNumber.Size = new System.Drawing.Size(40, 20);
            this.txtColumnNumber.TabIndex = 21;
            this.txtColumnNumber.Text = "0";
            this.txtColumnNumber.Parent = this.groupBoxMatrix;

            // =========================================================
            // 23. btnGetColumn (Получить столбец)
            // =========================================================
            this.btnGetColumn.Location = new System.Drawing.Point(450, 55);
            this.btnGetColumn.Name = "btnGetColumn";
            this.btnGetColumn.Size = new System.Drawing.Size(130, 25);
            this.btnGetColumn.TabIndex = 22;
            this.btnGetColumn.Text = "Получить столбец";
            this.btnGetColumn.UseVisualStyleBackColor = true;
            this.btnGetColumn.Click += new System.EventHandler(this.btnGetColumn_Click);
            this.btnGetColumn.Parent = this.groupBoxMatrix;

            // =========================================================
            // 24. labelColumn (Вектор-столбец)
            // =========================================================
            this.labelColumn.AutoSize = true;
            this.labelColumn.Location = new System.Drawing.Point(240, 95);
            this.labelColumn.Name = "labelColumn";
            this.labelColumn.Size = new System.Drawing.Size(94, 13);
            this.labelColumn.TabIndex = 23;
            this.labelColumn.Text = "Вектор-столбец:";
            this.labelColumn.Parent = this.groupBoxMatrix;

            // =========================================================
            // 25. txtColumn (поле для отображения вектора)
            // =========================================================
            this.txtColumn.Location = new System.Drawing.Point(240, 115);
            this.txtColumn.Multiline = true;
            this.txtColumn.Name = "txtColumn";
            this.txtColumn.ReadOnly = true;
            this.txtColumn.Size = new System.Drawing.Size(150, 65);
            this.txtColumn.TabIndex = 24;
            this.txtColumn.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtColumn.Parent = this.groupBoxMatrix;

            // =========================================================
            // 26. btnMultiply (Умножить матрицу на вектор)
            // =========================================================
            this.btnMultiply.Location = new System.Drawing.Point(450, 115);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(180, 65);
            this.btnMultiply.TabIndex = 25;
            this.btnMultiply.Text = "Умножить матрицу\r\nна вектор";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            this.btnMultiply.Parent = this.groupBoxMatrix;

            // =========================================================
            // 27. labelResult (Результат умножения)
            // =========================================================
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(20, 200);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(123, 13);
            this.labelResult.TabIndex = 26;
            this.labelResult.Text = "Результат умножения:";
            this.labelResult.Parent = this.groupBoxMatrix;

            // =========================================================
            // 28. txtResultMatrix (поле для отображения результата)
            // =========================================================
            this.txtResultMatrix.Location = new System.Drawing.Point(20, 220);
            this.txtResultMatrix.Multiline = true;
            this.txtResultMatrix.Name = "txtResultMatrix";
            this.txtResultMatrix.ReadOnly = true;
            this.txtResultMatrix.Size = new System.Drawing.Size(200, 60);
            this.txtResultMatrix.TabIndex = 27;
            this.txtResultMatrix.Font = new System.Drawing.Font("Courier New", 9F);
            this.txtResultMatrix.Parent = this.groupBoxMatrix;

            // =========================================================
            // 29. Form1
            // =========================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 700);
            this.Controls.Add(this.groupBoxMatrix);
            this.Controls.Add(this.txtResultString);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCountSymbol);
            this.Controls.Add(this.btnSplitReverse);
            this.Controls.Add(this.txtBorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCountVowels);
            this.Name = "Form1";
            this.Text = "Работа со строками и матрицами";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #region Объявление элементов управления

        // Элементы для работы со строками
        private System.Windows.Forms.Button btnCountVowels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.Button btnSplitReverse;
        private System.Windows.Forms.Button btnCountSymbol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResultString;

        // Элементы для работы с матрицей
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label labelCols;
        private System.Windows.Forms.TextBox txtCols;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.TextBox txtMatrix;
        private System.Windows.Forms.Label labelColumnNumber;
        private System.Windows.Forms.TextBox txtColumnNumber;
        private System.Windows.Forms.Button btnGetColumn;
        private System.Windows.Forms.Label labelColumn;
        private System.Windows.Forms.TextBox txtColumn;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox txtResultMatrix;

        #endregion
    }
}