namespace Calculator
{
    public class FileIOWrapper : IFileIOWrapper
    {
        public string ReadAllText(string filePath)
        {
            return System.IO.File.ReadAllText(filePath);
        }
    }
}
