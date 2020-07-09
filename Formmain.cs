using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Calcuator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelReesult.Text = "";
            labelDisplay.Text = "0";
            this.MinimumSize = this.Size;
            // 언어별 CultureInfo
            //en-US   영어(미국)
            //ko-KR   한국어(대한민국)
            //zh-CN   중국어(중국)
            //ja-JP   일본어(일본)
            //MessageBox.Show(CultureInfo.CurrentCulture.TextInfo.CultureName);
            if (CultureInfo.CurrentCulture.TextInfo.CultureName.Equals("ko-KR"))
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
            comboBox1.SelectedIndex = 2;
        }
    

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text.Equals("0"))
            {
                labelDisplay.Text = "";
            }
            labelDisplay.Text = labelDisplay.Text + ((Button)sender).Text;
            labelDisplay.Text = int.Parse(labelDisplay.Text.Trim().Replace(",", "")).ToString("#,##0");
        }
             
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelReesult.Text = "";
            labelDisplay.Text = "0";
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            labelReesult.Text = labelDisplay.Text.Replace(",", "") + "/";
            labelDisplay.Text = "0"; 
        }

        private void buttonMultiyply_Click(object sender, EventArgs e)
        {
            labelReesult.Text = labelDisplay.Text.Replace(",", "") + "*";
            labelDisplay.Text = "0";
        }

        private void buttonM_Click(object sender, EventArgs e)
        {
            labelReesult.Text = labelDisplay.Text.Replace(",", "") + "-";
            labelDisplay.Text = "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            labelReesult.Text = labelDisplay.Text.Replace(",","") + "+";
            labelDisplay.Text = "0";
        }

        private void buttonEqaul_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelReesult.Text) == false)
            {
                char op = labelReesult.Text[labelReesult.Text.Length - 1];
                string tempA = labelReesult.Text.Remove(labelReesult.Text.Length - 1);
                string tempB = labelDisplay.Text.Replace(",", "");
                int a = int.Parse(tempA);
                int b = int.Parse(tempB);
                double c = 0;
                if (op == '+')
                {
                    c = a + b;
                }
                else if (op == '-')
                {
                    c = a - b;
                }
                else if (op == '*')
                {
                    c = a * b;
                }
                else if (op == '/')
                {
                    c = a / b;
                }

                labelReesult.Text = "";
                labelDisplay.Text = c.ToString("#,##0");

            }
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.D0: { button0.PerformClick(); } break;
                case Keys.D1: { button1.PerformClick(); } break;
                case Keys.D2: { button2.PerformClick(); } break;
                case Keys.D3: { button3.PerformClick(); } break;
                case Keys.D4: { button4.PerformClick(); } break;
                case Keys.D5: { button5.PerformClick(); } break;
                case Keys.D6: { button6.PerformClick(); } break;
                case Keys.D7: { button7.PerformClick(); } break;
                case Keys.D8: { button8.PerformClick(); } break;
                case Keys.D9: { button9.PerformClick(); } break;
                default: { System.Console.WriteLine("unknown KeyCode: {0}", e.KeyCode); } break;
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout f = new FormAbout();
            f.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: // 영어
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                    }
                    break;
                case 1: // 한국어
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ko-KR");
                    }
                    break;
                case 2: // 중국어
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("zh-CN");
                    }
                    break;
                case 3: // 일본어
                    {
                        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ja-JP");
                    }
                    break;
            }

            setLanguage();
        }

        private void setLanguage()
        {
            this.Text = Language.String1;
        }
    }
}

        