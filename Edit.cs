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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }
        Final_Project_ITIContext project = new Final_Project_ITIContext();
        private void edit_btn_Click(object sender, EventArgs e)
        {
            Note n = new Note() { Title = title_textbox.Text, Note1 = note_textbox.Text, Date = DateTime.Today.ToString(), Catgid = int.Parse(category_combobox.SelectedValue.ToString()) };
            var p = project.Notes.FirstOrDefault(s => s.Title == n.Title);
            
            p.Title = new_title_text.Text;
            p.Note1 = n.Note1;
            p.Date = DateTime.Today.ToString();
            p.Catgid = n.Catgid;     
            project.SaveChanges();
            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 })/*.GroupBy(n => n.Catg.Category1)*/.ToList();
            dataGridView1.DataSource = notes;
            MessageBox.Show("Note Has Been Updated");

        }
        private void Edit_Load(object sender, EventArgs e)
        {
            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 })/*.GroupBy(n => n.Catg.Category1)*/.ToList();
            dataGridView1.DataSource = notes;
            category_combobox.DataSource = project.Categories.ToList();
            category_combobox.DisplayMember = "Category1";
            category_combobox.ValueMember = "Id";
        }

        private void note_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
