using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string ramz(string s)
        {
            char[] ch = new char[11];
            for (int i = 0; i < 5; i++)
            {
                ch[i] = (char)(s[i] + 5);
            }

            ch[5] = '-';
            for (int i = 6; i < 11; i++)
            {
                ch[i] = (char)(s[i] + 10);
            }


            string s2 = new string(ch);
            return s2;
        }

        public string ramz2(string s)
        {
            char[] ch = new char[10];
            for (int i = 0; i < ch.Length; i++)
            {
                ch[i] = (char)(s[i] + i);
            }
            string s2 = new string(ch);
            return s2;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //table1TableAdapter.FillBy(dataSet11.Table1, textBox1.Text);
            //if (dataSet11.Table1.Rows.Count == 0)
            //    MessageBox.Show("کد محصول اشتباه است");
            //else if (int.Parse((dataSet11.Table1.Rows[0]["installcount"]).ToString()) < 3)
            //{

                textBox3.Text = ramz2(textBox2.Text);
                //table1TableAdapter.InsertQuery (textBox1.Text , dataSet11.Table1.Rows[0]["installcount"] ,textBox2.Text );

            //}
            //else
            //{
            //    textBox3.Text = ramz(textBox2.Text);

            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'dataSet11.Table1' table. You can move, or remove it, as needed.
        //this.table1TableAdapter.Fill(this.dataSet11.Table1);

          //   this.table1TableAdapter.Fill(this.dataSet11.Table1);               
            
        }
    }
}
