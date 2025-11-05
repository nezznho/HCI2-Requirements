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

namespace HCI2_Requirements
{
    public partial class Form1 : Form
    {
        private readonly LoginService _loginService = new LoginService();
        private readonly SpeechSynthesizer _speaker = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
            _speaker.SpeakAsync("Welcome to Accessible Meal Planner. Please log in.");
        }

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();

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

        private void button2_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.Show();
            this.Hide();
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
                    _speaker.SpeakAsync("Login successful. Welcome, " + user.Username);
                    MessageBox.Show("Login Successful!", "Access Granted",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DashboardForm dash = new DashboardForm();
                    dash.ShowDialog();
                    this.Hide();
                }
                else
                {
                    _speaker.SpeakAsync("Invalid username or password. Please try again.");
                    MessageBox.Show("Invalid Username or Password!",
                                    "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (MySqlException mySqlEx)
            {
                var errB = MessageBox.Show("A database error occurred: " + mySqlEx.Message,
                                "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _speaker.SpeakAsync("A database error occurred. Please try again later.");
            }
            catch (Exception ex)
            {
                var errA = MessageBox.Show("An error occurred during login: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _speaker.SpeakAsync("An error occurred during login. Please try again.");
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            _speaker.SpeakAsync("Are you sure you want to exit?, Select Yes or No.");
            var response = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (response == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                _speaker.SpeakAsync("Exit cancelled. Returning to the application Please Login");

            }
        }

    }
}


