namespace Clockify2
{
    partial class Add_subtask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_subtask));
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(39, 64);
            pictureBox3.Margin = new Padding(1);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 42);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 52;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Location = new Point(93, 101);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 5);
            panel1.TabIndex = 51;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(92, 66);
            textBox1.Margin = new Padding(1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 40);
            textBox1.TabIndex = 50;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(83, 27);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(232, 40);
            label1.TabIndex = 49;
            label1.Text = "Subtask Name";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.SlateBlue;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("MV Boli", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(442, 64);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(112, 57);
            button1.TabIndex = 53;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Add_subtask
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(631, 171);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Add_subtask";
            Text = "Add_subtask";
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox3;
        private Panel panel1;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}