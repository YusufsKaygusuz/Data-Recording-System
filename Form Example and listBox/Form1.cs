using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Example_and_listBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TcNo, AdSoyad, Cinsiyet="", Mezuniyet = "", diller = "", uzmanlık = "";

            TcNo = textBox1.Text;
            AdSoyad = textBox2.Text;

            if(radioButton1.Checked == true)
            {
                Cinsiyet = radioButton1.Text;
            }
            else if(radioButton2.Checked == true)
            {
                Cinsiyet = radioButton2.Text;
            }

            if (radioButton3.Checked == true)
                Mezuniyet = radioButton3.Text;
            else if (radioButton4.Checked == true)
                Mezuniyet = radioButton4.Text;
            else if (radioButton5.Checked == true)
                Mezuniyet = radioButton5.Text;
            else if (radioButton6.Checked == true)
                Mezuniyet = radioButton6.Text;


            if (checkBox1.Checked)
                diller += "," + checkBox1.Text;
            if (checkBox2.Checked)
                diller += "," + checkBox2.Text;
            if (checkBox3.Checked)
                diller += "," + checkBox3.Text;
            if (checkBox4.Checked)
                diller += "," + checkBox4.Text;
            if (checkBox5.Checked)
                diller += "," + checkBox5.Text;
            if (checkBox6.Checked)
                diller += "," + checkBox6.Text;

            diller = diller.Substring(1);

            if (checkBox7.Checked)
                uzmanlık += "," + checkBox7.Text;
            if (checkBox8.Checked)
                uzmanlık += "," + checkBox8.Text;
            if (checkBox9.Checked)
                uzmanlık += "," + checkBox9.Text;
            if (checkBox10.Checked)
                uzmanlık += "," + checkBox10.Text;
            if (checkBox11.Checked)
                uzmanlık += "," + checkBox11.Text;
            if (checkBox12.Checked)
                uzmanlık += "," + checkBox12.Text;

            uzmanlık = uzmanlık.Substring(1);


            listBox1.Items.Add("Tc No: " + TcNo + " | " + "Adı Soyadı: " + AdSoyad + " | " + "Cinsiyeti: " + Cinsiyet + " | "+
                "Diller: " +diller + " | " +"Mezuniyet:" + Mezuniyet + " | " + "Uzmanlık: " + uzmanlık) ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
        }
    }
}
