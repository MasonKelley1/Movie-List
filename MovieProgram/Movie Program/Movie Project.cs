namespace Movie_Program
{
    public partial class frmMovieProject : Form
    {
        String line;
        int lineNum = 1;

        public void ReadFromTextFile()
        {
            string fileName = "E:\\movies to watch.txt";
            List<string> lines = File.ReadAllLines(fileName).ToList();

            foreach (string Item in lines)
            {
                lstMovieList.Items.Add(lineNum + "- " + Item);

                lineNum++;
            }
        }

        public frmMovieProject()
        {
            InitializeComponent();

            ReadFromTextFile();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newMov = new AddMovie();
            this.Hide();
            newMov.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var remMov = new RemoveMovie();
            this.Hide();
            remMov.Show();
        }
    }
}