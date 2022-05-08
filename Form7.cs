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
    public partial class Form7 : Form
    {
        CachedCrystalReport2 cr2;

        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            cr2 = new CachedCrystalReport2();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = cr2;

        }

          private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }
}
