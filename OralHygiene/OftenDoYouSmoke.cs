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
    public partial class OftenDoYouSmoke: Form
    {
        public static string selectedSmokingAnswer = "";

        public OftenDoYouSmoke()
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
            TypeOfToothpaste loginForm = new TypeOfToothpaste();
            this.Close();
            loginForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!ans1.Checked && !ans2.Checked && !ans3.Checked)  
            {
                MessageBox.Show("Please select how often you smoke.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ans1.Checked)  
                {
                    selectedSmokingAnswer = "At least Twice\n A Day";
                }
                else if (ans2.Checked) 
                {
                    selectedSmokingAnswer = "Once a Day";
                }
                else if (ans3.Checked) 
                {
                    selectedSmokingAnswer = "Never";
                }
                ResultDashboard loginForm = new ResultDashboard();
                loginForm.Show();
                this.Close();
            }
        }

        private void ans3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OftenDoYouSmoke_Load(object sender, EventArgs e)
        {

        }

        private void ans1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
