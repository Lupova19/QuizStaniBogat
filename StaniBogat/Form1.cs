using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat
{
    public partial class Form1 : Form
    {
        SqlDataReader reader;
        SqlCommand command;


        public Form1()
        {
            InitializeComponent();
        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }

        private void ResetScreen()
        {
            btnAnsA.BackColor = Color.Blue;
            btnAnsB.BackColor = Color.Blue;
            btnAnsC.BackColor = Color.Blue;
            btnAnsD.BackColor = Color.Blue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = Stani_Bogat_11d_2025; Integrated Security = True
            string connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Stani_Bogat_11d_2025; Integrated Security = True";
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            MessageBox.Show("Connect now opened!");
            command = connect.CreateCommand();
            command.CommandText = "Select * From Questions";
            reader = command.ExecuteReader();
            LoadRecordOnScreen();
        }

        private void LoadRecordOnScreen()
        {
            if (!reader.Read())
            {
                MessageBox.Show("Game over!");
                //scenarij pri kraj na igrata!!!
                return;
            }
            lblQuestion.Text = reader[1].ToString();
            btnAnsA.Text = reader[2].ToString();
            btnAnsB.Text = reader[3].ToString();
            btnAnsC.Text = reader[4].ToString();
            btnAnsD.Text = reader[5].ToString();
        }

        private void btnAnsA_Click(object sender, EventArgs e)
        {
            AnswersButtons(btnAnsA);
        }

        private void btnAnsB_Click(object sender, EventArgs e)
        {
            AnswersButtons(btnAnsB);
        }

        private void btnAnsC_Click(object sender, EventArgs e)
        {
            AnswersButtons(btnAnsC);
        }

        private void btnAnsD_Click(object sender, EventArgs e)
        {
            AnswersButtons(btnAnsD);
        }
        private void ClearScreen()
        {
            btnAnsA.BackColor = Color.Blue;
            btnAnsB.BackColor = Color.Blue;
            btnAnsC.BackColor = Color.Blue;
            btnAnsD.BackColor = Color.Blue;
        }
        public void AnswersButtons(Button btn)
        {
            ResetScreen();
            if (btn.Text == reader[6].ToString())
            {
                btn.BackColor = Color.Green;
                MessageBox.Show($"You won {(int)reader[7]} points.");
                ClearScreen();
                LoadRecordOnScreen();
            }
            else
            {
                btn.BackColor = Color.Red;
                MessageBox.Show($"ERROR");
                DialogResult ans = MessageBox.Show("Are you gonna continue", "", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
                if (ans == DialogResult.Yes)
                {
                    reader.Close();
                    reader = command.ExecuteReader();
                    ClearScreen();
                    LoadRecordOnScreen();
                }
                else
                {
                    reader.Close();
                }
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PulneneNaVaprosi questions = new PulneneNaVaprosi();
            questions.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
