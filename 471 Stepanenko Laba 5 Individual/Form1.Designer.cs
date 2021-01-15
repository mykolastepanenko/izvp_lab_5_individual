namespace _471_Stepanenko_Laba_5_Individual
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.userControl11 = new _471_Stepanenko_Laba_5_Individual.UserControl1();
            this.userControl12 = new _471_Stepanenko_Laba_5_Individual.UserControl1();
            this.userControl13 = new _471_Stepanenko_Laba_5_Individual.UserControl1();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.userControl13);
            this.panel1.Controls.Add(this.userControl12);
            this.panel1.Controls.Add(this.userControl11);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 775);
            this.panel1.TabIndex = 0;
            // 
            // userControl11
            // 
            this.userControl11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.userControl11.Location = new System.Drawing.Point(59, 81);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(517, 172);
            this.userControl11.TabIndex = 0;
            // 
            // userControl12
            // 
            this.userControl12.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.userControl12.Location = new System.Drawing.Point(50, 300);
            this.userControl12.Name = "userControl12";
            this.userControl12.Size = new System.Drawing.Size(517, 172);
            this.userControl12.TabIndex = 1;
            // 
            // userControl13
            // 
            this.userControl13.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.userControl13.Location = new System.Drawing.Point(50, 672);
            this.userControl13.Name = "userControl13";
            this.userControl13.Size = new System.Drawing.Size(517, 172);
            this.userControl13.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 800);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControl1 userControl11;
        private UserControl1 userControl13;
        private UserControl1 userControl12;
    }
}

