namespace StringApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCountVowels (Подсчитать гласные)
            // 
            this.btnCountVowels.Location = new System.Drawing.Point(320, 157);
            this.btnCountVowels.Name = "btnCountVowels";
            this.btnCountVowels.Size = new System.Drawing.Size(160, 40);
            this.btnCountVowels.TabIndex = 0;
            this.btnCountVowels.Text = "Подсчитать гласные";
            this.btnCountVowels.UseVisualStyleBackColor = true;
            this.btnCountVowels.Click += new System.EventHandler(this.btnCountVowels_Click);
            // 
            // label1 (Заголовок)
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Работа со строками";
            // 
            // label2 (Введите строку)
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите строку:";
            // 
            // txtInput (поле для ввода строки)
            // 
            this.txtInput.Location = new System.Drawing.Point(15, 79);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(465, 20);
            this.txtInput.TabIndex = 3;
            // 
            // label3 (Символ для поиска)
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Символ для поиска:";
            // 
            // txtSymbol (поле для ввода символа)
            // 
            this.txtSymbol.Location = new System.Drawing.Point(127, 117);
            this.txtSymbol.MaxLength = 1;
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(30, 20);
            this.txtSymbol.TabIndex = 5;
            // 
            // label4 (Граница разделения)
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Граница разделения:";
            // 
            // txtBorder (поле для ввода границы)
            // 
            this.txtBorder.Location = new System.Drawing.Point(301, 117);
            this.txtBorder.Name = "txtBorder";
            this.txtBorder.Size = new System.Drawing.Size(40, 20);
            this.txtBorder.TabIndex = 9;
            // 
            // btnCountSymbol (Подсчитать символ)
            // 
            this.btnCountSymbol.Location = new System.Drawing.Point(15, 157);
            this.btnCountSymbol.Name = "btnCountSymbol";
            this.btnCountSymbol.Size = new System.Drawing.Size(146, 40);
            this.btnCountSymbol.TabIndex = 7;
            this.btnCountSymbol.Text = "Подсчитать символ";
            this.btnCountSymbol.UseVisualStyleBackColor = true;
            this.btnCountSymbol.Click += new System.EventHandler(this.btnCountSymbol_Click);
            // 
            // btnSplitReverse (Разделить и реверсировать)
            // 
            this.btnSplitReverse.Location = new System.Drawing.Point(175, 157);
            this.btnSplitReverse.Name = "btnSplitReverse";
            this.btnSplitReverse.Size = new System.Drawing.Size(138, 40);
            this.btnSplitReverse.TabIndex = 6;
            this.btnSplitReverse.Text = "Разделить и реверс";
            this.btnSplitReverse.UseVisualStyleBackColor = true;
            this.btnSplitReverse.Click += new System.EventHandler(this.btnSplitReverse_Click);
            // 
            // label5 (Результат)
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Результат:";
            // 
            // txtResult (поле для вывода результата)
            // 
            this.txtResult.Location = new System.Drawing.Point(15, 256);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(465, 130);
            this.txtResult.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 420);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBorder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCountSymbol);
            this.Controls.Add(this.btnSplitReverse);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCountVowels);
            this.Name = "Form1";
            this.Text = "Работа со строками";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        // Объявление элементов управления (чтобы они были видны в коде)
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
        private System.Windows.Forms.TextBox txtResult;
    }
}