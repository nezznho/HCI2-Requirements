using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI2_Requirements
{
    public partial class AccessibilitySettingsForm : Form
    {
        public static class GlobalSettings
        {
            public static bool TextToSpeechChecker { get; set; } = true; // default true
            public static bool IsDarkModeOn { get; set; } = false; //false
            // Add other settings here (Font, Contrast, Dark Mode, etc.)
        }

        public AccessibilitySettingsForm()
        {
            InitializeComponent();
            texttospeech.Checked = GlobalSettings.TextToSpeechChecker ? true : false;
            darkMode.Checked = GlobalSettings.IsDarkModeOn ? true : false;

            ApplyTheme();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (texttospeech.Checked)
                {
                    GlobalSettings.TextToSpeechChecker = true;
                }
                else
                {
                    GlobalSettings.TextToSpeechChecker = false;
                }
                //FONT
                if (cmbfont == null)
                {
                    // change the font logic
                }
                //CONTRAST MODE
                if (cmbcontrastmode == null)
                {
                    // change the contrast mode logic
                }

                //DARK MODE: store the setting to getset
                GlobalSettings.IsDarkModeOn = darkMode.Checked;
                ApplyTheme();

                if (voiceSwt.Checked)
                {
                    // change the voice logic
                }

                if (readerSwt.Checked)
                {
                    // change the reader logic
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving settings {ex.Message}:", "An Error Occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Settings have been saved successfully.");
        }


        private void ApplyTheme()
        {
            if (GlobalSettings.IsDarkModeOn)
            {
                Color back = Color.FromArgb(0, 0, 0); // dark background
                Color fore = Color.White;                // light text

                // Form colors
                this.BackColor = back;
                this.ForeColor = fore;

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
                        control.BackColor = GlobalSettings.IsDarkModeOn ? Color.FromArgb(0, 0, 0) : SystemColors.Window;
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
                    // Ignore control
                }

                if (control.HasChildren)
                {
                    ApplyThemeToControl(control, back, fore);
                }
            }
        }



    }
}
