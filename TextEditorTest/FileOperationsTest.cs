

namespace TextEditorTest
{
    using static TextEditorLibrary.FileOperations;

    public class Tests
    {
        [Test]
        public void EmptyPath()
        {
            string path = "";
            string expected = "";
            Assert.That(RemoveFilenameFromPath(path), Is.EqualTo(expected));
        }
        [Test]
        public void OnlyFilename()
        {
            string path = "filename.xml";
            string expected = "";
            Assert.That(RemoveFilenameFromPath(path), Is.EqualTo(expected));
        }
        [Test]
        [Platform(Include = "Win")]
        public void WindowsPath()
        {
            string path = "C:\\dir1\\file.xml";
            string expected = "C:\\dir1\\";
            Assert.That(RemoveFilenameFromPath(path), Is.EqualTo(expected));
        }
        [Test]
        [Platform(Include = "Win")]
        public void OnlyFilenameWithBackslashInfront()
        {
            string path = "\\filename.xml";
            string expected = "";
            Assert.That(RemoveFilenameFromPath(path), Is.EqualTo(expected));
        }
        [Test]
        [Platform(Include = "Unix")]
        public void UnixPath()
        {
            string path = "C:/dir1/file.xml";
            string expected = "C:/dir1/";
            Assert.That(RemoveFilenameFromPath(path), Is.EqualTo(expected));
        }
    }
}