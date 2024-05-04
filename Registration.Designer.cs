namespace trpo_bibl
{
    partial class Registration
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
            textBoxF = new TextBox();
            textBoxImya = new TextBox();
            textBoxO = new TextBox();
            textBoxE = new TextBox();
            textBoxT = new TextBox();
            textBoxPas = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBoxF
            // 
            textBoxF.Location = new Point(355, 54);
            textBoxF.Margin = new Padding(4, 2, 4, 2);
            textBoxF.Name = "textBoxF";
            textBoxF.Size = new Size(235, 24);
            textBoxF.TabIndex = 0;
            textBoxF.TextChanged += textBoxF_TextChanged;
            // 
            // textBoxImya
            // 
            textBoxImya.Location = new Point(355, 102);
            textBoxImya.Margin = new Padding(4, 2, 4, 2);
            textBoxImya.Name = "textBoxImya";
            textBoxImya.Size = new Size(235, 24);
            textBoxImya.TabIndex = 1;
            textBoxImya.TextChanged += textBoxImya_TextChanged;
            // 
            // textBoxO
            // 
            textBoxO.Location = new Point(355, 150);
            textBoxO.Margin = new Padding(4, 2, 4, 2);
            textBoxO.Name = "textBoxO";
            textBoxO.Size = new Size(235, 24);
            textBoxO.TabIndex = 2;
            textBoxO.TextChanged += textBoxO_TextChanged;
            // 
            // textBoxE
            // 
            textBoxE.Location = new Point(355, 197);
            textBoxE.Margin = new Padding(4, 2, 4, 2);
            textBoxE.Name = "textBoxE";
            textBoxE.Size = new Size(235, 24);
            textBoxE.TabIndex = 3;
            textBoxE.TextChanged += textBoxE_TextChanged;
            // 
            // textBoxT
            // 
            textBoxT.Location = new Point(355, 245);
            textBoxT.Margin = new Padding(4, 2, 4, 2);
            textBoxT.Name = "textBoxT";
            textBoxT.Size = new Size(235, 24);
            textBoxT.TabIndex = 4;
            textBoxT.TextChanged += textBoxT_TextChanged;
            // 
            // textBoxPas
            // 
            textBoxPas.Location = new Point(355, 292);
            textBoxPas.Margin = new Padding(4, 2, 4, 2);
            textBoxPas.Name = "textBoxPas";
            textBoxPas.Size = new Size(235, 24);
            textBoxPas.TabIndex = 6;
            textBoxPas.TextChanged += textBoxPas_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(355, 345);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(237, 25);
            button1.TabIndex = 7;
            button1.Text = "Зарегистрироваться";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(355, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 8;
            label1.Text = "Фамилия";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(355, 83);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(34, 17);
            label2.TabIndex = 9;
            label2.Text = "Имя";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(355, 130);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 10;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(355, 178);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 17);
            label4.TabIndex = 11;
            label4.Text = "Email";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(355, 226);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 12;
            label5.Text = "Телефон";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(355, 273);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 13;
            label6.Text = "Пароль";
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Orange;
            ClientSize = new Size(900, 386);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxPas);
            Controls.Add(textBoxT);
            Controls.Add(textBoxE);
            Controls.Add(textBoxO);
            Controls.Add(textBoxImya);
            Controls.Add(textBoxF);
            Font = new Font("Showcard Gothic", 9.75F, FontStyle.Italic);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Registration";
            Text = "Registration";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxF;
        private TextBox textBoxImya;
        private TextBox textBoxO;
        private TextBox textBoxE;
        private TextBox textBoxT;
        private TextBox textBoxPas;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}