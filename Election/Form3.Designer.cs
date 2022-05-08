
namespace Election
{
    partial class Form3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Candidates_combo = new System.Windows.Forms.ComboBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.Display_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Candt_name_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.New_candt_nametextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.New_candt_agetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Voting_number_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Azure;
            this.button1.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "ToHome";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(135, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Candidates";
            // 
            // Candidates_combo
            // 
            this.Candidates_combo.FormattingEnabled = true;
            this.Candidates_combo.Location = new System.Drawing.Point(411, 114);
            this.Candidates_combo.Margin = new System.Windows.Forms.Padding(4);
            this.Candidates_combo.Name = "Candidates_combo";
            this.Candidates_combo.Size = new System.Drawing.Size(255, 24);
            this.Candidates_combo.TabIndex = 15;
            this.Candidates_combo.SelectedIndexChanged += new System.EventHandler(this.Candidates_combo_SelectedIndexChanged);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Azure;
            this.button_confirm.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.button_confirm.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_confirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_confirm.Location = new System.Drawing.Point(709, 309);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(147, 44);
            this.button_confirm.TabIndex = 16;
            this.button_confirm.Text = "Save";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // Display_button
            // 
            this.Display_button.BackColor = System.Drawing.Color.Azure;
            this.Display_button.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.Display_button.ForeColor = System.Drawing.Color.DarkBlue;
            this.Display_button.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Display_button.Location = new System.Drawing.Point(723, 102);
            this.Display_button.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Display_button.Name = "Display_button";
            this.Display_button.Size = new System.Drawing.Size(147, 47);
            this.Display_button.TabIndex = 17;
            this.Display_button.Text = "Display";
            this.Display_button.UseVisualStyleBackColor = false;
            this.Display_button.Click += new System.EventHandler(this.Display_button_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(112, 164);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "Candidates name";
            // 
            // Candt_name_textBox
            // 
            this.Candt_name_textBox.Location = new System.Drawing.Point(411, 164);
            this.Candt_name_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Candt_name_textBox.Name = "Candt_name_textBox";
            this.Candt_name_textBox.ReadOnly = true;
            this.Candt_name_textBox.Size = new System.Drawing.Size(255, 22);
            this.Candt_name_textBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(73, 293);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "New Candidate\'s name";
            // 
            // New_candt_nametextBox
            // 
            this.New_candt_nametextBox.Location = new System.Drawing.Point(411, 293);
            this.New_candt_nametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.New_candt_nametextBox.Name = "New_candt_nametextBox";
            this.New_candt_nametextBox.Size = new System.Drawing.Size(255, 22);
            this.New_candt_nametextBox.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(73, 343);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "New Candidate\'s age";
            // 
            // New_candt_agetextBox
            // 
            this.New_candt_agetextBox.Location = new System.Drawing.Point(411, 342);
            this.New_candt_agetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.New_candt_agetextBox.Name = "New_candt_agetextBox";
            this.New_candt_agetextBox.Size = new System.Drawing.Size(255, 22);
            this.New_candt_agetextBox.TabIndex = 25;
            this.New_candt_agetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.New_candt_agetextBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.DarkBlue;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(49, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 24);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total number of Candidates";
            // 
            // Voting_number_textBox
            // 
            this.Voting_number_textBox.Location = new System.Drawing.Point(411, 76);
            this.Voting_number_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Voting_number_textBox.Name = "Voting_number_textBox";
            this.Voting_number_textBox.ReadOnly = true;
            this.Voting_number_textBox.Size = new System.Drawing.Size(255, 22);
            this.Voting_number_textBox.TabIndex = 27;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1069, 475);
            this.Controls.Add(this.Voting_number_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.New_candt_agetextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.New_candt_nametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Candt_name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Display_button);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.Candidates_combo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.Indigo;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "ODP.Net ConnectedMode2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Candidates_combo;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button Display_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Candt_name_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox New_candt_nametextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox New_candt_agetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Voting_number_textBox;
    }
}