using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_Taking
{
    public partial class Form1 : Form
    {
        DataTable table;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table= new DataTable();
            table.Columns.Add("Title",typeof(string));
            table.Columns.Add("Message", typeof(string));
            dgv.DataSource = table;
            dgv.Columns["Message"].Visible = false;
            dgv.Columns["Title"].Width = 306;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textBox1.Text,textBox2.Text);
            button1.PerformClick();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentCell.RowIndex;
            if (index > -1)
            {
                textBox1.Text = table.Rows[index].ItemArray[0].ToString();
                textBox2.Text = table.Rows[index].ItemArray[1].ToString();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int index=dgv.CurrentCell.RowIndex;
            table.Rows[index].Delete();
        }
    }
}
