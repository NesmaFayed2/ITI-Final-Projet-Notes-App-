
namespace FinalProject_iti
{
    partial class ADD_NOTE
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.add_girdview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.addNote_btn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.note_textbox = new System.Windows.Forms.RichTextBox();
            this.deletecatg_btn = new System.Windows.Forms.Button();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.add_girdview)).BeginInit();
            this.SuspendLayout();
            // 
            // add_girdview
            // 
            this.add_girdview.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.add_girdview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.add_girdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.add_girdview.DefaultCellStyle = dataGridViewCellStyle1;
            this.add_girdview.Location = new System.Drawing.Point(12, 12);
            this.add_girdview.Name = "add_girdview";
            this.add_girdview.RowHeadersWidth = 62;
            this.add_girdview.RowTemplate.Height = 33;
            this.add_girdview.Size = new System.Drawing.Size(634, 305);
            this.add_girdview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(679, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(681, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Note";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(681, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 28);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category";
            // 
            // title_textbox
            // 
            this.title_textbox.BackColor = System.Drawing.Color.FloralWhite;
            this.title_textbox.ForeColor = System.Drawing.Color.Maroon;
            this.title_textbox.Location = new System.Drawing.Point(776, 13);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(203, 31);
            this.title_textbox.TabIndex = 2;
            // 
            // category_combobox
            // 
            this.category_combobox.BackColor = System.Drawing.Color.FloralWhite;
            this.category_combobox.ForeColor = System.Drawing.Color.Maroon;
            this.category_combobox.FormattingEnabled = true;
            this.category_combobox.Location = new System.Drawing.Point(785, 165);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(203, 33);
            this.category_combobox.TabIndex = 5;
            this.category_combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // addNote_btn
            // 
            this.addNote_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.addNote_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addNote_btn.ForeColor = System.Drawing.Color.Maroon;
            this.addNote_btn.Location = new System.Drawing.Point(776, 211);
            this.addNote_btn.Name = "addNote_btn";
            this.addNote_btn.Size = new System.Drawing.Size(150, 34);
            this.addNote_btn.TabIndex = 6;
            this.addNote_btn.Text = "Add Note +";
            this.addNote_btn.UseVisualStyleBackColor = false;
            this.addNote_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // note_textbox
            // 
            this.note_textbox.BackColor = System.Drawing.Color.FloralWhite;
            this.note_textbox.ForeColor = System.Drawing.Color.Maroon;
            this.note_textbox.Location = new System.Drawing.Point(776, 50);
            this.note_textbox.Name = "note_textbox";
            this.note_textbox.Size = new System.Drawing.Size(278, 95);
            this.note_textbox.TabIndex = 7;
            this.note_textbox.Text = "";
            // 
            // deletecatg_btn
            // 
            this.deletecatg_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.deletecatg_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletecatg_btn.ForeColor = System.Drawing.Color.Maroon;
            this.deletecatg_btn.Location = new System.Drawing.Point(994, 162);
            this.deletecatg_btn.Name = "deletecatg_btn";
            this.deletecatg_btn.Size = new System.Drawing.Size(210, 36);
            this.deletecatg_btn.TabIndex = 8;
            this.deletecatg_btn.Text = "Add new  Category";
            this.deletecatg_btn.UseVisualStyleBackColor = false;
            this.deletecatg_btn.Click += new System.EventHandler(this.deletecatg_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_btn.ForeColor = System.Drawing.Color.Maroon;
            this.edit_btn.Location = new System.Drawing.Point(776, 251);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(150, 34);
            this.edit_btn.TabIndex = 9;
            this.edit_btn.Text = "Edit ";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.delete_btn.ForeColor = System.Drawing.Color.Maroon;
            this.delete_btn.Location = new System.Drawing.Point(776, 291);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(150, 34);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // ADD_NOTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject_iti.Properties.Resources.pexels_pixabay_301717;
            this.ClientSize = new System.Drawing.Size(1207, 395);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.deletecatg_btn);
            this.Controls.Add(this.note_textbox);
            this.Controls.Add(this.addNote_btn);
            this.Controls.Add(this.category_combobox);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_girdview);
            this.Name = "ADD_NOTE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD_NOTE";
            this.Load += new System.EventHandler(this.ADD_NOTE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.add_girdview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.Button addNote_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox note_textbox;
        private System.Windows.Forms.Button deletecatg_btn;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        public System.Windows.Forms.DataGridView add_girdview;
    }
}