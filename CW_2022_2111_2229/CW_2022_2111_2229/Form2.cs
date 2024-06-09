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
    public partial class Form2 : Form
    {
        // координаты коэффициетов , которые меняем
        public int v1 { get; set; }
        public int v2 { get; set; }
        public int u1 { get; set; }
        public int u2 { get; set; }

        //порог изменения коэффициентов
        public double P { get; set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            v1 = Decimal.ToInt32(numericUpDown_v1.Value);
            u1 = Decimal.ToInt32(numericUpDown_u1.Value);
            v2 = Decimal.ToInt32(numericUpDown_v2.Value);
            u2 = Decimal.ToInt32(numericUpDown_u2.Value);
            P = Convert.ToDouble(textBox_P.Text);

            Close();
        }
    }
}
