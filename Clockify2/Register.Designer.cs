namespace Clockify2
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label2 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightYellow;
            label1.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(106, 392);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(313, 70);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(106, 486);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(614, 82);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(106, 697);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.MaxLength = 12;
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '•';
            textBox2.Size = new Size(614, 82);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(115, 896);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(614, 82);
            textBox3.TabIndex = 5;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(115, 1084);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(367, 49);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 1230);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(499, 47);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("MV Boli", 15.9000006F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(1407, 1171);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(300, 137);
            button1.TabIndex = 10;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1381, 1322);
            linkLabel1.Margin = new Padding(2, 0, 2, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(359, 41);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Do you have an account ?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(1366, 472);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(391, 445);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 72F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(463, 20);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(1040, 315);
            label7.TabIndex = 14;
            label7.Text = "Register";
            label7.Click += label7_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightYellow;
            label2.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(106, 603);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(262, 70);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightYellow;
            label8.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Teal;
            label8.Location = new Point(106, 814);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(165, 70);
            label8.TabIndex = 16;
            label8.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.LightYellow;
            label3.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(115, 998);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(205, 70);
            label3.TabIndex = 17;
            label3.Text = "Gender";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightYellow;
            label4.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(115, 1156);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(308, 70);
            label4.TabIndex = 18;
            label4.Text = "Birth Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightYellow;
            label5.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(1381, 392);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(367, 70);
            label5.TabIndex = 19;
            label5.Text = "Upload image";
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(115, 1322);
            button2.Margin = new Padding(6, 6, 6, 6);
            button2.Name = "button2";
            button2.Size = new Size(259, 111);
            button2.TabIndex = 44;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(137, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(264, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(1942, 1474);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 2, 2, 2);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label2;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button2;
        private PictureBox pictureBox2;
    }
}