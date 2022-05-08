
namespace Election
{
    partial class Form2
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
            this.button_confirm = new System.Windows.Forms.Button();
            this.Candidate_textBox = new System.Windows.Forms.TextBox();
            this.Candidate_name_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Symbol_comboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Age_textBox = new System.Windows.Forms.TextBox();
            this.Gender_textBox = new System.Windows.Forms.TextBox();
            this.Name_textBox = new System.Windows.Forms.TextBox();
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
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "ToHome";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_confirm
            // 
            this.button_confirm.BackColor = System.Drawing.Color.Azure;
            this.button_confirm.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.button_confirm.ForeColor = System.Drawing.Color.DarkBlue;
            this.button_confirm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_confirm.Location = new System.Drawing.Point(424, 388);
            this.button_confirm.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(135, 46);
            this.button_confirm.TabIndex = 12;
            this.button_confirm.Text = "Save";
            this.button_confirm.UseVisualStyleBackColor = false;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // Candidate_textBox
            // 
            this.Candidate_textBox.AcceptsTab = true;
            this.Candidate_textBox.Location = new System.Drawing.Point(515, 250);
            this.Candidate_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Candidate_textBox.Name = "Candidate_textBox";
            this.Candidate_textBox.ReadOnly = true;
            this.Candidate_textBox.Size = new System.Drawing.Size(365, 22);
            this.Candidate_textBox.TabIndex = 11;
            // 
            // Candidate_name_label
            // 
            this.Candidate_name_label.AutoSize = true;
            this.Candidate_name_label.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.Candidate_name_label.ForeColor = System.Drawing.Color.DarkBlue;
            this.Candidate_name_label.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Candidate_name_label.Location = new System.Drawing.Point(253, 251);
            this.Candidate_name_label.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.Candidate_name_label.Name = "Candidate_name_label";
            this.Candidate_name_label.Size = new System.Drawing.Size(168, 24);
            this.Candidate_name_label.TabIndex = 9;
            this.Candidate_name_label.Text = "Candidate name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(237, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Candidate  Symbol";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(315, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = " Name";
            // 
            // Symbol_comboBox
            // 
            this.Symbol_comboBox.FormattingEnabled = true;
            this.Symbol_comboBox.Location = new System.Drawing.Point(515, 304);
            this.Symbol_comboBox.Margin = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.Symbol_comboBox.Name = "Symbol_comboBox";
            this.Symbol_comboBox.Size = new System.Drawing.Size(365, 24);
            this.Symbol_comboBox.TabIndex = 14;
            this.Symbol_comboBox.SelectedIndexChanged += new System.EventHandler(this.Symbol_comboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(317, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = " Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 13F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkBlue;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(299, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 16;
            this.label4.Text = " Gender";
            // 
            // Age_textBox
            // 
            this.Age_textBox.Location = new System.Drawing.Point(515, 118);
            this.Age_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Age_textBox.Name = "Age_textBox";
            this.Age_textBox.Size = new System.Drawing.Size(365, 22);
            this.Age_textBox.TabIndex = 17;
            this.Age_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_textBox_KeyPress);
            // 
            // Gender_textBox
            // 
            this.Gender_textBox.Location = new System.Drawing.Point(515, 187);
            this.Gender_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Gender_textBox.Name = "Gender_textBox";
            this.Gender_textBox.Size = new System.Drawing.Size(365, 22);
            this.Gender_textBox.TabIndex = 18;
            this.Gender_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gender_textBox_KeyPress);
            // 
            // Name_textBox
            // 
            this.Name_textBox.Location = new System.Drawing.Point(515, 63);
            this.Name_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Name_textBox.Name = "Name_textBox";
            this.Name_textBox.Size = new System.Drawing.Size(365, 22);
            this.Name_textBox.TabIndex = 19;
            this.Name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Name_textBox_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1069, 475);
            this.Controls.Add(this.Name_textBox);
            this.Controls.Add(this.Gender_textBox);
            this.Controls.Add(this.Age_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Symbol_comboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.Candidate_textBox);
            this.Controls.Add(this.Candidate_name_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "ODP.Net ConnectedMode1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox Candidate_textBox;
        private System.Windows.Forms.Label Candidate_name_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Symbol_comboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Age_textBox;
        private System.Windows.Forms.TextBox Gender_textBox;
        private System.Windows.Forms.TextBox Name_textBox;
    }
}