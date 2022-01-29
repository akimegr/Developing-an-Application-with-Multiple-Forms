using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1
{
    public partial class Form2 : Form
    {
        public TextBox col;
        public Form2()
        {
            InitializeComponent();
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            radioButton1.Checked = true;
            vScrollBar1.Value = 200;
            vScrollBar2.Value = 200;
            vScrollBar3.Value = 200;
            textBox2.BackColor = Color.FromArgb(vScrollBar1.Value , vScrollBar2.Value, vScrollBar3.Value);
            textBox2.Enabled = false;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, 0, 0);
            textBox3.BackColor = Color.FromArgb(0, vScrollBar2.Value, 0);
            textBox4.BackColor = Color.FromArgb(0, 0, vScrollBar3.Value);
            textBox5.ForeColor = Color.FromArgb(vScrollBar1.Value, 0, 0);
            textBox6.ForeColor = Color.FromArgb(0, vScrollBar2.Value, 0);
            textBox7.ForeColor = Color.FromArgb(0, 0, vScrollBar3.Value);
            textBox5.Text = Convert.ToString(vScrollBar1.Value);
            textBox6.Text = Convert.ToString(vScrollBar2.Value);
            textBox7.Text = Convert.ToString(vScrollBar3.Value);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar1.Value <= 255)
            {
                vScrollBar1.Value += 1;
            }
            textBox2.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            textBox1.BackColor = Color.FromArgb(vScrollBar1.Value, 0, 0);
            textBox5.Text = Convert.ToString(vScrollBar1.Value);
            textBox5.ForeColor = Color.FromArgb(vScrollBar1.Value, 0, 0);
        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            if (vScrollBar2.Value <= 255)
            {
                vScrollBar2.Value += 1;
            }
            textBox2.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            textBox3.BackColor = Color.FromArgb(0, vScrollBar2.Value, 0);
            textBox6.Text = Convert.ToString(vScrollBar2.Value);
            textBox6.ForeColor = Color.FromArgb(0, vScrollBar2.Value, 0);

        }

        private void vScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            if(vScrollBar3.Value <= 255)
            {
                vScrollBar3.Value += 1;
            }
            textBox2.BackColor = Color.FromArgb(vScrollBar1.Value, vScrollBar2.Value, vScrollBar3.Value);
            textBox4.BackColor = Color.FromArgb(0, 0, vScrollBar3.Value);
            textBox7.Text = Convert.ToString(vScrollBar3.Value);
            textBox7.ForeColor = Color.FromArgb(0, 0, vScrollBar3.Value);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                vScrollBar1.Enabled = true;
            }
            else
            {
                vScrollBar1.Enabled = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                vScrollBar2.Enabled = true;
            }
            else
            {
                vScrollBar2.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                vScrollBar3.Enabled = true;
            }
            else
            {
                vScrollBar3.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            col.BackColor = textBox2.BackColor;
        }

    }
}
