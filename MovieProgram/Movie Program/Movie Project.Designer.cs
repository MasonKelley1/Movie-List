namespace Movie_Program
{
    partial class frmMovieProject
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpList = new GroupBox();
            lstMovieList = new ListBox();
            btnAdd = new Button();
            btnRemove = new Button();
            bindingSource1 = new BindingSource(components);
            btnGetRandom = new Button();
            grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // grpList
            // 
            grpList.Controls.Add(lstMovieList);
            grpList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grpList.Location = new Point(12, 12);
            grpList.Name = "grpList";
            grpList.Size = new Size(440, 461);
            grpList.TabIndex = 0;
            grpList.TabStop = false;
            grpList.Text = "Movie List";
            // 
            // lstMovieList
            // 
            lstMovieList.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lstMovieList.FormattingEnabled = true;
            lstMovieList.ItemHeight = 17;
            lstMovieList.Location = new Point(6, 22);
            lstMovieList.Name = "lstMovieList";
            lstMovieList.Size = new Size(428, 429);
            lstMovieList.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(12, 477);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(177, 42);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "&Add Movie";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(195, 477);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(147, 42);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "&Remove Movie";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnGetRandom
            // 
            btnGetRandom.Location = new Point(348, 477);
            btnGetRandom.Name = "btnGetRandom";
            btnGetRandom.Size = new Size(104, 42);
            btnGetRandom.TabIndex = 4;
            btnGetRandom.Text = "&Click to get random movie";
            btnGetRandom.UseVisualStyleBackColor = true;
            // 
            // frmMovieProject
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 519);
            Controls.Add(btnGetRandom);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(grpList);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "frmMovieProject";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Movie Project";
            grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpList;
        private ListBox lstMovieList;
        private Button btnRemove;
        private Button btnAdd;
        private BindingSource bindingSource1;
        private Button btnGetRandom;
    }
}