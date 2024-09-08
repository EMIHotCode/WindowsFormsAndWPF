namespace Lesson6_1
{
    partial class Теорема_пифагора
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxKatetA = new System.Windows.Forms.TextBox();
            this.txtBoxKatetB = new System.Windows.Forms.TextBox();
            this.txtBoxGepotenuza = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "катет А";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "катет В";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Гипотенуза";
            // 
            // txtBoxKatetA
            // 
            this.txtBoxKatetA.Location = new System.Drawing.Point(283, 29);
            this.txtBoxKatetA.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxKatetA.Name = "txtBoxKatetA";
            this.txtBoxKatetA.Size = new System.Drawing.Size(125, 22);
            this.txtBoxKatetA.TabIndex = 3;
            // 
            // txtBoxKatetB
            // 
            this.txtBoxKatetB.Location = new System.Drawing.Point(283, 79);
            this.txtBoxKatetB.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxKatetB.Name = "txtBoxKatetB";
            this.txtBoxKatetB.Size = new System.Drawing.Size(125, 22);
            this.txtBoxKatetB.TabIndex = 4;
            // 
            // txtBoxGepotenuza
            // 
            this.txtBoxGepotenuza.Location = new System.Drawing.Point(283, 136);
            this.txtBoxGepotenuza.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxGepotenuza.Name = "txtBoxGepotenuza";
            this.txtBoxGepotenuza.Size = new System.Drawing.Size(125, 22);
            this.txtBoxGepotenuza.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(52, 214);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(194, 214);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 36);
            this.button2.TabIndex = 7;
            this.button2.Text = "В Меню";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 36);
            this.button3.TabIndex = 8;
            this.button3.Text = "Сброс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Теорема_пифагора
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 334);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBoxGepotenuza);
            this.Controls.Add(this.txtBoxKatetB);
            this.Controls.Add(this.txtBoxKatetA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Теорема_пифагора";
            this.Text = "Теорема_пифагора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxKatetA;
        private System.Windows.Forms.TextBox txtBoxKatetB;
        private System.Windows.Forms.TextBox txtBoxGepotenuza;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}