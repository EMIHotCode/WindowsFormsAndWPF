namespace Lesson6_1
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
            this.listBoxAlgebra = new System.Windows.Forms.ListBox();
            this.listBoxGeometria = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAlgebra
            // 
            this.listBoxAlgebra.FormattingEnabled = true;
            this.listBoxAlgebra.Items.AddRange(new object[] {
            "Решение квадратного уравнения",
            "Упрощение алгебраических выражений"});
            this.listBoxAlgebra.Location = new System.Drawing.Point(43, 51);
            this.listBoxAlgebra.Name = "listBoxAlgebra";
            this.listBoxAlgebra.Size = new System.Drawing.Size(270, 316);
            this.listBoxAlgebra.TabIndex = 0;
            this.listBoxAlgebra.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBoxGeometria
            // 
            this.listBoxGeometria.FormattingEnabled = true;
            this.listBoxGeometria.Items.AddRange(new object[] {
            "Теорема Пифагора",
            "Нахождение треугольника по формуле Герона",
            "Площадь круга"});
            this.listBoxGeometria.Location = new System.Drawing.Point(396, 51);
            this.listBoxGeometria.Name = "listBoxGeometria";
            this.listBoxGeometria.Size = new System.Drawing.Size(270, 316);
            this.listBoxGeometria.TabIndex = 1;
            this.listBoxGeometria.SelectedIndexChanged += new System.EventHandler(this.listBoxGeometria_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Алгебра";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(396, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Геометрия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxGeometria);
            this.Controls.Add(this.listBoxAlgebra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlgebra;
        private System.Windows.Forms.ListBox listBoxGeometria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

