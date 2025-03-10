namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.Text);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox.Text) && !listBox.Items.Contains(textBox.Text))
            {
                listBox.Items.Add(textBox.Text);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}