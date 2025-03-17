namespace SimpleFormsAppWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] foodCuisine = { "Italian", "Chinese", "Filipino", "Mexican", "Indian", "Japanese" };
            comboBox.Items.AddRange(foodCuisine);

            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.SelectedIndex = 0;
        }

        private void addBtn_Click_1(object sender, EventArgs e)
        {
            foreach (var item in foodCheckedBox.Items)
            {
                bool isSelected = foodCheckedBox.GetItemChecked(foodCheckedBox.Items.IndexOf(item));
                if (isSelected && !foodListBox.Items.Contains(item))
                {
                    foodListBox.Items.Add(item);
                }
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selBtn_Click(object sender, EventArgs e)
        {
            string[] italianFood = { "Lasagna", "Risotto", "Cacio e pepe", "Pizza", "Spaghetti" };
            string[] chineseFood = { "Chow mein", "Fried rice", "Peking duck", "Spring rolls", "Mapo tofu" };
            string[] filipinoFood = { "Adobo", "Sinigang", "Sisig", "Lechon", "Bicol Express" };
            string[] mexicanFood = { "Cemita", "Chilaquiles", "Menudo", "Sopes", "Molotes" };
            string[] indianFood = { "Chicken Biryani", "Chana Masala", "Vegetable Curry", "Rogan Josh", "Butter Chicken" };
            string[] japaneseFood = { "Sushi", "Ramen", "Okonomiyaki", "Tempura", "Takoyaki" };

            foodCheckedBox.Items.Clear();

            if (comboBox.SelectedItem.ToString().Contains("Italian"))
            {
                foodCheckedBox.Items.AddRange(italianFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Chinese"))
            {
                foodCheckedBox.Items.AddRange(chineseFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Filipino"))
            {
                foodCheckedBox.Items.AddRange(filipinoFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Mexican"))
            {
                foodCheckedBox.Items.AddRange(mexicanFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Indian"))
            {
                foodCheckedBox.Items.AddRange(indianFood);
            }
            else if (comboBox.SelectedItem.ToString().Contains("Japanese"))
            {
                foodCheckedBox.Items.AddRange(japaneseFood);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (foodListBox.Items.Count >= 1)
            {
                foodListBox.Items.Remove(foodListBox.SelectedItem);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            foodListBox.Items.Clear();
        }
    }
}
