namespace HCI2_Requirements
{
    partial class AccessibilitySettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.texttospeech = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.cmbfont = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbcontrastmode = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsave = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.darkMode = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.voiceSwt = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.readerSwt = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accessibility Settings";
            // 
            // texttospeech
            // 
            this.texttospeech.Checked = true;
            this.texttospeech.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texttospeech.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.texttospeech.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.texttospeech.CheckedState.InnerColor = System.Drawing.Color.White;
            this.texttospeech.Location = new System.Drawing.Point(243, 124);
            this.texttospeech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texttospeech.Name = "texttospeech";
            this.texttospeech.Size = new System.Drawing.Size(55, 30);
            this.texttospeech.TabIndex = 0;
            this.texttospeech.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.texttospeech.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.texttospeech.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.texttospeech.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // cmbfont
            // 
            this.cmbfont.BackColor = System.Drawing.Color.Transparent;
            this.cmbfont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbfont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfont.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbfont.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbfont.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbfont.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbfont.ItemHeight = 30;
            this.cmbfont.Location = new System.Drawing.Point(243, 175);
            this.cmbfont.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbfont.Name = "cmbfont";
            this.cmbfont.Size = new System.Drawing.Size(178, 36);
            this.cmbfont.TabIndex = 1;
            // 
            // cmbcontrastmode
            // 
            this.cmbcontrastmode.BackColor = System.Drawing.Color.Transparent;
            this.cmbcontrastmode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbcontrastmode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcontrastmode.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcontrastmode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbcontrastmode.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcontrastmode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbcontrastmode.ItemHeight = 30;
            this.cmbcontrastmode.Location = new System.Drawing.Point(243, 229);
            this.cmbcontrastmode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbcontrastmode.Name = "cmbcontrastmode";
            this.cmbcontrastmode.Size = new System.Drawing.Size(178, 36);
            this.cmbcontrastmode.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Screen Reader:";
            // 
            // guna2Button1
            // 
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(242, 456);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(187, 44);
            this.guna2Button1.TabIndex = 13;
            this.guna2Button1.Text = "Cancel";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Voice Command:";
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(42, 456);
            this.btnsave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(187, 44);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "Save";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Contrast Mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 28);
            this.label3.TabIndex = 14;
            this.label3.Text = "Font:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "Text-to-speech:";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(117)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 100);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 28);
            this.label7.TabIndex = 15;
            this.label7.Text = "Dark Mode:";
            // 
            // darkMode
            // 
            this.darkMode.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.darkMode.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.darkMode.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.darkMode.CheckedState.InnerColor = System.Drawing.Color.White;
            this.darkMode.Location = new System.Drawing.Point(243, 287);
            this.darkMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.darkMode.Name = "darkMode";
            this.darkMode.Size = new System.Drawing.Size(55, 30);
            this.darkMode.TabIndex = 3;
            this.darkMode.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.darkMode.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.darkMode.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.darkMode.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // voiceSwt
            // 
            this.voiceSwt.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.voiceSwt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.voiceSwt.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.voiceSwt.CheckedState.InnerColor = System.Drawing.Color.White;
            this.voiceSwt.Location = new System.Drawing.Point(243, 334);
            this.voiceSwt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.voiceSwt.Name = "voiceSwt";
            this.voiceSwt.Size = new System.Drawing.Size(55, 30);
            this.voiceSwt.TabIndex = 3;
            this.voiceSwt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.voiceSwt.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.voiceSwt.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.voiceSwt.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // readerSwt
            // 
            this.readerSwt.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.readerSwt.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.readerSwt.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.readerSwt.CheckedState.InnerColor = System.Drawing.Color.White;
            this.readerSwt.Location = new System.Drawing.Point(243, 384);
            this.readerSwt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.readerSwt.Name = "readerSwt";
            this.readerSwt.Size = new System.Drawing.Size(55, 30);
            this.readerSwt.TabIndex = 3;
            this.readerSwt.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.readerSwt.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.readerSwt.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.readerSwt.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // AccessibilitySettingsForm
            // 
            this.AcceptButton = this.btnsave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(469, 524);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbcontrastmode);
            this.Controls.Add(this.readerSwt);
            this.Controls.Add(this.voiceSwt);
            this.Controls.Add(this.darkMode);
            this.Controls.Add(this.texttospeech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbfont);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AccessibilitySettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch texttospeech;
        private Guna.UI2.WinForms.Guna2ComboBox cmbfont;
        private Guna.UI2.WinForms.Guna2ComboBox cmbcontrastmode;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ToggleSwitch darkMode;
        private Guna.UI2.WinForms.Guna2ToggleSwitch readerSwt;
        private Guna.UI2.WinForms.Guna2ToggleSwitch voiceSwt;
    }
}