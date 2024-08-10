using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject_iti
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void view_btn_Click(object sender, EventArgs e)
        {
            VIEW v =new VIEW();
            v.Show();
         

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ADD_NOTE A = new ADD_NOTE();
            A.Show();
        }

        private void HOME_Load(object sender, EventArgs e)
        {

        }
    }
}
