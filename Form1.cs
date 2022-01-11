using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_XOR_Click(object sender, EventArgs e)
        {
            string strP = textBox_P.Text;
            int intP = Convert.ToInt32(strP, 16);
            string strKey = textBox_Key.Text;
            int intKey = Convert.ToInt32(strKey, 16);
            int intC = intP ^ intKey;
            string strC = Convert.ToString(intC, 16);
            textBox_C.Text = strC;
            textBox_P1.Text = textBox_P.Text;
            textBox_Key1.Text = textBox_Key.Text;
            textBox_C1.Text = textBox_C.Text;
            label7.Text = textBox_P.Text;
            string strP1 = Convert.ToString(intP, 10);
            label8.Text = strP1;
            string strP2 = Convert.ToString(intP, 2);
            label9.Text = strP2;
            label10.Text = textBox_Key.Text;
            string strKey1 = Convert.ToString(intKey, 10);
            label11.Text = strKey1;
            string strKey2 = Convert.ToString(intKey, 2);
            label12.Text = strKey2;
            label13.Text = textBox_C.Text;
            string strC1 = Convert.ToString(intC, 10);
            label14.Text = strC1;
            string strC2 = Convert.ToString(intC, 2);
            label15.Text = strC2;
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_P.Text = "";
            textBox_Key.Text = "";
            textBox_C.Text = "";
            textBox_P1.Text = "";
            textBox_Key1.Text = "";
            textBox_C1.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
        }
    }
}