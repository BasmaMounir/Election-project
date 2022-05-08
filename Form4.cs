using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Election
{
    public partial class Form4 : Form
    {
        
        OracleDataAdapter adapter1;
        OracleCommandBuilder builder1;
        DataSet ds1;
        public Form4()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f111 = new Form1();
            f111.ShowDialog();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            String constr = "Data source=orcl ;User Id=scott; Password=SCOTT;";
            String cmdstr = "";
            if(!(radioButton1.Checked) && !(radioButton2.Checked) && !(radioButton3.Checked))
            {
                MessageBox.Show(" Please choose Voter OR Candidate ");
            }
            else if(radioButton1.Checked)
            {
                cmdstr = "Select * from VOTERS";
            }
            else if(radioButton2.Checked)
            {
               cmdstr = "Select * from CANDIDATES ";
            }
            else if (radioButton3.Checked)
            {
                cmdstr = @"Select CANDIDATE_SYMBOL As Candidate_Symbol, candidate_name As Candidate_Name, candidate_age as Candidate_Age,count(voteforsymbol) As Number_Of_Voters
                           from CANDIDATES , voters
                           WHERE voteforsymbol = candidate_symbol
                           GROUP by CANDIDATE_SYMBOL , candidate_name, candidate_age ";
            }
            adapter1 = new OracleDataAdapter(cmdstr, constr);
            ds1 = new DataSet();
            adapter1.Fill(ds1);
            dataGridView1.DataSource = ds1.Tables[0];          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            builder1 = new OracleCommandBuilder(adapter1);
            adapter1.Update(ds1.Tables[0]);
            MessageBox.Show(" Update is Saved ");
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
