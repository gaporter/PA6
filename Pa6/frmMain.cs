using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pa6
{
    public partial class frmMain : Form
    {
        string cwid;
        List<Book> myBooks;
        public frmMain(string tempCwid)
        {
            this.cwid = tempCwid;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadList();
            
        }
        private void LoadList()
        {
            myBooks = BookFile.GetAllBooks(cwid);
            lstBooks.DataSource = myBooks;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book myBook = (Book)lstBooks.SelectedItem;

            txtTitleData.Text = myBook.title;
            txtAuthorData.Text = myBook.author;
            txtGenreData.Text = myBook.genre;
            txtCopiesData.Text = myBook.copies.ToString();
            txtLengthData.Text = myBook.length.ToString();


        }
    }
}
