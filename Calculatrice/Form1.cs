using System;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;

        public void disable()
        {
            label1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
        }

        public void enable()
        {
            label1.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "-" + label1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num = float.Parse(label1.Text);
            label1.Text = "";
            count = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num = float.Parse(label1.Text);
            label1.Text = "";
            count = 3;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "9";
            }
            else
            {
                label1.Text += "9";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "8";
            }
            else
            {
                label1.Text += "8";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "7";
            }
            else
            {
                label1.Text += "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num = float.Parse(label1.Text);
            label1.Text = "";
            count = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "6";
            }
            else
            {
                label1.Text += "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
               label1.Text = "5";
            }
            else
            {
                label1.Text += "5";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "4";
            }
            else
            {
                label1.Text += "4";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "3";
            }
            else
            {
                label1.Text += "3";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "2";
            }
            else
            {
                label1.Text += "2";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (label1.Text != "0") 
            {
                label1.Text += "0"; 
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num = float.Parse(label1.Text);
            label1.Text = "";
            count = 1;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            compute();
        }

        private void compute()
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(label1.Text);
                    label1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num - float.Parse(label1.Text);
                    label1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num * float.Parse(label1.Text);
                    label1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num / float.Parse(label1.Text);
                    label1.Text = ans.ToString();
                    break;
                default:
                    label1.Text = "Error!";
                    break;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0") 
            {
                label1.Text = "1";
            }
            else 
            {
                label1.Text += "1";
            }
        }

    }

}
