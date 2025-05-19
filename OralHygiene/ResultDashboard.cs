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
    public partial class ResultDashboard: Form
    {
        public ResultDashboard()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Answer1_Click(object sender, EventArgs e)
        {

        }

        private void Answer2_Click(object sender, EventArgs e)
        {

        }

        private void Answer3_Click(object sender, EventArgs e)
        {

        }

        private void Answer4_Click(object sender, EventArgs e)
        {

        }

        private void Answer5_Click(object sender, EventArgs e)
        {

        }

        private void ToothHealth1_Click(object sender, EventArgs e)
        {

        }

        private void ToothHealth2_Click(object sender, EventArgs e)
        {

        }
        private string EvaluateToothHealth()
        {
            string healthStatus = "";

            if (FlossDayCheck.selectedFlossingAnswer == "3 or more times\n a week" &&
                BrushingDay.selectedBrushingAnswer == "At least Twice\n A Day" &&
                TypeOfToothpaste.selectedToothpasteAnswer == "Fluoride\n toothpaste" &&
                OftenDoYouSmoke.selectedSmokingAnswer != "At least Twice\n A Day")
            {
                healthStatus = "Good";
            }
            else
            {
                healthStatus = "Needs Improvement";
            }

            return healthStatus;
        }
        private string EvaluateToothHealthDetail()
        {
            string healthDetail = "";

            if (BrushingDay.selectedBrushingAnswer == "Once a day" || FlossDayCheck.selectedFlossingAnswer == "Never")
            {
                healthDetail += "Medium risk for Cavities.\n";
            }
            else
            {
                healthDetail += "Low risk for Cavities.\n";
            }

            if (OftenDoYouSmoke.selectedSmokingAnswer == "At least Twice\n A Day")
            {
                healthDetail += "High risk for Gum Disease.\n";
            }
            else if (OftenDoYouSmoke.selectedSmokingAnswer != "Never")
            {
                healthDetail += "Medium risk for Gum Disease due to smoking.\n";
            }
            else
            {
                healthDetail += "Low risk for Gum Disease.\n";
            }

            return healthDetail;
        }

        private void RecommendProductBasedOnHealth()
        {
            string productRecommendation = "";

            if (ToothHealth1.Text == "Good" && ToothHealth2.Text.Contains("Low risk"))
            {
                productRecommendation = "You have good oral health!";
            }
            else if (ToothHealth1.Text == "Needs Improvement" || ToothHealth2.Text.Contains("Medium risk"))
            {
                productRecommendation = "We recommend using toothpaste for cavity prevention and gum health.";
            }
            else if (ToothHealth2.Text.Contains("High risk for Gum Disease") || ToothHealth2.Text.Contains("Medium risk for Gum Disease"))
            {
                productRecommendation = "You are at risk for gum disease.";
            }

            ProductRecommendationLabel.Text = productRecommendation;
        }

        private void ResultDashboard_Load(object sender, EventArgs e)
        {
            Answer1.Text = Form5.selectedAgeGroup;
            Answer2.Text = FlossDayCheck.selectedFlossingAnswer; 
            Answer3.Text = BrushingDay.selectedBrushingAnswer; 
            Answer4.Text = TypeOfToothpaste.selectedToothpasteAnswer; 
            Answer5.Text = OftenDoYouSmoke.selectedSmokingAnswer; 

            string toothHealth1 = EvaluateToothHealth();
            ToothHealth1.Text = toothHealth1; 

            string toothHealth2 = EvaluateToothHealthDetail();
            ToothHealth2.Text = toothHealth2;

            RecommendProductBasedOnHealth();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product loginForm = new Product();
            loginForm.Show();
            this.Close();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
