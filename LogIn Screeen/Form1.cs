namespace LogIn_Screeen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string username = usrtextbox.Text;
            string password = psswrdtextbox.Text;
            MessageBox.Show($"Username: {username}\nPassword: {password}");
        }
    }
}
