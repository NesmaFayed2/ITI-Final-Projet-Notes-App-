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
    public partial class addcatg : Form
    {
        public addcatg()
        {
            InitializeComponent();
        }
        Final_Project_ITIContext project = new Final_Project_ITIContext();
        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            Category c = new Category() {Category1=s};
            project.Categories.Add(c);
            project.SaveChanges();
            MessageBox.Show("Category has been added !");
            Close();
            ADD_NOTE n = new ADD_NOTE();
            n.Show();

        }

        private void addcatg_Load(object sender, EventArgs e)
        {

        }
    }
}
