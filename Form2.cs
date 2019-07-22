using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game_2
{
    public partial class Form2 : Form
    {
        Form myform = new game_1.Form1();
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //new form1().show();
            myform.Show();
            this.Hide();
        }
    }
}
