namespace trpo_bibl
{
    partial class BookAdd
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxName = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxJanre = new TextBox();
            textBoxYear = new TextBox();
            textBoxNumber = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 17);
            label1.TabIndex = 0;
            label1.Text = "Добавление книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 86);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 1;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 2;
            label3.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 163);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 3;
            label4.Text = "Жанр";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 203);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 4;
            label5.Text = "Год издания";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(283, 240);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(86, 17);
            label6.TabIndex = 5;
            label6.Text = "Количество";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(485, 80);
            textBoxName.Margin = new Padding(4, 2, 4, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(140, 24);
            textBoxName.TabIndex = 6;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(485, 118);
            textBoxAuthor.Margin = new Padding(4, 2, 4, 2);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(140, 24);
            textBoxAuthor.TabIndex = 7;
            // 
            // textBoxJanre
            // 
            textBoxJanre.Location = new Point(485, 158);
            textBoxJanre.Margin = new Padding(4, 2, 4, 2);
            textBoxJanre.Name = "textBoxJanre";
            textBoxJanre.Size = new Size(140, 24);
            textBoxJanre.TabIndex = 8;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(485, 197);
            textBoxYear.Margin = new Padding(4, 2, 4, 2);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(140, 24);
            textBoxYear.TabIndex = 9;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(485, 235);
            textBoxNumber.Margin = new Padding(4, 2, 4, 2);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(140, 24);
            textBoxNumber.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(519, 281);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 25);
            button1.TabIndex = 11;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(284, 281);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(105, 25);
            button2.TabIndex = 12;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BookAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(900, 342);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxJanre);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BookAdd";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookAdd";
            Load += BookAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxName;
        private TextBox textBoxAuthor;
        private TextBox textBoxJanre;
        private TextBox textBoxYear;
        private TextBox textBoxNumber;
        private Button button1;
        private Button button2;
    }
}