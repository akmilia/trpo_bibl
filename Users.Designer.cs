namespace trpo_bibl
{
    partial class Users
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            menu1 = new Menu();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(13, 36);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1102, 317);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            button1.Location = new Point(859, 374);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(256, 25);
            button1.TabIndex = 2;
            button1.Text = "Добавить пользователя";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // menu1
            // 
            menu1.Location = new Point(5, 5);
            menu1.Margin = new Padding(4, 2, 4, 2);
            menu1.Name = "menu1";
            menu1.Size = new Size(1125, 26);
            menu1.TabIndex = 3;
            menu1.Load += menu1_Load;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1138, 417);
            Controls.Add(menu1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Users";
            Text = "Users";
            Load += Users_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button1;
        private Menu menu1;
    }
}