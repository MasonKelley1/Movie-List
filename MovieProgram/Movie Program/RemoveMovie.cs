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
    public partial class RemoveMovie : Form
    {
        int lineNum = 1;
        int lineBeingDeleted;
        

        public RemoveMovie()
        {
            InitializeComponent();

            string fileName = "E:\\movies to watch.txt";
            List<string> lines = File.ReadAllLines(fileName).ToList();

            foreach (string Item in lines)
            {
                lstRemoveMovieList.Items.Add(lineNum + "- " + Item);

                lineNum++;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string fileName = "E:\\movies to watch.txt";
            List<string> lines = File.ReadAllLines(fileName).ToList();

            bool chosenLineSuccess = int.TryParse(txtRemove.Text, out lineBeingDeleted);
            if (chosenLineSuccess)
            {
                lines.RemoveAt(lineBeingDeleted - 1);
                File.WriteAllLines(fileName, lines.ToArray());
            }

            this.Close();
            Form movieProject = new frmMovieProject();
            movieProject.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Form movieProject = new frmMovieProject();
            movieProject.ShowDialog();
        }
    }
}
