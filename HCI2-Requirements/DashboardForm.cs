using System;
using System.Drawing;

//Mod
using System.Speech.Synthesis;
using System.Windows.Forms;
using static HCI2_Requirements.AccessibilitySettingsForm;

namespace HCI2_Requirements
{
    public partial class DashboardForm : Form
    {
        private SpeechSynthesizer _speaker = new SpeechSynthesizer();

        // Accessibility 
        private void SpeakIfOn(string message)
        {
            // Check the global setting before speaking
            if (GlobalSettings.TextToSpeechChecker)
            {
                // Use SpeakAsync to ensure the application doesn't freeze
                _speaker.SpeakAsync(message);
            }
        }

        private void ApplyTheme()
        {
            if (GlobalSettings.IsDarkModeOn)
            {
                Color back = Color.FromArgb(34, 34, 34); // dark background
                Color fore = Color.White;                // light text

                // Form colors
                this.BackColor = back;
                this.ForeColor = fore;

                // Apply recursively to all child controls
                ApplyThemeToControl(this, back, fore);
            }
            else
            {
                Color back = SystemColors.Control;
                Color fore = SystemColors.ControlText;

                this.BackColor = back;
                this.ForeColor = fore;

                ApplyThemeToControl(this, back, fore);
            }
        }

        private void ApplyThemeToControl(Control parent, Color back, Color fore)
        {
            foreach (Control control in parent.Controls)
            {
                try
                {
                    control.BackColor = back;
                    control.ForeColor = fore;

                    if (control is TextBox || control is RichTextBox)
                    {
                        control.BackColor = GlobalSettings.IsDarkModeOn ? Color.FromArgb(30, 30, 30) : SystemColors.Window;
                        control.ForeColor = fore;
                    }
                    else if (control is DataGridView dgv)
                    {
                        dgv.BackgroundColor = back;
                        dgv.DefaultCellStyle.BackColor = back;
                        dgv.DefaultCellStyle.ForeColor = fore;
                        dgv.ColumnHeadersDefaultCellStyle.BackColor = back;
                        dgv.ColumnHeadersDefaultCellStyle.ForeColor = fore;
                        dgv.RowHeadersDefaultCellStyle.BackColor = back;
                        dgv.RowHeadersDefaultCellStyle.ForeColor = fore;
                    }
                }
                catch
                {
                    // Ignore controls that can't accept these color changes
                }

                // Recurse into children
                if (control.HasChildren)
                {
                    ApplyThemeToControl(control, back, fore);
                }
            }
        }

        // End Accessibility
        public DashboardForm()
        {
            InitializeComponent();
            if (GlobalSettings.IsDarkModeOn)
            {
                ApplyTheme();
            }

            SpeakIfOn("Welcome to Dashboard");
        }


        private void btnaddmeal_Click(object sender, EventArgs e)
        {
            MealForm mealForm = new MealForm();
            mealForm.ShowDialog();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            SpeakIfOn("You're about to Exit");
            var message = MessageBox.Show("Are you sure you want to Exit?", "About to Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (message == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }


        private void btnaccessibility_Click(object sender, EventArgs e)
        {
            //this.btnaccessibility.Text = "Loading Accessibility Settings";

            AccessibilitySettingsForm form = new AccessibilitySettingsForm();
            form.ShowDialog();
        }


        private void btnlogout_Click(object sender, EventArgs e)
        {
            SpeakIfOn("You're about to Logout?");
            var confirm = MessageBox.Show("Are you sure you want to Logout", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Form1 form = new Form1();
                this.Hide();
                form.ShowDialog();
                this.Close();
            }
            else
            {
                SpeakIfOn("Logout Cancelled");
                return;
            }
            Form1 login = new Form1();
            login.Show();
            this.Close();
        }
        // need Lipat sa ibang class
        private void addtoList_Click(object sender, EventArgs e)
        {
            CheckBox newCheckBox = new CheckBox();
            TextBox newTextBox = new TextBox();

            newCheckBox.Text = "";
            newCheckBox.AutoSize = true;

            newTextBox.Text = "";
            newTextBox.Width = guna2Panel4.Width - 50;

            int verticalOffset = 5;
            int nextYPosition = 0;

            if (guna2Panel4.Controls.Count > 0)
            {
                // add sa ilalim 
                Control lastControl = guna2Panel4.Controls[guna2Panel4.Controls.Count - 1];
                nextYPosition = lastControl.Bottom + verticalOffset;
            }

            newCheckBox.Location = new System.Drawing.Point(5, nextYPosition);
            newTextBox.Location = new System.Drawing.Point(30, nextYPosition);

            guna2Panel4.Controls.Add(newCheckBox);
            guna2Panel4.Controls.Add(newTextBox);

            //pang scroll pag madami na
            guna2Panel4.ScrollControlIntoView(newTextBox);
        }

        // need Lipat sa ibang class
        private void removeBtn_Click(object sender, EventArgs e)
        {
            for (int i = guna2Panel4.Controls.Count - 1; i >= 0; i--)
            {
                Control currentControl = guna2Panel4.Controls[i];

                if (currentControl is CheckBox checkBox)
                {
                    if (checkBox.Checked)
                    {
                        if (i + 1 < guna2Panel4.Controls.Count && guna2Panel4.Controls[i + 1] is TextBox)
                        {
                            Control associatedTextBox = guna2Panel4.Controls[i + 1];
                            // Remove the CheckBox
                            guna2Panel4.Controls.Remove(checkBox);
                            guna2Panel4.Controls.Remove(associatedTextBox);
                        }
                        else if (i - 1 >= 0 && guna2Panel4  .Controls[i - 1] is TextBox)
                        {
                            if (i + 1 <     guna2Panel4.Controls.Count)
                            {
                                guna2Panel4.Controls.Remove(guna2Panel4.Controls[i + 1]);
                            }
                            guna2Panel4.Controls.Remove(checkBox);
                        }
                    }
                }
            }
            RepositionControls();
        }


        // need Lipat sa ibang class
        private void RepositionControls()
        {
            int verticalOffset = 7;
            int currentYPosition = 10;

            for (int i = 0; i < guna2Panel4.Controls.Count; i++)
            {
                Control currentControl = guna2Panel4.Controls[i];
                if (currentControl is CheckBox checkBox)
                {
                    checkBox.Location = new System.Drawing.Point(5, currentYPosition);

                    if (i + 1 < guna2Panel4.Controls.Count && guna2Panel4.Controls[i + 1] is TextBox textBox)
                    {
                        textBox.Location = new System.Drawing.Point(0, currentYPosition);
                        currentYPosition = checkBox.Bottom + verticalOffset;
                    }
                }
            }
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            addingUser add = new addingUser();
            add.ShowDialog();
        }

        private void viewmealBtn_Click_1(object sender, EventArgs e)
        {
            // Action
            viewMeal view = new viewMeal();
            view.ShowDialog();
        }

        private void btnlogout_MouseHover(object sender, EventArgs e)
        {
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
