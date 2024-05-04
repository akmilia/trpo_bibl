namespace trpo_bibl
{
    partial class UserAdd
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
            label7 = new Label();
            textBoxF = new TextBox();
            textBoxN = new TextBox();
            textBoxO = new TextBox();
            textBoxEmail = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(160, 17);
            label1.TabIndex = 0;
            label1.Text = "Добавление читателя. ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 80);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(67, 17);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(279, 119);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 2;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(280, 154);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 3;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 192);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(49, 17);
            label5.TabIndex = 4;
            label5.Text = "Почта";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(279, 224);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 5;
            label6.Text = "Телефон";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 264);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(57, 17);
            label7.TabIndex = 6;
            label7.Text = "Пароль";
            // 
            // textBoxF
            // 
            textBoxF.Location = new Point(464, 75);
            textBoxF.Margin = new Padding(4, 2, 4, 2);
            textBoxF.Name = "textBoxF";
            textBoxF.Size = new Size(140, 24);
            textBoxF.TabIndex = 7;
            textBoxF.TextChanged += textBoxF_TextChanged;
            // 
            // textBoxN
            // 
            textBoxN.Location = new Point(464, 113);
            textBoxN.Margin = new Padding(4, 2, 4, 2);
            textBoxN.Name = "textBoxN";
            textBoxN.Size = new Size(140, 24);
            textBoxN.TabIndex = 8;
            textBoxN.TextChanged += textBoxN_TextChanged;
            // 
            // textBoxO
            // 
            textBoxO.Location = new Point(464, 148);
            textBoxO.Margin = new Padding(4, 2, 4, 2);
            textBoxO.Name = "textBoxO";
            textBoxO.Size = new Size(140, 24);
            textBoxO.TabIndex = 9;
            textBoxO.TextChanged += textBoxO_TextChanged;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(464, 186);
            textBoxEmail.Margin = new Padding(4, 2, 4, 2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(140, 24);
            textBoxEmail.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(464, 222);
            textBox5.Margin = new Padding(4, 2, 4, 2);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 24);
            textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(464, 258);
            textBox6.Margin = new Padding(4, 2, 4, 2);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(140, 24);
            textBox6.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(410, 303);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(105, 25);
            button1.TabIndex = 13;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(900, 383);
            Controls.Add(button1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxO);
            Controls.Add(textBoxN);
            Controls.Add(textBoxF);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            Margin = new Padding(4, 2, 4, 2);
            Name = "UserAdd";
            Text = "UserAddcs";
            Load += UserAdd_Load;
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
        private Label label7;
        private TextBox textBoxF;
        private TextBox textBoxN;
        private TextBox textBoxO;
        private TextBox textBoxEmail;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button button1;
    }
}