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
            for (int i = 0; i < 30; i++)
            {
                userControlArr[i] = new _471_Stepanenko_Laba_5_Individual.UserControl1();
            }
            this.SuspendLayout();
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
            foreach (UserControl1 item in userControlArr)
            {
                this.Controls.Add(item);
            }
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private UserControl1[] userControlArr = new UserControl1[30];

        #endregion

    }
}

