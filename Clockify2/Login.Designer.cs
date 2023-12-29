namespace Clockify2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label7 = new Label();
            button3 = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            label3 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1646, 954);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Microsoft Sans Serif", 39.75F, FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.SlateBlue;
            label7.Location = new Point(577, 106);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(515, 76);
            label7.TabIndex = 55;
            label7.Text = "Welcome Back !";
            // 
            // button3
            // 
            button3.BackColor = Color.Gainsboro;
            button3.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.SlateBlue;
            button3.Location = new Point(416, 709);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(107, 48);
            button3.TabIndex = 54;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Gainsboro;
            label4.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SlateBlue;
            label4.Location = new Point(664, 709);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(348, 34);
            label4.TabIndex = 53;
            label4.Text = "Don't have an account ?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Gainsboro;
            linkLabel1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.SlateBlue;
            linkLabel1.Location = new Point(1030, 709);
            linkLabel1.Margin = new Padding(1, 0, 1, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(117, 34);
            linkLabel1.TabIndex = 52;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.WhiteSmoke;
            label3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(587, 441);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(204, 46);
            label3.TabIndex = 51;
            label3.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(753, 564);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(241, 109);
            button1.TabIndex = 50;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(587, 506);
            textBox2.Margin = new Padding(1);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(550, 37);
            textBox2.TabIndex = 49;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(587, 353);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 37);
            textBox1.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(587, 290);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 46);
            label1.TabIndex = 47;
            label1.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1646, 954);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label7;
        private Button button3;
        private Label label4;
        private LinkLabel linkLabel1;
        private Label label3;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
    }
}