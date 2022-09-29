using ExampleFormApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleFormApplication_
{
    public partial class Form3 : UserInfo
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = UserInfo.SetValueForText2;
            label3.Text = UserInfo.SetValueForText3;
            
        }

        
    }
}
