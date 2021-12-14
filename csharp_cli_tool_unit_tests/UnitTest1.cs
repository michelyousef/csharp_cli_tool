using NUnit.Framework;
using csharp_cli_tool;
using System.IO;
using System.Collections.Generic;
using System;

namespace csharp_cli_tool_unit_tests
{
    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CheckingReadingFileTest()
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


        [Test]
        public void CheckingMinimumCountThrowsExceptionTest()
        {
            //Arrange
            // creating a list with only 2 elements
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Jim", "Smith", new DateTime(), 2, 50, "Offensive Duties"));
            employees.Add(new Employee("Michel", "Yousef", new DateTime(), 1, 40, "Offensive Duties"));
            //Act

            //Assert
            Assert.Throws<ArgumentNullException>(() => csharp_cli_tool.Program.SelectingEmployees(employees)); 

        }
    }
}
