namespace WindowsFormsApp1
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
            this.createButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.getElementButton = new System.Windows.Forms.Button();
            this.showArrayButton = new System.Windows.Forms.Button();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.otherNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.indexNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(33, 103);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(123, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Создать массив";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(33, 132);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(123, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Сложить массив";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(33, 165);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(123, 23);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "Вычесть из массива";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Location = new System.Drawing.Point(33, 223);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(123, 23);
            this.multiplyButton.TabIndex = 3;
            this.multiplyButton.Text = "Умножить";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // getElementButton
            // 
            this.getElementButton.Location = new System.Drawing.Point(33, 194);
            this.getElementButton.Name = "getElementButton";
            this.getElementButton.Size = new System.Drawing.Size(123, 23);
            this.getElementButton.TabIndex = 4;
            this.getElementButton.Text = "Достать элемент";
            this.getElementButton.UseVisualStyleBackColor = true;
            this.getElementButton.Click += new System.EventHandler(this.getElementButton_Click);
            // 
            // showArrayButton
            // 
            this.showArrayButton.Location = new System.Drawing.Point(33, 252);
            this.showArrayButton.Name = "showArrayButton";
            this.showArrayButton.Size = new System.Drawing.Size(123, 23);
            this.showArrayButton.TabIndex = 5;
            this.showArrayButton.Text = "Показать";
            this.showArrayButton.UseVisualStyleBackColor = true;
            this.showArrayButton.Click += new System.EventHandler(this.showArrayButton_Click);
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Location = new System.Drawing.Point(214, 103);
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.sizeNumericUpDown.TabIndex = 6;
            this.sizeNumericUpDown.ValueChanged += new System.EventHandler(this.sizeNumericUpDown_ValueChanged);
            // 
            // otherNumericUpDown
            // 
            this.otherNumericUpDown.Location = new System.Drawing.Point(214, 148);
            this.otherNumericUpDown.Name = "otherNumericUpDown";
            this.otherNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.otherNumericUpDown.TabIndex = 7;
            this.otherNumericUpDown.ValueChanged += new System.EventHandler(this.otherNumericUpDown_ValueChanged);
            // 
            // numberNumericUpDown
            // 
            this.numberNumericUpDown.Location = new System.Drawing.Point(214, 235);
            this.numberNumericUpDown.Name = "numberNumericUpDown";
            this.numberNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.numberNumericUpDown.TabIndex = 9;
            this.numberNumericUpDown.ValueChanged += new System.EventHandler(this.numberNumericUpDown_ValueChanged);
            // 
            // indexNumericUpDown
            // 
            this.indexNumericUpDown.Location = new System.Drawing.Point(214, 197);
            this.indexNumericUpDown.Name = "indexNumericUpDown";
            this.indexNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.indexNumericUpDown.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Размерность массива";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Действие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Индекс";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Число";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.forest;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.indexNumericUpDown);
            this.Controls.Add(this.numberNumericUpDown);
            this.Controls.Add(this.otherNumericUpDown);
            this.Controls.Add(this.sizeNumericUpDown);
            this.Controls.Add(this.showArrayButton);
            this.Controls.Add(this.getElementButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.createButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otherNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.indexNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button getElementButton;
        private System.Windows.Forms.Button showArrayButton;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.NumericUpDown otherNumericUpDown;
        private System.Windows.Forms.NumericUpDown numberNumericUpDown;
        private System.Windows.Forms.NumericUpDown indexNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

