namespace kursaaaaash
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            button_registration = new Button();
            button_log_in = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox_login = new TextBox();
            pictureBox2 = new PictureBox();
            textBox_password = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button_registration
            // 
            button_registration.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_registration.ForeColor = Color.FromArgb(64, 64, 64);
            button_registration.Location = new Point(55, 347);
            button_registration.Name = "button_registration";
            button_registration.Size = new Size(294, 66);
            button_registration.TabIndex = 0;
            button_registration.Text = "Регистрация";
            button_registration.UseVisualStyleBackColor = true;
            button_registration.Click += button_registration_Click;
            // 
            // button_log_in
            // 
            button_log_in.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            button_log_in.ForeColor = Color.FromArgb(64, 64, 64);
            button_log_in.Location = new Point(435, 347);
            button_log_in.Name = "button_log_in";
            button_log_in.Size = new Size(296, 66);
            button_log_in.TabIndex = 1;
            button_log_in.Text = "Вход";
            button_log_in.UseVisualStyleBackColor = true;
            button_log_in.Click += button_log_in_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Perpetua Titling MT", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(246, 31);
            label1.Name = "label1";
            label1.Size = new Size(313, 54);
            label1.TabIndex = 2;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(105, 110);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // textBox_login
            // 
            textBox_login.Font = new Font("Nirmala UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_login.ForeColor = Color.FromArgb(64, 64, 64);
            textBox_login.Location = new Point(232, 127);
            textBox_login.Multiline = true;
            textBox_login.Name = "textBox_login";
            textBox_login.Size = new Size(444, 35);
            textBox_login.TabIndex = 5;
            textBox_login.Text = "\r\n";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(105, 224);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // textBox_password
            // 
            textBox_password.Font = new Font("Nirmala UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_password.ForeColor = Color.FromArgb(64, 64, 64);
            textBox_password.Location = new Point(232, 242);
            textBox_password.Multiline = true;
            textBox_password.Name = "textBox_password";
            textBox_password.Size = new Size(444, 35);
            textBox_password.TabIndex = 7;
            textBox_password.UseSystemPasswordChar = true;
            // 
            // Authorization
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox_password);
            Controls.Add(pictureBox2);
            Controls.Add(textBox_login);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(button_log_in);
            Controls.Add(button_registration);
            Name = "Authorization";
            Text = "Authorization";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button button_registration;
        private Button button_log_in;
        private Label label1;
        private PictureBox pictureBox1;
        public TextBox textBox_login;
        private PictureBox pictureBox2;
        public TextBox textBox_password;
    }
}