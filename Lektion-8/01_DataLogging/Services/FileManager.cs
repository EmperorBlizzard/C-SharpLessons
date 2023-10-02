using _01_DataLogging.Interfaces;

namespace _01_DataLogging.Services;

public class FileManager : IFileManager
{
    public string ReadFromFile(string filepath)
    {
        try
        {
            if (File.Exists(filepath))
            {
                return File.ReadAllText(filepath);
            }
        }
        catch { }

        return null!;
    }

    public bool SaveToFile(string filePath, string content)
    {
        try
        {
            using StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(content);
            return true;
        }
        catch { }

        return false;

    }
}
