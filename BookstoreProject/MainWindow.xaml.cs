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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Win32;

namespace BookstoreProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BookList bl = new BookList();
        private BookstoresList bs = new BookstoresList();
        
        public MainWindow()
        {
            InitializeComponent();
            lwBooks.ItemsSource = bl.Books;
        }

        public void BooksViewRefresh()
        {
            lwBooks.ItemsSource = null;
            lwBooks.ItemsSource = bl.Books;
        }

        private void lwBooks_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (btnAdd.IsEnabled = btnEdit.IsEnabled = btnDelete.IsEnabled = lwBooks.SelectedIndex != -1)
            {
                this.DataContext=(BookList)lwBooks.SelectedItem;
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddBookWindow addBookWindow = new AddBookWindow(ref bl);
            addBookWindow.Show();
        }


        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditBookWindow editBookWindow = new EditBookWindow(ref bl, (Books)lwBooks.SelectedItem);
            editBookWindow.Show();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Books item = (Books)lwBooks.SelectedItem;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Delete book " + item.Name + "?", "Delete Confirmation", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                bl.Delete(item);
                BooksViewRefresh();
            }
        }

        private void txtSearchBook_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {
                BooksViewRefresh();
            }
            else
            {
                if(((TextBox)sender).Name == "txtSearchBook")
                {
                    lwBooks.ItemsSource = bl.Search(((TextBox)sender).Text);
                }
            }
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            Books books = (Books)lwBooks.SelectedItem;
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show(bl.Info(books));
        }
        private void importBooks_Click(object sender, RoutedEventArgs e)
        {
            string path = getImportFilePath();
            if (path != null)
            {
                bl.ReadData(path);
                BooksViewRefresh();
            }
        }
        private string getImportFilePath()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (openFileDialog.ShowDialog() == true)
                return openFileDialog.FileName;
            else
                return null;
        }
        private void exportBooks_Click(object sender, RoutedEventArgs e)
        {
            string path = getExportFilePath();
            if (path != null)
            {
                bl.WriteData(path);
            }
        }
        private string getExportFilePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (saveFileDialog.ShowDialog() == true)
                return saveFileDialog.FileName;
            else
                return null;
        }
    }
}
