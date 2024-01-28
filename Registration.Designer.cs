namespace kursaaaaash
{
    partial class Registration
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button_to_registrat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(263, 28);
            label1.Name = "label1";
            label1.Size = new Size(275, 48);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Nirmala UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = Color.FromArgb(64, 64, 64);
            textBox1.Location = new Point(142, 130);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 43);
            textBox1.TabIndex = 1;
            textBox1.Text = "Придумайте логин";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Nirmala UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.FromArgb(64, 64, 64);
            textBox2.Location = new Point(142, 217);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(507, 43);
            textBox2.TabIndex = 2;
            textBox2.Text = "Придумайте пароль";
            // 
            // button_to_registrat
            // 
            button_to_registrat.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_to_registrat.ForeColor = Color.FromArgb(64, 64, 64);
            button_to_registrat.Location = new Point(156, 336);
            button_to_registrat.Name = "button_to_registrat";
            button_to_registrat.Size = new Size(466, 62);
            button_to_registrat.TabIndex = 3;
            button_to_registrat.Text = "Зарегистрироваться";
            button_to_registrat.UseVisualStyleBackColor = true;
            button_to_registrat.Click += button_to_registrat_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(button_to_registrat);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox textBox1;
        public TextBox textBox2;
        public Button button_to_registrat;
    }
}