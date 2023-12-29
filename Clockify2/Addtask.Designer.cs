namespace Clockify2
{
    partial class Addtask
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addtask));
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label4 = new Label();
            textBox1 = new TextBox();
            button3 = new Button();
            label1 = new Label();
            button4 = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            linkLabel2 = new LinkLabel();
            textBox3 = new TextBox();
            comboBox1 = new ComboBox();
            label11 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker3 = new DateTimePicker();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkSlateBlue;
            label4.Location = new Point(55, 235);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(219, 50);
            label4.TabIndex = 13;
            label4.Text = "Task Name";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(339, 243);
            textBox1.Margin = new Padding(1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(257, 44);
            textBox1.TabIndex = 14;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(176, 876);
            button3.Name = "button3";
            button3.Size = new Size(122, 53);
            button3.TabIndex = 47;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 77.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(537, 12);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(408, 147);
            label1.TabIndex = 46;
            label1.Text = "Tasks";
            // 
            // button4
            // 
            button4.BackColor = Color.SlateBlue;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("MV Boli", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(669, 807);
            button4.Margin = new Padding(1);
            button4.Name = "button4";
            button4.Size = new Size(223, 123);
            button4.TabIndex = 45;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateBlue;
            label2.Location = new Point(55, 559);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(223, 50);
            label2.TabIndex = 54;
            label2.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkSlateBlue;
            label3.Location = new Point(774, 391);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 50);
            label3.TabIndex = 53;
            label3.Text = "End Time";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkSlateBlue;
            label5.Location = new Point(774, 233);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(205, 50);
            label5.TabIndex = 52;
            label5.Text = "Start Time";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BackColor = Color.White;
            linkLabel2.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.ForeColor = Color.DarkSlateBlue;
            linkLabel2.LinkColor = Color.DarkSlateBlue;
            linkLabel2.Location = new Point(1040, 807);
            linkLabel2.Margin = new Padding(1, 0, 1, 0);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(299, 26);
            linkLabel2.TabIndex = 50;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "For Collaborating click here";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.WhiteSmoke;
            textBox3.Location = new Point(339, 559);
            textBox3.Margin = new Padding(1);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(906, 83);
            textBox3.TabIndex = 49;
            textBox3.Tag = "";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Extremely important", "important", "medium", "easy" });
            comboBox1.Location = new Point(339, 405);
            comboBox1.Margin = new Padding(1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 36);
            comboBox1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Malgun Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkSlateBlue;
            label11.Location = new Point(55, 395);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(152, 50);
            label11.TabIndex = 32;
            label11.Text = "Priority";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(1040, 251);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.ShowUpDown = true;
            dateTimePicker2.Size = new Size(227, 27);
            dateTimePicker2.TabIndex = 57;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Location = new Point(1040, 405);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.ShowUpDown = true;
            dateTimePicker3.Size = new Size(227, 27);
            dateTimePicker3.TabIndex = 58;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1324, 19);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(63, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 60;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1393, 12);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(51, 51);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 59;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Addtask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1456, 945);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(dateTimePicker3);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(linkLabel2);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(label11);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            ForeColor = Color.DarkSlateBlue;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
            Name = "Addtask";
            Text = "Task";
            Load += Task_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label4;
        private TextBox textBox1;
        private Button button3;
        private Label label1;
        private Button button4;
        private Label label2;
        private Label label3;
        private Label label5;
        private LinkLabel linkLabel2;
        private TextBox textBox3;
        private ComboBox comboBox1;
        private Label label11;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
    }
}