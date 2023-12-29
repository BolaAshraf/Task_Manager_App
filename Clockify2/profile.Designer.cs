namespace Clockify2
{
    partial class profile
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
            label9 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 60F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.SlateBlue;
            label9.Location = new Point(563, 12);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(334, 113);
            label9.TabIndex = 57;
            label9.Text = "Profile";
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(940, 205);
            pictureBox1.Margin = new Padding(1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 64;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(961, 447);
            label1.Name = "label1";
            label1.Size = new Size(126, 46);
            label1.TabIndex = 66;
            label1.Text = "label1";
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.DarkSlateBlue;
            progressBar1.Location = new Point(57, 205);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(582, 217);
            progressBar1.TabIndex = 67;
            progressBar1.Click += progressBar1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkSlateBlue;
            button2.Location = new Point(57, 449);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(122, 53);
            button2.TabIndex = 68;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1443, 553);
            Controls.Add(button2);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            FormBorderStyle = FormBorderStyle.None;
            Name = "profile";
            Text = "profile";
            Load += profile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label9;
        private PictureBox pictureBox1;
        private Label label1;
        private ProgressBar progressBar1;
        private Button button2;
    }
}