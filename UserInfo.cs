using ExampleFormApplication_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleFormApplication
{
    public partial class UserInfo : Form
    {
        public static string SetValueForText2 = "";
        public static string SetValueForText3 = "";

        public UserInfo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            SetValueForText2 = textBox2.Text;
            SetValueForText3 = textBox3.Text;

            Form3 frm3 = new Form3();
            frm3.Show();

            MessageBox.Show("Hello" + ' ' + textBox2.Text + ' ' + textBox3.Text + ' ' +

            ". Welcome to the Windows Application", "Welcome", MessageBoxButtons.OKCancel,

            MessageBoxIcon.Information);

            this.Dispose(false);
        }

        private void UserInfo_Load(object sender, EventArgs e)
        {
            
        }
        
    }      
}
