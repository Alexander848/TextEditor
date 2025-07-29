namespace TextEditorLibrary
{
    public static class FileOperations
    {
        /// <summary>
        /// Removes filename and extension of path.
        /// </summary>
        /// <param name="filepath">String of filepath.</param>
        /// <returns>Filepath without filename and extension.</returns>
        public static string RemoveFilenameFromPath(string filepath)
        {
            int positionLastSeparator = filepath.LastIndexOf(Path.DirectorySeparatorChar) + 1;
            if (positionLastSeparator == 1)
                return "";
            return filepath.Substring(0, positionLastSeparator);
        }
    }
}
