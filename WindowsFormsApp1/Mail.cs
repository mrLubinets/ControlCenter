using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
            string from = textBox1.Text;
            string to = textBox2.Text;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
