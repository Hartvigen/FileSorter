using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
using WindForms = System.Windows.Forms;

namespace FileSorter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WindForms.FolderBrowserDialog _folderBrowserDialog = new WindForms.FolderBrowserDialog();
        private readonly string[] _imageExtensions = { ".png", ".jpg", ".gif" };
        private string _fromPath;
        private string _toPathUp;
        private string _toPathDown;
        private string _toPathRight;
        private string _toPathLeft;
        private string _imagePath = @"C:\Users\Dick Kickem\Documents\MEGA\Billeder\Random pics\Wat\6f1.png";
        private string _newFolderName;


        public MainWindow()
        {
            InitializeComponent();
            Image1.Source = new BitmapImage(new Uri(imagePath));

        }

        public string imagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }

        }

        public string fromPath
        {
            get { return _fromPath; }
            set { _fromPath = value; }
        }

        public string toPathUp
        {
            get { return _toPathUp; }
            set { _toPathUp = value; }
        }


        public void TestImage(object sender, KeyEventArgs e)
        {
            imagePath = @"C:\Users\Dick Kickem\Documents\MEGA\Billeder\Random pics\Wat\b87.jpg";
            if (e.Key == Key.E)
            {
                Image1.Source = new BitmapImage(new Uri(imagePath));
            }

            else
            {
                MessageBox.Show("pressed something XD");
            }

        }

        public void TestImageClick(object sender, RoutedEventArgs e)
        {
            _imagePath = @"C:\Users\Dick Kickem\Documents\MEGA\Billeder\Random pics\Wat\6f1.png";
            Image1.Source = new BitmapImage(new Uri(_imagePath));
        }


        public void SendToPath(object sender, RoutedEventArgs e)
        {
            try
            {
                File.Move(_imagePath, _toPathUp);
            }
            catch (IOException s)
            {
                MessageBox.Show("A problem occured with IO: " + s);
            }
        }

        public void OpenToPathUpOnClick(object sender, RoutedEventArgs e)
        {
            
            var dialog = _folderBrowserDialog;
            var result = dialog.ShowDialog();

            if (result != WindForms.DialogResult.OK || !Directory.Exists(_folderBrowserDialog.SelectedPath))
                return;
            _toPathUp = dialog.SelectedPath;
        }

    }
}
