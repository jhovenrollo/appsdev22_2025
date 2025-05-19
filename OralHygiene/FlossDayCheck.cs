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
    public partial class FlossDayCheck: Form
    {
        public static string selectedFlossingAnswer = ""; 
        public FlossDayCheck()
        {
            InitializeComponent();
        }

 

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 loginForm = new Form5(); 
            this.Close();
            loginForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form5 loginForm = new Form5();
            this.Close();
            loginForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!ans1.Checked && !ans2.Checked && !ans3.Checked)
            {
                MessageBox.Show("Please select how often you floss your teeth.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ans1.Checked)
                {
                    selectedFlossingAnswer = "3 or more times\n a week";
                }
                else if (ans2.Checked)
                {
                    selectedFlossingAnswer = "less than 3 times\n a week";
                }
                else if (ans3.Checked)
                {
                    selectedFlossingAnswer = "Never";
                }

                BrushingDay loginForm = new BrushingDay();
                loginForm.Show();
                this.Close();
            }
        }

        private void FlossDayCheck_Load(object sender, EventArgs e)
        {

        }
    }
}
