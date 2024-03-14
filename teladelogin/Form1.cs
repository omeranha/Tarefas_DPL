using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teladelogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox3.Text == "ds@etefmc") {
                MessageBox.Show("login e senha corretos\nAcesso liberado");
            } else {
                MessageBox.Show("login ou senha incorretos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
