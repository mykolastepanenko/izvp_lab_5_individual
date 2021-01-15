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
            int y = 20;
            int index = 1;
            this.panel1 = new System.Windows.Forms.Panel();
            for (int i = 0; i < 30; i++)
            {
                userControlArr[i] = new _471_Stepanenko_Laba_5_Individual.UserControl1();
            }
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            foreach (UserControl1 item in userControlArr)
            {
                this.panel1.Controls.Add(item);
            }
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 775);
            this.panel1.TabIndex = 0;
            //
            // UserControlArr
            //
            foreach (UserControl1 item in userControlArr)
            {
                item.Location = new System.Drawing.Point(20, y);
                item.Name = "userController" + index;
                item.Size = new System.Drawing.Size(517, 170);
                item.TabIndex = 0;
                y += 190;
                index++;
            }
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
        private UserControl1[] userControlArr = new UserControl1[30];
    }
}

