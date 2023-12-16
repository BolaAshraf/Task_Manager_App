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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            label4 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(45, 103);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 29);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 144);
            textBox1.Margin = new Padding(1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 229);
            textBox2.Margin = new Padding(1);
            textBox2.MaxLength = 12;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(231, 23);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(294, 326);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(45, 182);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(113, 29);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(190, 26);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(148, 63);
            label2.TabIndex = 6;
            label2.Text = "Login";
            label2.Click += label2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 10);
            pictureBox2.Margin = new Padding(1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(104, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(88, 281);
            linkLabel1.Margin = new Padding(1, 0, 1, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(58, 17);
            linkLabel1.TabIndex = 23;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(45, 267);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(172, 17);
            label4.TabIndex = 24;
            label4.Text = "Don't have an account ?";
            // 
            // button3
            // 
            button3.BackColor = Color.Teal;
            button3.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.LightYellow;
            button3.Location = new Point(27, 330);
            button3.Margin = new Padding(1);
            button3.Name = "button3";
            button3.Size = new Size(94, 36);
            button3.TabIndex = 45;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(416, 374);
            Controls.Add(button3);
            Controls.Add(label4);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private Label label4;
        private Button button3;
    }
}