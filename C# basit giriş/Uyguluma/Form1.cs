using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyguluma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int x;
        private void button1_Click(object sender, EventArgs e)
        {
     
            listView1.Items.Add(textBox1.Text);
            listView1.Items[x].SubItems.Add(comboBox1.Text);
            listView1.Items[x].SubItems.Add(textBox3.Text);
            x++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Matematik");
            comboBox1.Items.Add("Edebiyat");
            comboBox1.Items.Add("Felsefe");
            comboBox1.Items.Add("Dil Anlatım");
            comboBox1.Items.Add("İnkılap Tarihi");
            comboBox1.Items.Add("Beden Eğitimi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            comboBox1.Text = "";
            listView1.Items.Clear();
        }
    }
}
