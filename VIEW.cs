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
    public partial class VIEW : Form
    {
        public VIEW()
        {
            InitializeComponent();
          
        }

        Final_Project_ITIContext project = new Final_Project_ITIContext();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          


        }

        private void VIEW_Load(object sender, EventArgs e)
        {
            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date ,category=n.Catg.Category1}).ToList();
            dataGridView1.DataSource = notes;
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                var searcht_title = title_textbox.Text;
                var search_date = date_textbox.Text;
                var note1 = project.Notes.Where(n => n.Title.Contains(searcht_title.ToLower()) && n.Date.Contains(search_date)).Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 }).ToList();
                dataGridView1.DataSource = note1;

           
               
                //var note2 = project.Notes.Where(n => n.Date.Contains(search_date)).Select(n => new { Title = n.Title, note = n.Note1, date = n.Date }).ToList();
                //dataGridView1.DataSource = note2;

        }

        private void restore_btn_Click(object sender, EventArgs e)
        {
            var notes = project.Notes.Select(n => new { Title = n.Title, note = n.Note1, date = n.Date, category = n.Catg.Category1 }).ToList();
            dataGridView1.DataSource = notes;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            button2.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (dataGridView1.SelectedRows.Count == 0)
            {
                //MessageBox.Show("no selectedrow");
                return;
            }


            richTextBox1.Text = "Title:-"+ dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "\n"+ "Note:-"+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "\n" + "Date:-" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
  
        }
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            button2.PerformClick();
        }
    }
}
