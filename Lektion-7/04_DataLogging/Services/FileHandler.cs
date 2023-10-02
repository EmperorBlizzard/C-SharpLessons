using _04_DataLogging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DataLogging.Services;

public class FileHandler : IFileHandler
{
    public IEnumerable<string> ReadFromFile(string filePath)
    {
        if (File.Exists(filePath))
            return File.ReadAllLines(filePath);
        return null!;
    }

    public void SaveToFile(string filePath, string content)
    {

    }
}
