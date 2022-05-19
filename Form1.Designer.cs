
namespace CALCULATOR
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.PanelWindow = new System.Windows.Forms.Panel();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.buttonZero = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttoNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonDivid = new System.Windows.Forms.Button();
            this.buttonErase = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonInSquare = new System.Windows.Forms.Button();
            this.buttonSqrt = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.PanelWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelWindow
            // 
            this.PanelWindow.Controls.Add(this.buttonEquals);
            this.PanelWindow.Controls.Add(this.buttonPlusMinus);
            this.PanelWindow.Controls.Add(this.buttonZero);
            this.PanelWindow.Controls.Add(this.buttonDot);
            this.PanelWindow.Controls.Add(this.buttonPlus);
            this.PanelWindow.Controls.Add(this.buttonThree);
            this.PanelWindow.Controls.Add(this.buttonTwo);
            this.PanelWindow.Controls.Add(this.buttonOne);
            this.PanelWindow.Controls.Add(this.buttonMinus);
            this.PanelWindow.Controls.Add(this.buttonSix);
            this.PanelWindow.Controls.Add(this.buttonFive);
            this.PanelWindow.Controls.Add(this.buttonFour);
            this.PanelWindow.Controls.Add(this.buttonMultiply);
            this.PanelWindow.Controls.Add(this.buttoNine);
            this.PanelWindow.Controls.Add(this.buttonEight);
            this.PanelWindow.Controls.Add(this.buttonSeven);
            this.PanelWindow.Controls.Add(this.buttonDivid);
            this.PanelWindow.Controls.Add(this.buttonErase);
            this.PanelWindow.Controls.Add(this.buttonClear);
            this.PanelWindow.Controls.Add(this.button5);
            this.PanelWindow.Controls.Add(this.button4);
            this.PanelWindow.Controls.Add(this.buttonInSquare);
            this.PanelWindow.Controls.Add(this.buttonSqrt);
            this.PanelWindow.Controls.Add(this.buttonPercent);
            this.PanelWindow.Controls.Add(this.textBox1);
            this.PanelWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelWindow.Location = new System.Drawing.Point(0, 0);
            this.PanelWindow.Name = "PanelWindow";
            this.PanelWindow.Size = new System.Drawing.Size(331, 551);
            this.PanelWindow.TabIndex = 0;
            // 
            // buttonEquals
            // 
            this.buttonEquals.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonEquals.Location = new System.Drawing.Point(249, 481);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(78, 67);
            this.buttonEquals.TabIndex = 24;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = true;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEquals_Click);
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonPlusMinus.Location = new System.Drawing.Point(168, 481);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(75, 67);
            this.buttonPlusMinus.TabIndex = 23;
            this.buttonPlusMinus.Text = "±";
            this.buttonPlusMinus.UseVisualStyleBackColor = true;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonZero
            // 
            this.buttonZero.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonZero.Location = new System.Drawing.Point(87, 481);
            this.buttonZero.Name = "buttonZero";
            this.buttonZero.Size = new System.Drawing.Size(75, 67);
            this.buttonZero.TabIndex = 22;
            this.buttonZero.Text = "0";
            this.buttonZero.UseVisualStyleBackColor = true;
            this.buttonZero.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDot.Location = new System.Drawing.Point(3, 481);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(75, 67);
            this.buttonDot.TabIndex = 21;
            this.buttonDot.Text = ".";
            this.buttonDot.UseVisualStyleBackColor = true;
            this.buttonDot.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonPlus.Location = new System.Drawing.Point(249, 408);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(79, 67);
            this.buttonPlus.TabIndex = 20;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonThree
            // 
            this.buttonThree.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonThree.Location = new System.Drawing.Point(168, 408);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(75, 67);
            this.buttonThree.TabIndex = 19;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = true;
            this.buttonThree.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonTwo.Location = new System.Drawing.Point(87, 408);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(75, 67);
            this.buttonTwo.TabIndex = 18;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonOne.Location = new System.Drawing.Point(3, 408);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(75, 67);
            this.buttonOne.TabIndex = 17;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonMinus.Location = new System.Drawing.Point(248, 335);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(79, 67);
            this.buttonMinus.TabIndex = 16;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonSix
            // 
            this.buttonSix.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSix.Location = new System.Drawing.Point(168, 335);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(75, 67);
            this.buttonSix.TabIndex = 15;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = true;
            this.buttonSix.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonFive.Location = new System.Drawing.Point(87, 335);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(75, 67);
            this.buttonFive.TabIndex = 14;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = true;
            this.buttonFive.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonFour.Location = new System.Drawing.Point(3, 335);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(75, 67);
            this.buttonFour.TabIndex = 13;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = true;
            this.buttonFour.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonMultiply.Location = new System.Drawing.Point(248, 262);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(79, 67);
            this.buttonMultiply.TabIndex = 12;
            this.buttonMultiply.Text = "ˣ";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttoNine
            // 
            this.buttoNine.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttoNine.Location = new System.Drawing.Point(168, 262);
            this.buttoNine.Name = "buttoNine";
            this.buttoNine.Size = new System.Drawing.Size(75, 67);
            this.buttoNine.TabIndex = 11;
            this.buttoNine.Text = "9";
            this.buttoNine.UseVisualStyleBackColor = true;
            this.buttoNine.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonEight.Location = new System.Drawing.Point(87, 262);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(75, 67);
            this.buttonEight.TabIndex = 10;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = true;
            this.buttonEight.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSeven.Location = new System.Drawing.Point(3, 262);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(75, 67);
            this.buttonSeven.TabIndex = 9;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = true;
            this.buttonSeven.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonDivid
            // 
            this.buttonDivid.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDivid.Location = new System.Drawing.Point(248, 189);
            this.buttonDivid.Name = "buttonDivid";
            this.buttonDivid.Size = new System.Drawing.Size(80, 67);
            this.buttonDivid.TabIndex = 8;
            this.buttonDivid.Text = "/";
            this.buttonDivid.UseVisualStyleBackColor = true;
            this.buttonDivid.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // buttonErase
            // 
            this.buttonErase.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonErase.Location = new System.Drawing.Point(167, 189);
            this.buttonErase.Name = "buttonErase";
            this.buttonErase.Size = new System.Drawing.Size(75, 67);
            this.buttonErase.TabIndex = 7;
            this.buttonErase.Text = "<=";
            this.buttonErase.UseVisualStyleBackColor = true;
            this.buttonErase.Click += new System.EventHandler(this.buttonErase_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonClear.Location = new System.Drawing.Point(84, 189);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(78, 67);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(3, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 67);
            this.button5.TabIndex = 5;
            this.button5.Text = "CE";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.button4.Location = new System.Drawing.Point(248, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 67);
            this.button4.TabIndex = 4;
            this.button4.Text = "1/x";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonInSquare
            // 
            this.buttonInSquare.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonInSquare.Location = new System.Drawing.Point(168, 116);
            this.buttonInSquare.Name = "buttonInSquare";
            this.buttonInSquare.Size = new System.Drawing.Size(75, 67);
            this.buttonInSquare.TabIndex = 3;
            this.buttonInSquare.Text = "ₓ⁮²";
            this.buttonInSquare.UseVisualStyleBackColor = true;
            this.buttonInSquare.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonSqrt
            // 
            this.buttonSqrt.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSqrt.Location = new System.Drawing.Point(84, 116);
            this.buttonSqrt.Name = "buttonSqrt";
            this.buttonSqrt.Size = new System.Drawing.Size(78, 67);
            this.buttonSqrt.TabIndex = 2;
            this.buttonSqrt.Text = "√";
            this.buttonSqrt.UseVisualStyleBackColor = true;
            this.buttonSqrt.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(3, 116);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(75, 67);
            this.buttonPercent.TabIndex = 1;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonSqrt_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 69);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 551);
            this.Controls.Add(this.PanelWindow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(331, 539);
            this.Name = "FormCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Калькулятор";
            this.PanelWindow.ResumeLayout(false);
            this.PanelWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelWindow;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button buttonZero;
        private System.Windows.Forms.Button buttonDot;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttoNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonDivid;
        private System.Windows.Forms.Button buttonErase;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonInSquare;
        private System.Windows.Forms.Button buttonSqrt;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.TextBox textBox1;
    }
}

