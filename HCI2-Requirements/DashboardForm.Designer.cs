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
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnaddmeal = new System.Windows.Forms.Button();
            this.btnaccessibility = new System.Windows.Forms.Button();
            this.btnviewmeal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.addUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(349, 428);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(179, 39);
            this.btnlogout.TabIndex = 19;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnaddmeal
            // 
            this.btnaddmeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmeal.Location = new System.Drawing.Point(83, 383);
            this.btnaddmeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddmeal.Name = "btnaddmeal";
            this.btnaddmeal.Size = new System.Drawing.Size(179, 39);
            this.btnaddmeal.TabIndex = 19;
            this.btnaddmeal.Text = "Add Meal";
            this.btnaddmeal.UseVisualStyleBackColor = true;
            this.btnaddmeal.Click += new System.EventHandler(this.btnaddmeal_Click);
            // 
            // btnaccessibility
            // 
            this.btnaccessibility.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccessibility.Location = new System.Drawing.Point(349, 267);
            this.btnaccessibility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaccessibility.Name = "btnaccessibility";
            this.btnaccessibility.Size = new System.Drawing.Size(179, 39);
            this.btnaccessibility.TabIndex = 19;
            this.btnaccessibility.Text = "Accessibility Setting";
            this.btnaccessibility.UseVisualStyleBackColor = true;
            this.btnaccessibility.Click += new System.EventHandler(this.btnaccessibility_Click);
            // 
            // btnviewmeal
            // 
            this.btnviewmeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewmeal.Location = new System.Drawing.Point(349, 348);
            this.btnviewmeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnviewmeal.Name = "btnviewmeal";
            this.btnviewmeal.Size = new System.Drawing.Size(179, 39);
            this.btnviewmeal.TabIndex = 19;
            this.btnviewmeal.Text = "View Meal";
            this.btnviewmeal.UseVisualStyleBackColor = true;
            this.btnviewmeal.Click += new System.EventHandler(this.btnviewmeal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(494, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 27);
            this.label4.TabIndex = 18;
            this.label4.Text = "Welcome, (Username)!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HCI2_Requirements.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(24, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(77, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "MealPlanner";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(778, 79);
            this.guna2Panel1.TabIndex = 23;
            // 
            // addUser
            // 
            this.addUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.Location = new System.Drawing.Point(145, 258);
            this.addUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(179, 39);
            this.addUser.TabIndex = 19;
            this.addUser.Text = "Add New User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.btnaddmeal_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 555);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnaccessibility);
            this.Controls.Add(this.btnviewmeal);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.addUser);
            this.Controls.Add(this.btnaddmeal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnaddmeal;
        private System.Windows.Forms.Button btnaccessibility;
        private System.Windows.Forms.Button btnviewmeal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Button addUser;
    }
}