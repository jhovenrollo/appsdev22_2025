﻿using System;
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
    public partial class ReduceTartarPaste: Form
    {
        public ReduceTartarPaste()
        {
            InitializeComponent();

            this.Load += ReduceTartarPaste_Load;

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


        private void button1_Click(object sender, EventArgs e)
        {
            ReduceTartar loginForm = new ReduceTartar();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form dialog = new Form();
            dialog.Text = "Product Details - Colgate Total Clean Mint";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Reduce Tartar\Toothpaste\Colgate total.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Colgate Total Clean Mint";
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
            lblName.Text = "Colgate Total Clean Mint";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 160";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Provides 12-hour protection against germs.\nFights cavities, plaque, tartar buildup, and bad breath.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Includes:\n- Triclosan\n- Sodium Fluoride\n- Glycerin\n- Hydrated Silica\n- Flavor\n- Sodium Saccharin\n- Carrageenan";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 210);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 130);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);

            // ✅ Fix: Set height to enable scrolling properly
            content.Height = lblBuy.Bottom + 10;

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
            dialog.Text = "Product Details - Sensodyne Pronamel";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Reduce Tartar\Toothpaste\Sensodyne Pronamel.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Sensodyne Pronamel";
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
            content.AutoSize = true;
            content.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Label lblName = new Label();
            lblName.Text = "Sensodyne Pronamel";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 645";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Helps protect tooth enamel against acid erosion.\nStrengthens enamel and keeps teeth healthy.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Includes:\n- Water\n- Sorbitol\n- Hydrated Silica\n- Glycerin\n- PEG-8\n- Sodium Lauryl Sulfate\n- Flavor\n- Titanium Dioxide\n- Sodium Fluoride\n- Sodium Saccharin";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 225);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Watsons\n- Mercury Drug\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 130);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
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
            dialog.Text = "Product Details - Parodontax Clean Mint Toothpaste";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Reduce Tartar\Toothpaste\paradontax.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Parodontax Clean Mint Toothpaste";
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
            content.AutoSize = true;
            content.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Label lblName = new Label();
            lblName.Text = "Parodontax Clean Mint Toothpaste";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 555.11";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Clinically proven to help reduce plaque and bleeding gums.\nWith a clean mint flavor for fresh breath.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Includes:\n- Sodium Bicarbonate\n- Glycerin\n- Aqua\n- Cocamidopropyl Betaine\n- Aroma\n- Xanthan Gum\n- Sodium Fluoride";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 215);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Mercury Drug\n- Watsons\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 130);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
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
            dialog.Text = "Product Details - Crest Tartar Protection Toothpaste";
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
            img.Image = Image.FromFile(@"C:\Users\abell\OneDrive\Documents\ImageOralHygiene\UI for Products\Reduce Tartar\Toothpaste\crest white.jpg");
            img.SizeMode = PictureBoxSizeMode.Zoom;
            img.Dock = DockStyle.Fill;
            imgPanel.Controls.Add(img);
            dialog.Controls.Add(imgPanel);

            Label lblImageCaption = new Label();
            lblImageCaption.Text = "Crest Tartar Protection Toothpaste";
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
            content.AutoSize = true;

            Label lblName = new Label();
            lblName.Text = "Crest Tartar Protection Toothpaste";
            lblName.Font = fontBold16;
            lblName.ForeColor = Color.Black;
            lblName.AutoSize = true;
            lblName.Location = new Point(0, 0);

            Label lblPrice = new Label();
            lblPrice.Text = "Price: Php 149";
            lblPrice.Font = font14;
            lblPrice.ForeColor = Color.Black;
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(0, lblName.Bottom + 10);

            Label lblDesc = new Label();
            lblDesc.Text = "Provides protection against tartar build-up.\nStrengthens enamel and keeps breath fresh.";
            lblDesc.Font = font14;
            lblDesc.ForeColor = Color.Black;
            lblDesc.Size = new Size(420, 60);
            lblDesc.Location = new Point(0, lblPrice.Bottom + 10);

            Label lblIngredients = new Label();
            lblIngredients.Text = "Includes:\n- Sodium Fluoride\n- Hydrated Silica\n- Sodium Lauryl Sulfate\n- Trisodium Phosphate\n- Flavor\n- Cellulose Gum";
            lblIngredients.Font = font14;
            lblIngredients.ForeColor = Color.Black;
            lblIngredients.Size = new Size(420, 200);
            lblIngredients.Location = new Point(0, lblDesc.Bottom + 10);

            Label lblBuy = new Label();
            lblBuy.Text = "Available at:\n- Mercury Drug\n- Watsons\n- Shopee\n- Lazada";
            lblBuy.Font = font14;
            lblBuy.ForeColor = Color.Black;
            lblBuy.Size = new Size(420, 130);
            lblBuy.Location = new Point(0, lblIngredients.Bottom + 10);

            content.Controls.Add(lblName);
            content.Controls.Add(lblPrice);
            content.Controls.Add(lblDesc);
            content.Controls.Add(lblIngredients);
            content.Controls.Add(lblBuy);
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

        private void ReduceTartarPaste_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersToPanel(panel2, 30); 
            ApplyRoundedCornersToPanel(panel1, 30);
            ApplyRoundedCornersToPanel(panel3, 30);
            ApplyRoundedCornersToPanel(panel4, 30);
        }
    }
}
