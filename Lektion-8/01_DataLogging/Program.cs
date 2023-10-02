using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;

var fileManager = new FileManager();
IDataLogger dataLogger = new DataLogger(@"c\faofoaköafeok\log.txt", fileManager);

//Act
dataLogger.Log("agpaiogkadlgpa");


Console.ReadKey();