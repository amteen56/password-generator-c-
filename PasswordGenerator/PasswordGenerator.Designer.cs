namespace PasswordGenerator
{
    partial class PasswordGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.cobolength = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chknumber = new System.Windows.Forms.CheckBox();
            this.chkspecial = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordtextBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.notextBox1 = new System.Windows.Forms.TextBox();
            this.sptextBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Length:";
            // 
            // cobolength
            // 
            this.cobolength.FormattingEnabled = true;
            this.cobolength.Items.AddRange(new object[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "16"});
            this.cobolength.Location = new System.Drawing.Point(246, 77);
            this.cobolength.Name = "cobolength";
            this.cobolength.Size = new System.Drawing.Size(274, 28);
            this.cobolength.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 2;
            // 
            // chknumber
            // 
            this.chknumber.AutoSize = true;
            this.chknumber.Location = new System.Drawing.Point(100, 131);
            this.chknumber.Name = "chknumber";
            this.chknumber.Size = new System.Drawing.Size(139, 24);
            this.chknumber.TabIndex = 3;
            this.chknumber.Text = "Use a Number?";
            this.chknumber.UseVisualStyleBackColor = true;
            // 
            // chkspecial
            // 
            this.chkspecial.AutoSize = true;
            this.chkspecial.Location = new System.Drawing.Point(265, 131);
            this.chkspecial.Name = "chkspecial";
            this.chkspecial.Size = new System.Drawing.Size(209, 24);
            this.chkspecial.TabIndex = 4;
            this.chkspecial.Text = "Use a Special Character?";
            this.chkspecial.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(246, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 50);
            this.button3.TabIndex = 8;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // passwordtextBox1
            // 
            this.passwordtextBox1.Location = new System.Drawing.Point(131, 295);
            this.passwordtextBox1.Multiline = true;
            this.passwordtextBox1.Name = "passwordtextBox1";
            this.passwordtextBox1.Size = new System.Drawing.Size(410, 54);
            this.passwordtextBox1.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "No Of Numbers?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "No Of Special Char?";
            // 
            // notextBox1
            // 
            this.notextBox1.Location = new System.Drawing.Point(145, 186);
            this.notextBox1.Name = "notextBox1";
            this.notextBox1.Size = new System.Drawing.Size(117, 26);
            this.notextBox1.TabIndex = 14;
            // 
            // sptextBox2
            // 
            this.sptextBox2.Location = new System.Drawing.Point(455, 186);
            this.sptextBox2.Name = "sptextBox2";
            this.sptextBox2.Size = new System.Drawing.Size(117, 26);
            this.sptextBox2.TabIndex = 15;
            // 
            // PasswordGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.sptextBox2);
            this.Controls.Add(this.notextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordtextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkspecial);
            this.Controls.Add(this.chknumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cobolength);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PasswordGenerator";
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.PasswordGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cobolength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chknumber;
        private System.Windows.Forms.CheckBox chkspecial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwordtextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox notextBox1;
        private System.Windows.Forms.TextBox sptextBox2;
    }
}

