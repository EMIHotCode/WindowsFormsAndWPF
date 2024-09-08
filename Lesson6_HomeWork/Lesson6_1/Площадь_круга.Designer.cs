namespace Lesson6_1
{
    partial class Площадь_круга
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTask1 = new System.Windows.Forms.TextBox();
            this.labelRezult1 = new System.Windows.Forms.Label();
            this.textBoxRezult1 = new System.Windows.Forms.TextBox();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.textBoxRezult2 = new System.Windows.Forms.TextBox();
            this.labelRezult2 = new System.Windows.Forms.Label();
            this.textBoxTask2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.textBoxRezult3 = new System.Windows.Forms.TextBox();
            this.labelRezult3 = new System.Windows.Forms.Label();
            this.textBoxTask3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(175, 322);
            this.button2.Margin = new System.Windows.Forms.Padding(5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 34);
            this.button2.TabIndex = 13;
            this.button2.Text = "В Меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonTask1
            // 
            this.buttonTask1.Location = new System.Drawing.Point(36, 116);
            this.buttonTask1.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(87, 28);
            this.buttonTask1.TabIndex = 12;
            this.buttonTask1.Text = "Решить";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(42, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(404, 216);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnReset1);
            this.tabPage1.Controls.Add(this.textBoxRezult1);
            this.tabPage1.Controls.Add(this.labelRezult1);
            this.tabPage1.Controls.Add(this.textBoxTask1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonTask1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(396, 190);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Через радиус";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnReset2);
            this.tabPage2.Controls.Add(this.textBoxRezult2);
            this.tabPage2.Controls.Add(this.labelRezult2);
            this.tabPage2.Controls.Add(this.textBoxTask2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.buttonTask2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(396, 190);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Через диаметр";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnReset3);
            this.tabPage3.Controls.Add(this.textBoxRezult3);
            this.tabPage3.Controls.Add(this.labelRezult3);
            this.tabPage3.Controls.Add(this.textBoxTask3);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.buttonTask3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(396, 190);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Через длину окружности";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Выберите одну из вкладок для нахождения площади круга ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Формула S = π × r^2, где r — это радиус, π — это константа = 3,14";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введите радиус:";
            // 
            // textBoxTask1
            // 
            this.textBoxTask1.Location = new System.Drawing.Point(129, 51);
            this.textBoxTask1.Name = "textBoxTask1";
            this.textBoxTask1.Size = new System.Drawing.Size(81, 20);
            this.textBoxTask1.TabIndex = 2;
            // 
            // labelRezult1
            // 
            this.labelRezult1.AutoSize = true;
            this.labelRezult1.Location = new System.Drawing.Point(33, 155);
            this.labelRezult1.Name = "labelRezult1";
            this.labelRezult1.Size = new System.Drawing.Size(124, 13);
            this.labelRezult1.TabIndex = 13;
            this.labelRezult1.Text = "Площадь круга равна: ";
            // 
            // textBoxRezult1
            // 
            this.textBoxRezult1.Location = new System.Drawing.Point(163, 152);
            this.textBoxRezult1.Name = "textBoxRezult1";
            this.textBoxRezult1.Size = new System.Drawing.Size(47, 20);
            this.textBoxRezult1.TabIndex = 14;
            // 
            // btnReset1
            // 
            this.btnReset1.Location = new System.Drawing.Point(133, 116);
            this.btnReset1.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(87, 28);
            this.btnReset1.TabIndex = 15;
            this.btnReset1.Text = "Сбросить";
            this.btnReset1.UseVisualStyleBackColor = true;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(134, 111);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(87, 28);
            this.btnReset2.TabIndex = 22;
            this.btnReset2.Text = "Сбросить";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // textBoxRezult2
            // 
            this.textBoxRezult2.Location = new System.Drawing.Point(164, 147);
            this.textBoxRezult2.Name = "textBoxRezult2";
            this.textBoxRezult2.Size = new System.Drawing.Size(47, 20);
            this.textBoxRezult2.TabIndex = 21;
            // 
            // labelRezult2
            // 
            this.labelRezult2.AutoSize = true;
            this.labelRezult2.Location = new System.Drawing.Point(34, 150);
            this.labelRezult2.Name = "labelRezult2";
            this.labelRezult2.Size = new System.Drawing.Size(124, 13);
            this.labelRezult2.TabIndex = 20;
            this.labelRezult2.Text = "Площадь круга равна: ";
            // 
            // textBoxTask2
            // 
            this.textBoxTask2.Location = new System.Drawing.Point(140, 43);
            this.textBoxTask2.Name = "textBoxTask2";
            this.textBoxTask2.Size = new System.Drawing.Size(81, 20);
            this.textBoxTask2.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Введите диаметр:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Формула: S = d^2 / 4 × π, где d — это диаметр ";
            // 
            // buttonTask2
            // 
            this.buttonTask2.Location = new System.Drawing.Point(37, 111);
            this.buttonTask2.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(87, 28);
            this.buttonTask2.TabIndex = 19;
            this.buttonTask2.Text = "Решить";
            this.buttonTask2.UseVisualStyleBackColor = true;
            this.buttonTask2.Click += new System.EventHandler(this.buttonTask2_Click);
            // 
            // btnReset3
            // 
            this.btnReset3.Location = new System.Drawing.Point(133, 108);
            this.btnReset3.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(87, 28);
            this.btnReset3.TabIndex = 29;
            this.btnReset3.Text = "Сбросить";
            this.btnReset3.UseVisualStyleBackColor = true;
            this.btnReset3.Click += new System.EventHandler(this.btnReset3_Click);
            // 
            // textBoxRezult3
            // 
            this.textBoxRezult3.Location = new System.Drawing.Point(163, 144);
            this.textBoxRezult3.Name = "textBoxRezult3";
            this.textBoxRezult3.Size = new System.Drawing.Size(47, 20);
            this.textBoxRezult3.TabIndex = 28;
            // 
            // labelRezult3
            // 
            this.labelRezult3.AutoSize = true;
            this.labelRezult3.Location = new System.Drawing.Point(33, 147);
            this.labelRezult3.Name = "labelRezult3";
            this.labelRezult3.Size = new System.Drawing.Size(124, 13);
            this.labelRezult3.TabIndex = 27;
            this.labelRezult3.Text = "Площадь круга равна: ";
            // 
            // textBoxTask3
            // 
            this.textBoxTask3.Location = new System.Drawing.Point(186, 40);
            this.textBoxTask3.Name = "textBoxTask3";
            this.textBoxTask3.Size = new System.Drawing.Size(81, 20);
            this.textBoxTask3.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Введите длину окружности:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Формула: S = L^2​ / (4 × π), где L — это длина окружности";
            // 
            // buttonTask3
            // 
            this.buttonTask3.Location = new System.Drawing.Point(36, 108);
            this.buttonTask3.Margin = new System.Windows.Forms.Padding(5);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(87, 28);
            this.buttonTask3.TabIndex = 26;
            this.buttonTask3.Text = "Решить";
            this.buttonTask3.UseVisualStyleBackColor = true;
            this.buttonTask3.Click += new System.EventHandler(this.buttonTask3_Click);
            // 
            // Площадь_круга
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Name = "Площадь_круга";
            this.Text = "Площадь_круга";
            this.Load += new System.EventHandler(this.Площадь_круга_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRezult1;
        private System.Windows.Forms.TextBox textBoxTask1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRezult1;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.TextBox textBoxRezult2;
        private System.Windows.Forms.Label labelRezult2;
        private System.Windows.Forms.TextBox textBoxTask2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonTask2;
        private System.Windows.Forms.Button btnReset3;
        private System.Windows.Forms.TextBox textBoxRezult3;
        private System.Windows.Forms.Label labelRezult3;
        private System.Windows.Forms.TextBox textBoxTask3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonTask3;
    }
}