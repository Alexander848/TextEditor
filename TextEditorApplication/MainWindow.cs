using TextEditorLibrary;

namespace TextEditorApplication
{
    public partial class MainWindow : Form
    {
        private string lastOpenedDirectory = "C:\\";
        private string currentFile = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new();
            openFileDialog.InitialDirectory = lastOpenedDirectory;
            openFileDialog.Filter = "Textdateien (*.txt)|*.txt";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = openFileDialog.FileName;

                mainTextBox.Text = File.ReadAllText(currentFile);

                lastOpenedDirectory = FileOperations.RemoveFilenameFromPath(currentFile);

                this.Text = currentFile;
            }
        }
    }
}
