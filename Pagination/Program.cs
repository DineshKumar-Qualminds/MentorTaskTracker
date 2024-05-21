namespace Pagination
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main()
        {
           
            List<Employee> employees = new List<Employee>();
            for (int i = 1; i <= 100; i++)
            {
                employees.Add(new Employee
                {
                    Id = i,
                    FirstName = "First" + i,
                    LastName = "Last" + i,
                    dob = DateTime.Today.AddYears(-i),
                    emailID = "email" + i + "@example.com"
                });
            }


            Console.Write("Enter page size: ");
            int pageSize = int.Parse(Console.ReadLine());

            
            Console.Write("Enter page number: ");
            int pageNumber = int.Parse(Console.ReadLine());

            
            int startIndex = (pageNumber - 1) * pageSize;
            int endIndex = Math.Min(startIndex + pageSize - 1, employees.Count - 1);

           
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine($"Id: {employees[i].Id}, Name: {employees[i].FirstName} {employees[i].LastName}, DOB: {employees[i].dob}, Email: {employees[i].emailID}");
            }

            
            Console.WriteLine($"\nShowing page {pageNumber} of {Math.Ceiling((double)employees.Count / pageSize)}");
        }

        class Employee
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime dob { get; set; }
            public string emailID { get; set; }
        }
    }

}
