using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace electricity
{
    public partial class Form1 : Form
    {
        double count, count1, count2, count3, count4, count5, count6, sum, sum1, sum2, sum3,
            sum4, sum5, sum6, sum7, sumn, sumf, sumper, sumall;

        private void Clearbtn_Click_1(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.Items.Add(0.52);
            comboBox1.Items.Add(0.59);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void cal_button_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(comboBox2.Text);
            count = double.Parse(comboBox1.Text);

            if (count > 15)
            {
                count1 = count - 15;
                sum = 15 * 1.8632;
            }
            else
            {
                sum = count * 1.8632;
            }
            if (count1 > 10)
            {
                count2 = count1 - 10;
                sum1 = 10 * 2.5026;
            }
            else
            {
                sum = count1 * 2.5026;
            }
            if (count2 > 10)
            {
                count3 = count2 - 10;
                sum2 = 10 * 2.7549;
            }
            else
            {
                sum2 = count2 * 2.7549;
            }
            if (count3 >= 65)
            {
                count4 = count3 - 65;
                sum3 = 65 * 3.1381;
            }
            else
            {
                sum3 = count3 * 3.1381;
            }
            if (count4 > 50)
            {
                count5 = count4 - 50;
                sum4 = 50 * 3.2315;
            }
            else
            {
                sum4 = count4 * 3.2315;
            }
            if (count5 >= 250)
            {
                count6 = count5 - 250;
                sum5 = 250 * 3.7362;
            }
            else
            {
                sum5 = count5 * 3.7362;
            }
            if (count6 >= 400)
            {
                sum6 = count6 * 3.9361;
            }
            sum7 = sum + sum1 + sum2 + sum3 + sum4 + sum5 + sum6;
            sumn = sum7 + 8.19;
            sumf = count * a;
            sumper = (sum + sumf) * 7 / 100;
            sumall = sumn + sumf + sumper;
            textBox4.Text = sumn.ToString("#,###.00");
            textBox5.Text = sumf.ToString("#,###.00");
            textBox6.Text = sumper.ToString("#,###.00");
            textBox7.Text = sumall.ToString("#,###.00");
        }       
    }
}
