
namespace Election
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDeleteModifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTheResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crystal2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSymbolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displaInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateVoteReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.candidateToolStripMenuItem,
            this.voterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1121, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDeleteModifyToolStripMenuItem,
            this.generateVoteReportToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(112, 24);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // addDeleteModifyToolStripMenuItem
            // 
            this.addDeleteModifyToolStripMenuItem.Name = "addDeleteModifyToolStripMenuItem";
            this.addDeleteModifyToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.addDeleteModifyToolStripMenuItem.Text = "Add/Delete/Modify Candidate";
            this.addDeleteModifyToolStripMenuItem.Click += new System.EventHandler(this.addDeleteModifyToolStripMenuItem_Click);
            // 
            // candidateToolStripMenuItem
            // 
            this.candidateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTheResultToolStripMenuItem,
            this.crystal2ToolStripMenuItem});
            this.candidateToolStripMenuItem.Name = "candidateToolStripMenuItem";
            this.candidateToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.candidateToolStripMenuItem.Text = "Candidate";
            // 
            // showTheResultToolStripMenuItem
            // 
            this.showTheResultToolStripMenuItem.Name = "showTheResultToolStripMenuItem";
            this.showTheResultToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.showTheResultToolStripMenuItem.Text = "Show The Result";
            this.showTheResultToolStripMenuItem.Click += new System.EventHandler(this.showTheResultToolStripMenuItem_Click);
            // 
            // crystal2ToolStripMenuItem
            // 
            this.crystal2ToolStripMenuItem.Name = "crystal2ToolStripMenuItem";
            this.crystal2ToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.crystal2ToolStripMenuItem.Text = "Display info";
            this.crystal2ToolStripMenuItem.Click += new System.EventHandler(this.crystal2ToolStripMenuItem_Click);
            // 
            // voterToolStripMenuItem
            // 
            this.voterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSymbolToolStripMenuItem,
            this.displaInfoToolStripMenuItem});
            this.voterToolStripMenuItem.Name = "voterToolStripMenuItem";
            this.voterToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.voterToolStripMenuItem.Text = "Voter";
            this.voterToolStripMenuItem.Click += new System.EventHandler(this.voterToolStripMenuItem_Click);
            // 
            // selectSymbolToolStripMenuItem
            // 
            this.selectSymbolToolStripMenuItem.Name = "selectSymbolToolStripMenuItem";
            this.selectSymbolToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.selectSymbolToolStripMenuItem.Text = "Select Symbol";
            this.selectSymbolToolStripMenuItem.Click += new System.EventHandler(this.selectSymbolToolStripMenuItem_Click);
            // 
            // displaInfoToolStripMenuItem
            // 
            this.displaInfoToolStripMenuItem.Name = "displaInfoToolStripMenuItem";
            this.displaInfoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.displaInfoToolStripMenuItem.Text = "Displa info";
            this.displaInfoToolStripMenuItem.Click += new System.EventHandler(this.displaInfoToolStripMenuItem_Click);
            // 
            // generateVoteReportToolStripMenuItem
            // 
            this.generateVoteReportToolStripMenuItem.Name = "generateVoteReportToolStripMenuItem";
            this.generateVoteReportToolStripMenuItem.Size = new System.Drawing.Size(287, 26);
            this.generateVoteReportToolStripMenuItem.Text = "Generate vote report";
            this.generateVoteReportToolStripMenuItem.Click += new System.EventHandler(this.generateVoteReportToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1121, 593);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSymbolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDeleteModifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTheResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crystal2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displaInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateVoteReportToolStripMenuItem;
    }
}

