namespace Movie_Program
{
    public partial class frmMovieProject : Form
    {
        public frmMovieProject()
        {
            InitializeComponent();
        }

        public List<string> movieList = new List<string>();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newMov = new AddMovie();
            this.Hide();
            newMov.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}