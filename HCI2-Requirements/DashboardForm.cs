using System;
//Mod
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace HCI2_Requirements
{
    public partial class DashboardForm : Form
    {
        private readonly SpeechSynthesizer _speaker = new SpeechSynthesizer();

        public DashboardForm()
        {
            InitializeComponent();
            _speaker.SpeakAsync("Welcome to Dashboard, Please Select what action you like.");
        }


        private void btnaddmeal_Click(object sender, EventArgs e)
        {
            MealForm mealForm = new MealForm();
            mealForm.ShowDialog();
            this.Hide();
        }

        private void btnaccessibility_Click(object sender, EventArgs e)
        {
            //this.btnaccessibility.Text = "Loading Accessibility Settings";

            AccessibilitySettingsForm form = new AccessibilitySettingsForm();
            form.ShowDialog();
            this.Hide();
        }

        private void btnviewmeal_Click(object sender, EventArgs e)
        {
            // Action

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            _speaker.SpeakAsync("You're about to Logout Select Yes or No");
            var confirm = MessageBox.Show("Are you sure you want to Logout", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Form1 form = new Form1();
                form.Show();
                this.Close();
                return;
            }
            else
            {
                _speaker.SpeakAsync("Logout Cancelled");
                return;
            }
        }

    }
}
