using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegeEventSample
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLabelGonder_Click(object sender, EventArgs e)
        {

            this.Close();
            Form1 form1 = new Form1();
        }
        public string GetTextValue1()
        {
            return textBox1.Text;
        }
        public string GetTextValue2()
        {
            return textBox2.Text;
        }

    }
}
