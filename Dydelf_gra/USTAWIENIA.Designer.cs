namespace Dydelf_gra
{
    partial class USTAWIENIA
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
            X = new TextBox();
            Y = new TextBox();
            krokodyle = new TextBox();
            dydelfy = new TextBox();
            czas = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // X
            // 
            X.Location = new Point(237, 124);
            X.Name = "X";
            X.Size = new Size(100, 23);
            X.TabIndex = 0;
            X.TextChanged += X_TextChanged;
            // 
            // Y
            // 
            Y.Location = new Point(237, 214);
            Y.Name = "Y";
            Y.Size = new Size(100, 23);
            Y.TabIndex = 1;
            Y.TextChanged += Y_TextChanged;
            // 
            // krokodyle
            // 
            krokodyle.Location = new Point(438, 214);
            krokodyle.Name = "krokodyle";
            krokodyle.Size = new Size(100, 23);
            krokodyle.TabIndex = 2;
            krokodyle.TextChanged += krokodyle_TextChanged;
            // 
            // dydelfy
            // 
            dydelfy.Location = new Point(438, 124);
            dydelfy.Name = "dydelfy";
            dydelfy.Size = new Size(100, 23);
            dydelfy.TabIndex = 3;
            dydelfy.TextChanged += dydelfy_TextChanged;
            // 
            // czas
            // 
            czas.Location = new Point(437, 316);
            czas.Name = "czas";
            czas.Size = new Size(100, 23);
            czas.TabIndex = 4;
            czas.TextChanged += czas_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label1.Location = new Point(249, 98);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 5;
            label1.Text = "plansza";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(450, 98);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 6;
            label2.Text = "Dydelfy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(186, 119);
            label3.Name = "label3";
            label3.Size = new Size(24, 25);
            label3.TabIndex = 7;
            label3.Text = "X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(186, 212);
            label4.Name = "label4";
            label4.Size = new Size(24, 25);
            label4.TabIndex = 8;
            label4.Text = "Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(437, 188);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 9;
            label5.Text = "Krokodyle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(359, 311);
            label6.Name = "label6";
            label6.Size = new Size(51, 25);
            label6.TabIndex = 10;
            label6.Text = "Czas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label7.Location = new Point(300, 9);
            label7.Name = "label7";
            label7.Size = new Size(170, 32);
            label7.TabIndex = 11;
            label7.Text = "USTAWIENIA";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            button1.Location = new Point(237, 383);
            button1.Name = "button1";
            button1.Size = new Size(90, 31);
            button1.TabIndex = 12;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // USTAWIENIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(czas);
            Controls.Add(dydelfy);
            Controls.Add(krokodyle);
            Controls.Add(Y);
            Controls.Add(X);
            Name = "USTAWIENIA";
            Text = "USTAWIENIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox X;
        private TextBox Y;
        private TextBox krokodyle;
        private TextBox dydelfy;
        private TextBox czas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
    }
}