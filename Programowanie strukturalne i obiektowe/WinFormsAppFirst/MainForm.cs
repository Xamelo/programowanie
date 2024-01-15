namespace WinFormsAppFirst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBoxFavouriteMeal.SelectedIndex = 1;

            labelCurrentTime.Text = DateTime.Now.ToString();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            string schoolSubject = "Fav subjects: ";
            if (checkBoxSchoolSubjectMathematics.Checked)
            {
                schoolSubject += "math ";
            }
            if (checkBoxSchoolSubjectEnglish.Checked)
            {
                schoolSubject += "english ";
            }

            string pizzaWithPineapple = "";
            if (radioButtonPizzaQuestionYes.Checked)
            {
                pizzaWithPineapple = name + " likes pizza with pineapple xd";
            }
            else
            {
                pizzaWithPineapple = name + " is normal xd";
            }

            string favouriteMeal = comboBoxFavouriteMeal.Text;

            MessageBox.Show($"Hello {name} in first program\n" +
                $"\n{schoolSubject}" +
                $"\n{pizzaWithPineapple}" +
                $"\nFavourite meal: {favouriteMeal}",
                "Announcement",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2
                );
        }

        private void buttonRefreshTime_Click(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString();
            timerRefreshTime.Enabled = !timerRefreshTime.Enabled;
        }

        private void timerRefreshTime_Tick(object sender, EventArgs e)
        {
            labelCurrentTime.Text = DateTime.Now.ToString();
        }

        private void labelMouseClick_MouseClick(object sender, MouseEventArgs e)
        {
            /*if (e.Button == MouseButtons.Left)
                labelMouseClick.Text = "Left click";
            if (e.Button == MouseButtons.Right)
                labelMouseClick.Text = "Right click";*/
            
            labelMouseClick.Text = e.Button.ToString() + " click";
        }
    }
}