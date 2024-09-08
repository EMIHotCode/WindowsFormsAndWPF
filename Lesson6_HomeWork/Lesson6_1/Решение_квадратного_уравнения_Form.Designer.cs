namespace Lesson6_1
{
    partial class Решение_квадратного_уравнения_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtBoxA = new System.Windows.Forms.TextBox();
            this.txtBoxB = new System.Windows.Forms.TextBox();
            this.txtBoxC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtBoxX1 = new System.Windows.Forms.TextBox();
            this.txtBoxX2 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "A*x^2+B*x+C=0   Введите значиения A,B,C";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.58823F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.41177F));
            this.tableLayoutPanel1.Controls.Add(this.lblA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxC, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 61);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(206, 100);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(3, 0);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(15, 16);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(3, 33);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(15, 16);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(3, 66);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(15, 16);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C";
            // 
            // txtBoxA
            // 
            this.txtBoxA.Location = new System.Drawing.Point(24, 3);
            this.txtBoxA.Name = "txtBoxA";
            this.txtBoxA.Size = new System.Drawing.Size(171, 22);
            this.txtBoxA.TabIndex = 3;
            // 
            // txtBoxB
            // 
            this.txtBoxB.Location = new System.Drawing.Point(24, 36);
            this.txtBoxB.Name = "txtBoxB";
            this.txtBoxB.Size = new System.Drawing.Size(171, 22);
            this.txtBoxB.TabIndex = 4;
            // 
            // txtBoxC
            // 
            this.txtBoxC.Location = new System.Drawing.Point(24, 69);
            this.txtBoxC.Name = "txtBoxC";
            this.txtBoxC.Size = new System.Drawing.Size(168, 22);
            this.txtBoxC.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(40, 226);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(63, 16);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "корень 1";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(40, 262);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(63, 16);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "корень 2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "В Меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtBoxX1
            // 
            this.txtBoxX1.Location = new System.Drawing.Point(109, 226);
            this.txtBoxX1.Name = "txtBoxX1";
            this.txtBoxX1.Size = new System.Drawing.Size(64, 22);
            this.txtBoxX1.TabIndex = 6;
            // 
            // txtBoxX2
            // 
            this.txtBoxX2.Location = new System.Drawing.Point(109, 262);
            this.txtBoxX2.Name = "txtBoxX2";
            this.txtBoxX2.Size = new System.Drawing.Size(64, 22);
            this.txtBoxX2.TabIndex = 7;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(170, 304);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(111, 36);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Решение_квадратного_уравнения_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 369);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtBoxX2);
            this.Controls.Add(this.txtBoxX1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Решение_квадратного_уравнения_Form";
            this.Text = "Решение_квадратного_уравнения_Form";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtBoxA;
        private System.Windows.Forms.TextBox txtBoxB;
        private System.Windows.Forms.TextBox txtBoxC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtBoxX1;
        private System.Windows.Forms.TextBox txtBoxX2;
        private System.Windows.Forms.Button btnReset;
    }
}