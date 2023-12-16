namespace Clockify2
{
    partial class Task
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            checkedListBox1 = new CheckedListBox();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Extremely important", "important", "medium", "easy" });
            comboBox1.Location = new Point(247, 390);
            comboBox1.Margin = new Padding(1, 1, 1, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(144, 28);
            comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(43, 374);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 45);
            label2.TabIndex = 7;
            label2.Text = "Priority";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MV Boli", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Teal;
            label3.Location = new Point(43, 483);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(176, 45);
            label3.TabIndex = 9;
            label3.Text = "End time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Teal;
            label1.Location = new Point(35, 430);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 45);
            label1.TabIndex = 10;
            label1.Text = "Start time";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(247, 499);
            maskedTextBox1.Margin = new Padding(1, 1, 1, 1);
            maskedTextBox1.Mask = "00/00/0000 90:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(120, 27);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(248, 441);
            maskedTextBox2.Margin = new Padding(1, 1, 1, 1);
            maskedTextBox2.Mask = "00/00/0000 90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(120, 27);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Teal;
            label4.Location = new Point(43, 193);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(203, 45);
            label4.TabIndex = 13;
            label4.Text = "Task Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 201);
            textBox1.Margin = new Padding(1, 1, 1, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(120, 29);
            textBox1.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(35, 547);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(206, 45);
            label5.TabIndex = 15;
            label5.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(247, 547);
            textBox2.Margin = new Padding(1, 1, 1, 1);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 42);
            textBox2.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 20.1F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Teal;
            label6.Location = new Point(43, 270);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(153, 45);
            label6.TabIndex = 17;
            label6.Text = "SubTask";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "SubTask1", "SubTask2", "SubTask3", "SubTask4" });
            checkedListBox1.Location = new Point(248, 253);
            checkedListBox1.Margin = new Padding(1, 1, 1, 1);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(143, 92);
            checkedListBox1.TabIndex = 19;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.Location = new Point(296, 621);
            linkLabel1.Margin = new Padding(1, 0, 1, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(299, 26);
            linkLabel1.TabIndex = 20;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "For Collaborating click here";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(200, 44);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(182, 79);
            label7.TabIndex = 21;
            label7.Text = "Tasks";
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("MV Boli", 14.1F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.LightYellow;
            button1.Location = new Point(51, 615);
            button1.Margin = new Padding(1, 1, 1, 1);
            button1.Name = "button1";
            button1.Size = new Size(132, 41);
            button1.TabIndex = 22;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 26);
            pictureBox2.Margin = new Padding(1, 1, 1, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("MV Boli", 15.9000006F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(55, 709);
            button2.Margin = new Padding(1);
            button2.Name = "button2";
            button2.Size = new Size(107, 48);
            button2.TabIndex = 24;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(573, 767);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(checkedListBox1);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1, 1, 1, 1);
            Name = "Task";
            Text = "Task";
            Load += Task_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private CheckedListBox checkedListBox1;
        private LinkLabel linkLabel1;
        private Label label7;
        private Button button1;
        private PictureBox pictureBox2;
        private Button button2;
    }
}