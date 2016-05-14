namespace Dialog_test_v._1
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
            this.Confirm = new System.Windows.Forms.Button();
            this.Character_Name = new System.Windows.Forms.TextBox();
            this.Enter_Name = new System.Windows.Forms.Label();
            this.Name_Choose = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Name_Choose.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Confirm
            // 
            this.Confirm.Location = new System.Drawing.Point(8, 82);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(101, 23);
            this.Confirm.TabIndex = 0;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Character_Name
            // 
            this.Character_Name.Location = new System.Drawing.Point(9, 56);
            this.Character_Name.Name = "Character_Name";
            this.Character_Name.Size = new System.Drawing.Size(100, 20);
            this.Character_Name.TabIndex = 1;
            // 
            // Enter_Name
            // 
            this.Enter_Name.Location = new System.Drawing.Point(6, 16);
            this.Enter_Name.Name = "Enter_Name";
            this.Enter_Name.Size = new System.Drawing.Size(101, 37);
            this.Enter_Name.TabIndex = 2;
            this.Enter_Name.Text = "Enter your character\'s name";
            // 
            // Name_Choose
            // 
            this.Name_Choose.Controls.Add(this.Confirm);
            this.Name_Choose.Controls.Add(this.Enter_Name);
            this.Name_Choose.Controls.Add(this.Character_Name);
            this.Name_Choose.Location = new System.Drawing.Point(13, 12);
            this.Name_Choose.Name = "Name_Choose";
            this.Name_Choose.Size = new System.Drawing.Size(116, 113);
            this.Name_Choose.TabIndex = 3;
            this.Name_Choose.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(135, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 231);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(7, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(495, 155);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(135, 277);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(514, 155);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Name_Choose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Name_Choose.ResumeLayout(false);
            this.Name_Choose.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.TextBox Character_Name;
        private System.Windows.Forms.Label Enter_Name;
        private System.Windows.Forms.GroupBox Name_Choose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

