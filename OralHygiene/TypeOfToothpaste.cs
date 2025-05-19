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
    public partial class TypeOfToothpaste: Form
    {
        public static string selectedToothpasteAnswer = "";

        public TypeOfToothpaste()
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
            BrushingDay loginForm = new BrushingDay();
            this.Close();
            loginForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!ans1.Checked && !ans2.Checked && !ans3.Checked && !ans4.Checked)  
            {
                MessageBox.Show("Please select the type of toothpaste you use.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (ans1.Checked)  
                {
                    selectedToothpasteAnswer = "Non-fluoride";
                }
                else if (ans2.Checked)  
                {
                    selectedToothpasteAnswer = "Fluoride";
                }
                else if (ans3.Checked)  
                {
                    selectedToothpasteAnswer = "Fluoride prescription\n toothpaste";
                }
                else if (ans4.Checked)  
                {
                    selectedToothpasteAnswer = "I don't know";
                }
            }


                OftenDoYouSmoke loginForm = new OftenDoYouSmoke();
            loginForm.Show();
            this.Close();
        }

        private void TypeOfToothpaste_Load(object sender, EventArgs e)
        {

        }

        private void ans3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
