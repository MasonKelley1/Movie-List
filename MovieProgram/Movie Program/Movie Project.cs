namespace Movie_Program
{
    public partial class frmMovieProject : Form
    {
        String line;
        int lineNum = 1;
        public frmMovieProject()
        {
            InitializeComponent();

            try
            {
                StreamReader sr = new StreamReader("E:\\movies to watch.txt");

                line = sr.ReadLine();

                while (line != null)
                {

                    lstMovieList.Items.Add(lineNum.ToString() + line);
                    lineNum += 1;

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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