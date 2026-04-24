namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            Свойства = new TabPage();
            labelResult = new Label();
            button1 = new Button();
            textBoxInput = new TextBox();
            label1 = new Label();
            МинМакс = new TabPage();
            labelInfo = new Label();
            labelMinMax = new Label();
            buttonMinMax = new Button();
            textBoxN = new TextBox();
            ЧетНечет = new TabPage();
            labelEvenOdd = new Label();
            labelInfo1 = new Label();
            buttonEvenOdd = new Button();
            Реверс = new TabPage();
            textBoxReverse = new TextBox();
            labelReverse = new Label();
            lableInfo2 = new Label();
            buttonReverse = new Button();
            Сдвиг = new TabPage();
            textBoxShift = new TextBox();
            labelShift = new Label();
            labelInfo2 = new Label();
            buttonShift = new Button();
            Дубликаты = new TabPage();
            textBoxDuplicates = new TextBox();
            labelDuplicates = new Label();
            labelInfo3 = new Label();
            buttonDuplicates = new Button();
            tabControl1.SuspendLayout();
            Свойства.SuspendLayout();
            МинМакс.SuspendLayout();
            ЧетНечет.SuspendLayout();
            Реверс.SuspendLayout();
            Сдвиг.SuspendLayout();
            Дубликаты.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Свойства);
            tabControl1.Controls.Add(МинМакс);
            tabControl1.Controls.Add(ЧетНечет);
            tabControl1.Controls.Add(Реверс);
            tabControl1.Controls.Add(Сдвиг);
            tabControl1.Controls.Add(Дубликаты);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1087, 703);
            tabControl1.TabIndex = 0;
            // 
            // Свойства
            // 
            Свойства.Controls.Add(labelResult);
            Свойства.Controls.Add(button1);
            Свойства.Controls.Add(textBoxInput);
            Свойства.Controls.Add(label1);
            Свойства.Location = new Point(4, 29);
            Свойства.Name = "Свойства";
            Свойства.Padding = new Padding(3);
            Свойства.Size = new Size(1079, 670);
            Свойства.TabIndex = 0;
            Свойства.Text = "Свойства";
            Свойства.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(522, 84);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 20);
            labelResult.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(32, 299);
            button1.Name = "button1";
            button1.Size = new Size(245, 29);
            button1.TabIndex = 2;
            button1.Text = "Вычислить сумму";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(32, 41);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(245, 252);
            textBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 18);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите 10 чисел:";
            // 
            // МинМакс
            // 
            МинМакс.Controls.Add(labelInfo);
            МинМакс.Controls.Add(labelMinMax);
            МинМакс.Controls.Add(buttonMinMax);
            МинМакс.Controls.Add(textBoxN);
            МинМакс.Location = new Point(4, 29);
            МинМакс.Name = "МинМакс";
            МинМакс.Padding = new Padding(3);
            МинМакс.Size = new Size(1079, 670);
            МинМакс.TabIndex = 1;
            МинМакс.Text = "МинМакс";
            МинМакс.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            labelInfo.AutoSize = true;
            labelInfo.Location = new Point(45, 34);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(186, 20);
            labelInfo.TabIndex = 3;
            labelInfo.Text = "Введите размер массива:";
            // 
            // labelMinMax
            // 
            labelMinMax.AutoSize = true;
            labelMinMax.Location = new Point(473, 74);
            labelMinMax.Name = "labelMinMax";
            labelMinMax.Size = new Size(0, 20);
            labelMinMax.TabIndex = 2;
            // 
            // buttonMinMax
            // 
            buttonMinMax.Location = new Point(45, 102);
            buttonMinMax.Name = "buttonMinMax";
            buttonMinMax.Size = new Size(186, 29);
            buttonMinMax.TabIndex = 1;
            buttonMinMax.Text = "Найти Мин и Макс";
            buttonMinMax.UseVisualStyleBackColor = true;
            buttonMinMax.Click += buttonMinMax_Click;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(45, 57);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(186, 27);
            textBoxN.TabIndex = 0;
            // 
            // ЧетНечет
            // 
            ЧетНечет.Controls.Add(labelEvenOdd);
            ЧетНечет.Controls.Add(labelInfo1);
            ЧетНечет.Controls.Add(buttonEvenOdd);
            ЧетНечет.Location = new Point(4, 29);
            ЧетНечет.Name = "ЧетНечет";
            ЧетНечет.Size = new Size(1079, 670);
            ЧетНечет.TabIndex = 2;
            ЧетНечет.Text = "ЧетНечет";
            ЧетНечет.UseVisualStyleBackColor = true;
            // 
            // labelEvenOdd
            // 
            labelEvenOdd.AutoSize = true;
            labelEvenOdd.Location = new Point(117, 134);
            labelEvenOdd.Name = "labelEvenOdd";
            labelEvenOdd.Size = new Size(0, 20);
            labelEvenOdd.TabIndex = 2;
            // 
            // labelInfo1
            // 
            labelInfo1.AutoSize = true;
            labelInfo1.Location = new Point(8, 14);
            labelInfo1.Name = "labelInfo1";
            labelInfo1.Size = new Size(275, 20);
            labelInfo1.TabIndex = 1;
            labelInfo1.Text = "Массив из 15 случайных чисел (10-50)";
            // 
            // buttonEvenOdd
            // 
            buttonEvenOdd.Location = new Point(15, 37);
            buttonEvenOdd.Name = "buttonEvenOdd";
            buttonEvenOdd.Size = new Size(102, 29);
            buttonEvenOdd.TabIndex = 0;
            buttonEvenOdd.Text = "Подсчитать";
            buttonEvenOdd.UseVisualStyleBackColor = true;
            buttonEvenOdd.Click += buttonEvenOdd_Click;
            // 
            // Реверс
            // 
            Реверс.Controls.Add(textBoxReverse);
            Реверс.Controls.Add(labelReverse);
            Реверс.Controls.Add(lableInfo2);
            Реверс.Controls.Add(buttonReverse);
            Реверс.Location = new Point(4, 29);
            Реверс.Name = "Реверс";
            Реверс.Size = new Size(1079, 670);
            Реверс.TabIndex = 3;
            Реверс.Text = "Реверс";
            Реверс.UseVisualStyleBackColor = true;
            // 
            // textBoxReverse
            // 
            textBoxReverse.Location = new Point(17, 53);
            textBoxReverse.Name = "textBoxReverse";
            textBoxReverse.Size = new Size(224, 27);
            textBoxReverse.TabIndex = 3;
            // 
            // labelReverse
            // 
            labelReverse.AutoSize = true;
            labelReverse.Location = new Point(422, 53);
            labelReverse.Name = "labelReverse";
            labelReverse.Size = new Size(0, 20);
            labelReverse.TabIndex = 2;
            // 
            // lableInfo2
            // 
            lableInfo2.AutoSize = true;
            lableInfo2.Location = new Point(17, 19);
            lableInfo2.Name = "lableInfo2";
            lableInfo2.Size = new Size(224, 20);
            lableInfo2.TabIndex = 1;
            lableInfo2.Text = "Введите 5 чисел через пробел:";
            // 
            // buttonReverse
            // 
            buttonReverse.Location = new Point(17, 104);
            buttonReverse.Name = "buttonReverse";
            buttonReverse.Size = new Size(224, 29);
            buttonReverse.TabIndex = 0;
            buttonReverse.Text = "Сделать реверс";
            buttonReverse.UseVisualStyleBackColor = true;
            buttonReverse.Click += buttonReverse_Click;
            // 
            // Сдвиг
            // 
            Сдвиг.Controls.Add(textBoxShift);
            Сдвиг.Controls.Add(labelShift);
            Сдвиг.Controls.Add(labelInfo2);
            Сдвиг.Controls.Add(buttonShift);
            Сдвиг.Location = new Point(4, 29);
            Сдвиг.Name = "Сдвиг";
            Сдвиг.Size = new Size(1079, 670);
            Сдвиг.TabIndex = 4;
            Сдвиг.Text = "Сдвиг";
            Сдвиг.UseVisualStyleBackColor = true;
            // 
            // textBoxShift
            // 
            textBoxShift.Location = new Point(27, 40);
            textBoxShift.Name = "textBoxShift";
            textBoxShift.Size = new Size(212, 27);
            textBoxShift.TabIndex = 3;
            // 
            // labelShift
            // 
            labelShift.AutoSize = true;
            labelShift.Location = new Point(447, 47);
            labelShift.Name = "labelShift";
            labelShift.Size = new Size(0, 20);
            labelShift.TabIndex = 2;
            // 
            // labelInfo2
            // 
            labelInfo2.AutoSize = true;
            labelInfo2.Location = new Point(27, 17);
            labelInfo2.Name = "labelInfo2";
            labelInfo2.Size = new Size(212, 20);
            labelInfo2.TabIndex = 1;
            labelInfo2.Text = "Введите числа через пробел:";
            // 
            // buttonShift
            // 
            buttonShift.Location = new Point(27, 84);
            buttonShift.Name = "buttonShift";
            buttonShift.Size = new Size(212, 29);
            buttonShift.TabIndex = 0;
            buttonShift.Text = "Сдвинуть вправо";
            buttonShift.UseVisualStyleBackColor = true;
            buttonShift.Click += buttonShift_Click;
            // 
            // Дубликаты
            // 
            Дубликаты.Controls.Add(textBoxDuplicates);
            Дубликаты.Controls.Add(labelDuplicates);
            Дубликаты.Controls.Add(labelInfo3);
            Дубликаты.Controls.Add(buttonDuplicates);
            Дубликаты.Location = new Point(4, 29);
            Дубликаты.Name = "Дубликаты";
            Дубликаты.Size = new Size(1079, 670);
            Дубликаты.TabIndex = 5;
            Дубликаты.Text = "Дубликаты";
            Дубликаты.UseVisualStyleBackColor = true;
            // 
            // textBoxDuplicates
            // 
            textBoxDuplicates.Location = new Point(21, 49);
            textBoxDuplicates.Name = "textBoxDuplicates";
            textBoxDuplicates.Size = new Size(232, 27);
            textBoxDuplicates.TabIndex = 3;
            // 
            // labelDuplicates
            // 
            labelDuplicates.Location = new Point(438, 56);
            labelDuplicates.Name = "labelDuplicates";
            labelDuplicates.Size = new Size(373, 305);
            labelDuplicates.TabIndex = 2;
            // 
            // labelInfo3
            // 
            labelInfo3.AutoSize = true;
            labelInfo3.Location = new Point(21, 16);
            labelInfo3.Name = "labelInfo3";
            labelInfo3.Size = new Size(232, 20);
            labelInfo3.TabIndex = 1;
            labelInfo3.Text = "Введите 10 чисел через пробел:";
            // 
            // buttonDuplicates
            // 
            buttonDuplicates.Location = new Point(21, 82);
            buttonDuplicates.Name = "buttonDuplicates";
            buttonDuplicates.Size = new Size(232, 29);
            buttonDuplicates.TabIndex = 0;
            buttonDuplicates.Text = "Подсчитать дубликаты";
            buttonDuplicates.UseVisualStyleBackColor = true;
            buttonDuplicates.Click += buttonDuplicates_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1090, 715);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            Свойства.ResumeLayout(false);
            Свойства.PerformLayout();
            МинМакс.ResumeLayout(false);
            МинМакс.PerformLayout();
            ЧетНечет.ResumeLayout(false);
            ЧетНечет.PerformLayout();
            Реверс.ResumeLayout(false);
            Реверс.PerformLayout();
            Сдвиг.ResumeLayout(false);
            Сдвиг.PerformLayout();
            Дубликаты.ResumeLayout(false);
            Дубликаты.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Свойства;
        private TabPage МинМакс;
        private TabPage ЧетНечет;
        private TabPage Реверс;
        private TabPage Сдвиг;
        private TabPage Дубликаты;
        private Label label1;
        private Label labelResult;
        private Button button1;
        private TextBox textBoxInput;
        private TextBox textBoxN;
        private Label labelMinMax;
        private Button buttonMinMax;
        private Label labelInfo;
        private Label labelEvenOdd;
        private Label labelInfo1;
        private Button buttonEvenOdd;
        private TextBox textBoxReverse;
        private Label labelReverse;
        private Label lableInfo2;
        private Button buttonReverse;
        private TextBox textBoxShift;
        private Label labelShift;
        private Label labelInfo2;
        private Button buttonShift;
        private TextBox textBoxDuplicates;
        private Label labelDuplicates;
        private Label labelInfo3;
        private Button buttonDuplicates;
    }
}
