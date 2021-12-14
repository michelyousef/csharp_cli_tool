using NUnit.Framework;
using csharp_cli_tool;

namespace csharp_cli_tool_unit_tests
{
    public class ProgramTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddingEmployeesCase()
        {
            //Arrange
            Employee employee = new Employee();
            employee.FirstName = "M";
            employee.LastName = "Y";
            employee.Date = new System.DateTime();
            employee.Division = 4;
            employee.Points = 34;
            employee.Summary = "Offensive Duties";

            //Act

            //Assert
            Assert.Pass();
        }
    }
}
