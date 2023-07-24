namespace Movie_Program
{
    partial class AddMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rtbMovies = new RichTextBox();
            btnAddMovie = new Button();
            btnCancel = new Button();
            lblWarning = new Label();
            SuspendLayout();
            // 
            // rtbMovies
            // 
            rtbMovies.Location = new Point(12, 12);
            rtbMovies.Name = "rtbMovies";
            rtbMovies.Size = new Size(354, 154);
            rtbMovies.TabIndex = 0;
            rtbMovies.Text = "";
            // 
            // btnAddMovie
            // 
            btnAddMovie.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddMovie.Location = new Point(12, 172);
            btnAddMovie.Name = "btnAddMovie";
            btnAddMovie.Size = new Size(229, 34);
            btnAddMovie.TabIndex = 1;
            btnAddMovie.Text = "&Add Movie";
            btnAddMovie.UseVisualStyleBackColor = true;
            btnAddMovie.Click += btnAddMovie_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(247, 172);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 34);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblWarning
            // 
            lblWarning.BorderStyle = BorderStyle.Fixed3D;
            lblWarning.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblWarning.Location = new Point(12, 209);
            lblWarning.Name = "lblWarning";
            lblWarning.Size = new Size(354, 32);
            lblWarning.TabIndex = 3;
            lblWarning.Text = "NOTE: Each movie must be input on its own line. After entering movie, press enter to skip to next line and type next movie\r\n";
            // 
            // AddMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(378, 249);
            Controls.Add(lblWarning);
            Controls.Add(btnCancel);
            Controls.Add(btnAddMovie);
            Controls.Add(rtbMovies);
            MaximizeBox = false;
            Name = "AddMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddMovie";
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddMovie;
        private Button btnCancel;
        private RichTextBox rtbMovies;
        private Label lblWarning;
    }
}