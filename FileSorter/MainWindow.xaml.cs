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

namespace FileSorter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WinForms.FolderBrowserDialog _folderBrowserDialog = new WinForms.FolderBrowserDialog();
        private string _fromPath;
        private string _toPath;
        private string _imagePath;
        private string _newFolderName;


        public MainWindow()
        {
            InitializeComponent();
        }

       public string FromPath
        {
            get{ return _fromPath; }

            set {_fromPath = value;}
        }


        private void SelectFromPath(object sender, RoutedEventArgs e)
        {
            var result = _folderBrowserDialog.ShowDialog();
        }
    }
}
