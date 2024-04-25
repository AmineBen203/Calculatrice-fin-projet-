using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                button17.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1) 
            {
                AppendZero();
                button16.PerformClick(); 
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                button15.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                button14.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                button12.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                button11.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                button10.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                button8.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                button7.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                button13.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                button9.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                button4.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                button5.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                button6.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                
                compute();
            }

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
            ans = 0;
            num = 0;    
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
            AppendZero();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text += ".";
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
                case 5:
                    ans = num % float.Parse(label1.Text);
                    label1.Text = ans.ToString();
                    break;
                default:
                    label1.Text = "Error!";
                    break;
            }

            count = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            count = 5;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void rougeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.FromArgb(220, 20, 60);
            button17.ForeColor = Color.White;
            button16.BackColor = Color.FromArgb(220, 20, 60);
            button16.ForeColor = Color.White;
            button15.BackColor = Color.FromArgb(220, 20, 60);
            button15.ForeColor = Color.White;
            button14.BackColor = Color.FromArgb(220, 20, 60);
            button14.ForeColor = Color.White;
            button11.BackColor = Color.FromArgb(220, 20, 60);
            button11.ForeColor = Color.White;
            button6.BackColor = Color.FromArgb(220, 20, 60);
            button6.ForeColor = Color.White;
            button7.BackColor = Color.FromArgb(220, 20, 60);
            button7.ForeColor = Color.White;
            button10.BackColor = Color.FromArgb(220, 20, 60);
            button10.ForeColor = Color.White;
            button7.BackColor = Color.FromArgb(220, 20, 60);
            button7.ForeColor = Color.White;
            button12.BackColor = Color.FromArgb(220, 20, 60);
            button12.ForeColor = Color.White; 
            button18.BackColor = Color.FromArgb(220, 20, 60);
            button18.ForeColor = Color.White;
            button8.BackColor = Color.FromArgb(220, 20, 60);
            button8.ForeColor = Color.White;

            button1.BackColor = Color.FromArgb(178, 34, 34);
            button1.ForeColor = Color.White;
            button2.BackColor = Color.FromArgb(178, 34, 34);
            button2.ForeColor = Color.White;
            button3.BackColor = Color.FromArgb(178, 34, 34);
            button3.ForeColor = Color.White;

            label1.BackColor = Color.FromArgb(248, 248, 255);
            label1.ForeColor = Color.Black;

            BackColor = Color.FromArgb(248, 248, 255);



        }

        private void blancToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button17.BackColor = Color.DarkGray;
            button17.ForeColor = Color.White;
            button16.BackColor = Color.DarkGray;
            button16.ForeColor = Color.White;
            button15.BackColor = Color.DarkGray;
            button15.ForeColor = Color.White;
            button14.BackColor = Color.DarkGray;
            button14.ForeColor = Color.White;
            button11.BackColor = Color.DarkGray;
            button11.ForeColor = Color.White;
            button6.BackColor = Color.DarkGray;
            button6.ForeColor = Color.White;
            button7.BackColor = Color.DarkGray;
            button7.ForeColor = Color.White;
            button10.BackColor = Color.DarkGray;
            button10.ForeColor = Color.White;
            button7.BackColor = Color.DarkGray;
            button7.ForeColor = Color.White;
            button12.BackColor = Color.DarkGray;
            button12.ForeColor = Color.White; 
            button18.BackColor = Color.DarkGray;
            button18.ForeColor = Color.White;
            button8.BackColor = Color.DarkGray;
            button8.ForeColor = Color.White;

            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.White;

            label1.BackColor = Color.FromArgb(248, 248, 255);
            label1.ForeColor = Color.Black;

            BackColor = Color.FromArgb(248, 248, 255);
        }

        private void rosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button17.BackColor = SystemColors.WindowFrame;
            button17.ForeColor = Color.White;
            button16.BackColor = SystemColors.WindowFrame;;
            button16.ForeColor = Color.White;
            button15.BackColor = SystemColors.WindowFrame;
            button15.ForeColor = Color.White;
            button14.BackColor = SystemColors.WindowFrame;
            button14.ForeColor = Color.White;
            button11.BackColor = SystemColors.WindowFrame;
            button11.ForeColor = Color.White;
            button6.BackColor = SystemColors.WindowFrame;
            button6.ForeColor = Color.White;
            button7.BackColor = SystemColors.WindowFrame;
            button7.ForeColor = Color.White;
            button10.BackColor = SystemColors.WindowFrame;
            button10.ForeColor = Color.White;
            button7.BackColor = SystemColors.WindowFrame;
            button7.ForeColor = Color.White;
            button12.BackColor = SystemColors.WindowFrame;
            button12.ForeColor = Color.White;
            button18.BackColor = SystemColors.WindowFrame;
            button18.ForeColor = Color.White;
            button8.BackColor = SystemColors.WindowFrame;
            button8.ForeColor = Color.White;

            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.Black;
            button3.BackColor = Color.Gray;
            button3.ForeColor = Color.Black;

            label1.BackColor = Color.Black;
            label1.ForeColor = Color.White;

            BackColor = Color.Black;
        }

        private void àProposDeCeProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Application : Calculatrice \nVersion: 1.1(25/04/2024)\nAuteur : Mohamed Amine BEN AHMED ");
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

        private void AppendZero()
        {
            if (label1.Text != "0")
            {
                label1.Text += "0";
            }
        }


    }

}
