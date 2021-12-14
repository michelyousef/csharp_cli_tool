using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


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
            // checking if the file path is correct
            try
            {
                string[] myLines = File.ReadAllLines(fullFilePath);
                employees = AddingEmployees(myLines);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            // ordering the list by division then by points
            employees = employees.OrderBy(emp => emp.Division).ThenByDescending(emp => emp.Points).ToList();

            // selecting the top 3 records from the sorted list
            List<Employee> selectedEmployees = new List<Employee>();
            // making sure employees list has at least 3 records
            if (employees.Count >= 3)
            selectedEmployees = employees.Take(3).ToList();

            // Printing the selected employees to the console
           
            Console.WriteLine("records:");
            foreach (var employee in selectedEmployees)
            {
                Console.WriteLine(employee.PrintRecords());

            }


            // Stopping the console program from closing 
            Console.ReadLine();
        }


        // Adding records to employees list
        public static List<Employee> AddingEmployees(string[] fileData)
        {
            List<Employee> employees = new List<Employee>();


            foreach (var entry in fileData)
            {
                // splitting each line into an array
                string[] records = entry.Split(',');
                // adding each line in a separate object in the Employee class
                Employee employee = new Employee();
                employee.FirstName = records[0];
                employee.LastName = records[1];
                employee.Date = Convert.ToDateTime(records[2]);
                employee.Division = Convert.ToInt16(records[3]);
                employee.Points = Convert.ToInt16(records[4]);
                employee.Summary = records[5];
                // adding the record to the employees list 
                employees.Add(employee);


            }

            return employees;
        }
    }
}
