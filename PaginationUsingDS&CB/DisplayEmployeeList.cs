using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginationUsingADO
{
    public class DisplayEmployeeList
    {
        public static void DisplayEmployees(List<Employee> employees, int pageNumber, int pageSize)
        {
            int startIndex = (pageNumber -1) * pageSize;    
            int endIndex = Math.Min(startIndex+pageSize-1,employees.Count-1);

            Console.WriteLine("------------------------------------------------------------------------------------------------");
            Console.WriteLine("|    Id    |   First Name   |   Last Name   |   Date of Birth   |             Email          |");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine($"| {employees[i].Id,-7} | {employees[i].FirstName,-14} | {employees[i].LastName,-13} | " +
                    $"{employees[i].DateOfBirth.ToShortDateString(),-17} | {employees[i].EmailId,-20} |");
            }

            Console.WriteLine("-----------------------------------------------------------------------------");
         
        }
        
    }
}
