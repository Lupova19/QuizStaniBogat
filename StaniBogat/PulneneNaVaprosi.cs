using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat
{
    public partial class PulneneNaVaprosi : Form
    {
        string connectionString = "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=Stani_Bogat_11d_2025; Integrated Security=True";
        SqlConnection connect;
        public PulneneNaVaprosi()
        {
            InitializeComponent();
            connect = new SqlConnection(connectionString);
        }

        private void PulneneNaVaprosi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stani_Bogat_11d_2025DataSet.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.stani_Bogat_11d_2025DataSet.Questions);

        }

        private void PulneneNaVaprosi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                connect.Open();
                string sql = "INSERT INTO Questions (Question, AnsA, AnsB, AnsC, AnsD, CorrectAns, Points) " +
                             "VALUES (@question, @ansA, @ansB, @ansC, @ansD, @correctAns, @points)";

                using (SqlCommand cmd = new SqlCommand(sql, connect))
                {
                    cmd.Parameters.AddWithValue("@question", questionTextBox.Text);
                    cmd.Parameters.AddWithValue("@ansA", ansATextBox.Text);
                    cmd.Parameters.AddWithValue("@ansB", ansBTextBox.Text);
                    cmd.Parameters.AddWithValue("@ansC", ansCTextBox.Text);
                    cmd.Parameters.AddWithValue("@ansD", ansDTextBox.Text);
                    cmd.Parameters.AddWithValue("@correctAns", correctAnswerTextBox.Text);
                    cmd.Parameters.AddWithValue("@points", int.Parse(pointsTextBox.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The question has been added!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (questionTextBox.Text != "" && ansATextBox.Text != "" && ansBTextBox.Text != "" &&
                ansCTextBox.Text != "" && ansDTextBox.Text != "" && correctAnswerTextBox.Text != "")
            {
                string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=Stani_Bogat_11d_2025; Integrated Security=true";
                SqlConnection connect = new SqlConnection(connectionString);

                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string sql = "UPDATE Questions " +
                             "SET Question = @question, AnsA = @ans1, AnsB = @ans2, AnsC = @ans3, AnsD = @ans4, " +
                             "CorrectAns = @ansCorrect, Points = @points " +
                             "WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, connect);

                cmd.Parameters.AddWithValue("@question", questionTextBox.Text);
                cmd.Parameters.AddWithValue("@ans1", ansATextBox.Text);
                cmd.Parameters.AddWithValue("@ans2", ansBTextBox.Text);
                cmd.Parameters.AddWithValue("@ans3", ansCTextBox.Text);
                cmd.Parameters.AddWithValue("@ans4", ansDTextBox.Text);
                cmd.Parameters.AddWithValue("@ansCorrect", correctAnswerTextBox.Text);
                cmd.Parameters.AddWithValue("@points", int.Parse(pointsTextBox.Text));
                cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));

                int updatedRows = cmd.ExecuteNonQuery();
                if (updatedRows> 0)
                {
                    MessageBox.Show("The question is updated!");
                }
                else
                {
                    MessageBox.Show("The question is not found!");
                }

                connect.Close();
            }
            else
            {
                MessageBox.Show("Please enter information in all fields! ");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=(localdb)\MSSQLLocalDB; Database=Stani_Bogat_11d_2025; Integrated Security=true";
            SqlConnection connect = new SqlConnection(connectionString);

            if (connect.State == ConnectionState.Closed)
                connect.Open();

            string sql = "DELETE FROM Questions WHERE id = @id";
            SqlCommand cmd = new SqlCommand(sql, connect);

            cmd.Parameters.AddWithValue("@id", int.Parse(idTextBox.Text));

            int deletedRows = cmd.ExecuteNonQuery();
            if (deletedRows > 0)
            {
                MessageBox.Show("The question is deleted!!");
            }
            else
            {
                MessageBox.Show("There is no question like this!");
            }

            connect.Close();
        }

        private void pointsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
