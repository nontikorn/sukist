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
    public partial class Form1 : Form
    {
        int b2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "pea" | textBox2.Text != "1234")
            {
                MessageBox.Show("รหัสผ่านถูกต้อง");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
                b2++;
                if (b2 == 3)
                {
                    MessageBox.Show("user และ password ผิด !!! เกิน 3 ครั้งกรุณาออกจากโปรแกรม", "รหัสผ่านผิด 3 ครั้ง");
                    this.Close();
                }
                else
                {

                }
                this.Hide();
                Form2 f2 = new Form2();
                f2.Show();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ยืนยันการออกจากโปรแกรม", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
        }
    }
    }

