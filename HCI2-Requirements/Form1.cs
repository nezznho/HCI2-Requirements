using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
//TTS
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HCI2_Requirements.AccessibilitySettingsForm;

namespace HCI2_Requirements
{
    public partial class Form1 : Form
    {
        private readonly LoginService _loginService = new LoginService();
        private SpeechSynthesizer _speaker = new SpeechSynthesizer();

        private void SpeakIfOn(string message)
        {
            // Check the global setting before speaking
            if (GlobalSettings.TextToSpeechChecker)
            {
                // Use SpeakAsync to ensure the application doesn't freeze
                _speaker.SpeakAsync(message);
            }
        }

        public Form1()
        {
            InitializeComponent();
            SpeakIfOn("Welcome to Accessible Meal Planner. Please log in.");
        }

        private void ReadMealPlanButton_Click(object sender, EventArgs e)
        {/*
            string mealPlanText; // Get the text from the control
            synthesizer.SpeakAsync(mealPlanText); // Speak the text asynchronously
        */
        }

        private SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine();

        public void SetupVoiceInput()
        {
            // Create a grammar for simple commands
            var choices = new Choices(new string[] { "add breakfast", "oatmeal", "schedule meal" });
            var grammar = new Grammar(new GrammarBuilder(choices));

            recognizer.LoadGrammar(grammar);
            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string command = e.Result.Text.ToLower();

            if (command.Contains("add breakfast"))
            {
                // Logic to open the meal creation dialog
                MessageBox.Show("Voice command recognized: Opening Add Breakfast window.");
            }
        }

      

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                userr user = new userr(username, password);

                bool isAuthenticated = _loginService.AuthenticateUser(user.Username, user.Password);

                if (isAuthenticated)
                {
                    SpeakIfOn("Login successful");
                    MessageBox.Show("Login Successful!", "Access Granted",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DashboardForm dash = new DashboardForm();
                    dash.ShowDialog();
                    this.Close();
                }
                else
                {
                    SpeakIfOn("Invalid username or password. Please try again.");
                    MessageBox.Show("Invalid Username or Password!",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException mySqlEx)
            {
                var errB = MessageBox.Show("A database error occurred: " + mySqlEx.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SpeakIfOn("A connection error occurred. Please try again later.");
            }
            catch (Exception ex)
            {
                var errA = MessageBox.Show("An error occurred during login: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SpeakIfOn("An error occurred during login. Please try again.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            SpeakIfOn("Are you sure you want to exit?, Select Yes or No.");
            var response = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                SpeakIfOn("Exit cancelled. Returning to the application Please Login");

            }
        }


        private void Form1_FormClosing(object sender, EventArgs e)
        {
            _speaker.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}


