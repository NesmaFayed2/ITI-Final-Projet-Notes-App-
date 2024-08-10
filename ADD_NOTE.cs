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
    public partial class ADD_NOTE : Form
    {
        public ADD_NOTE()
        {
            InitializeComponent();
        }
        Final_Project_ITIContext project = new Final_Project_ITIContext();
        private void button1_Click(object sender, EventArgs e)
        {


            Note n = new Note() { Title=title_textbox.Text , Note1=note_textbox.Text,Date= DateTime.Today.ToString(), Catgid=int.Parse(category_combobox.SelectedValue.ToString())};
            project.Notes.Add(n);          
            project.SaveChanges();
            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 }).ToList();
            add_girdview.DataSource = notes;
            title_textbox.Text = "";
            note_textbox.Text = "";

        }
        private void deletecatg_btn_Click(object sender, EventArgs e)
        {
            addcatg c = new addcatg();
            c.Show();
            Close();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ADD_NOTE_Load(object sender, EventArgs e)
        {

            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 })/*.GroupBy(n => n.Catg.Category1)*/.ToList();
            add_girdview.DataSource = notes;
            category_combobox.DataSource = project.Categories.ToList();
            category_combobox.DisplayMember = "Category1";
            category_combobox.ValueMember = "Id";
            

        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Edit m=new Edit();
            m.Show();
            Close();
         


        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            delete d = new delete();
            d.Show();
            Close();

        }

      

      
    }
}
