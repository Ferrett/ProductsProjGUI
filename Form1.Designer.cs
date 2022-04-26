
namespace WindowsFormsApp2
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
            this.textBoxGet1 = new System.Windows.Forms.TextBox();
            this.get1btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.get4btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.get3btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxGet2 = new System.Windows.Forms.TextBox();
            this.get2btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPost1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.post1btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxPost2 = new System.Windows.Forms.TextBox();
            this.textBoxPost3 = new System.Windows.Forms.TextBox();
            this.textBoxPost4 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.post2btn = new System.Windows.Forms.Button();
            this.textBoxReply = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.deletebtn1 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.deletetextBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.deletetextBox2 = new System.Windows.Forms.TextBox();
            this.deletebtn2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxresult2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGet1
            // 
            this.textBoxGet1.Location = new System.Drawing.Point(92, 41);
            this.textBoxGet1.Name = "textBoxGet1";
            this.textBoxGet1.Size = new System.Drawing.Size(276, 20);
            this.textBoxGet1.TabIndex = 0;
            // 
            // get1btn
            // 
            this.get1btn.Location = new System.Drawing.Point(382, 32);
            this.get1btn.Name = "get1btn";
            this.get1btn.Size = new System.Drawing.Size(84, 36);
            this.get1btn.TabIndex = 2;
            this.get1btn.Text = "GET";
            this.get1btn.UseVisualStyleBackColor = true;
            this.get1btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(129, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Get products by category ID";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(573, 250);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(509, 355);
            this.listBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(146, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Get all products";
            // 
            // get4btn
            // 
            this.get4btn.Location = new System.Drawing.Point(288, 226);
            this.get4btn.Name = "get4btn";
            this.get4btn.Size = new System.Drawing.Size(84, 36);
            this.get4btn.TabIndex = 9;
            this.get4btn.Text = "GET";
            this.get4btn.UseVisualStyleBackColor = true;
            this.get4btn.Click += new System.EventHandler(this.get4btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(133, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Get all categories";
            // 
            // get3btn
            // 
            this.get3btn.Location = new System.Drawing.Point(288, 175);
            this.get3btn.Name = "get3btn";
            this.get3btn.Size = new System.Drawing.Size(84, 36);
            this.get3btn.TabIndex = 11;
            this.get3btn.Text = "GET";
            this.get3btn.UseVisualStyleBackColor = true;
            this.get3btn.Click += new System.EventHandler(this.get3btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(133, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Get products by name";
            // 
            // textBoxGet2
            // 
            this.textBoxGet2.Location = new System.Drawing.Point(96, 119);
            this.textBoxGet2.Name = "textBoxGet2";
            this.textBoxGet2.Size = new System.Drawing.Size(276, 20);
            this.textBoxGet2.TabIndex = 13;
            // 
            // get2btn
            // 
            this.get2btn.Location = new System.Drawing.Point(382, 110);
            this.get2btn.Name = "get2btn";
            this.get2btn.Size = new System.Drawing.Size(84, 36);
            this.get2btn.TabIndex = 14;
            this.get2btn.Text = "GET";
            this.get2btn.UseVisualStyleBackColor = true;
            this.get2btn.Click += new System.EventHandler(this.get2btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(220, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Add category";
            // 
            // textBoxPost1
            // 
            this.textBoxPost1.Location = new System.Drawing.Point(145, 366);
            this.textBoxPost1.Name = "textBoxPost1";
            this.textBoxPost1.Size = new System.Drawing.Size(276, 20);
            this.textBoxPost1.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(220, 412);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Add product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 477);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Name:";
            // 
            // post1btn
            // 
            this.post1btn.Location = new System.Drawing.Point(445, 357);
            this.post1btn.Name = "post1btn";
            this.post1btn.Size = new System.Drawing.Size(84, 36);
            this.post1btn.TabIndex = 21;
            this.post1btn.Text = "POST";
            this.post1btn.UseVisualStyleBackColor = true;
            this.post1btn.Click += new System.EventHandler(this.post1btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Category ID:";
            // 
            // textBoxPost2
            // 
            this.textBoxPost2.Location = new System.Drawing.Point(145, 444);
            this.textBoxPost2.Name = "textBoxPost2";
            this.textBoxPost2.Size = new System.Drawing.Size(276, 20);
            this.textBoxPost2.TabIndex = 23;
            // 
            // textBoxPost3
            // 
            this.textBoxPost3.Location = new System.Drawing.Point(145, 477);
            this.textBoxPost3.Name = "textBoxPost3";
            this.textBoxPost3.Size = new System.Drawing.Size(276, 20);
            this.textBoxPost3.TabIndex = 24;
            // 
            // textBoxPost4
            // 
            this.textBoxPost4.Location = new System.Drawing.Point(145, 509);
            this.textBoxPost4.Name = "textBoxPost4";
            this.textBoxPost4.Size = new System.Drawing.Size(276, 20);
            this.textBoxPost4.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.get1btn);
            this.panel1.Controls.Add(this.get2btn);
            this.panel1.Controls.Add(this.textBoxGet1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxGet2);
            this.panel1.Controls.Add(this.get3btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.get4btn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 287);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBoxReply);
            this.panel2.Location = new System.Drawing.Point(12, 318);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(544, 287);
            this.panel2.TabIndex = 28;
            // 
            // post2btn
            // 
            this.post2btn.Location = new System.Drawing.Point(445, 468);
            this.post2btn.Name = "post2btn";
            this.post2btn.Size = new System.Drawing.Size(84, 36);
            this.post2btn.TabIndex = 29;
            this.post2btn.Text = "POST";
            this.post2btn.UseVisualStyleBackColor = true;
            this.post2btn.Click += new System.EventHandler(this.post2btn_Click);
            // 
            // textBoxReply
            // 
            this.textBoxReply.Location = new System.Drawing.Point(43, 255);
            this.textBoxReply.Name = "textBoxReply";
            this.textBoxReply.ReadOnly = true;
            this.textBoxReply.Size = new System.Drawing.Size(454, 20);
            this.textBoxReply.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label11.Location = new System.Drawing.Point(230, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Result:";
            // 
            // deletebtn1
            // 
            this.deletebtn1.Location = new System.Drawing.Point(942, 44);
            this.deletebtn1.Name = "deletebtn1";
            this.deletebtn1.Size = new System.Drawing.Size(84, 36);
            this.deletebtn1.TabIndex = 30;
            this.deletebtn1.Text = "DELETE";
            this.deletebtn1.UseVisualStyleBackColor = true;
            this.deletebtn1.Click += new System.EventHandler(this.deletebtn1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label12.Location = new System.Drawing.Point(725, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Delete product by ID";
            // 
            // deletetextBox1
            // 
            this.deletetextBox1.Location = new System.Drawing.Point(660, 53);
            this.deletetextBox1.Name = "deletetextBox1";
            this.deletetextBox1.Size = new System.Drawing.Size(276, 20);
            this.deletetextBox1.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label13.Location = new System.Drawing.Point(725, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Delete product by Name";
            // 
            // deletetextBox2
            // 
            this.deletetextBox2.Location = new System.Drawing.Point(660, 131);
            this.deletetextBox2.Name = "deletetextBox2";
            this.deletetextBox2.Size = new System.Drawing.Size(276, 20);
            this.deletetextBox2.TabIndex = 34;
            // 
            // deletebtn2
            // 
            this.deletebtn2.Location = new System.Drawing.Point(942, 122);
            this.deletebtn2.Name = "deletebtn2";
            this.deletebtn2.Size = new System.Drawing.Size(84, 36);
            this.deletebtn2.TabIndex = 35;
            this.deletebtn2.Text = "DELETE";
            this.deletebtn2.UseVisualStyleBackColor = true;
            this.deletebtn2.Click += new System.EventHandler(this.deletebtn2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textBoxresult2);
            this.panel3.Location = new System.Drawing.Point(573, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(509, 222);
            this.panel3.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label14.Location = new System.Drawing.Point(214, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Result:";
            // 
            // textBoxresult2
            // 
            this.textBoxresult2.Location = new System.Drawing.Point(27, 183);
            this.textBoxresult2.Name = "textBoxresult2";
            this.textBoxresult2.ReadOnly = true;
            this.textBoxresult2.Size = new System.Drawing.Size(454, 20);
            this.textBoxresult2.TabIndex = 38;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 617);
            this.Controls.Add(this.deletebtn2);
            this.Controls.Add(this.deletetextBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.deletetextBox1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.deletebtn1);
            this.Controls.Add(this.post2btn);
            this.Controls.Add(this.textBoxPost4);
            this.Controls.Add(this.textBoxPost3);
            this.Controls.Add(this.textBoxPost2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.post1btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPost1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxGet1;
        private System.Windows.Forms.Button get1btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button get4btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button get3btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxGet2;
        private System.Windows.Forms.Button get2btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPost1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button post1btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxPost2;
        private System.Windows.Forms.TextBox textBoxPost3;
        private System.Windows.Forms.TextBox textBoxPost4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button post2btn;
        private System.Windows.Forms.TextBox textBoxReply;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button deletebtn1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deletetextBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox deletetextBox2;
        private System.Windows.Forms.Button deletebtn2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxresult2;
    }
}

