namespace trpo_bibl
{
    partial class Profile
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
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            button2 = new Button();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            menu21 = new Menu2();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 3;
            label1.Text = "Фамилия:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 119);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 4;
            label2.Text = "Имя:";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(11, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 284);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Личные данные";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 233);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 8;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 175);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 7;
            label3.Text = "Отчество: ";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(881, 61);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Найти";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 61);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(423, 27);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(293, 108);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(858, 501);
            dataGridView1.TabIndex = 10;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // menu21
            // 
            menu21.Location = new Point(1, 4);
            menu21.Name = "menu21";
            menu21.Size = new Size(841, 43);
            menu21.TabIndex = 11;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(1179, 644);
            Controls.Add(menu21);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Name = "Profile";
            Text = "Profile";
            Load += Profile_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Menu2 menu21;
        private Label label3;
        private Label label4;
    }
}