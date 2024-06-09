using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_2022_2111_2229
{
    public partial class Form3 : Form
    {
        public int v1 { get; set; }
        public int v2 { get; set; }
        public int u1 { get; set; }
        public int u2 { get; set; }
        public int u3 { get; set; }
        public int v3 { get; set; }

        //порог изменения коэффициентов
        public double PL { get; set; }
        public double PH { get; set; }
        public double P { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            v1 = Decimal.ToInt32(numericUpDown_v1.Value);
            u1 = Decimal.ToInt32(numericUpDown_u1.Value);
            v2 = Decimal.ToInt32(numericUpDown_v2.Value);
            u2 = Decimal.ToInt32(numericUpDown_u2.Value);
            v3 = Decimal.ToInt32(numericUpDown_v3.Value);
            u3 = Decimal.ToInt32(numericUpDown_u3.Value);

            PL = Convert.ToDouble(textBox_PL.Text);
            PH = Convert.ToDouble(textBox_PH.Text);
            P = Convert.ToDouble(textBox_P.Text);

            Close();
        }
    }
}
