using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookstoreProject
{
    public class EditBookWindow : BookWindow
    {
        private Books b;
        public EditBookWindow(ref BookList bookList, Books book) : base(ref bookList)
        {
            Title = "Edit book " + book.Name;
            btnConfirm.Content = "Edit";
            b = book;
            txtName.Text = b.Name;
            txtAuthor.Text = b.Author;
            txtYear.Text = b.Year.ToString();
            txtPrice.Text = b.Price.ToString();
        }
        protected override void confirmAct()
        {
            bl.Edit(b, (string)txtName.Text, (string)txtAuthor.Text, int.Parse(txtYear.Text), decimal.Parse(txtPrice.Text));
        }
    }
}
