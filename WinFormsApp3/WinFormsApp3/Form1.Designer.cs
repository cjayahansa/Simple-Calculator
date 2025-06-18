namespace WinFormsApp3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            RESULT = new TextBox();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            RESULT_L = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F);
            button1.Location = new Point(12, 212);
            button1.Name = "button1";
            button1.Size = new Size(64, 56);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F);
            button2.Location = new Point(77, 213);
            button2.Name = "button2";
            button2.Size = new Size(64, 56);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 18F);
            button3.Location = new Point(142, 213);
            button3.Name = "button3";
            button3.Size = new Size(64, 56);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 18F);
            button4.Location = new Point(12, 274);
            button4.Name = "button4";
            button4.Size = new Size(64, 54);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(77, 275);
            button5.Name = "button5";
            button5.Size = new Size(64, 54);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 18F);
            button6.Location = new Point(142, 275);
            button6.Name = "button6";
            button6.Size = new Size(64, 54);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 18F);
            button7.Location = new Point(12, 334);
            button7.Name = "button7";
            button7.Size = new Size(64, 54);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 18F);
            button8.Location = new Point(77, 335);
            button8.Name = "button8";
            button8.Size = new Size(64, 54);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 18F);
            button9.Location = new Point(142, 334);
            button9.Name = "button9";
            button9.Size = new Size(64, 54);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button_Click;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 18F);
            button10.Location = new Point(77, 394);
            button10.Name = "button10";
            button10.Size = new Size(64, 54);
            button10.TabIndex = 9;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 18F);
            button11.Location = new Point(12, 394);
            button11.Name = "button11";
            button11.Size = new Size(64, 54);
            button11.TabIndex = 10;
            button11.Text = "00";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button_Click;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 18F);
            button12.Location = new Point(142, 394);
            button12.Name = "button12";
            button12.Size = new Size(64, 54);
            button12.TabIndex = 11;
            button12.Text = ".";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            // 
            // button13
            // 
            button13.Font = new Font("Segoe UI", 18F);
            button13.Location = new Point(212, 212);
            button13.Name = "button13";
            button13.Size = new Size(64, 54);
            button13.TabIndex = 12;
            button13.Text = "*";
            button13.UseVisualStyleBackColor = true;
            button13.Click += Operation;
            // 
            // button14
            // 
            button14.Font = new Font("Segoe UI", 18F);
            button14.Location = new Point(212, 275);
            button14.Name = "button14";
            button14.Size = new Size(64, 54);
            button14.TabIndex = 13;
            button14.Text = "+";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Operation;
            // 
            // button15
            // 
            button15.Font = new Font("Segoe UI", 18F);
            button15.Location = new Point(212, 334);
            button15.Name = "button15";
            button15.Size = new Size(64, 54);
            button15.TabIndex = 14;
            button15.Text = "-";
            button15.UseVisualStyleBackColor = true;
            button15.Click += Operation;
            // 
            // button16
            // 
            button16.Font = new Font("Segoe UI", 18F);
            button16.Location = new Point(212, 394);
            button16.Name = "button16";
            button16.Size = new Size(64, 54);
            button16.TabIndex = 15;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Operation;
            // 
            // RESULT
            // 
            RESULT.Font = new Font("Segoe UI", 18F);
            RESULT.Location = new Point(12, 159);
            RESULT.Name = "RESULT";
            RESULT.Size = new Size(328, 39);
            RESULT.TabIndex = 16;
            RESULT.Text = "0";
            RESULT.TextAlign = HorizontalAlignment.Right;
            // 
            // button17
            // 
            button17.Font = new Font("Segoe UI", 18F);
            button17.Location = new Point(282, 215);
            button17.Name = "button17";
            button17.Size = new Size(64, 54);
            button17.TabIndex = 17;
            button17.Text = "AC";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button18
            // 
            button18.Font = new Font("Segoe UI", 18F);
            button18.Location = new Point(282, 275);
            button18.Name = "button18";
            button18.Size = new Size(64, 54);
            button18.TabIndex = 18;
            button18.Text = "C";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // button19
            // 
            button19.Font = new Font("Segoe UI", 18F);
            button19.Location = new Point(282, 345);
            button19.Name = "button19";
            button19.Size = new Size(64, 103);
            button19.TabIndex = 19;
            button19.Text = "=";
            button19.UseVisualStyleBackColor = true;
            button19.Click += button19_Click;
            // 
            // RESULT_L
            // 
            RESULT_L.Font = new Font("Segoe UI", 20F);
            RESULT_L.Location = new Point(12, 22);
            RESULT_L.Name = "RESULT_L";
            RESULT_L.Size = new Size(134, 54);
            RESULT_L.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 450);
            Controls.Add(RESULT_L);
            Controls.Add(button19);
            Controls.Add(button18);
            Controls.Add(button17);
            Controls.Add(RESULT);
            Controls.Add(button16);
            Controls.Add(button15);
            Controls.Add(button14);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CALCULATOR";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private TextBox RESULT;
        private Button button17;
        private Button button18;
        private Button button19;
        private Label RESULT_L;
    }
}
