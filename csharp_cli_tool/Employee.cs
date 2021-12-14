using System;
namespace csharp_cli_tool
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public Int16 Division { get; set; }
        public Int16 Points { get; set; }
        public string Summary { get; set; }

        // printing YAML formatted description of employee
        public string PrintRecords()
        {
            return $"- name: {FirstName} {LastName} \n  details: In division {Division} from {Date.ToString("yyyy-MM-dd")} performing {Summary}";

        }


        // empty constructor
        public Employee()
        {

        }

        // Constructor with arguments
        public Employee(string first, string last, DateTime date, Int16 division, Int16 points, string summary )
        {
            FirstName = first;
            LastName = last;
            Date = date;
            Division = division;
            Points = points;
            Summary = summary;
        }


    }
}
