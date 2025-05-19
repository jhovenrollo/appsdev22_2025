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
    public partial class BrushingDay: Form
    {
        public static string selectedBrushingAnswer = "";
        public BrushingDay()
        {
            InitializeComponent();
        }

        private void BrushingDay_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!ans1.Checked && !ans2.Checked && !ans3.Checked) 
            {
                MessageBox.Show("Please select how often you brush your teeth.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ans1.Checked)  
                {
                    selectedBrushingAnswer = "At least Twice A Day";
                }
                else if (ans2.Checked) 
                {
                    selectedBrushingAnswer = "Once a Day";
                }
                else if (ans3.Checked) 
                {
                    selectedBrushingAnswer = "Not everyday";
                }

                TypeOfToothpaste loginForm = new TypeOfToothpaste();
                loginForm.Show();
                this.Close();
            }

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form5 loginForm = new Form5();
            this.Close();
            loginForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FlossDayCheck loginForm = new FlossDayCheck();
            this.Close();
            loginForm.Show();
        }

        private void ans1_Click(object sender, EventArgs e)
        {

        }
    }
}
