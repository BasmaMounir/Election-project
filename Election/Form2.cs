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
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=scott; Password=SCOTT;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Select CANDIDATE_SYMBOL From CANDIDATES";
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Symbol_comboBox.Items.Add(dr[0]);
            }
            dr.Close();
        }
        private void Symbol_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Select CANDIDATE_NAME From CANDIDATES where CANDIDATE_SYMBOL=:symbol";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("symbol", Symbol_comboBox.SelectedItem);
            OracleDataReader dr1 = c.ExecuteReader();
            if (dr1.Read())
            {
                Candidate_textBox.Text = dr1[0].ToString();
            }
            dr1.Close();
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Name_textBox.Text) || string.IsNullOrWhiteSpace(Age_textBox.Text) ||
                string.IsNullOrWhiteSpace(Gender_textBox.Text) || string.IsNullOrWhiteSpace(Symbol_comboBox.Text))
            {
                MessageBox.Show(" Please fill All the TextBox ");
            }
            else
            { 
                OracleCommand c2 = new OracleCommand();
                c2.Connection = conn;
                c2.CommandText = "insert into VOTERS values(voter_id.nextval,:name,:age,:gender,:symbol)";
                c2.CommandType = CommandType.Text;
                c2.Parameters.Add("name", Name_textBox.Text);
                c2.Parameters.Add("age", Convert.ToInt32(Age_textBox.Text));
                c2.Parameters.Add("gender", Gender_textBox.Text.ToString());
                c2.Parameters.Add("symbol", Convert.ToInt32(Symbol_comboBox.Text));
                int check = c2.ExecuteNonQuery();
                if (check != -1)
                {
                    MessageBox.Show(" Thank You to Vote ");
                }
                else
                {
                    MessageBox.Show(" Please Try again ");
                }
            }
        }
        private void Age_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void Name_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        private void Gender_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
