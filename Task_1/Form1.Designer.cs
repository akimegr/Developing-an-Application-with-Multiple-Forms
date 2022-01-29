namespace Task_1
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ans = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tgxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.закрытьПрограммуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.x = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xk = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.H = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(74, 170);
            this.ans.Multiline = true;
            this.ans.Name = "ans";
            this.ans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ans.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ans.Size = new System.Drawing.Size(505, 231);
            this.ans.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(457, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tgxToolStripMenuItem,
            this.sinxToolStripMenuItem,
            this.cosxToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 76);
            // 
            // tgxToolStripMenuItem
            // 
            this.tgxToolStripMenuItem.Name = "tgxToolStripMenuItem";
            this.tgxToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.tgxToolStripMenuItem.Text = "tg(x)";
            // 
            // sinxToolStripMenuItem
            // 
            this.sinxToolStripMenuItem.Name = "sinxToolStripMenuItem";
            this.sinxToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.sinxToolStripMenuItem.Text = "sin(x)";
            // 
            // cosxToolStripMenuItem
            // 
            this.cosxToolStripMenuItem.Name = "cosxToolStripMenuItem";
            this.cosxToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.cosxToolStripMenuItem.Text = "cos(x)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьПрограммуToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // закрытьПрограммуToolStripMenuItem
            // 
            this.закрытьПрограммуToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.закрытьПрограммуToolStripMenuItem.Name = "закрытьПрограммуToolStripMenuItem";
            this.закрытьПрограммуToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.закрытьПрограммуToolStripMenuItem.Text = "Закрыть программу";
            this.закрытьПрограммуToolStripMenuItem.Click += new System.EventHandler(this.закрытьПрограммуToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(273, 407);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Изменить цвет";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // x
            // 
            this.x.Location = new System.Drawing.Point(134, 41);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(100, 22);
            this.x.TabIndex = 12;
            this.x.Text = "0.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Xk";
            // 
            // xk
            // 
            this.xk.Location = new System.Drawing.Point(134, 99);
            this.xk.Name = "xk";
            this.xk.Size = new System.Drawing.Size(100, 22);
            this.xk.TabIndex = 15;
            this.xk.Text = "1";
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(457, 41);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 22);
            this.n.TabIndex = 16;
            this.n.Text = "16";
            // 
            // H
            // 
            this.H.Location = new System.Drawing.Point(457, 99);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(100, 22);
            this.H.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(418, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.H);
            this.Controls.Add(this.n);
            this.Controls.Add(this.xk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ans);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "check";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem tgxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosxToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem закрытьПрограммуToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.TextBox x;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xk;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox H;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

