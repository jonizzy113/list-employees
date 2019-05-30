using System;
using System.Collections.Generic;

namespace List_employees
{
    public class Company
    {
        /*
            Create a constructor method that accepts two arguments:
            1. The name of the company
            2. The date it was created
            The constructor will set the value of the public properties
        */
        // C O N S T R U C T O R 
        public Company(string name, DateTime date)
        {
            Name = name;
            CreatedOn = date;
        }

        // P U B L I C
        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        List<Employee> EmployeeList = new List<Employee>();

        public void AddEmployee(Employee emp) => EmployeeList.Add(emp);

        public void ListEmployee(){
            foreach(Employee emp in EmployeeList){
                // Console.WriteLine(emp.FirstName);
                // Console.WriteLine(emp.LastName);
                // Console.WriteLine(emp.Title);
                // Console.WriteLine(emp.StartDate);
                Console.WriteLine($"{emp.FirstName} {emp.LastName} works for {this.Name} as {emp.Title} since {emp.StartDate.ToShortDateString()}");
            }
        }

    }

    public class Employee
    {

        // P U B L I C 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Company CutThroatTechnologies = new Company("HAPPYDAYS", DateTime.Now);
            
            Employee Chaffin = new Employee()
            {
                FirstName = "Jon",
                LastName = "Schaffer",
                Title = "Nature Instructor",
                StartDate = new DateTime(2015, 2, 3)
            };

            Employee Luke = new Employee()
            {
                FirstName = "Jameka",
                LastName = "Smith",
                Title = "IT Analyst",
                StartDate = new DateTime(2010, 11, 20)
            };

            Employee Adam = new Employee()
            {
                FirstName = "Billy",
                LastName = "Mathison",
                Title = "Event Coordinator",
                StartDate = new DateTime(2003, 3, 9)
            };
            
            CutThroatTechnologies.AddEmployee(Chaffin);
            CutThroatTechnologies.AddEmployee(Luke);
            CutThroatTechnologies.AddEmployee(Adam);

            
            CutThroatTechnologies.ListEmployee();
        }
    }
}
