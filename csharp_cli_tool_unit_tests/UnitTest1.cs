using NUnit.Framework;
using csharp_cli_tool;
using System.IO;

namespace csharp_cli_tool_unit_tests
{
    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddingEmployeesTest()
        {
            //Arrange
            string fileName = "records.csv";
            // retrieving relative file path in the project
            string fullFilePath = Path.Combine("../../..", fileName);
            string[] myLines = File.ReadAllLines(fullFilePath);


            //Act

            //Assert
            Assert.IsNotNull(myLines);
            Assert.IsNotEmpty(myLines);
        }
    }
}
