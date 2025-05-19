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
    public partial class WhiteTeeth: Form
    {
        public WhiteTeeth()
        {
            InitializeComponent();

            Color originalColor = Color.FromArgb(110, 152, 135);
            pictureBox4.MouseEnter += (s, ev) => pictureBox4.BackColor = Color.LightGray;
            pictureBox4.MouseLeave += (s, ev) => pictureBox4.BackColor = originalColor;

            pictureBox2.MouseEnter += (s, ev) => pictureBox2.BackColor = Color.LightGray;
            pictureBox2.MouseLeave += (s, ev) => pictureBox2.BackColor = originalColor;

            pictureBox3.MouseEnter += (s, ev) => pictureBox3.BackColor = Color.LightGray;
            pictureBox3.MouseLeave += (s, ev) => pictureBox3.BackColor = originalColor;

            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 1;
            button1.BackColor = Color.Transparent;

            this.Load += WhiteTeeth_Load;
        }

        private void ApplyRoundedCornersToControl(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Product loginForm = new Product();
            loginForm.Show();
            this.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WhiteTeethPaste loginForm = new WhiteTeethPaste();
            loginForm.Show();
            this.Close();

            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WhiteTeethMouthWash loginForm = new WhiteTeethMouthWash();
            loginForm.Show();
            this.Close();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            WhiteTeethTools loginForm = new WhiteTeethTools();
            loginForm.Show();
            this.Close();
        }

        private void WhiteTeeth_Load(object sender, EventArgs e)
        {
            ApplyRoundedCornersToControl(pictureBox4, 20);
            ApplyRoundedCornersToControl(pictureBox2, 20);
            ApplyRoundedCornersToControl(pictureBox3, 20);
        }
    }
}
