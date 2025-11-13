using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M17A_Library.Book
{
    public partial class fBook : Form
    {
        string coverImageFileName = "";
        Database database;

        public fBook(Database database)
        {
            InitializeComponent();

            this.database = database;
        }

        private void B_OpenFile_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.Filter = "Imagens |*.jpg;*.jpeg;*.png; | Todos os ficheiros | *.*";
            file.InitialDirectory = "C:\\";
            file.Multiselect = false;

            if (file.ShowDialog() == DialogResult.OK)
            {
                string f = file.FileName;

                if (System.IO.File.Exists(f))
                {
                    PB_CoverImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    PB_CoverImage.Image = Image.FromFile(f);
                    coverImageFileName = f;
                }
            }
        }

        private void B_Save_Click(object sender, EventArgs e)
        {
            Book newBook = new Book();

            newBook.title = TB_Title.Text;
            newBook.isbn = TB_ISBN.Text;
            newBook.year = int.Parse(TB_Year.Text);
            newBook.author = TB_Author.Text;
            newBook.aquisitionDate = DTP_AquisitionDate.Value;
            newBook.price = decimal.Parse(TB_Price.Text);
            newBook.coverImage = Utilities.ProgrammFolder("M17A_Library") + @"\" + newBook.isbn;
            newBook.state = true;

            List<string> errors = newBook.Validate();

            if (errors.Count > 0)
            {
                string message = "";

                foreach (string error in errors)
                {
                    message += error + "; ";
                }

                LB_Feedback.Text = message;
                LB_Feedback.ForeColor = Color.Red;

                return;
            }

            newBook.Add();
        }
    }
}
