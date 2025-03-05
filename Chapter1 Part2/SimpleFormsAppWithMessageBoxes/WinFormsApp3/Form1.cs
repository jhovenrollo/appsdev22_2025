namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            String fNameValue = firstName.Text;
            String mNameValue = middleName.Text;
            String lNameValue = lastName.Text;
            String sNameValue = suffix.Text;

            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Hello there! {fNameValue} {mNameValue} {lNameValue} {sNameValue}", "Greetings!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Submission was cancelled", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                                                                    
        }
    }
}
