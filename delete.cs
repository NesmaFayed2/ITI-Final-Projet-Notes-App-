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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }
        Final_Project_ITIContext project = new Final_Project_ITIContext();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Load(object sender, EventArgs e)
        {
            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 }).ToList();
            dataGridView1.DataSource = notes;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var p = project.Notes.FirstOrDefault(s => s.Title == title_textbox.Text);
            project.Remove(p);
            project.SaveChanges();
            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 }).ToList();
            dataGridView1.DataSource = notes;
            MessageBox.Show("Note Has Been Deleted");
   
        }
    }
}
