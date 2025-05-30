﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oralHygiene
{
    public partial class RoutineTongueScraper: Form
    {
        public RoutineTongueScraper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoutineFloss loginForm = new RoutineFloss();
            loginForm.Show();
            this.Close();
        }
        private void ShowForm(Form form)
        {
            form.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string searchQuery = textBox2.Text.Trim().ToLower();

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
    }
}
