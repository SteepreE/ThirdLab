namespace ThirdLab
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
            this.Vec1Label = new System.Windows.Forms.Label();
            this.Vec2Label = new System.Windows.Forms.Label();
            this.Vec1XInput = new System.Windows.Forms.TextBox();
            this.Vec1YInput = new System.Windows.Forms.TextBox();
            this.Vec1ZInput = new System.Windows.Forms.TextBox();
            this.Vec2ZInput = new System.Windows.Forms.TextBox();
            this.Vec2YInput = new System.Windows.Forms.TextBox();
            this.Vec2XInput = new System.Windows.Forms.TextBox();
            this.Summ = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DotResult = new System.Windows.Forms.Label();
            this.CrossResult = new System.Windows.Forms.Label();
            this.DiffResult = new System.Windows.Forms.Label();
            this.SummResult = new System.Windows.Forms.Label();
            this.Vec1Len = new System.Windows.Forms.Label();
            this.Vec2Len = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Vec1Img = new System.Windows.Forms.PictureBox();
            this.Vec2Img = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Vec1Img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vec2Img)).BeginInit();
            this.SuspendLayout();
            // 
            // Vec1Label
            // 
            this.Vec1Label.AutoSize = true;
            this.Vec1Label.Location = new System.Drawing.Point(12, 9);
            this.Vec1Label.Name = "Vec1Label";
            this.Vec1Label.Size = new System.Drawing.Size(47, 13);
            this.Vec1Label.TabIndex = 1;
            this.Vec1Label.Text = "Vector a";
            // 
            // Vec2Label
            // 
            this.Vec2Label.AutoSize = true;
            this.Vec2Label.Location = new System.Drawing.Point(350, 9);
            this.Vec2Label.Name = "Vec2Label";
            this.Vec2Label.Size = new System.Drawing.Size(47, 13);
            this.Vec2Label.TabIndex = 2;
            this.Vec2Label.Text = "Vector b";
            // 
            // Vec1XInput
            // 
            this.Vec1XInput.Location = new System.Drawing.Point(15, 45);
            this.Vec1XInput.Name = "Vec1XInput";
            this.Vec1XInput.Size = new System.Drawing.Size(44, 20);
            this.Vec1XInput.TabIndex = 3;
            this.Vec1XInput.TextChanged += new System.EventHandler(this.ChangesHandler);
            // 
            // Vec1YInput
            // 
            this.Vec1YInput.Location = new System.Drawing.Point(80, 45);
            this.Vec1YInput.Name = "Vec1YInput";
            this.Vec1YInput.Size = new System.Drawing.Size(47, 20);
            this.Vec1YInput.TabIndex = 4;
            this.Vec1YInput.TextChanged += new System.EventHandler(this.ChangesHandler);
            // 
            // Vec1ZInput
            // 
            this.Vec1ZInput.Location = new System.Drawing.Point(146, 45);
            this.Vec1ZInput.Name = "Vec1ZInput";
            this.Vec1ZInput.Size = new System.Drawing.Size(44, 20);
            this.Vec1ZInput.TabIndex = 5;
            this.Vec1ZInput.TextChanged += new System.EventHandler(this.ChangesHandler);
            // 
            // Vec2ZInput
            // 
            this.Vec2ZInput.Location = new System.Drawing.Point(484, 45);
            this.Vec2ZInput.Name = "Vec2ZInput";
            this.Vec2ZInput.Size = new System.Drawing.Size(44, 20);
            this.Vec2ZInput.TabIndex = 8;
            this.Vec2ZInput.TextChanged += new System.EventHandler(this.ChangesHandler);
            // 
            // Vec2YInput
            // 
            this.Vec2YInput.Location = new System.Drawing.Point(418, 45);
            this.Vec2YInput.Name = "Vec2YInput";
            this.Vec2YInput.Size = new System.Drawing.Size(47, 20);
            this.Vec2YInput.TabIndex = 7;
            this.Vec2YInput.TextChanged += new System.EventHandler(this.ChangesHandler);
            // 
            // Vec2XInput
            // 
            this.Vec2XInput.Location = new System.Drawing.Point(353, 45);
            this.Vec2XInput.Name = "Vec2XInput";
            this.Vec2XInput.Size = new System.Drawing.Size(44, 20);
            this.Vec2XInput.TabIndex = 6;
            this.Vec2XInput.TextChanged += new System.EventHandler(this.ChangesHandler);
            // 
            // Summ
            // 
            this.Summ.AutoSize = true;
            this.Summ.Location = new System.Drawing.Point(15, 194);
            this.Summ.Name = "Summ";
            this.Summ.Size = new System.Drawing.Size(44, 13);
            this.Summ.TabIndex = 9;
            this.Summ.Text = "Сумма:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Разность:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Скалярное произведение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Векторное произведение:";
            // 
            // DotResult
            // 
            this.DotResult.AutoSize = true;
            this.DotResult.Location = new System.Drawing.Point(452, 194);
            this.DotResult.Name = "DotResult";
            this.DotResult.Size = new System.Drawing.Size(0, 13);
            this.DotResult.TabIndex = 13;
            // 
            // CrossResult
            // 
            this.CrossResult.AutoSize = true;
            this.CrossResult.Location = new System.Drawing.Point(455, 219);
            this.CrossResult.Name = "CrossResult";
            this.CrossResult.Size = new System.Drawing.Size(0, 13);
            this.CrossResult.TabIndex = 14;
            // 
            // DiffResult
            // 
            this.DiffResult.AutoSize = true;
            this.DiffResult.Location = new System.Drawing.Point(79, 219);
            this.DiffResult.Name = "DiffResult";
            this.DiffResult.Size = new System.Drawing.Size(0, 13);
            this.DiffResult.TabIndex = 15;
            // 
            // SummResult
            // 
            this.SummResult.AutoSize = true;
            this.SummResult.Location = new System.Drawing.Point(65, 194);
            this.SummResult.Name = "SummResult";
            this.SummResult.Size = new System.Drawing.Size(0, 13);
            this.SummResult.TabIndex = 16;
            // 
            // Vec1Len
            // 
            this.Vec1Len.AutoSize = true;
            this.Vec1Len.Location = new System.Drawing.Point(196, 9);
            this.Vec1Len.Name = "Vec1Len";
            this.Vec1Len.Size = new System.Drawing.Size(0, 13);
            this.Vec1Len.TabIndex = 17;
            // 
            // Vec2Len
            // 
            this.Vec2Len.AutoSize = true;
            this.Vec2Len.Location = new System.Drawing.Point(528, 9);
            this.Vec2Len.Name = "Vec2Len";
            this.Vec2Len.Size = new System.Drawing.Size(0, 13);
            this.Vec2Len.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Длинна:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Длинна:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 38);
            this.button1.TabIndex = 21;
            this.button1.Text = "Случайные вектора";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CreateRandomVectors);
            // 
            // Vec1Img
            // 
            this.Vec1Img.Location = new System.Drawing.Point(15, 71);
            this.Vec1Img.Name = "Vec1Img";
            this.Vec1Img.Size = new System.Drawing.Size(175, 120);
            this.Vec1Img.TabIndex = 22;
            this.Vec1Img.TabStop = false;
            // 
            // Vec2Img
            // 
            this.Vec2Img.Location = new System.Drawing.Point(353, 72);
            this.Vec2Img.Name = "Vec2Img";
            this.Vec2Img.Size = new System.Drawing.Size(175, 120);
            this.Vec2Img.TabIndex = 23;
            this.Vec2Img.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 283);
            this.Controls.Add(this.Vec2Img);
            this.Controls.Add(this.Vec1Img);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Vec2Len);
            this.Controls.Add(this.Vec1Len);
            this.Controls.Add(this.SummResult);
            this.Controls.Add(this.DiffResult);
            this.Controls.Add(this.CrossResult);
            this.Controls.Add(this.DotResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Summ);
            this.Controls.Add(this.Vec2ZInput);
            this.Controls.Add(this.Vec2YInput);
            this.Controls.Add(this.Vec2XInput);
            this.Controls.Add(this.Vec1ZInput);
            this.Controls.Add(this.Vec1YInput);
            this.Controls.Add(this.Vec1XInput);
            this.Controls.Add(this.Vec2Label);
            this.Controls.Add(this.Vec1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Vec1Img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vec2Img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Vec1Label;
        private System.Windows.Forms.Label Vec2Label;
        private System.Windows.Forms.TextBox Vec1XInput;
        private System.Windows.Forms.TextBox Vec1YInput;
        private System.Windows.Forms.TextBox Vec1ZInput;
        private System.Windows.Forms.TextBox Vec2ZInput;
        private System.Windows.Forms.TextBox Vec2YInput;
        private System.Windows.Forms.TextBox Vec2XInput;
        private System.Windows.Forms.Label Summ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DotResult;
        private System.Windows.Forms.Label CrossResult;
        private System.Windows.Forms.Label DiffResult;
        private System.Windows.Forms.Label SummResult;
        private System.Windows.Forms.Label Vec1Len;
        private System.Windows.Forms.Label Vec2Len;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox Vec1Img;
        private System.Windows.Forms.PictureBox Vec2Img;
    }
}

