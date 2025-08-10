namespace ActivityManager
{
    public partial class Form1 : Form
    {
        public List<string> Tags;
        public Form1()
        {
            InitializeComponent();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {

        }

        private void titel_Click(object sender, EventArgs e)
        {

        }

        private void allButton_Click(object sender, EventArgs e)
        {

        }

        private void mainListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bearbeitenButton_Click(object sender, EventArgs e)
        {
            BearbeitenFenster bearbeiten = new BearbeitenFenster();
            bearbeiten.ShowDialog();
        }
    }
}
