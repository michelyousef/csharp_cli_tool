using System;
using System.Collections.Generic;
using System.IO;

namespace csharp_cli_tool
{
    class Program
    {
        static void Main(string[] args)
        {


            // creating a list of all records
            List<Employee> employees = new List<Employee>();
            string fileName = "records.csv";
            // retrieving relative file path in the project
            string fullFilePath = Path.Combine("../../..", fileName);
            // reading file data and storing it in a string array
            string[] myLines = File.ReadAllLines(fullFilePath);
            
            foreach (var line in myLines)
            {
                // storing each line in the csv file as an array
                string[] records = line.Split(',');
                // adding each line in a separate object in the Employee class
                Employee employee = new Employee();
                employee.FirstName = records[0];
                employee.LastName = records[1];
                employee.Date = records[2];
                employee.Division = Convert.ToInt16(records[3]);
                employee.Points = Convert.ToInt16(records[4]);
                employee.Summary = records[5];
                // adding the record to the employees list 
                employees.Add(employee);


            }
           
           

            // Stopping the console program from closing 
            Console.ReadLine();
        }
    }
}
