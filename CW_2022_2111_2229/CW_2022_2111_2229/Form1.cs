using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CW_2022_2111_2229
{
    public partial class Form1 : Form
    {
        int h, w;
        int length;
        const int split_size = 8;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton_Hide.Checked = true;
            radioButton_Extract.Checked = false;
            radioButton_DCT.Checked = true;
            groupBox_Hide.Visible = true;
            groupBox_Extract.Visible = false;
            richTextBox_Hide.MaxLength = 0;
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;

                h = image.Height;
                w = image.Width;

                length = (h / split_size) * (w / split_size) / 8;
                label6.Text = label2.Text = length.ToString();
                richTextBox_Hide.MaxLength = length;
                richTextBox_Extract.Text = "";
            }
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            string txt = richTextBox_Hide.Text;
            
            if(radioButton_DCT.Checked && txt != "" && length != 0 && pictureBox1.Image != null)
            {
                DCT dct = new DCT();
                Form2 f = new Form2();
                f.ShowDialog();

                dct.v1 = f.v1;
                dct.u1 = f.u1;
                dct.v2 = f.v2;
                dct.u2 = f.u2;
                dct.P = f.P;

                pictureBox1.Image = dct.Hide(txt, new Bitmap(pictureBox1.Image));

                richTextBox_Hide.Text = "";
                MessageBox.Show("Сообщение успешно скрыто!", "Внимание!", MessageBoxButtons.OK);
            }
            else if(radioButton_BMYY.Checked && txt != "" && length != 0 && pictureBox1.Image != null)
            {
                DCT dct = new DCT();
                Form3 f = new Form3();
                f.ShowDialog();

                dct.v1 = f.v1;
                dct.u1 = f.u1;
                dct.v2 = f.v2;
                dct.u2 = f.u2;
                dct.v3 = f.v3;
                dct.u3 = f.u3;
                dct.P = f.P;
                dct.PL = f.PL;
                dct.PH = f.PH;

                pictureBox1.Image = dct.Hide_BMYY(txt, new Bitmap(pictureBox1.Image));
                richTextBox_Hide.Text = "";
                MessageBox.Show("Сообщение успешно скрыто!", "Внимание!", MessageBoxButtons.OK);
            }
        }

        private void richTextBox_Hide_TextChanged(object sender, EventArgs e)
        {
            label6.Text = (length - richTextBox_Hide.TextLength).ToString();
        }

        private void radioButton_Hide_Click(object sender, EventArgs e)
        {
            groupBox_Extract.Visible = false;
            groupBox_Hide.Visible = true;
        }

        private void radioButton_Extract_Click(object sender, EventArgs e)
        {
            groupBox_Hide.Visible = false;
            groupBox_Extract.Visible = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fs = saveFileDialog1.FileName;
                pictureBox1.Image.Save(fs);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Выйти?","Внимание!",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void radioButton_BMYY_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_BMYY.Checked && pictureBox1.Image != null) button_Analysis.Visible = true;
            else button_Analysis.Visible = false;
        }

        private void button_Analysis_Click(object sender, EventArgs e)
        {
            DCT dct = new DCT();

            Form3 f = new Form3();
            f.ShowDialog();

            dct.v1 = f.v1;
            dct.u1 = f.u1;
            dct.v2 = f.v2;
            dct.u2 = f.u2;
            dct.v3 = f.v3;
            dct.u3 = f.u3;
            dct.P = f.P;
            dct.PL = f.PL;
            dct.PH = f.PH;

            string lngth = Convert.ToString(dct.CountOfCorrectBlocks(new Bitmap(pictureBox1.Image)));

            string str = "Максимальная длина сообщения: " + lngth + ".";

            MessageBox.Show(str, "Анализ изображения", MessageBoxButtons.OK);

            length = Convert.ToInt32(lngth);

            label6.Text = label2.Text = lngth;
            richTextBox_Hide.MaxLength = length;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.Show();
        }

        private void button_Extract_Click(object sender, EventArgs e)
        {
            if (radioButton_DCT.Checked)
            {
                DCT dct = new DCT();

                Form2 f = new Form2();
                f.ShowDialog();

                dct.v1 = f.v1;
                dct.u1 = f.u1;
                dct.v2 = f.v2;
                dct.u2 = f.u2;
                dct.P = f.P;

                richTextBox_Extract.Text = dct.Extract(new Bitmap(pictureBox1.Image));

                MessageBox.Show("Сообщение успешно извлечено!", "Внимание!", MessageBoxButtons.OK);
            }
            else if (radioButton_BMYY.Checked)
            {
                DCT dct = new DCT();

                Form3 f = new Form3();
                f.ShowDialog();

                dct.v1 = f.v1;
                dct.u1 = f.u1;
                dct.v2 = f.v2;
                dct.u2 = f.u2;
                dct.v3 = f.v3;
                dct.u3 = f.u3;
                dct.P = f.P;
                dct.PL = f.PL;
                dct.PH = f.PH;

                richTextBox_Extract.Text = dct.Extract_BMYY(new Bitmap(pictureBox1.Image));
                MessageBox.Show("Сообщение успешно извлечено!", "Внимание!", MessageBoxButtons.OK);
            }
        }
    }
}
