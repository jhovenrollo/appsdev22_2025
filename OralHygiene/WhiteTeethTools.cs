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

namespace oralHygiene
{
    public partial class WhiteTeethTools: Form
    {
        public WhiteTeethTools()
        {
            InitializeComponent();
            this.Load += WhiteTeethTools_Load;

            Color originalColor = Color.FromArgb(110, 152, 135);

            panel1.MouseEnter += (s, ev) => panel1.BackColor = Color.LightGray;
            panel1.MouseLeave += (s, ev) => panel1.BackColor = originalColor;

            panel2.MouseEnter += (s, ev) => panel2.BackColor = Color.LightGray;
            panel2.MouseLeave += (s, ev) => panel2.BackColor = originalColor;

            panel3.MouseEnter += (s, ev) => panel3.BackColor = Color.LightGray;
            panel3.MouseLeave += (s, ev) => panel3.BackColor = originalColor;

            panel4.MouseEnter += (s, ev) => panel4.BackColor = Color.LightGray;
            panel4.MouseLeave += (s, ev) => panel4.BackColor = originalColor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            WhiteTeeth loginForm = new WhiteTeeth();
            loginForm.Show();
            this.Close();
        }

        private void ShowProductDialog(string productName, string price, string description, string imagePath, string ingredients, string availability)
        {
            Form dialog = new Form();
            dialog.Text = $"Product Details - {productName}";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(800, 500);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14);
            Font fontBold16 = new Font("Segoe UI", 16, FontStyle.Bold);

            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(30, 30);
            imgPanel.Size = new Size(250, 270);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(imagePath);
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = productName;
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 390);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            RichTextBox richInfo = new RichTextBox();
            richInfo.Font = font14; // default font
            richInfo.ForeColor = Color.Black;
            richInfo.Location = new Point(10, 10);
            richInfo.Size = new Size(420, 360);
            richInfo.BackColor = Color.FromArgb(245, 250, 252);
            richInfo.BorderStyle = BorderStyle.None;
            richInfo.ReadOnly = true;

            // Set full text first
            string fullText =
                $"{productName}\n" +
                $"Price: {price}\n\n" +
                $"{description}\n\n" +
                "Ingredients / Kit Includes:\n" +
                $"{ingredients}\n\n" +
                "Available at:\n" +
                $"{availability}";

            richInfo.Text = fullText;

            // Apply bold to just the product name
            richInfo.Select(0, productName.Length);
            richInfo.SelectionFont = fontBold16;
            richInfo.Select(0, 0); // remove selection

            infoPanel.Controls.Add(richInfo);
            dialog.Controls.Add(infoPanel);

            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Click += (s, e) => dialog.Close();
            dialog.Controls.Add(okBtn);

            dialog.ShowDialog();
        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowProductDialog(
        "Crest 3D Whitestrips Glamorous White",
        "Php 195.00",
        "Whitens teeth by removing years of stains.",
        @"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Whiter Teeth\Dental Tools\Crest 3D White Strips.jpg",
        "- 14 treatments\n- Advanced Seal Technology\n- No-slip grip\n- Enamel-safe",
        "- Watsons\n- Mercury Drug"
    );
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowProductDialog(
        "Colgate Optic White Teeth Whitening Pen",
        "Php 899",
        "Easily apply whitening serum overnight.\nClinically proven to whiten teeth in 1 week.",
        @"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Whiter Teeth\Dental Tools\Colgate Optical White.jpg",
        "Includes:\n- Hydrogen peroxide\n- Enamel-safe formulation\n- Precision pen tip",
        "Watsons\nMercury Drug\nShopee\nLazada"
    );
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowProductDialog(
        "Dr. Song Professional Teeth Whitening Kit",
        "Php 162.00",
        "Professional-grade whitening at home.\nIncludes gel syringes and mouth trays.",
        @"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Whiter Teeth\Dental Tools\Dr.Song.jpg",
        "Kit Includes:\n- Carbamide Peroxide Gel\n- LED light\n- Syringes\n- Mouth Trays",
        "Shopee\nLazada"
    );
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowProductDialog(
        "Philips Sonicare FlexCare+ Electric Toothbrush",
        "Php 750",
        "Electric toothbrush with advanced sonic technology.\nImproves gum health and plaque removal.",
        @"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Whiter Teeth\Dental Tools\Philips Sonic Care.jpg",
        "Features:\n- Multiple brushing modes\n- Long battery life\n- Smart timer\n- Charging base",
        "Appliance stores\nWatsons\nShopee\nLazada"
    );
        }

        private void ApplyRoundedCornersToPanel(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            panel.Region = new Region(path);
        }
        private void WhiteTeethTools_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersToPanel(panel2, 30); 
            ApplyRoundedCornersToPanel(panel1, 30);
            ApplyRoundedCornersToPanel(panel3, 30);
            ApplyRoundedCornersToPanel(panel4, 30);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
