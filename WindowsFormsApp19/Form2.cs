using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form2 : Form
    {
        double count, count1, count2, count3, count4, count5, count6, sum, sum2, sum1, sum3, sum4, sum5, sum6, sum7, sumn, sumf, sumper, sum11;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            comboBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("คุณไม่ได้กรอกข้อมูล", "คำเตือน");
                    textBox1.Focus();
                }
                else
                {
                    comboBox1.Focus();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(0.52);
            comboBox1.Items.Add(0.59);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a;
            a = double.Parse(comboBox1.Text);
            count = double.Parse(textBox1.Text);
            if(count > 15)
            {
                count1 = count - 15;
                sum = 15 * 1.8632;
            }
            else
            {
                sum = count * 1.8632;

            }
            if(count1 > 10)
            {
                count2 = count1 - 10;
                sum1 = 10 * 2.5026; 
            }
            else
            {
                sum1 = count * 2.5026;
            }
            if(count3 >= 10)
            {
                count4 = count3 - 10;
                sum2 = 10 * 2.7549;
            }
            else
            {
                sum2 = count2 * 2.7549;
            }
            if(count3 >= 65)
            {
                count4 = count3 - 65;
                sum2 = 65 * 3.1381;
            }
            else
            {
                sum2 = count2 * 3.1381;
            }
            if (count4 >= 50)
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
                count5 = count5 - 250;
                sum5 = 250 * 3.7362;
            }
            else
            {
                sum5 = count5 * 3.7362;
            }
            if (count6 >= 400 )
            {
                sum6 = count6 * 3.9361;
            }
            sum7 = sum + sum1 + sum2 + sum3 + sum4 + sum5 + sum6;
            sumn = sum7 + 8.19;
            sumf = count * a;
            sumper = (sum + sumf) * 7 / 100;
            sum11 = sumn + sumf + sumper;
            textBox2.Text = sumn.ToString("#,###.00");
            textBox3.Text = sumf.ToString("#,###.00");
            textBox4.Text = sumper.ToString("#,###.00");
            textBox5.Text = sum11.ToString("#,###.00");


        }
    }
}
