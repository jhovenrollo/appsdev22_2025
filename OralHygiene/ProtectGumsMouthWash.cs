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
    public partial class ProtectGumsMouthWash: Form
    {
        public ProtectGumsMouthWash()
        {
            InitializeComponent();
            this.Load += ProtectGumsMouthWash_Load;

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

        private void button1_Click(object sender, EventArgs e)
        {
            ProtectGums loginForm = new ProtectGums();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - ACT Mouthwash Anticavity Fluoride";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\protect Gums\Mouthwash\act mouthwash anticavity fluoride.jpeg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "ACT Mouthwash Anticavity Fluoride";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "ACT Mouthwash Anticavity Fluoride";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 573";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Strengthens teeth and helps prevent cavities.\nAlcohol-free formula with fluoride protection.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Sodium Fluoride\n" +
                "- Water\n" +
                "- Sorbitol\n" +
                "- Propylene Glycol\n" +
                "- Poloxamer 407\n" +
                "- Flavor\n" +
                "- Benzoic Acid\n" +
                "- Sucralose\n" +
                "- Sodium Benzoate\n" +
                "- Blue 1";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 220);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 80);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Click += (s, args) => dialog.Close();
            dialog.Controls.Add(okBtn);

            dialog.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - Colgate Total Advanced Pro-Shield Mouthwash";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\protect Gums\Mouthwash\colgate total advanced pro-shield mouthwash.jpeg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Colgate Total Advanced Pro-Shield Mouthwash";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "Colgate Total Advanced Pro-Shield Mouthwash";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 1,299";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Kills 99% of germs, even after eating and drinking.\nProvides 12-hour protection against bad breath.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Cetylpyridinium Chloride\n" +
                "- Water\n" +
                "- Glycerin\n" +
                "- Propylene Glycol\n" +
                "- Poloxamer 407\n" +
                "- Flavor\n" +
                "- Sodium Saccharin\n" +
                "- Benzoic Acid\n" +
                "- Sucralose\n" +
                "- Blue 1";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 220);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 80);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Click += (s, args) => dialog.Close();
            dialog.Controls.Add(okBtn);

            dialog.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - Crest Pro-Health Multi-Protection";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\protect Gums\Mouthwash\crest pro-health multi-protection.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Crest Pro-Health Multi-Protection";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "Crest Pro-Health Multi-Protection";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 573.41";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Alcohol-free mouthwash that kills 99% of germs.\nProtects against plaque, gingivitis, and bad breath.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Cetylpyridinium Chloride\n" +
                "- Water\n" +
                "- Glycerin\n" +
                "- Propylene Glycol\n" +
                "- Sodium Hexametaphosphate\n" +
                "- Flavor\n" +
                "- Sodium Saccharin\n" +
                "- Blue 1\n" +
                "- Sucralose";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 200);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 80);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            okBtn.Click += (s, args) => dialog.Close();
            dialog.Controls.Add(okBtn);

            dialog.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - Listerine Antiseptic Original Mouthwash";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\protect Gums\Mouthwash\listerine antiseptic original mouthwash.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Listerine Antiseptic Original Mouthwash";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "Listerine Antiseptic Original Mouthwash";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 424.95";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Kills 99.9% of germs that cause bad breath, plaque, and gingivitis.\nClinically proven and trusted by dentists.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Water\n" +
                "- Alcohol (26.9%)\n" +
                "- Thymol\n" +
                "- Eucalyptol\n" +
                "- Methyl Salicylate\n" +
                "- Menthol\n" +
                "- Benzoic Acid\n" +
                "- Poloxamer 407\n" +
                "- Sodium Benzoate\n" +
                "- Caramel";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 240);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 80);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            Button okBtn = new Button();
            okBtn.Text = "OK";
            okBtn.Size = new Size(80, 35);
            okBtn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            okBtn.BackColor = Color.White;
            okBtn.FlatStyle = FlatStyle.Flat;
            okBtn.Location = new Point(dialog.ClientSize.Width - 100, dialog.ClientSize.Height - 60);
            okBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
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
        private void ProtectGumsMouthWash_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersToPanel(panel2, 30); 
            ApplyRoundedCornersToPanel(panel1, 30);
            ApplyRoundedCornersToPanel(panel3, 30);
            ApplyRoundedCornersToPanel(panel4, 30);
        }
    }
}
