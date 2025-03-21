using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaniBogat
{
    public partial class PulneneNaVaprosi : Form
    {
        public PulneneNaVaprosi()
        {
            InitializeComponent();
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
    }
}
