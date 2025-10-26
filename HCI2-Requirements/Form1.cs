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
        public Form1()
        {
            InitializeComponent();
        }

        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();

        private void ReadMealPlanButton_Click(object sender, EventArgs e)
        {
            string mealPlanText; // Get the text from the control
            synthesizer.SpeakAsync(mealPlanText); // Speak the text asynchronously
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
    }
}


