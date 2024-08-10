
namespace FinalProject_iti
{
    partial class Edit
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
            this.note_textbox = new System.Windows.Forms.RichTextBox();
            this.category_combobox = new System.Windows.Forms.ComboBox();
            this.title_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.new_title_text = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // note_textbox
            // 
            this.note_textbox.BackColor = System.Drawing.Color.FloralWhite;
            this.note_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.note_textbox.ForeColor = System.Drawing.Color.Maroon;
            this.note_textbox.Location = new System.Drawing.Point(126, 111);
            this.note_textbox.Name = "note_textbox";
            this.note_textbox.Size = new System.Drawing.Size(278, 95);
            this.note_textbox.TabIndex = 13;
            this.note_textbox.Text = "";
            this.note_textbox.TextChanged += new System.EventHandler(this.note_textbox_TextChanged);
            // 
            // category_combobox
            // 
            this.category_combobox.BackColor = System.Drawing.Color.FloralWhite;
            this.category_combobox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.category_combobox.ForeColor = System.Drawing.Color.Maroon;
            this.category_combobox.FormattingEnabled = true;
            this.category_combobox.Location = new System.Drawing.Point(126, 222);
            this.category_combobox.Name = "category_combobox";
            this.category_combobox.Size = new System.Drawing.Size(203, 36);
            this.category_combobox.TabIndex = 12;
            // 
            // title_textbox
            // 
            this.title_textbox.BackColor = System.Drawing.Color.FloralWhite;
            this.title_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_textbox.ForeColor = System.Drawing.Color.Maroon;
            this.title_textbox.Location = new System.Drawing.Point(126, 29);
            this.title_textbox.Name = "title_textbox";
            this.title_textbox.Size = new System.Drawing.Size(203, 34);
            this.title_textbox.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(29, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(29, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Note";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Title";
            // 
            // edit_btn
            // 
            this.edit_btn.BackColor = System.Drawing.Color.FloralWhite;
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.edit_btn.ForeColor = System.Drawing.Color.Maroon;
            this.edit_btn.Location = new System.Drawing.Point(139, 282);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(150, 34);
            this.edit_btn.TabIndex = 14;
            this.edit_btn.Text = "Edit ";
            this.edit_btn.UseVisualStyleBackColor = false;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // new_title_text
            // 
            this.new_title_text.BackColor = System.Drawing.Color.FloralWhite;
            this.new_title_text.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.new_title_text.ForeColor = System.Drawing.Color.Maroon;
            this.new_title_text.Location = new System.Drawing.Point(126, 74);
            this.new_title_text.Name = "new_title_text";
            this.new_title_text.Size = new System.Drawing.Size(203, 34);
            this.new_title_text.TabIndex = 16;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label.ForeColor = System.Drawing.Color.Maroon;
            this.label.Location = new System.Drawing.Point(27, 74);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(93, 25);
            this.label.TabIndex = 15;
            this.label.Text = "New Title";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(422, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(508, 284);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject_iti.Properties.Resources.pexels_pixabay_301717;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.new_title_text);
            this.Controls.Add(this.label);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.note_textbox);
            this.Controls.Add(this.category_combobox);
            this.Controls.Add(this.title_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox note_textbox;
        private System.Windows.Forms.ComboBox category_combobox;
        private System.Windows.Forms.TextBox title_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.TextBox new_title_text;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}