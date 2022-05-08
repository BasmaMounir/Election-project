using Election;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Election
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            
        }

        private void selectSymbolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
           
        }

        private void voterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addDeleteModifyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void showTheResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

    
        private void crystal2ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void displaInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void generateVoteReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
