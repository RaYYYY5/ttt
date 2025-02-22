namespace TicTacToetest1
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
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
            GameTimer = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            greetingLabel = new Label();
            nameTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 23);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(426, 23);
            label2.Name = "label2";
            label2.Size = new Size(163, 28);
            label2.TabIndex = 1;
            label2.Text = "Computer Wins:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(104, 141);
            button1.Name = "button1";
            button1.Size = new Size(140, 138);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(259, 141);
            button2.Name = "button2";
            button2.Size = new Size(140, 138);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(417, 141);
            button3.Name = "button3";
            button3.Size = new Size(140, 138);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(104, 294);
            button4.Name = "button4";
            button4.Size = new Size(140, 138);
            button4.TabIndex = 2;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(259, 294);
            button5.Name = "button5";
            button5.Size = new Size(140, 138);
            button5.TabIndex = 3;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(417, 294);
            button6.Name = "button6";
            button6.Size = new Size(140, 138);
            button6.TabIndex = 4;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(104, 448);
            button7.Name = "button7";
            button7.Size = new Size(140, 138);
            button7.TabIndex = 2;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(259, 448);
            button8.Name = "button8";
            button8.Size = new Size(140, 138);
            button8.TabIndex = 3;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(417, 448);
            button9.Name = "button9";
            button9.Size = new Size(140, 138);
            button9.TabIndex = 4;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayClickButton;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(248, 616);
            button10.Name = "button10";
            button10.Size = new Size(173, 63);
            button10.TabIndex = 5;
            button10.Text = "NewGame";
            button10.UseVisualStyleBackColor = true;
            button10.Click += NewGame;
            // 
            // GameTimer
            // 
            GameTimer.Interval = 1000;
            GameTimer.Tick += ComputerMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(270, 23);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 6;
            label3.Text = "Tie:";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetingLabel.Location = new Point(151, 99);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(70, 28);
            greetingLabel.TabIndex = 8;
            greetingLabel.Text = "label4";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(151, 57);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(346, 27);
            nameTextBox.TabIndex = 9;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 697);
            Controls.Add(nameTextBox);
            Controls.Add(greetingLabel);
            Controls.Add(label3);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button7);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
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
        private System.Windows.Forms.Timer GameTimer;
        private Label label3;
        private Label greetingLabel;
        private TextBox nameTextBox;
    }
}
