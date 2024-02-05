namespace Zadanie
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String email = textBoxMail.Text;

            if (!(email.Contains("@")))
            {
                labelCommunication.Text = "Nieprawid�owy adres e-mail";
            }
            else if (!(textBoxPassword.Text == textBoxRepeatPass.Text))
            {
                labelCommunication.Text = "Has�a si� r�ni�";
            }
            else
                labelCommunication.Text = $"Witaj {email}";
        }
    }
}