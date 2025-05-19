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
    public partial class ReduceTartarTools: Form
    {
        public ReduceTartarTools()
        {
            InitializeComponent();

            this.Load += ReduceTartarTools_Load;

            Color originalColor = Color.FromArgb(110, 152, 135);

            panel2.MouseEnter += (s, ev) => panel2.BackColor = Color.LightGray;
            panel2.MouseLeave += (s, ev) => panel2.BackColor = originalColor;

            panel3.MouseEnter += (s, ev) => panel3.BackColor = Color.LightGray;
            panel3.MouseLeave += (s, ev) => panel3.BackColor = originalColor;

            panel4.MouseEnter += (s, ev) => panel4.BackColor = Color.LightGray;
            panel4.MouseLeave += (s, ev) => panel4.BackColor = originalColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReduceTartar loginForm = new ReduceTartar();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - Crest 3D White";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(750, 500);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14, FontStyle.Regular);
            Font fontBold14 = new Font("Segoe UI", 14, FontStyle.Bold);

            // --- Image Panel ---
            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(20, 20);
            imgPanel.Size = new Size(240, 240);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;
            imgPanel.Padding = new Padding(5);

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Whiter Teeth\Toothpaste\Crest 3d White.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            // --- Image Caption ---
            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Crest 3D White";
            lblImageCaption.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 30);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 5);
            dialog.Controls.Add(lblImageCaption);

            // --- Info Panel ---
            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(280, 20);
            infoPanel.Size = new Size(440, 400);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            // --- Scrollable Content ---
            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 410;

            // --- Product Labels ---
            Label lblName = new Label();
            lblName.Text = "Crest 3D White Radiant Mint";
            lblName.Font = fontBold14;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 319";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Whitens teeth by removing surface stains.\nSafe for daily use.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(400, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            // --- Ingredients ---
            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Sorbitol\n" +
                "- Water\n" +
                "- Hydrated Silica\n" +
                "- PEG-6\n" +
                "- Sodium Hexametaphosphate\n" +
                "- Cocamidopropyl Betaine\n" +
                "- Flavor\n" +
                "- Zinc Citrate\n" +
                "- Sodium Fluoride\n" +
                "- Xanthan Gum\n" +
                "- Sodium Saccharin\n" +
                "- Blue 1";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(400, 280);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            // --- Where to Buy ---
            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(400, 125);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            // --- Add to content ---
            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);

            // --- Auto adjust height ---
            int contentHeight = lblBuy.Bottom + 10;
            content.Size = new Size(410, contentHeight);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            // --- OK Button ---
            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Click += (s, args) => dialog.Close();
            dialog.Controls.Add(okBtn);

            // --- Show Dialog ---
            dialog.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - iSmile Ultrasonic Tooth Cleaner";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(750, 500);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14, FontStyle.Regular);
            Font fontBold14 = new Font("Segoe UI", 14, FontStyle.Bold);

            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(20, 20);
            imgPanel.Size = new Size(240, 240);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;
            imgPanel.Padding = new Padding(5);

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Reduce Tartar\Dental Tools\philips sonicare.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "iSmile Ultrasonic Tooth Cleaner";
            lblImageCaption.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 30);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 5);
            dialog.Controls.Add(lblImageCaption);

            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(280, 20);
            infoPanel.Size = new Size(440, 400);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 410;

            Label lblName = new Label();
            lblName.Text = "iSmile Ultrasonic Electric Tooth Cleaner";
            lblName.Font = fontBold14;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 1,878";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Removes tartar and plaque buildup effectively.\nUses ultrasonic vibrations for deep cleaning.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(400, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblFeatures = new Label();
            lblFeatures.Text = "Features:\n" +
                "- Ultrasonic technology\n" +
                "- Safe for enamel\n" +
                "- USB rechargeable\n" +
                "- Waterproof design\n" +
                "- Suitable for daily or weekly use";
            lblFeatures.Font = font14;
            lblFeatures.ForeColor = Color.Black;
            lblFeatures.Size = new Size(400, 150);
            lblFeatures.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Shopee\n- Lazada\n- Amazon\n- Official website";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(400, 100);
            lblBuy.Location = new Point(0, lblFeatures.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblFeatures);
            content.Controls.Add(lblBuy);

            content.Size = new Size(410, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Click += (s, args) => dialog.Close();
            dialog.Controls.Add(okBtn);

            dialog.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - GUM Soft-Picks";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(750, 450);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14, FontStyle.Regular);
            Font fontBold14 = new Font("Segoe UI", 14, FontStyle.Bold);

            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(20, 20);
            imgPanel.Size = new Size(240, 240);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;
            imgPanel.Padding = new Padding(5);

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Reduce Tartar\Dental Tools\gum soft picks.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "GUM Soft-Picks";
            lblImageCaption.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 30);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 5);
            dialog.Controls.Add(lblImageCaption);

            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(280, 20);
            infoPanel.Size = new Size(440, 340);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 410;

            Label lblName = new Label();
            lblName.Text = "GUM Soft-Picks Original";
            lblName.Font = fontBold14;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 1878";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Gentle rubber bristles remove food and plaque between teeth.\nGreat alternative to flossing for sensitive gums.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(400, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblFeatures = new Label();
            lblFeatures.Text = "Features:\n" +
                "- Soft rubber bristles\n" +
                "- Gentle on gums\n" +
                "- Ideal for braces and implants\n" +
                "- Compact travel case included";
            lblFeatures.Font = font14;
            lblFeatures.ForeColor = Color.Black;
            lblFeatures.Size = new Size(400, 130);
            lblFeatures.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(400, 125);
            lblBuy.Location = new Point(0, lblFeatures.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblFeatures);
            content.Controls.Add(lblBuy);

            content.Size = new Size(410, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Click += (s, args) => dialog.Close();
            dialog.Controls.Add(okBtn);

            dialog.ShowDialog();
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

        private void ReduceTartarTools_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersToPanel(panel2, 30);
            ApplyRoundedCornersToPanel(panel3, 30);
            ApplyRoundedCornersToPanel(panel4, 30);
        }
    }
}
