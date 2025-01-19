namespace Movie_Program
{
    partial class RemoveMovie
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
            lstRemoveMovieList = new ListBox();
            lblRemove = new Label();
            txtRemove = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lstRemoveMovieList
            // 
            lstRemoveMovieList.FormattingEnabled = true;
            lstRemoveMovieList.ItemHeight = 15;
            lstRemoveMovieList.Location = new Point(12, 12);
            lstRemoveMovieList.Name = "lstRemoveMovieList";
            lstRemoveMovieList.Size = new Size(351, 169);
            lstRemoveMovieList.TabIndex = 0;
            // 
            // lblRemove
            // 
            lblRemove.BorderStyle = BorderStyle.Fixed3D;
            lblRemove.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblRemove.Location = new Point(12, 184);
            lblRemove.Name = "lblRemove";
            lblRemove.Size = new Size(351, 50);
            lblRemove.TabIndex = 1;
            lblRemove.Text = "Which movie do you want to remove? (type the number)";
            // 
            // txtRemove
            // 
            txtRemove.Location = new Point(12, 237);
            txtRemove.Name = "txtRemove";
            txtRemove.Size = new Size(100, 23);
            txtRemove.TabIndex = 2;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 266);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(167, 35);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete Movie";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(185, 266);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(178, 35);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // RemoveMovie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(375, 317);
            Controls.Add(btnCancel);
            Controls.Add(btnDelete);
            Controls.Add(txtRemove);
            Controls.Add(lblRemove);
            Controls.Add(lstRemoveMovieList);
            Name = "RemoveMovie";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RemoveMovie";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRemoveMovieList;
        private Label lblRemove;
        private TextBox txtRemove;
        private Button btnDelete;
        private Button btnCancel;
    }
}