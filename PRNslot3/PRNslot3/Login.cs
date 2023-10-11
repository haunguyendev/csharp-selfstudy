using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRNslot3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)

        {
            // int? a => ? o day la co the gan gia tri null
            var name = textFullName.Text;
            var result = "xin chao " + name;
            lbFullName.Text = result;
            MessageBox.Show(result, "Info", MessageBoxButtons.OK);


        }
    }
}
