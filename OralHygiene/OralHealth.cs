using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oralHygiene
{
    public partial class OralHealth: Form
    {
        public OralHealth()
        {
            InitializeComponent();

            Color originalColor = Color.FromArgb(110, 152, 135);

            pictureBox9.MouseEnter += (s, ev) => pictureBox9.BackColor = Color.LightGray;
            pictureBox9.MouseLeave += (s, ev) => pictureBox9.BackColor = Color.White;

            pictureBox2.MouseEnter += (s, ev) => pictureBox2.BackColor = Color.LightGray;
            pictureBox2.MouseLeave += (s, ev) => pictureBox2.BackColor = Color.White;

            pictureBox3.MouseEnter += (s, ev) => pictureBox3.BackColor = Color.LightGray;
            pictureBox3.MouseLeave += (s, ev) => pictureBox3.BackColor = Color.White;

            pictureBox7.MouseEnter += (s, ev) => pictureBox7.BackColor = Color.LightGray;
            pictureBox7.MouseLeave += (s, ev) => pictureBox7.BackColor = Color.White;

            pictureBox5.MouseEnter += (s, ev) => pictureBox5.BackColor = Color.LightGray;
            pictureBox5.MouseLeave += (s, ev) => pictureBox5.BackColor = Color.White;

            pictureBox10.MouseEnter += (s, ev) => pictureBox10.BackColor = Color.LightGray;
            pictureBox10.MouseLeave += (s, ev) => pictureBox10.BackColor = Color.White;

            pictureBox8.MouseEnter += (s, ev) => pictureBox8.BackColor = Color.LightGray;
            pictureBox8.MouseLeave += (s, ev) => pictureBox8.BackColor = Color.White;

            pictureBox6.MouseEnter += (s, ev) => pictureBox6.BackColor = Color.LightGray;
            pictureBox6.MouseLeave += (s, ev) => pictureBox6.BackColor = Color.White;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void OralHealth_Load(object sender, EventArgs e)
        {

        }

        private void OralHBtnLbl_Click(object sender, EventArgs e)
        {
            OralHealth loginForm = new OralHealth();
            loginForm.Show();
            this.Close();
        }

        private void BHome_Click(object sender, EventArgs e)
        {
            Main loginForm = new Main();
            loginForm.Show();
            this.Close();
        }

        private void SProduct_Click(object sender, EventArgs e)
        {
            Product loginForm = new Product();
            loginForm.Show();
            this.Close();
        }

        private void BOralHealthChk_Click(object sender, EventArgs e)
        {
            OralHealthChck loginForm = new OralHealthChck();
            loginForm.Show();
            this.Close();
        }

        private void BPrductMtch_Click(object sender, EventArgs e)
        {
            ProductMatch loginForm = new ProductMatch();
            loginForm.Show();
            this.Close();
        }

        private void BAbout_Click(object sender, EventArgs e)
        {
            AboutInfo loginForm = new AboutInfo();
            loginForm.Show();
            this.Close();
        }


        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Whitening Advice";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string selectedDentalConcern = "";

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Healthy Gums";
        }


        private void button3_Click(object sender, EventArgs e)
        {
                string selectedAge = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedAge))
            {
                ShowCustomMessageBox("Please select an age category first.", "Missing Information", true); 
                return;
            }

            string message = "";

            if (selectedAge.Contains("Baby teeth"))
            {
                if (selectedDentalConcern == "Reduce Sensitivity")
                {
                    message = "👶 Reduce Sensitivity (0–12)\n\n" +
                              "• Have your child brush twice daily with a soft-bristled toothbrush and fluoride toothpaste.\n" +
                              "• Avoid acidic foods and drinks like citrus juice, soda, and sports drinks.\n" +
                              "• Limit sugary snacks and sweets.\n" +
                              "• Ensure their diet includes enough calcium and vitamin D.\n" +
                              "• Visit the dentist regularly for early detection of dental issues.";

                    ShowCustomMessageBox(message, "Reduce Sensitivity Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Protect Enamel")
                {
                    message = "👶 Protect Enamel (0–12)\n\n" +
                              "• Use a Soft Toothbrush: A soft-bristled toothbrush is gentler on your child’s teeth and gums, preventing damage and enamel wear.\n" +
                              "• Limit Starchy Foods: Foods like chips and fries quickly turn into sugar, which promotes bacteria that harms tooth enamel.\n" +
                              "• Floss Daily: Flossing cleans areas brushing misses, preventing plaque buildup and cavities. Start when teeth touch.\n" +
                              "• Add Dairy: Dairy products like cheese and yogurt help protect enamel and neutralize harmful acids.\n" +
                              "• Rinse After Meals: Swishing water after meals helps remove food debris from between teeth.\n" +
                              "• Avoid Whitening Toothpastes: These can wear down enamel. Choose fluoride toothpaste for stronger teeth.\n" +
                              "• Find a Pediatric Dentist: Pediatric dentists specialize in young teeth and can monitor enamel health.";

                    ShowCustomMessageBox(message, "Protect Enamel Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Reduce Plaque")
                {
                    message = "👶 Reduce Plaque (0–12)\n\n" +
                              "• Visit the dentist every 6 months for cleaning and checkups.\n" +
                              "• Brush twice a day and floss once daily.\n" +
                              "• Serve healthy meals and encourage drinking water.\n" +
                              "• Limit sugary snacks and drinks.\n" +
                              "• Ask the dentist about fluoride and sealants to help reduce plaque buildup.";

                    ShowCustomMessageBox(message, "Reduce Plaque Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Control Tartar")
                {
                    message = "👶 Control Tartar (0–12)\n\n" +
                              "• Use fluoride toothpaste in a pea-sized amount to help prevent plaque and tartar buildup. For children under 3 years old, only use a rice grain-sized smear if recommended by a dentist.\n" +
                              "• Brush teeth twice a day, especially after breakfast and before bedtime, using a soft-bristled, child-sized toothbrush with adult supervision.\n" +
                              "• Encourage daily flossing with the help of a guardian, especially once the child has two teeth that touch.\n" +
                              "• Offer water instead of sugary drinks to rinse away food particles and acids that can lead to tartar.\n" +
                              "• Schedule regular dental visits every six months to professionally clean and monitor the child’s oral health.";

                    ShowCustomMessageBox(message, "Control Tartar Advice", false);
                    return; 
                }
                if (selectedDentalConcern == "Better Breath")
                {
                    message = "👶 Better Breath (0–12)\n\n" +
                              "• Brush the child’s teeth and tongue gently twice a day using fluoride toothpaste to remove odor-causing bacteria.\n" +
                              "• Encourage them to drink plenty of water to stay hydrated and rinse away food particles.\n" +
                              "• Avoid too many sugary or sticky snacks, which contribute to bacterial buildup and bad breath.\n" +
                              "• Clean pacifiers, toys, and bottles regularly to prevent bacterial transfer.\n" +
                              "• Ask your pediatric dentist if using a soft baby tongue scraper is safe for your child to help reduce odor-causing residue.";

                    ShowCustomMessageBox(message, "Better Breath Advice", false);
                    return; 
                }
                if (selectedDentalConcern == "Prevent Cavities")
                {
                    message = "👶 Prevent Cavities (0–12)\n\n" +
                              "• Brush your teeth twice daily using fluoride toothpaste to strengthen enamel and fight acid attacks from plaque.\n" +
                              "• Floss daily to remove food particles and plaque between teeth where a toothbrush can't reach.\n" +
                              "• Limit sugary and acidic foods and drinks like candy, soda, and fruit juices that feed cavity-causing bacteria.\n" +
                              "• Chew sugar-free gum after meals to stimulate saliva production, which naturally neutralizes acids in your mouth.\n" +
                              "• Visit your dentist every 6 months for professional cleaning and early detection of cavity risks.\n" +
                              "✅ According to the CDC and ADA, fluoride remains one of the most effective agents for cavity prevention. It helps rebuild weakened enamel and slows down the loss of minerals.\n" +
                              "📚 Reference: Centers for Disease Control and Prevention. (2020). Oral Health Basics. CDC Website https://www.cdc.gov/oral-health/index.html";

                    ShowCustomMessageBox(message, "Prevent Cavities Advice", false);
                    return; 
                }
                else if (selectedDentalConcern == "Healthy Gums") 
                {
                    message = "👶 Healthy Gums (0–12)\n\n" +
                              "• Gently massage the gums with a clean, soft cloth or silicone finger brush even before teeth erupt to improve circulation and remove bacteria.\n" +
                              "• Once teeth appear, brush twice daily using a soft-bristled toothbrush and a rice-sized amount of fluoride toothpaste.\n" +
                              "• Encourage drinking water after meals to wash away food particles and neutralize acids.\n" +
                              "• Avoid giving too many sugary snacks or drinks, as sugar promotes gum inflammation and decay.\n" +
                              "• Schedule your child’s first dental visit by their first birthday or within 6 months of the first tooth appearing to ensure gum and tooth development are on track.";

                    ShowCustomMessageBox(message, "Healthy Gums Advice", false);
                }
                else
                {
                    message = "👶 Baby Teeth (0–12)\n\n" +
                              "• Brush twice daily with a soft-bristled toothbrush and a smear or pea-sized amount of fluoride toothpaste (depending on age), to gently remove surface stains.\n" +
                              "• Avoid sugary snacks and drinks, especially between meals, to reduce staining and plaque buildup.\n" +
                              "• Encourage drinking plenty of water throughout the day, especially after eating, to help rinse away food particles and maintain a clean mouth.\n" +
                              "• Wipe baby’s gums and teeth with a clean, damp cloth after feedings (for infants), or brush gently as soon as teeth emerge.\n" +
                              "• Visit the dentist regularly, starting at age 1, to monitor tooth development and receive personalized cleaning and care tips.\n" +
                              "• Brush your child’s teeth twice a day using a soft-bristled, child-sized toothbrush and a rice-sized amount of fluoride toothpaste (pea-sized if 3–6 years old).";

                    ShowCustomMessageBox(message, "Whitening Advice", false);
                }
            }
            
            if (selectedAge.Contains("Permanent teeth"))
            {
                if (selectedDentalConcern == "Reduce Sensitivity")
                {
                    message = "🧑 Reduce Sensitivity (13+)\n\n" +
                              "• Use desensitizing toothpaste to reduce discomfort.\n" +
                              "• Opt for a soft-bristled toothbrush to protect enamel.\n" +
                              "• Rinse with saltwater or hydrogen peroxide to soothe pain.\n" +
                              "• Avoid acidic foods and drinks that can worsen sensitivity.\n" +
                              "• Consider using a mouthguard if you grind your teeth at night.";

                    ShowCustomMessageBox(message, "Reduce Sensitivity Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Protect Enamel")
                {
                    message = "🧑 Protect Enamel (13+)\n\n" +
                              "• Brush and Floss Daily: Brush twice a day and floss once to remove plaque and bacteria that wear down enamel.\n" +
                              "• Use Fluoride Toothpaste and a Soft Brush: Fluoride strengthens enamel, and soft bristles prevent abrasion. Brush gently!\n" +
                              "• Limit Acid Exposure: Drink acidic beverages (like soda) through a straw and rinse with water after.\n" +
                              "• Stay Hydrated & Chew Sugar-Free Gum: These promote saliva, which naturally protects and remineralizes enamel.\n" +
                              "• Address Underlying Issues: Treat dry mouth, GERD, or bruxism (grinding). Ask your dentist about sealants and wear a mouthguard if needed.";

                    ShowCustomMessageBox(message, "Protect Enamel Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Control Tartar")
                {
                    message = "🧑 Control Tartar (13+)\n\n" +
                              "• Gently massage the gums with a clean, soft cloth or silicone finger brush even before teeth erupt to improve circulation and remove bacteria.\n" +
                              "• Once teeth appear, brush twice daily using a soft-bristled toothbrush and a rice-sized amount of fluoride toothpaste.\n" +
                              "• Encourage drinking water after meals to wash away food particles and neutralize acids.\n" +
                              "• Avoid giving too many sugary snacks or drinks, as sugar promotes gum inflammation and decay.\n" +
                              "• Schedule your child’s first dental visit by their first birthday or within 6 months of the first tooth appearing to ensure gum and tooth development are on track.";

                    ShowCustomMessageBox(message, "Control Tartar Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Better Breath")
                {
                    message = "🧑 Better Breath (13+)\n\n" +
                              "• Brush twice a day for 2 minutes and floss daily. Don’t forget to clean your tongue using a brush or tongue scraper.\n" +
                              "• Use alcohol-free antibacterial mouthwash to reduce odor-causing bacteria.\n" +
                              "• Visit your dentist regularly—every 6 months or as needed for cleanings and checkups.\n" +
                              "• Stay hydrated by drinking lots of water to prevent dry mouth.\n" +
                              "• Stimulate saliva with sugar-free gum, candy, or crunchy foods; ask your dentist about artificial saliva if needed.\n" +
                              "• Avoid alcohol, tobacco, and too much caffeine as they dry out your mouth and worsen breath.\n" +
                              "📚 Reference: https://my.clevelandclinic.org/health/diseases/17771-bad-breath-halitosis";

                    ShowCustomMessageBox(message, "Better Breath Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Reduce Plaque")
                {
                    message = "🧑 Reduce Plaque (13+)\n\n" +
                              "• Brush your teeth twice daily with fluoride toothpaste to remove plaque.\n" +
                              "• Floss daily to clean between your teeth and remove plaque buildup.\n" +
                              "• Use mouthwash to kill bacteria and reduce plaque accumulation.\n" +
                              "• Limit sugary foods and drinks to reduce plaque-forming bacteria.\n" +
                              "• Visit the dentist every 6 months for professional cleaning and plaque removal.";

                    ShowCustomMessageBox(message, "Reduce Plaque Advice", false);
                    return;
                }
                if (selectedDentalConcern == "Prevent Cavities")
                {
                    message = "🧑 Prevent Cavities (13+)\n\n" +
                              "• Brush your teeth twice daily using fluoride toothpaste to strengthen enamel and fight acid attacks from plaque.\n" +
                              "• Floss daily to remove food particles and plaque between teeth where a toothbrush can't reach.\n" +
                              "• Limit sugary and acidic foods and drinks like candy, soda, and fruit juices that feed cavity-causing bacteria.\n" +
                              "• Chew sugar-free gum after meals to stimulate saliva production, which naturally neutralizes acids in your mouth.\n" +
                              "• Visit your dentist every 6 months for professional cleaning and early detection of cavity risks.\n" +
                              "✅ According to the CDC and ADA, fluoride remains one of the most effective agents for cavity prevention. It helps rebuild weakened enamel and slows down the loss of minerals.\n" +
                              "📚 Reference: Centers for Disease Control and Prevention. (2020). Oral Health Basics. CDC Website";

                    ShowCustomMessageBox(message, "Prevent Cavities Advice", false);
                    return; 
                }
               
                else if (selectedDentalConcern == "Healthy Gums") 
                {
                    message = "🧑 Healthy Gums (13+)\n\n" +
                              "• Brush twice a day with fluoride toothpaste and a soft-bristled toothbrush for 2 minutes.\n" +
                              "• Floss once daily to remove plaque between teeth and along the gumline.\n" +
                              "• Avoid smoking and limit sugary foods to prevent gum disease and cavities.\n" +
                              "• Replace your toothbrush every 3–4 months or when the bristles are worn.\n" +
                              "• Visit your dentist regularly for checkups and cleanings, at least every 6 months.\n\n" +
                              "📚 Reference: https://medlineplus.gov/ency/article/001957.htm";

                    ShowCustomMessageBox(message, "Healthy Gums Advice", false);
                }
                else
                {
                    message = "🧑 Permanent Teeth (13+)\n\n" +
                              "• Brush your teeth twice daily using fluoride toothpaste to strengthen enamel and fight acid attacks from plaque.\n" +
                              "• Floss daily to remove food particles and plaque between teeth where a toothbrush can't reach\n" +
                              "• Limit sugary and acidic foods and drinks like candy, soda, and fruit juices that feed cavity-causing bacteria.\n" +
                              "• Chew sugar-free gum after meals to stimulate saliva production, which naturally neutralizes acids in your mouth.\n" +
                              "• Visit your dentist every 6 months for professional cleaning and early detection of cavity risks.\n" +
                              "⚠️ Note: According to the CDC and ADA, fluoride remains one of the most effective agents for cavity prevention. It helps rebuild weakened enamel and slows down the loss of minerals.\n" +
                              "📚 Reference: Centers for Disease Control and Prevention. (2020). Oral Health Basics. CDC Website";

                    ShowCustomMessageBox(message, "Whitening Advice", false);
                }

            }
        }

        private void ShowCustomMessageBox(string message, string title, bool dynamicSize)
        {

            Form customMsgBox = new Form
            {
                Text = title,
                StartPosition = FormStartPosition.CenterScreen,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            if (dynamicSize)
            {
                customMsgBox.AutoSize = true;
                customMsgBox.AutoSizeMode = AutoSizeMode.GrowOnly;
            }
            else
            {
                customMsgBox.Size = new System.Drawing.Size(700, 500); 
            }

            Label label = new Label
            {
                Text = message,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopLeft, 
                Font = new System.Drawing.Font("Microsoft Sans Serif", 14),
                AutoSize = false,
                Padding = new Padding(20),
                Margin = new Padding(10)
            };

            label.MaximumSize = new Size(660, 0); 

            customMsgBox.Controls.Add(label);

            customMsgBox.ShowDialog();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Reduce Plaque";

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Prevent Cavities";

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Reduce Sensitivity";
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Protect Enamel";

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Control Tartar";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            selectedDentalConcern = "Better Breath";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox1.Text.Trim().ToLower();

            // Handle abbreviations and map them to full terms
            if (searchQuery.Contains("prod"))
            {
                searchQuery = "product";
            }
            else if (searchQuery.Contains("home") || searchQuery.Contains("main"))
            {
                searchQuery = "home";
            }
            else if (searchQuery.Contains("oral"))
            {
                if (searchQuery.Contains("healthcheck") || searchQuery.Contains("check"))
                {
                    searchQuery = "oralhealthcheck";
                }
                else
                {
                    searchQuery = "oralhealth";
                }
            }
            else if (searchQuery.Contains("match"))
            {
                if (searchQuery.Contains("prod"))
                {
                    searchQuery = "productmatch";
                }
                else
                {
                    searchQuery = "productmatch";
                }
            }
            else if (searchQuery.Contains("tool"))
            {
                searchQuery = "dentaltools";
            }
            // Add condition for brushing or flossing
            else if (searchQuery.Contains("flossing") || searchQuery.Contains("proper floss"))
            {
                searchQuery = "howtodentalfloss";
            }
            else if (searchQuery.Contains("brushing") || searchQuery.Contains("proper brush"))
            {
                searchQuery = "properwaytobrush";
            }
            else if (searchQuery.Contains("kids"))
            {
                searchQuery = "kidstoothbrush";  // Treat "kids" as a shortcut for "kidstoothbrush"
            }
            else if (searchQuery.Contains("tongue"))
            {
                searchQuery = "tonguescraper";
            }
            else if (searchQuery.Contains("floss"))
            {
                searchQuery = "dentalfloss";
            }
            else if (searchQuery.Contains("pressbrush") || searchQuery.Contains("sensorbrush") || searchQuery.Contains("psbrush"))
            {
                searchQuery = "pressuresensortoothbrush";  // Abbreviation for Pressure Sensor Toothbrush
            }
            else if (searchQuery.Contains("modebrush") || searchQuery.Contains("modeelectric"))
            {
                searchQuery = "modeelectrictoothbrush";  // Abbreviation for Mode Electric Toothbrush
            }
            else if (searchQuery.Contains("howtousetonguescraoer") || searchQuery.Contains("howtousescraper"))
            {
                searchQuery = "tonguescraper";  // Abbreviation for Mode Electric Toothbrush
            }
            else if (searchQuery.Contains("abt"))
            {
                searchQuery = "about";
            }
            else if (searchQuery.Contains("soft"))
            {
                searchQuery = "softbrush";
            }
            else if (searchQuery.Contains("hard"))
            {
                searchQuery = "hardbrush";
            }
            else if (searchQuery.Contains("medium"))
            {
                searchQuery = "mediumbrush";
            }

            switch (searchQuery)
            {

                case "about":
                    ShowForm(new AboutInfo());
                    return;
                case "product":
                    ShowForm(new Product());
                    return;

                case "productmatch":
                    ShowForm(new ProductMatch());
                    return;

                case "oralhealth":
                    ShowForm(new OralHealth());
                    return;

                case "oralhealthcheck":
                    ShowForm(new OralHealthChck());
                    return;

                case "home":
                    ShowForm(new Main());
                    return;

                case "toothpaste":
                    ShowForm(new ProductMatchToothpaste());
                    return;

                case "mouthwash":
                    ShowForm(new ProductMtchMouthWash());
                    return;

                case "dentaltools":
                    ShowForm(new ProductMtchDentalTools());
                    return;

                case "toothbrush":
                    ShowForm(new ProductMtchTypesBrush());
                    return;

                case "manualbrush":
                    ShowForm(new ProductMtchManualBrush());
                    return;

                case "electricbrush":
                    ShowForm(new ProductMtchElectricBrush());
                    return;

                case "howtodentalfloss":
                    // Route to flossing routine page
                    ShowForm(new RoutineFloss());
                    return;

                case "properwaytobrush":
                    // Route to brushing routine page
                    ShowForm(new Routine());
                    return;

                case "sensitivitytoothpaste":
                    ShowForm(new ProductMtchSensePaste());
                    return;

                case "fluoride":
                    ShowForm(new ProductMtchFlouride());
                    return;

                case "nonfluoride":
                    ShowForm(new ProductMtchNonFlouride());
                    return;

                case "whitening":
                    ShowForm(new ProductMtchColgate());
                    return;
                case "kidstoothbrush":
                    ShowForm(new ProductMtchBrush2());  // Add the new form for Kid's Toothbrush
                    return;
                case "sonictoothbrush":
                    ShowForm(new ProductMtchEBrush2());  // Sonic Toothbrush
                    return;
                case "pressuresensortoothbrush":
                    ShowForm(new ProductMtchEBrush3());  // Pressure Sensor Toothbrush
                    return;
                case "modeelectrictoothbrush":
                    ShowForm(new ProductMtchEBrush4());  // Mode Electric Toothbrush
                    return;
                case "howtousetonguescraper":
                    ShowForm(new RoutineTongueScraper());  // Mode Electric Toothbrush
                    return;
                case "tonguescraper":
                    ShowForm(new ProductMtchTScraper());  // Mode Electric Toothbrush
                    return;
                case "dentalfloss":
                    ShowForm(new ProductMtchFloss());  // Mode Electric Toothbrush
                    return;
                case "softbrush":
                    ShowForm(new ProductMtchSoftBristle());  // Mode Electric Toothbrush
                    return;
                case "mediumbrush":
                    ShowForm(new ProductMtchMediumBristle());  // Mode Electric Toothbrush
                    return;
                case "hardtbrush":
                    ShowForm(new ProductMtchHardBristle());  // Mode Electric Toothbrush
                    return;

                default:
                    MessageBox.Show("No matching form found.");
                    break;
            }
        }
        private void ShowForm(Form form)
        {
            form.Show();
            this.Close();
        }
    }
}
