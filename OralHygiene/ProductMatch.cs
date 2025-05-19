using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace oralHygiene
{
    public partial class ProductMatch : Form
    {
        public ProductMatch()
        {
            InitializeComponent(); 
            Color originalColor = Color.FromArgb(110, 152, 135);

            pictureBox9.MouseEnter += (s, ev) => pictureBox9.BackColor = Color.LightGray;
            pictureBox9.MouseLeave += (s, ev) => pictureBox9.BackColor = Color.White;  

            pictureBox2.MouseEnter += (s, ev) => pictureBox2.BackColor = Color.LightGray;
            pictureBox2.MouseLeave += (s, ev) => pictureBox2.BackColor = Color.White;  

            pictureBox10.MouseEnter += (s, ev) => pictureBox10.BackColor = Color.LightGray;
            pictureBox10.MouseLeave += (s, ev) => pictureBox10.BackColor = Color.White; 

            ApplyCircularBorder(pictureBox9);
            ApplyCircularBorder(pictureBox2);
            ApplyCircularBorder(pictureBox10);

        }

        private void ApplyCircularBorder(PictureBox pictureBox)
        {
            int width = pictureBox.Width;
            int height = pictureBox.Height;
            pictureBox.Region = new Region(new Rectangle(0, 0, width, height));
            pictureBox.Region = new Region(new Rectangle(0, 0, width, height));
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, width, height);
                pictureBox.Region = new Region(path);
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void BOralHealth_Click(object sender, EventArgs e)
        {
            OralHealth loginForm = new OralHealth();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int diameter = Math.Min(pictureBox2.Width, pictureBox2.Height);
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, diameter, diameter);

            pictureBox2.Region = new Region(path);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductMatchToothpaste loginForm = new ProductMatchToothpaste();
            loginForm.Show();
            this.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox9_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int diameter = Math.Min(pictureBox9.Width, pictureBox9.Height);
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, diameter, diameter);

            pictureBox9.Region = new Region(path);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void pictureBox10_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int diameter = Math.Min(pictureBox10.Width, pictureBox10.Height);
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, diameter, diameter);

            pictureBox10.Region = new Region(path);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ProductMtchMouthWash loginForm = new ProductMtchMouthWash();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ProductMtchDentalTools loginForm = new ProductMtchDentalTools();
            loginForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
        private void ShowForm(Form form)
        {
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
    
    }

