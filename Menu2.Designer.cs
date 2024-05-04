namespace trpo_bibl
{
    partial class Menu2
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            книгиToolStripMenuItem = new ToolStripMenuItem();
            заказыToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // книгиToolStripMenuItem
            // 
            книгиToolStripMenuItem.Name = "книгиToolStripMenuItem";
            книгиToolStripMenuItem.Size = new Size(65, 24);
            книгиToolStripMenuItem.Text = "Книги";
            книгиToolStripMenuItem.Click += книгиToolStripMenuItem_Click;
            // 
            // заказыToolStripMenuItem
            // 
            заказыToolStripMenuItem.Name = "заказыToolStripMenuItem";
            заказыToolStripMenuItem.Size = new Size(72, 24);
            заказыToolStripMenuItem.Text = "Заказы";
            заказыToolStripMenuItem.Click += заказыToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(67, 24);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Orange;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { книгиToolStripMenuItem, заказыToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(673, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Menu2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            Name = "Menu2";
            Size = new Size(673, 34);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripMenuItem книгиToolStripMenuItem;
        private ToolStripMenuItem заказыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private MenuStrip menuStrip1;
    }
}
