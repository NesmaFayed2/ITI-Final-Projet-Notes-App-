
namespace FinalProject_iti
{
    partial class HOME
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
            this.button2 = new System.Windows.Forms.Button();
            this.view_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(205, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add New note + ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // view_btn
            // 
            this.view_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.view_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.view_btn.Font = new System.Drawing.Font("Segoe UI", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.view_btn.ForeColor = System.Drawing.Color.SaddleBrown;
            this.view_btn.Location = new System.Drawing.Point(276, 248);
            this.view_btn.Name = "view_btn";
            this.view_btn.Size = new System.Drawing.Size(208, 58);
            this.view_btn.TabIndex = 2;
            this.view_btn.Text = "View All Notes";
            this.view_btn.UseVisualStyleBackColor = false;
            this.view_btn.Click += new System.EventHandler(this.view_btn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(-8, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(974, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO YOUR NOTES !";
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImage = global::FinalProject_iti.Properties.Resources.WhatsApp_Image_2022_09_24_at_11_36_02_PM;
            this.ClientSize = new System.Drawing.Size(1114, 615);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.view_btn);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button view_btn;
        private System.Windows.Forms.Label label1;
    }
}