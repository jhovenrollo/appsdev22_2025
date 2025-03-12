namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] movies = { "Hello, Love, Again", "The Gorge", "Sonic the Hedgehog 3", "Baby John", "Phantom", "Train to Busan", "The Flu", "Sniper", "IT" };
            moviecheckedList.Items.AddRange(movies);

            moviecheckedList.CheckOnClick = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movies in moviecheckedList.Items)
            {
                bool isSelected = moviecheckedList.GetItemChecked(moviecheckedList.Items.IndexOf(movies));
                if (isSelected && !movieBoxList.Items.Contains(movies))
                {
                    movieBoxList.Items.Add(movies);
                }
            }

        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            if (movieBoxList.Items.Count >= 1) 
            {
                movieBoxList.Items.Remove(movieBoxList.SelectedItem);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            movieBoxList.Items.Clear();
        }
    }
}
