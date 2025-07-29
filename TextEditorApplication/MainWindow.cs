namespace TextEditorApplication
{
    public partial class MainWindow : Form
    {
        private string lastOpenedDirectory = "C:\\";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void OpenMenu_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = lastOpenedDirectory;
                openFileDialog.Filter = "Textdateien (*.txt)|*.txt|Alle Dateien (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;

                    mainTextBox.Text = File.ReadAllText(selectedFilePath);
                }
            }
        }
    }
}
