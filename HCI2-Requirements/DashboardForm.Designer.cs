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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MonthCalendar monthCalendar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnaddmeal = new System.Windows.Forms.Button();
            this.viewmealBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnexit = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnaccessibility = new System.Windows.Forms.Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addtoList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Cursor = System.Windows.Forms.Cursors.Default;
            monthCalendar.Location = new System.Drawing.Point(33, 123);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnlogout.BackgroundImage")));
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderSize = 0;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(959, 10);
            this.btnlogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(38, 43);
            this.btnlogout.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnlogout, "Logout\r\n");
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            this.btnlogout.MouseHover += new System.EventHandler(this.btnlogout_MouseHover);
            // 
            // btnaddmeal
            // 
            this.btnaddmeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnaddmeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddmeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmeal.Location = new System.Drawing.Point(14, 507);
            this.btnaddmeal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaddmeal.Name = "btnaddmeal";
            this.btnaddmeal.Size = new System.Drawing.Size(230, 50);
            this.btnaddmeal.TabIndex = 19;
            this.btnaddmeal.Text = "Add Meal";
            this.toolTip1.SetToolTip(this.btnaddmeal, "Add New Meal");
            this.btnaddmeal.UseVisualStyleBackColor = false;
            this.btnaddmeal.Click += new System.EventHandler(this.btnaddmeal_Click);
            // 
            // viewmealBtn
            // 
            this.viewmealBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.viewmealBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viewmealBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewmealBtn.Location = new System.Drawing.Point(14, 561);
            this.viewmealBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewmealBtn.Name = "viewmealBtn";
            this.viewmealBtn.Size = new System.Drawing.Size(230, 50);
            this.viewmealBtn.TabIndex = 19;
            this.viewmealBtn.Text = "View Meal";
            this.toolTip1.SetToolTip(this.viewmealBtn, "View All Meal");
            this.viewmealBtn.UseVisualStyleBackColor = false;
            this.viewmealBtn.Click += new System.EventHandler(this.viewmealBtn_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 37);
            this.label4.TabIndex = 18;
            this.label4.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 34);
            this.label2.TabIndex = 22;
            this.label2.Text = "MealPlanner";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(117)))), ((int)(((byte)(126)))));
            this.guna2Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.pictureBox1);
            this.guna2Panel1.Controls.Add(this.btnaccessibility);
            this.guna2Panel1.Controls.Add(this.btnlogout);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1008, 65);
            this.guna2Panel1.TabIndex = 23;
            // 
            // btnexit
            // 
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnexit.FillColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Black;
            this.btnexit.Location = new System.Drawing.Point(19, 618);
            this.btnexit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(223, 43);
            this.btnexit.TabIndex = 23;
            this.btnexit.Text = "Exit";
            this.toolTip1.SetToolTip(this.btnexit, "Exit");
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::HCI2_Requirements.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // btnaccessibility
            // 
            this.btnaccessibility.BackColor = System.Drawing.Color.Transparent;
            this.btnaccessibility.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaccessibility.BackgroundImage")));
            this.btnaccessibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnaccessibility.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaccessibility.FlatAppearance.BorderSize = 0;
            this.btnaccessibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccessibility.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccessibility.Location = new System.Drawing.Point(910, 11);
            this.btnaccessibility.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnaccessibility.Name = "btnaccessibility";
            this.btnaccessibility.Size = new System.Drawing.Size(38, 43);
            this.btnaccessibility.TabIndex = 19;
            this.btnaccessibility.Text = " ";
            this.toolTip1.SetToolTip(this.btnaccessibility, "Accessibility");
            this.btnaccessibility.UseVisualStyleBackColor = false;
            this.btnaccessibility.Click += new System.EventHandler(this.btnaccessibility_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.guna2Panel3.Controls.Add(monthCalendar);
            this.guna2Panel3.Controls.Add(this.monthCalendar1);
            this.guna2Panel3.Controls.Add(this.panel2);
            this.guna2Panel3.Location = new System.Drawing.Point(271, 98);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(350, 562);
            this.guna2Panel3.TabIndex = 24;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(-882, -405);
            this.monthCalendar1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(144)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 82);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "WEEK AT A GLANCE";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.guna2Panel4.Location = new System.Drawing.Point(641, 184);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(337, 423);
            this.guna2Panel4.TabIndex = 24;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Crimson;
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.ForeColor = System.Drawing.Color.Black;
            this.removeBtn.Location = new System.Drawing.Point(809, 613);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(169, 44);
            this.removeBtn.TabIndex = 26;
            this.removeBtn.Text = "Remove";
            this.toolTip1.SetToolTip(this.removeBtn, "Remove Grocery List");
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addtoList
            // 
            this.addtoList.BackColor = System.Drawing.Color.SpringGreen;
            this.addtoList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addtoList.FlatAppearance.BorderSize = 0;
            this.addtoList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addtoList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addtoList.ForeColor = System.Drawing.Color.Black;
            this.addtoList.Location = new System.Drawing.Point(643, 613);
            this.addtoList.Name = "addtoList";
            this.addtoList.Size = new System.Drawing.Size(163, 44);
            this.addtoList.TabIndex = 25;
            this.addtoList.Text = "Add";
            this.toolTip1.SetToolTip(this.addtoList, "Add Grocery List");
            this.addtoList.UseVisualStyleBackColor = false;
            this.addtoList.Click += new System.EventHandler(this.addtoList_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(115)))), ((int)(((byte)(144)))));
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(641, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(337, 80);
            this.panel3.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(72, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 34);
            this.label5.TabIndex = 24;
            this.label5.Text = "GROCERY LIST";
            // 
            // addNewBtn
            // 
            this.addNewBtn.BackColor = System.Drawing.Color.Lime;
            this.addNewBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addNewBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.addNewBtn.Location = new System.Drawing.Point(14, 454);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(229, 48);
            this.addNewBtn.TabIndex = 27;
            this.addNewBtn.Text = "Add User";
            this.toolTip1.SetToolTip(this.addNewBtn, "Add New User");
            this.addNewBtn.UseVisualStyleBackColor = false;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 672);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.addtoList);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.viewmealBtn);
            this.Controls.Add(this.btnaddmeal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnaddmeal;
        private System.Windows.Forms.Button btnaccessibility;
        private System.Windows.Forms.Button viewmealBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button addtoList;
        private System.Windows.Forms.Button removeBtn;
        private Guna.UI2.WinForms.Guna2Button btnexit;
        private System.Windows.Forms.Button addNewBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}