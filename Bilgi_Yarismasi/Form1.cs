using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;



        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;


            soruno++;
            LblSoruno.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ? ";
                BtnA.Text = "1978";
                BtnB.Text = "1938";
                BtnC.Text = "1905";
                BtnD.Text = "1923";

                label1.Text = "1923";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = "Galatasaray kaç yılında kurulmuştur ? ";
                BtnA.Text = "1978";
                BtnB.Text = "1938";
                BtnC.Text = "1905";
                BtnD.Text = "1923";

                label1.Text = "1905";
            }

            if (soruno == 3)
            {
                richTextBox1.Text = "Laiklik kaç yılında ilan edilmiştir ? ";
                BtnA.Text = "1978";
                BtnB.Text = "1938";
                BtnC.Text = "1905";
                BtnD.Text = "1923";

                label1.Text = "1978";
            }

        }



        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            BtnSonraki.Enabled = true;


            label2.Text = BtnA.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            BtnSonraki.Enabled = true;

            label2.Text = BtnB.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            BtnSonraki.Enabled = true;

            label2.Text = BtnC.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;

            BtnSonraki.Enabled = true;

            label2.Text = BtnD.Text;
            if (label1.Text == label2.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }
    }
}
