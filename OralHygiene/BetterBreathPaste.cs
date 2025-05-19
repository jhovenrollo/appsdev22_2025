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
    public partial class BetterBreathPaste: Form
    {
        public BetterBreathPaste()
        {
            InitializeComponent();
            this.Load += BetterBreathPaste_Load;

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
            BetterBreath loginForm = new BetterBreath();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - Closeup Menthol Fresh Toothpaste";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(800, 500);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14);
            Font fontBold16 = new Font("Segoe UI", 16, FontStyle.Bold);

            // ----- IMAGE PANEL -----
            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(30, 30);
            imgPanel.Size = new Size(250, 270);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Better Breath\Toothpaste\Closeup Menthol Fresh Toothpaste.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            // Label under image
            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Closeup Menthol Fresh Toothpaste";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            // ----- INFO PANEL -----
            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "Closeup Menthol Fresh Toothpaste";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 2030";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Keeps your breath fresh for hours.\nMenthol-rich formula for cooling and antibacterial protection.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Sorbitol\n" +
                "- Hydrated Silica\n" +
                "- Sodium Lauryl Sulfate\n" +
                "- Flavor\n" +
                "- Cellulose Gum\n" +
                "- Sodium Fluoride\n" +
                "- Sodium Saccharin\n" +
                "- Menthol";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 230);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 125);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            // OK Button
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
            dialog.Text = "Product Details - Sensodyne Pronamel Fresh Breath Toothpaste";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(800, 500);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14);
            Font fontBold16 = new Font("Segoe UI", 16, FontStyle.Bold);

            // ----- IMAGE PANEL -----
            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(30, 30);
            imgPanel.Size = new Size(250, 270);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Better Breath\Toothpaste\sensodyne pronamel fresh breath toothpaste.jpeg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            // Label under image
            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Sensodyne Pronamel Fresh Breath";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            // ----- INFO PANEL -----
            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "Sensodyne Pronamel Fresh Breath";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 166.00";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Helps protect enamel from acid erosion.\nFreshens breath while providing long-lasting sensitivity relief.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Water\n" +
                "- Sorbitol\n" +
                "- Hydrated Silica\n" +
                "- Glycerin\n" +
                "- Potassium Nitrate\n" +
                "- Sodium Fluoride\n" +
                "- Flavor\n" +
                "- Sodium Saccharin";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 230);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 125);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            // OK Button
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
            dialog.Text = "Product Details - Crest Pro-Health Advanced Toothpaste";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(800, 500);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14);
            Font fontBold16 = new Font("Segoe UI", 16, FontStyle.Bold);

            // ----- IMAGE PANEL -----
            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(30, 30);
            imgPanel.Size = new Size(250, 270);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Better Breath\Toothpaste\Crest Pro-Health Clean Mint Toothpaste.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            // Label under image
            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Crest Pro-Health Advanced";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            // ----- INFO PANEL -----
            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "Crest Pro-Health Advanced Toothpaste";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 534.11";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Protects against plaque, gingivitis, acid erosion, sensitivity, and bad breath.\nGives a clean mint flavor for all-day freshness.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Stannous Fluoride\n" +
                "- Sorbitol\n" +
                "- Water\n" +
                "- Hydrated Silica\n" +
                "- Sodium Lauryl Sulfate\n" +
                "- Flavor\n" +
                "- Xanthan Gum\n" +
                "- Sodium Saccharin\n" +
                "- Titanium Dioxide";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 230);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 125);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            // OK Button
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
            dialog.Text = "Product Details - TheraBreath Toothpaste";
            dialog.FormBorderStyle = FormBorderStyle.FixedDialog;
            dialog.StartPosition = FormStartPosition.CenterParent;
            dialog.ClientSize = new Size(800, 500);
            dialog.MaximizeBox = false;
            dialog.MinimizeBox = false;
            dialog.BackColor = Color.FromArgb(111, 144, 139);

            Font font14 = new Font("Segoe UI", 14);
            Font fontBold16 = new Font("Segoe UI", 16, FontStyle.Bold);

            // ----- IMAGE PANEL -----
            Panel imgPanel = new Panel();
            imgPanel.Location = new Point(30, 30);
            imgPanel.Size = new Size(250, 270);
            imgPanel.BackColor = Color.White;
            imgPanel.BorderStyle = BorderStyle.FixedSingle;

            PictureBox img = new PictureBox();
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Better Breath\Toothpaste\TheraBreath1234.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            // Label under image
            Label lblImageCaption = new Label();
            lblImageCaption.Text = "TheraBreath Toothpaste";
            lblImageCaption.Font = fontBold16;
            lblImageCaption.ForeColor = Color.Black;
            lblImageCaption.TextAlign = ContentAlignment.MiddleCenter;
            lblImageCaption.Size = new Size(imgPanel.Width, 40);
            lblImageCaption.Location = new Point(imgPanel.Left, imgPanel.Bottom + 10);
            dialog.Controls.Add(lblImageCaption);

            // ----- INFO PANEL -----
            Panel infoPanel = new Panel();
            infoPanel.Location = new Point(310, 30);
            infoPanel.Size = new Size(450, 370);
            infoPanel.AutoScroll = true;
            infoPanel.BackColor = Color.FromArgb(245, 250, 252);

            Panel content = new Panel();
            content.Location = new Point(10, 10);
            content.Width = 420;

            Label lblName = new Label();
            lblName.Text = "TheraBreath Toothpaste";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 580.92";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Fights bad breath, promotes healthy gums, and helps control plaque.\nScientifically formulated with oxygenating compounds.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Ingredients:\n" +
                "- Purified Water\n" +
                "- Aloe Vera Gel\n" +
                "- Xylitol\n" +
                "- Sodium Bicarbonate\n" +
                "- Natural Flavors\n" +
                "- Sodium Benzoate\n" +
                "- Sodium Chlorite\n" +
                "- Green Tea Extract\n" +
                "- CoQ10";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 230);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 125);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
            content.Size = new Size(420, lblBuy.Bottom + 10);
            infoPanel.Controls.Add(content);
            dialog.Controls.Add(infoPanel);

            // OK Button
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
        private void BetterBreathPaste_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersToPanel(panel2, 30); 
            ApplyRoundedCornersToPanel(panel1, 30);
            ApplyRoundedCornersToPanel(panel3, 30);
            ApplyRoundedCornersToPanel(panel4, 30);
        }
    }
}
