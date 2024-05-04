namespace trpo_bibl
{
    partial class AdminProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProfile));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menu1 = new Menu();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(293, 59);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 17);
            label1.TabIndex = 1;
            label1.Text = "Ты библиотекарь!!!!!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(211, 91);
            pictureBox1.Margin = new Padding(4, 2, 4, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(357, 143);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // menu1
            // 
            menu1.BackColor = Color.MintCream;
            menu1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            menu1.Location = new Point(-3, -1);
            menu1.Margin = new Padding(4, 2, 4, 2);
            menu1.Name = "menu1";
            menu1.Size = new Size(797, 27);
            menu1.TabIndex = 3;
            menu1.Load += menu1_Load;
            // 
            // AdminProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Orange;
            ClientSize = new Size(801, 317);
            Controls.Add(menu1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 2, 4, 2);
            Name = "AdminProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminProfile";
            Load += AdminProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox1;
        private Menu menu1;
    }
}