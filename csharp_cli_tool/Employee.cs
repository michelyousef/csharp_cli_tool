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
            return ($"- name: {FirstName} {LastName} \n  details: In division {Division} from {Date.ToString("yyyy-MM-dd")} performing {Summary}");

        }


    }
}
