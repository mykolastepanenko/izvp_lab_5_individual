using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace _471_Stepanenko_Laba_5_Individual
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        public string titleProp
        {
            set
            {
                label1.Text = value;
            }
        }
        public string case1Prop
        {
            set
            {
                radioButton1.Text = value;
            }
        }
        public string case2Prop
        {
            set
            {
                radioButton2.Text = value;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Ви не вибрали жодну відповідь");
            }
            else
            {
                var parent = this.Parent.Parent as Form1;
                if (radioButton2.Checked == true)
                {
                    parent.getMark += 1;
                    this.button1.Enabled = false;
                    this.BackColor = Color.DarkGreen;
                }
                else
                {
                    this.button1.Enabled = false;
                    this.BackColor = Color.DarkRed;
                }
            }
        }
    }
}
