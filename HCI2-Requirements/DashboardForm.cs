using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// sql text to speech
using MySql.Data.MySqlClient;
using System.Speech.Synthesis;


namespace HCI2_Requirements
{
    public partial class DashboardForm : Form
    {
        private readonly SpeechSynthesizer _speaker = new SpeechSynthesizer();
        
        public DashboardForm()
        {
            InitializeComponent();
            _speaker.SpeakAsync("Welcome to the Dashboard. You can add a meal, view meals, " +
                "adjust accessibility settings, log out, or exit the application at the top right corner.");
        }


        private void btnaddmeal_Click(object sender, EventArgs e)
        {
            MealForm mealForm = new MealForm();
            mealForm.ShowDialog();
            this.Hide();
        }

        private void btnaccessibility_Click(object sender, EventArgs e)
        {
            AccessibilitySettingsForm form = new AccessibilitySettingsForm();
            form.ShowDialog();
            this.Hide();
        }

        private void btnviewmeal_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            _speaker.SpeakAsync("Are you sure you want to exit the application?");

            var checker = MessageBox.Show("Are you sure you want to exit?", "Exit Application",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (checker == DialogResult.Yes)
            {
                // Select Yes
                this.Close();
            }
            else
            {
                // Select No
                _speaker.SpeakAsync("Exit cancelled.");
            }
        }

    }
}
