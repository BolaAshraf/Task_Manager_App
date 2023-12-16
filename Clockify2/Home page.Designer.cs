namespace Clockify2
{
    partial class Home_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_page));
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            button5 = new Button();
            label7 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            myTasksToolStripMenuItem = new ToolStripMenuItem();
            addNewTaskToolStripMenuItem = new ToolStripMenuItem();
            showAllTasksToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            notificationsToolStripMenuItem = new ToolStripMenuItem();
            activityLogToolStripMenuItem = new ToolStripMenuItem();
            feedBackToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            linkLabel1 = new LinkLabel();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.ForeColor = SystemColors.InactiveCaption;
            textBox1.Location = new Point(27, 304);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(536, 32);
            textBox1.TabIndex = 0;
            textBox1.Text = "search here";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(723, 100);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(550, 551);
            label1.Name = "label1";
            label1.Size = new Size(61, 26);
            label1.TabIndex = 15;
            label1.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 76);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 167);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(569, 304);
            button5.Name = "button5";
            button5.Size = new Size(53, 40);
            button5.TabIndex = 23;
            button5.Text = "🔎";
            button5.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MV Boli", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Teal;
            label7.Location = new Point(355, 100);
            label7.Name = "label7";
            label7.Size = new Size(256, 105);
            label7.TabIndex = 24;
            label7.Text = "Home";
            label7.Click += label7_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Teal;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, myTasksToolStripMenuItem, settingsToolStripMenuItem, notificationsToolStripMenuItem, feedBackToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(923, 48);
            menuStrip1.TabIndex = 29;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            fileToolStripMenuItem.ForeColor = Color.Snow;
            fileToolStripMenuItem.Image = (Image)resources.GetObject("fileToolStripMenuItem.Image");
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(103, 44);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            closeToolStripMenuItem.Image = (Image)resources.GetObject("closeToolStripMenuItem.Image");
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(158, 34);
            closeToolStripMenuItem.Text = "close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // myTasksToolStripMenuItem
            // 
            myTasksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewTaskToolStripMenuItem, showAllTasksToolStripMenuItem });
            myTasksToolStripMenuItem.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            myTasksToolStripMenuItem.ForeColor = Color.White;
            myTasksToolStripMenuItem.Image = (Image)resources.GetObject("myTasksToolStripMenuItem.Image");
            myTasksToolStripMenuItem.Name = "myTasksToolStripMenuItem";
            myTasksToolStripMenuItem.Size = new Size(187, 44);
            myTasksToolStripMenuItem.Text = "My tasks";
            myTasksToolStripMenuItem.Click += myTasksToolStripMenuItem_Click;
            // 
            // addNewTaskToolStripMenuItem
            // 
            addNewTaskToolStripMenuItem.Image = (Image)resources.GetObject("addNewTaskToolStripMenuItem.Image");
            addNewTaskToolStripMenuItem.Name = "addNewTaskToolStripMenuItem";
            addNewTaskToolStripMenuItem.Size = new Size(334, 44);
            addNewTaskToolStripMenuItem.Text = "Add New Task";
            addNewTaskToolStripMenuItem.Click += addNewTaskToolStripMenuItem_Click;
            // 
            // showAllTasksToolStripMenuItem
            // 
            showAllTasksToolStripMenuItem.Image = (Image)resources.GetObject("showAllTasksToolStripMenuItem.Image");
            showAllTasksToolStripMenuItem.Name = "showAllTasksToolStripMenuItem";
            showAllTasksToolStripMenuItem.Size = new Size(334, 44);
            showAllTasksToolStripMenuItem.Text = "Show All Tasks";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            settingsToolStripMenuItem.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            settingsToolStripMenuItem.ForeColor = Color.White;
            settingsToolStripMenuItem.Image = (Image)resources.GetObject("settingsToolStripMenuItem.Image");
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(175, 44);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("MV Boli", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(229, 34);
            editToolStripMenuItem.Text = "Edit Profile";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // notificationsToolStripMenuItem
            // 
            notificationsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { activityLogToolStripMenuItem });
            notificationsToolStripMenuItem.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            notificationsToolStripMenuItem.ForeColor = Color.White;
            notificationsToolStripMenuItem.Image = (Image)resources.GetObject("notificationsToolStripMenuItem.Image");
            notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            notificationsToolStripMenuItem.Size = new Size(245, 44);
            notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // activityLogToolStripMenuItem
            // 
            activityLogToolStripMenuItem.Name = "activityLogToolStripMenuItem";
            activityLogToolStripMenuItem.Size = new Size(296, 44);
            activityLogToolStripMenuItem.Text = "Activity Log";
            // 
            // feedBackToolStripMenuItem
            // 
            feedBackToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { reportsToolStripMenuItem });
            feedBackToolStripMenuItem.Font = new Font("MV Boli", 18F, FontStyle.Bold, GraphicsUnit.Point);
            feedBackToolStripMenuItem.ForeColor = Color.White;
            feedBackToolStripMenuItem.Image = (Image)resources.GetObject("feedBackToolStripMenuItem.Image");
            feedBackToolStripMenuItem.Name = "feedBackToolStripMenuItem";
            feedBackToolStripMenuItem.Size = new Size(182, 44);
            feedBackToolStripMenuItem.Text = "FeedBack";
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(195, 34);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(41, 342);
            panel1.Name = "panel1";
            panel1.Size = new Size(488, 563);
            panel1.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(488, 560);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(723, 304);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(148, 40);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // button2
            // 
            button2.BackColor = Color.Teal;
            button2.Font = new Font("MV Boli", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.LightYellow;
            button2.Location = new Point(749, 815);
            button2.Name = "button2";
            button2.Size = new Size(122, 54);
            button2.TabIndex = 44;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Home_page
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.LightYellow;
            ClientSize = new Size(923, 925);
            Controls.Add(button2);
            Controls.Add(linkLabel1);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(button5);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            Font = new Font("MV Boli", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Home_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home_page";
            Load += Home_page_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Button button5;
        private Label label7;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem myTasksToolStripMenuItem;
        private ToolStripMenuItem addNewTaskToolStripMenuItem;
        private ToolStripMenuItem showAllTasksToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private Panel panel1;
        private DataGridView dataGridView1;
        private LinkLabel linkLabel1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem notificationsToolStripMenuItem;
        private ToolStripMenuItem activityLogToolStripMenuItem;
        private ToolStripMenuItem feedBackToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private Button button2;
    }
}