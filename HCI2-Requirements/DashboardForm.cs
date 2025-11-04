using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HCI2_Requirements
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
     
        }


        private void btnaddmeal_Click(object sender, EventArgs e)
        {
            MealForm mealForm = new MealForm();
            mealForm.ShowDialog();
            this.Hide();
        }

        private void btnaccessibility_Click(object sender, EventArgs e)
        {
            AccessibilitySettingsForm form = new AccessibilitySettingsForm();
            form.ShowDialog();
            this.Hide();
        }

        private void btnviewmeal_Click(object sender, EventArgs e)
        {

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();
        }
    }
}
