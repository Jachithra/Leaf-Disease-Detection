using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Skincancerdetction
{
    public partial class F_2_Identification : Form
    {
        Class1 f1 = new Class1();
        Class2 f2= new Class2();
        public F_2_Identification(Bitmap bmp,string s, Bitmap bmp1)
        {
            InitializeComponent();
            pictureBox1.Image = (System.Drawing.Image)bmp;
            pictureBox2.Image = (System.Drawing.Image)bmp1;
            show(s);

        }
        public void show(string n)
        {
            string[] files = n.Split(new[] { "^&*#(" }, StringSplitOptions.None);

            if (files.Length >= 1)
            {
                pictureBox2.Visible = true;
                string t = files[0].ToString();
               // string text = files[1].ToString();
                // string h = files[2].ToString();
              //  pictureBox2.Image = Base64ToImage(t);

                //string[] txtfile = text.Split(new[] { "---" }, StringSplitOptions.None);
                //state.Text = txtfile[0].ToString();
                //type.Text = txtfile[1].ToString();
                //desc.Text = txtfile[2].ToString();
                if (t == f1.a1)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a101;
                    textBox1.Text = f2.a102;
                    textBox2.Text = f2.a103;
                    textBox3.Text = f2.a104;
                    textBox4.Text = (Convert.ToDouble(f1.a1) / Program.sdata).ToString();

                }
                if (t == f1.a2)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a201;
                    textBox1.Text = f2.a202;
                    textBox2.Text = f2.a203;
                    textBox3.Text = f2.a204;
                    textBox4.Text = (Convert.ToDouble(f1.a2) / Program.sdata).ToString();
                }
                if (t == f1.a3)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a301;
                    textBox1.Text = f2.a302;
                    textBox2.Text = f2.a303;
                    textBox3.Text = f2.a304;
                    textBox4.Text = (Convert.ToDouble(f1.a3) / Program.sdata).ToString();
                }
                if (t == f1.a4)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a401;
                    textBox1.Text = f2.a402;
                    textBox2.Text = f2.a403;
                    textBox3.Text = f2.a404;
                    textBox4.Text = (Convert.ToDouble(f1.a4) / Program.sdata).ToString();

                }
                if (t == f1.a5)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a501;
                    textBox1.Text = f2.a502;
                    textBox2.Text = f2.a503;
                    textBox3.Text = f2.a504;
                    textBox4.Text = (Convert.ToDouble(f1.a5) / Program.sdata).ToString();

                }
                if (t == f1.a6)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a601;
                    textBox1.Text = f2.a602;
                    textBox2.Text = f2.a603;
                    textBox3.Text = f2.a604;
                    textBox4.Text = (Convert.ToDouble(f1.a6) / Program.sdata).ToString();

                }
                if (t == f1.a7)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a701;
                    textBox1.Text = f2.a702;
                    textBox2.Text = f2.a703;
                    textBox3.Text = f2.a704;
                    textBox4.Text = (Convert.ToDouble(f1.a7) / Program.sdata).ToString();

                }
                if (t == f1.a8)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a801;
                    textBox1.Text = f2.a802;
                    textBox2.Text = f2.a803;
                    textBox3.Text = f2.a804;
                    textBox4.Text = (Convert.ToDouble(f1.a8) / Program.sdata).ToString();
                }
                 if (t == f1.a9)
                    {
                        state.Text = "Abnormal";
                        type.Text = f2.a901;
                        textBox1.Text = f2.a902;
                        textBox2.Text = f2.a903;
                        textBox3.Text = f2.a904;
                        textBox4.Text = (Convert.ToDouble(f1.a9) / Program.sdata).ToString();

                    }
                if (t == f1.a10)
                    {
                        state.Text = "Abnormal";
                        type.Text = f2.a1001;
                        textBox1.Text = f2.a1002;
                        textBox2.Text = f2.a1003;
                        textBox3.Text = f2.a1004;
                        textBox4.Text = (Convert.ToDouble(f1.a10) / Program.sdata).ToString();

                    }
                if (t == f1.a11)
                {
                    state.Text = "Abnormal";
                    type.Text = f2.a1101;
                    textBox1.Text = f2.a1102;
                    textBox2.Text = f2.a1103;
                    textBox3.Text = f2.a1104;
                    textBox4.Text = (Convert.ToDouble(f1.a11) / Program.sdata).ToString();

                }
                
            }
            else
            {
                pictureBox2.Visible = false;
                state.Text = "Abnormal";
                type.Text = "UnKnown Disease";
            }
           
        }
        public System.Drawing.Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void F_2_TumourIdentification_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
