using TextEditorLibrary;

namespace TextEditorApplication
{
    public partial class MainWindow : Form
    {
        private string lastOpenedDirectory = "C:\\";

        private string currentFile = "";
        public string CurrentFile
        {
            get => currentFile;
            set
            {
                currentFile = value;
                this.Text = currentFile;
            }
        }
            

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog openFileDialog = new();
                openFileDialog.InitialDirectory = lastOpenedDirectory;
                openFileDialog.Filter = "Textfiles (*.txt)|*.txt";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string chosenFile = openFileDialog.FileName;

                    mainTextBox.Text = File.ReadAllText(chosenFile);

                    CurrentFile = chosenFile;
                    lastOpenedDirectory = FileOperations.RemoveFilenameFromPath(CurrentFile);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open file");
            }
            
        }

        private void SaveFile_Click(Object sender, EventArgs e)
        {
            if (CurrentFile == "")
            {
                SaveAsFile_Click(sender, e);
                return;
            }

            try
            {
                File.WriteAllText(CurrentFile, mainTextBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save file");
            }

        }

        private void SaveAsFile_Click(Object sender, EventArgs e)
        {
            try
            {
                using SaveFileDialog saveFileDialog = new();
                saveFileDialog.InitialDirectory = lastOpenedDirectory;
                saveFileDialog.Filter = "Textfiles (*.txt)|*.txt";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filepath = saveFileDialog.FileName;
                    File.WriteAllText(filepath, mainTextBox.Text);

                    CurrentFile = filepath;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Could not save file");
            }
        }
    }
}
