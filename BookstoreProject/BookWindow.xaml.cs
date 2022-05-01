using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BookstoreProject
{
    /// <summary>
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public abstract partial class BookWindow : Window
    {
        protected BookList bl;
        public BookWindow(ref BookList bookList)
        {
            InitializeComponent();
            bl = bookList;
        }
        protected abstract void confirmAct();

        private void btnConfirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                confirmAct();
                ((MainWindow)Application.Current.MainWindow).BooksViewRefresh();
                this.Close();
            }
            catch (FormatException)
            {
                lblError.Content = "Invalid price or year format";
            }
            catch (Exception addException)
            {
                lblError.Content = addException.Message;
            }
        }

    }
}
