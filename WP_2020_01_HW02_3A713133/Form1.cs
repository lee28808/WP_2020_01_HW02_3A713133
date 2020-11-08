using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WP_2020_01_HW02_3A713133.Properties;

namespace WP_2020_01_HW02_3A713133
{
    public partial class Form1 : Form
    {
        List<Image> b = new List<Image>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b.Add(Resources._1);
            b.Add(Resources._2);
            b.Add(Resources._3);
            b.Add(Resources._4);
            b.Add(Resources._5);
            b.Add(Resources._6);
            b.Add(Resources._7);
            b.Add(Resources._8);
            b.Add(Resources._9);
            b.Add(Resources._10);
            b.Add(Resources._11);
            b.Add(Resources._12);
            b.Add(Resources._13);
            b.Add(Resources._14);
            b.Add(Resources._15);
            b.Add(Resources._16);
            b.Add(Resources._17);
            b.Add(Resources._18);
            b.Add(Resources._19);
            b.Add(Resources._20);
            b.Add(Resources._21);
            b.Add(Resources._22);
            b.Add(Resources._23);
            b.Add(Resources._24);
            b.Add(Resources._25);
            b.Add(Resources._26);
            b.Add(Resources._27);
            b.Add(Resources._28);
            b.Add(Resources._29);
            b.Add(Resources._30);
            b.Add(Resources._31);
            b.Add(Resources._32);
            b.Add(Resources._33);
            b.Add(Resources._34);
            b.Add(Resources._35);
            b.Add(Resources._36);
            b.Add(Resources._37);
            b.Add(Resources._38);
            b.Add(Resources._39);
            b.Add(Resources._40);
            b.Add(Resources._41);
            b.Add(Resources._42);
            b.Add(Resources._43);
            b.Add(Resources._44);
            b.Add(Resources._45);
            b.Add(Resources._46);
            b.Add(Resources._47);
            b.Add(Resources._48);
            b.Add(Resources._49);
            b.Add(Resources._50);
            b.Add(Resources._51);
            b.Add(Resources._52);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int a = new Random().Next(51) + 1;
            pictureBox1.Image = b[a];  
        }
    }
}
