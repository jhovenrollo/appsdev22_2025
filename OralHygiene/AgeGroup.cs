using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oralHygiene
{
    public partial class Form5: Form
    {
        public static string selectedAgeGroup = "";

        public Form5()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!ans1.Checked && !ans2.Checked && !ans3.Checked) 
            {
                MessageBox.Show("Please select an age group.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ans1.Checked)
                {
                    selectedAgeGroup = "Young Adults (18-39)";
                }
                else if (ans2.Checked)
                {
                    selectedAgeGroup = "Adults (40-59)";
                }
                else if (ans3.Checked)
                {
                    selectedAgeGroup = "Senior (60+)";
                }

                FlossDayCheck loginForm = new FlossDayCheck();
                loginForm.Show();
                this.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 loginForm = new Form5();
            this.Close();
            loginForm.Show();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            OralHealthChck loginForm = new OralHealthChck();
            this.Close();
            loginForm.Show();
        }
    }
}
