namespace trpo_bibl
{
    partial class BookEdit
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
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            textBoxName = new TextBox();
            textBoxAuthor = new TextBox();
            textBoxJanre = new TextBox();
            textBoxYear = new TextBox();
            textBoxNumber = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 17);
            label1.TabIndex = 0;
            label1.Text = "Редактирование книги";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(201, 277);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 25);
            button1.TabIndex = 1;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(473, 277);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(105, 25);
            button2.TabIndex = 2;
            button2.Text = "Удалить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 67);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 17);
            label2.TabIndex = 3;
            label2.Text = "Название";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 104);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 17);
            label3.TabIndex = 4;
            label3.Text = "Автор";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 142);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(45, 17);
            label4.TabIndex = 5;
            label4.Text = "Жанр";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 179);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(89, 17);
            label5.TabIndex = 6;
            label5.Text = "Год издания";
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 216);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(86, 17);
            label7.TabIndex = 8;
            label7.Text = "Количество";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(437, 65);
            textBoxName.Margin = new Padding(4, 2, 4, 2);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(140, 24);
            textBoxName.TabIndex = 9;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(437, 102);
            textBoxAuthor.Margin = new Padding(4, 2, 4, 2);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(140, 24);
            textBoxAuthor.TabIndex = 10;
            // 
            // textBoxJanre
            // 
            textBoxJanre.Location = new Point(437, 139);
            textBoxJanre.Margin = new Padding(4, 2, 4, 2);
            textBoxJanre.Name = "textBoxJanre";
            textBoxJanre.Size = new Size(140, 24);
            textBoxJanre.TabIndex = 11;
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(437, 177);
            textBoxYear.Margin = new Padding(4, 2, 4, 2);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(140, 24);
            textBoxYear.TabIndex = 12;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(437, 214);
            textBoxNumber.Margin = new Padding(4, 2, 4, 2);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(140, 24);
            textBoxNumber.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(303, 39);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 14;
            // 
            // BookEdit
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(805, 374);
            Controls.Add(label6);
            Controls.Add(textBoxNumber);
            Controls.Add(textBoxYear);
            Controls.Add(textBoxJanre);
            Controls.Add(textBoxAuthor);
            Controls.Add(textBoxName);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            Margin = new Padding(4, 2, 4, 2);
            Name = "BookEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookEdit";
            Load += BookEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox textBoxName;
        private TextBox textBoxAuthor;
        private TextBox textBoxJanre;
        private TextBox textBoxYear;
        private TextBox textBoxNumber;
        private Label label6;
    }
}