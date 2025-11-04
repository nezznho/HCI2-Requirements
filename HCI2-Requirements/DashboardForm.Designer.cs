namespace HCI2_Requirements
{
    partial class DashboardForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnaddmeal = new System.Windows.Forms.Button();
            this.btnaccessibility = new System.Windows.Forms.Button();
            this.btnviewmeal = new System.Windows.Forms.Button();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Welcome, (Username)!";
            // 
            // btnlogout
            // 
            this.btnlogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(0, 394);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(284, 46);
            this.btnlogout.TabIndex = 19;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnaddmeal
            // 
            this.btnaddmeal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnaddmeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmeal.Location = new System.Drawing.Point(0, 518);
            this.btnaddmeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddmeal.Name = "btnaddmeal";
            this.btnaddmeal.Size = new System.Drawing.Size(284, 39);
            this.btnaddmeal.TabIndex = 19;
            this.btnaddmeal.Text = "Add Meal";
            this.btnaddmeal.UseVisualStyleBackColor = true;
            this.btnaddmeal.Click += new System.EventHandler(this.btnaddmeal_Click);
            // 
            // btnaccessibility
            // 
            this.btnaccessibility.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnaccessibility.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccessibility.Location = new System.Drawing.Point(0, 440);
            this.btnaccessibility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaccessibility.Name = "btnaccessibility";
            this.btnaccessibility.Size = new System.Drawing.Size(284, 39);
            this.btnaccessibility.TabIndex = 19;
            this.btnaccessibility.Text = "Accessibility Setting";
            this.btnaccessibility.UseVisualStyleBackColor = true;
            this.btnaccessibility.Click += new System.EventHandler(this.btnaccessibility_Click);
            // 
            // btnviewmeal
            // 
            this.btnviewmeal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnviewmeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewmeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewmeal.Location = new System.Drawing.Point(0, 479);
            this.btnviewmeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnviewmeal.Name = "btnviewmeal";
            this.btnviewmeal.Size = new System.Drawing.Size(284, 39);
            this.btnviewmeal.TabIndex = 19;
            this.btnviewmeal.Text = "View Meal";
            this.btnviewmeal.UseVisualStyleBackColor = true;
            this.btnviewmeal.Click += new System.EventHandler(this.btnviewmeal_Click);
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.FillColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(805, 0);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(50, 43);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "X";
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.label2.Location = new System.Drawing.Point(85, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 34);
            this.label2.TabIndex = 23;
            this.label2.Text = "MealPlanner";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HCI2_Requirements.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnlogout);
            this.panel1.Controls.Add(this.btnaccessibility);
            this.panel1.Controls.Add(this.btnviewmeal);
            this.panel1.Controls.Add(this.btnaddmeal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 557);
            this.panel1.TabIndex = 24;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 557);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnaddmeal;
        private System.Windows.Forms.Button btnaccessibility;
        private System.Windows.Forms.Button btnviewmeal;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
    }
}