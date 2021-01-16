using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _471_Stepanenko_Laba_5_Individual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int getMark
        {
            set
            {
                mark++;
                this.label2.Text = System.String.Format("Ваша оцінка: {0} із {1}", mark, 30);
            }
            get
            {
                return mark;
            }
        }
    }
}
