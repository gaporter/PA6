namespace Pa6
{
    partial class frmMain
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitleData = new System.Windows.Forms.TextBox();
            this.txtAuthorData = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtGenreData = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtCopiesData = new System.Windows.Forms.TextBox();
            this.lblCopies = new System.Windows.Forms.Label();
            this.txtIsbnData = new System.Windows.Forms.TextBox();
            this.lblSBN = new System.Windows.Forms.Label();
            this.txtLengthData = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelte = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(229, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(45, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // txtTitleData
            // 
            this.txtTitleData.Location = new System.Drawing.Point(233, 45);
            this.txtTitleData.Name = "txtTitleData";
            this.txtTitleData.Size = new System.Drawing.Size(148, 29);
            this.txtTitleData.TabIndex = 1;
            // 
            // txtAuthorData
            // 
            this.txtAuthorData.Location = new System.Drawing.Point(233, 106);
            this.txtAuthorData.Name = "txtAuthorData";
            this.txtAuthorData.Size = new System.Drawing.Size(148, 29);
            this.txtAuthorData.TabIndex = 3;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(229, 79);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(66, 24);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author";
            // 
            // txtGenreData
            // 
            this.txtGenreData.Location = new System.Drawing.Point(233, 167);
            this.txtGenreData.Name = "txtGenreData";
            this.txtGenreData.Size = new System.Drawing.Size(148, 29);
            this.txtGenreData.TabIndex = 5;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(229, 140);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(63, 24);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre";
            // 
            // txtCopiesData
            // 
            this.txtCopiesData.Location = new System.Drawing.Point(233, 231);
            this.txtCopiesData.Name = "txtCopiesData";
            this.txtCopiesData.Size = new System.Drawing.Size(148, 29);
            this.txtCopiesData.TabIndex = 7;
            // 
            // lblCopies
            // 
            this.lblCopies.AutoSize = true;
            this.lblCopies.Location = new System.Drawing.Point(229, 204);
            this.lblCopies.Name = "lblCopies";
            this.lblCopies.Size = new System.Drawing.Size(151, 24);
            this.lblCopies.TabIndex = 6;
            this.lblCopies.Text = "Copies Avalable ";
            // 
            // txtIsbnData
            // 
            this.txtIsbnData.Location = new System.Drawing.Point(233, 292);
            this.txtIsbnData.Name = "txtIsbnData";
            this.txtIsbnData.Size = new System.Drawing.Size(148, 29);
            this.txtIsbnData.TabIndex = 9;
            // 
            // lblSBN
            // 
            this.lblSBN.AutoSize = true;
            this.lblSBN.Location = new System.Drawing.Point(229, 265);
            this.lblSBN.Name = "lblSBN";
            this.lblSBN.Size = new System.Drawing.Size(52, 24);
            this.lblSBN.TabIndex = 8;
            this.lblSBN.Text = "ISBN";
            // 
            // txtLengthData
            // 
            this.txtLengthData.Location = new System.Drawing.Point(233, 352);
            this.txtLengthData.Name = "txtLengthData";
            this.txtLengthData.Size = new System.Drawing.Size(148, 29);
            this.txtLengthData.TabIndex = 11;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(229, 325);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 24);
            this.lblLength.TabIndex = 10;
            this.lblLength.Text = "Length";
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 24;
            this.lstBooks.Location = new System.Drawing.Point(12, 45);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(198, 340);
            this.lstBooks.TabIndex = 12;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.lstBooks_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(389, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 251);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(389, 336);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(97, 45);
            this.btnRent.TabIndex = 14;
            this.btnRent.Text = "Rent";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(508, 336);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(97, 45);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(234, 403);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 33);
            this.btnNew.TabIndex = 16;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(332, 403);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 33);
            this.btnEdit.TabIndex = 17;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelte
            // 
            this.btnDelte.Location = new System.Drawing.Point(433, 403);
            this.btnDelte.Name = "btnDelte";
            this.btnDelte.Size = new System.Drawing.Size(75, 33);
            this.btnDelte.TabIndex = 18;
            this.btnDelte.Text = "Delete";
            this.btnDelte.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(530, 403);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 33);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 458);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelte);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRent);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.txtLengthData);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtIsbnData);
            this.Controls.Add(this.lblSBN);
            this.Controls.Add(this.txtCopiesData);
            this.Controls.Add(this.lblCopies);
            this.Controls.Add(this.txtGenreData);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.txtAuthorData);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitleData);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMain";
            this.Text = "Audio Book Rental Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitleData;
        private System.Windows.Forms.TextBox txtAuthorData;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtGenreData;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtCopiesData;
        private System.Windows.Forms.Label lblCopies;
        private System.Windows.Forms.TextBox txtIsbnData;
        private System.Windows.Forms.Label lblSBN;
        private System.Windows.Forms.TextBox txtLengthData;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelte;
        private System.Windows.Forms.Button btnClose;
    }
}