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

namespace VuTrungNghia
{
    public partial class Form1 : Form
    {
        private const string V = "hoa khung";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Q.Text = ("xin chao 20DTHA5");
            this.BackColor = Color.Yellow;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = "xin chao 20DTHA5" + textBox1.Text;
        }
        private void textbox1_textchanged(object sender, eventargs e)

        {
            
        }
        
       
    }
}
