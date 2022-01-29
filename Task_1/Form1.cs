using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab3rpvs.Class1;

namespace Task_1
{
    public partial class Form1 : Form
    {
        static string tAns = "";
        public static double radians(double degrees)
        {
            double radians;
            double pi = Math.PI;
            radians = (pi / 180) * degrees;
            return radians;
        }


        public Form1()
        {
            InitializeComponent();
            this.ans.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            ans.ReadOnly = true;
            H.ReadOnly = true;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String s="";
            double x1 = 0.1;
            double x2 = 1;
            double N = double.Parse(n.Text);
            double ansH = (x2 - x1) / N;
            H.Text = ansH.ToString();
            double sum = 0;
            int fa = 1;
            int NN = 0;
            double prim = Math.Pow((-1), N) * Math.Pow(x1, (2 * N + 1)) / (fa);
            while (x1 <= x2 + 0.00001)
            {
                sum = 0;
                prim = 0;
                NN = 0;
                while (NN <= N)
                {
                    fa = 1;
                    int countFa = 1;
                    while (countFa <= (2 * NN + 1))
                    {
                        fa *= countFa;
                        countFa++;
                    }
                    prim = Math.Pow((-1), NN) * Math.Pow(x1, (2 * NN + 1)) / (fa);
                    sum += prim;

                    NN++;
                }
                s += "При x: " + x1.ToString() + " сумма: " + sum + " При sin(x): " + Math.Sin(x1) + "\r\n";

                x1 += ansH;
            }

            ans.Text = s;
        


    }


    private void закрытьПрограммуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void form_MydelegateEvent(Color s)
        {
            ans.BackColor = s;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            form.col = this.ans;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
