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
            winnerAnnounceLabel = new Label();
            button11 = new Button();
            label4 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(82, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Player Wins:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(404, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 42);
            label2.TabIndex = 1;
            label2.Text = "Computer Wins:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(82, 172);
            button1.Name = "button1";
            button1.Size = new Size(155, 145);
            button1.TabIndex = 2;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PlayClickButton;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(243, 172);
            button2.Name = "button2";
            button2.Size = new Size(151, 145);
            button2.TabIndex = 3;
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += PlayClickButton;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(404, 172);
            button3.Name = "button3";
            button3.Size = new Size(155, 145);
            button3.TabIndex = 4;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += PlayClickButton;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(82, 323);
            button4.Name = "button4";
            button4.Size = new Size(151, 145);
            button4.TabIndex = 2;
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += PlayClickButton;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(243, 323);
            button5.Name = "button5";
            button5.Size = new Size(151, 145);
            button5.TabIndex = 3;
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += PlayClickButton;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(404, 323);
            button6.Name = "button6";
            button6.Size = new Size(155, 145);
            button6.TabIndex = 4;
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += PlayClickButton;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(82, 474);
            button7.Name = "button7";
            button7.Size = new Size(155, 150);
            button7.TabIndex = 2;
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += PlayClickButton;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(243, 474);
            button8.Name = "button8";
            button8.Size = new Size(155, 150);
            button8.TabIndex = 3;
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += PlayClickButton;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Location = new Point(404, 474);
            button9.Name = "button9";
            button9.Size = new Size(155, 150);
            button9.TabIndex = 4;
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += PlayClickButton;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button10.Location = new Point(82, 630);
            button10.Name = "button10";
            button10.Size = new Size(155, 40);
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
            label3.Location = new Point(243, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 28);
            label3.TabIndex = 6;
            label3.Text = "Tie:";
            // 
            // greetingLabel
            // 
            greetingLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(greetingLabel, 3);
            greetingLabel.Dock = DockStyle.Fill;
            greetingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            greetingLabel.Location = new Point(82, 84);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(477, 42);
            greetingLabel.TabIndex = 8;
            greetingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(nameTextBox, 2);
            nameTextBox.Location = new Point(243, 45);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(316, 27);
            nameTextBox.TabIndex = 9;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // winnerAnnounceLabel
            // 
            winnerAnnounceLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(winnerAnnounceLabel, 3);
            winnerAnnounceLabel.Dock = DockStyle.Fill;
            winnerAnnounceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            winnerAnnounceLabel.Location = new Point(82, 126);
            winnerAnnounceLabel.Name = "winnerAnnounceLabel";
            winnerAnnounceLabel.Size = new Size(477, 43);
            winnerAnnounceLabel.TabIndex = 10;
            winnerAnnounceLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button11.Location = new Point(404, 630);
            button11.Name = "button11";
            button11.Size = new Size(155, 40);
            button11.TabIndex = 11;
            button11.Text = "Exit";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 42);
            label4.Name = "label4";
            label4.Size = new Size(119, 20);
            label4.TabIndex = 12;
            label4.Text = "Enter you name: ";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.29306F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1379585F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1379585F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.1379547F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.2930641F));
            tableLayoutPanel1.Controls.Add(label2, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label4, 1, 1);
            tableLayoutPanel1.Controls.Add(nameTextBox, 2, 1);
            tableLayoutPanel1.Controls.Add(button10, 1, 7);
            tableLayoutPanel1.Controls.Add(button11, 3, 7);
            tableLayoutPanel1.Controls.Add(button9, 3, 6);
            tableLayoutPanel1.Controls.Add(button8, 2, 6);
            tableLayoutPanel1.Controls.Add(button7, 1, 6);
            tableLayoutPanel1.Controls.Add(button4, 1, 5);
            tableLayoutPanel1.Controls.Add(button5, 2, 5);
            tableLayoutPanel1.Controls.Add(button6, 3, 5);
            tableLayoutPanel1.Controls.Add(button2, 2, 4);
            tableLayoutPanel1.Controls.Add(button3, 3, 4);
            tableLayoutPanel1.Controls.Add(button1, 1, 4);
            tableLayoutPanel1.Controls.Add(greetingLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(winnerAnnounceLabel, 1, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.290924F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.290924F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.290924F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.496009F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.4675884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.4675884F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2000313F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.496009F));
            tableLayoutPanel1.Size = new Size(643, 673);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(643, 673);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(800, 850);
            MinimumSize = new Size(661, 700);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
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
        private Label winnerAnnounceLabel;
        private Button button11;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
