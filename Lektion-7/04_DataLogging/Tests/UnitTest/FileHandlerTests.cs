using _04_DataLogging.Interfaces;
using _04_DataLogging.Services;
using Xunit;

namespace _04_DataLogging.Tests.UnitTest;

public class FileHandelerTests
{
    [Fact]
    public void ReadFromFile_Should_WhenFileDoesNotExistReturnNull()
    {
        //Arrange
        IFileHandler fileHandler = new FileHandler();
        string filePath = "fakefile.txt";


        //Act

        IEnumerable<string> result = fileHandler.ReadFromFile(filePath);


        //Assert
        Assert.Null(result);

    }

}
