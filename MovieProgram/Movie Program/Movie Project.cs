namespace Movie_Program
{
    public partial class frmMovieProject : Form
    {
        String line;
        public frmMovieProject()
        {
            InitializeComponent();

            try
            {
                StreamReader sr = new StreamReader("E:\\movies to watch.txt");

                line = sr.ReadLine();

                while (line != null)
                {
                    lstMovieList.Items.Add(line);

                    line = sr.ReadLine();
                }

                sr.Close();
            }
            catch(Exception ex)
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
    }
}