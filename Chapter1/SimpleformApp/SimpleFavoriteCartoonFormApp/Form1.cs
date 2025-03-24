namespace SimpleFavoriteCartoonFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cartoonCharacters = { "Bob", "Helen", "Violet", "Dash", "Jack-Jack", };
            comboBox.Items.AddRange(cartoonCharacters);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                MessageBox.Show("Please Select a character", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedChar = comboBox.SelectedItem.ToString() ?? "";
            Image? characterImage = null;

            using (MemoryStream ms = new MemoryStream())
            {
                switch (selectedChar)
                {
                    case "Bob":
                        ms.Write(Properties.Resources.bob, 0, Properties.Resources.bob.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                    case "Helen":
                        ms.Write(Properties.Resources.helen, 0, Properties.Resources.helen.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                    case "Violet":
                        ms.Write(Properties.Resources.violet, 0, Properties.Resources.violet.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                    case "Dash":
                        ms.Write(Properties.Resources.dash, 0, Properties.Resources.dash.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                    case "Jack-Jack":
                        ms.Write(Properties.Resources.jack, 0, Properties.Resources.jack.Length);
                        characterImage = Image.FromStream(ms);
                        break;
                }
            }
            pictureBox.Image = characterImage;
        }
        private void clrBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
