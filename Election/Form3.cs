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
    public partial class Form3 : Form
    {
        string ordb = "Data source=orcl ;User Id=scott; Password=SCOTT;";
        OracleConnection conn;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f11 = new Form1();
            f11.ShowDialog();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
        private void Display_button_Click_1(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "SYMBOL_NUM";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("num", OracleDbType.Int32, ParameterDirection.Output);
            c2.ExecuteNonQuery();
            Voting_number_textBox.Text = c2.Parameters["num"].Value.ToString();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DISPLAY_CANDIDATE";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("candt", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Candidates_combo.Items.Add(dr[0]);
            }
            dr.Close();
        }
        private void Candidates_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Select CANDIDATE_NAME From CANDIDATES where CANDIDATE_SYMBOL=:symbol";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("symbol", Candidates_combo.SelectedItem);
            OracleDataReader dr1 = c.ExecuteReader();
            if (dr1.Read())
            {
                Candt_name_textBox.Text = dr1[0].ToString();
            }
            dr1.Close();
        }
        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(New_candt_nametextBox.Text) ||
                string.IsNullOrWhiteSpace(New_candt_agetextBox.Text))
            {
                MessageBox.Show(" Please fill All the TextBox ");
            }
            else 
            {
                if(Convert.ToInt32(New_candt_agetextBox.Text) < 29)
                {
                    MessageBox.Show(" Please Candidate age MUST be greter than 29 ");
                }
                
                else
                {
                    OracleCommand c3 = new OracleCommand();
                    c3.Connection = conn;
                    c3.CommandText = "insert into Candidates values(Candidate_Symbol.nextval,:name,:age)";
                    c3.CommandType = CommandType.Text;
                    c3.Parameters.Add("name", Convert.ToString(New_candt_nametextBox.Text));
                    c3.Parameters.Add("age", Convert.ToInt32(New_candt_agetextBox.Text));
                    int check = c3.ExecuteNonQuery();
                    if (check != -1)
                    {
                        MessageBox.Show(" A New Candidate is Add succsecfully ");
                    }
                    else
                    {
                        MessageBox.Show(" Please Try again ");
                    }
                }
            }
        }
        private void New_candt_agetextBox_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
