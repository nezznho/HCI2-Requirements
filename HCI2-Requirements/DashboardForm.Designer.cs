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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(520, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(410, 52);
            this.label4.TabIndex = 18;
            this.label4.Text = "Welcome, (Username)!";
            // 
            // btnlogout
            // 
            this.btnlogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Location = new System.Drawing.Point(466, 264);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(201, 49);
            this.btnlogout.TabIndex = 19;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnaddmeal
            // 
            this.btnaddmeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddmeal.Location = new System.Drawing.Point(61, 63);
            this.btnaddmeal.Name = "btnaddmeal";
            this.btnaddmeal.Size = new System.Drawing.Size(201, 49);
            this.btnaddmeal.TabIndex = 19;
            this.btnaddmeal.Text = "Add Meal";
            this.btnaddmeal.UseVisualStyleBackColor = true;
            this.btnaddmeal.Click += new System.EventHandler(this.btnaddmeal_Click);
            // 
            // btnaccessibility
            // 
            this.btnaccessibility.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaccessibility.Location = new System.Drawing.Point(466, 63);
            this.btnaccessibility.Name = "btnaccessibility";
            this.btnaccessibility.Size = new System.Drawing.Size(201, 49);
            this.btnaccessibility.TabIndex = 19;
            this.btnaccessibility.Text = "Accessibility Setting";
            this.btnaccessibility.UseVisualStyleBackColor = true;
            this.btnaccessibility.Click += new System.EventHandler(this.btnaccessibility_Click);
            // 
            // btnviewmeal
            // 
            this.btnviewmeal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviewmeal.Location = new System.Drawing.Point(61, 264);
            this.btnviewmeal.Name = "btnviewmeal";
            this.btnviewmeal.Size = new System.Drawing.Size(201, 49);
            this.btnviewmeal.TabIndex = 19;
            this.btnviewmeal.Text = "View Meal";
            this.btnviewmeal.UseVisualStyleBackColor = true;
            this.btnviewmeal.Click += new System.EventHandler(this.btnviewmeal_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnaccessibility);
            this.guna2Panel1.Controls.Add(this.btnviewmeal);
            this.guna2Panel1.Controls.Add(this.btnlogout);
            this.guna2Panel1.Controls.Add(this.btnaddmeal);
            this.guna2Panel1.Location = new System.Drawing.Point(308, 225);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(724, 420);
            this.guna2Panel1.TabIndex = 20;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 795);
            this.ControlBox = false;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnaddmeal;
        private System.Windows.Forms.Button btnaccessibility;
        private System.Windows.Forms.Button btnviewmeal;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}