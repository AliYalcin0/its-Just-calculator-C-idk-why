using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NedenBilmiyorum_HesapMakinesi
{
    public partial class HesapMakinesi : Form
    {
        public HesapMakinesi()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        int sayi1, sayi2,sonuc;
        string islem;

        private void button10_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri+"1";

            textBox1.Text = veri.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "2";

            textBox1.Text = veri.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "0";

            textBox1.Text = veri.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            else { SystemSounds.Beep.Play();}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = sayi1 + " * ";
            islem = " * ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = sayi1 + " - ";
            islem = " - ";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = sayi1 + " + ";
            islem = " + ";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "3";

            textBox1.Text = veri.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "4";

            textBox1.Text = veri.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "5";

            textBox1.Text = veri.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "6";

            textBox1.Text = veri.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "7";

            textBox1.Text = veri.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "8";

            textBox1.Text = veri.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string veri = textBox1.Text;
            if (veri == "0")
            {
                textBox1.Text = null;
                veri = null;
            }


            veri = veri + "9";

            textBox1.Text = veri.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            islem = " % ";
            textBox2.Text = sayi1 + " % ";
        }

        private void HesapMakinesi_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == '\b')
            {
                if(textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
                
            }

            if (e.KeyChar == 'r')
            {
                try
                {


                    textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 2);
                    sayi2 = Convert.ToInt32(textBox1.Text);
                    textBox2.Text = sayi1 + islem + sayi2;

                    if (islem == " / ")
                    {
                        sonuc = sayi1 / sayi2;
                        textBox1.Text = sonuc.ToString();
                    }

                    else if (islem == " * ")
                    {
                        sonuc = sayi1 * sayi2;
                        textBox1.Text = sonuc.ToString();
                    }

                    else if (islem == " - ")
                    {
                        sonuc = sayi1 - sayi2;
                        textBox1.Text = sonuc.ToString();
                    }

                    else if (islem == " + ")
                    {
                        sonuc = sayi1 + sayi2;
                        textBox1.Text = sonuc.ToString();
                    }

                    else if (islem == " % ")
                    {
                        sonuc = (sayi1 * sayi2) / 100;
                        textBox1.Text = sonuc.ToString();
                    }

                    else
                    {
                        SystemSounds.Asterisk.Play();
                    }


                }
                catch
                {
                    SystemSounds.Asterisk.Play();
                }

            }

            if (e.KeyChar == '/')
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "0";
                textBox2.Text = sayi1 + " / ";
                islem = " / ";
            }

            if (e.KeyChar == '*')
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "0";
                textBox2.Text = sayi1 + " * ";
                islem = " * ";
            }

            if (e.KeyChar == '-')
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "0";
                textBox2.Text = sayi1 + " - ";
                islem = " - ";
            }

            if (e.KeyChar == '+')
            {
                sayi1 = Convert.ToInt32(textBox1.Text);
                textBox1.Text = "0";
                textBox2.Text = sayi1 + " + ";
                islem = " + ";
            }

            if (e.KeyChar == '0')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "0";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '1')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "1";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '2')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "2";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '3')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "3";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '4')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "4";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '5')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "5";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '6')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "6";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '7')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "7";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '8')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "8";

                textBox1.Text = veri.ToString();
            }

            else if (e.KeyChar == '9')
            {
                string veri = textBox1.Text;
                if (veri == "0")
                {
                    textBox1.Text = null;
                    veri = null;
                }


                veri = veri + "9";

                textBox1.Text = veri.ToString();
            }

            else { SystemSounds.Beep.Play(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "0";
            textBox2.Text = sayi1+" / ";
            islem = " / ";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {

            
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 2);
                sayi2 = Convert.ToInt32(textBox1.Text);
                textBox2.Text = sayi1 + islem + sayi2;

                if(islem == " / ")
                {
                    sonuc = sayi1 / sayi2;
                    textBox1.Text = sonuc.ToString();
                }

                else if (islem == " * ")
                {
                    sonuc = sayi1 * sayi2;
                    textBox1.Text = sonuc.ToString();
                }

                else if (islem == " - ")
                {
                    sonuc = sayi1 - sayi2;
                    textBox1.Text = sonuc.ToString();
                }

                else if (islem == " + ")
                {
                    sonuc = sayi1 + sayi2;
                    textBox1.Text = sonuc.ToString();
                }

                else if(islem == " % ")
                {
                    sonuc = (sayi1 * sayi2) / 100;
                    textBox1.Text = sonuc.ToString();
                }

                else
                {
                    SystemSounds.Asterisk.Play();
                }


            }

            catch
            {
                SystemSounds.Asterisk.Play();
            }
        }
    }
}
