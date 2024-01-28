namespace kursaaaaash
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(25, 22);
            button1.Name = "button1";
            button1.Size = new Size(157, 151);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(188, 22);
            button2.Name = "button2";
            button2.Size = new Size(157, 151);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(351, 22);
            button3.Name = "button3";
            button3.Size = new Size(157, 151);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(25, 179);
            button4.Name = "button4";
            button4.Size = new Size(157, 151);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(188, 179);
            button5.Name = "button5";
            button5.Size = new Size(157, 151);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(351, 179);
            button6.Name = "button6";
            button6.Size = new Size(157, 151);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(25, 336);
            button7.Name = "button7";
            button7.Size = new Size(157, 151);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(188, 336);
            button8.Name = "button8";
            button8.Size = new Size(157, 151);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Perpetua Titling MT", 48F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(351, 336);
            button9.Name = "button9";
            button9.Size = new Size(157, 151);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(576, 37);
            label1.Name = "label1";
            label1.Size = new Size(127, 48);
            label1.TabIndex = 9;
            label1.Text = "Ходы";
            // 
            // button10
            // 
            button10.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button10.Location = new Point(25, 504);
            button10.Name = "button10";
            button10.Size = new Size(207, 63);
            button10.TabIndex = 10;
            button10.Text = "Заново";
            button10.UseVisualStyleBackColor = true;
            button10.Click += Button10_Click;
            // 
            // button11
            // 
            button11.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button11.Location = new Point(611, 504);
            button11.Name = "button11";
            button11.Size = new Size(213, 63);
            button11.TabIndex = 11;
            button11.Text = "Выход";
            button11.UseVisualStyleBackColor = true;
            button11.Click += Button11_Click;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(997, 600);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(label1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.FromArgb(64, 64, 64);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicTacToe";
            Text = "Tic Tac Toe";
            TransparencyKey = Color.Black;
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
        private Label label1;
        private Button button10;
        public Button button11;
    }
}