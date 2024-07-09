namespace Address_Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string name = nametextbox.Text;
            string email = EmailtextBox.Text;
            string phone = phonetextbox.Text;

            SaveToFile(name, email, phone);
        }

        private void SaveToFile(string name, string email, string phone)
        {
            string filePath = "\"C:\\Users\\HP\\source\\repos\\dcit318-assignment4-10945439\\Address Book\\AddressInfo.txt\"";
                MessageBox.Show("saved successfuly");
        }
    }

}
