using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Program
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form movieProject = new frmMovieProject();
            this.Close();
            movieProject.ShowDialog();
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {

        }
    }
}
