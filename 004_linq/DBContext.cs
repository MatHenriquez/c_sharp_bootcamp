using LINQDemos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemos
{
    public static class DBContext
    {
        public static List<Student> Students { get; set; }
        public static List<University> Universities { get; set; }

        static DBContext()
        {

            Universities =
            [
                new University { Id = 1, Name = "University of Washington", City = "Seattle", Country = "USA" },
                new University { Id = 2, Name = "University of Oregon", City = "Eugene", Country = "USA" },
                new University { Id = 3, Name = "University of California", City = "Berkeley", Country = "USA" },
                new University { Id = 4, Name = "University of British Columbia", City = "Vancouver", Country = "Canada" },
                new University { Id = 5, Name = "University of Toronto", City = "Toronto", Country = "Canada" },
            ];

            Students =
            [
                new Student { Id = 1, FirstName = "John", LastName = "Doe", UniversityId = 4 },
                new Student { Id = 2, FirstName = "Jane", LastName = "Doe", UniversityId = 0 },
                new Student { Id = 3, FirstName = "Bob", LastName = "Smith", UniversityId = 1 },
                new Student { Id = 4, FirstName = "Sally", LastName = "Smith", UniversityId = 1 },
                new Student { Id = 5, FirstName = "Bill", LastName = "Jones", UniversityId = 3 },
                new Student { Id = 6, FirstName = "Mary", LastName = "Jones", UniversityId = 2 },
                new Student { Id = 7, FirstName = "Tom", LastName = "Brown", UniversityId = 3 },
                new Student { Id = 8, FirstName = "Sue", LastName = "Brown", UniversityId = 4 },
                new Student { Id = 9, FirstName = "Harry", LastName = "Williams", UniversityId = 4 },
                new Student { Id = 10, FirstName = "Betty", LastName = "Williams", UniversityId = 1 },
                new Student { Id = 11, FirstName = "Fred", LastName = "Davis", UniversityId = 0 },
                new Student { Id = 12, FirstName = "Wilma", LastName = "Davis", UniversityId = 2 },
                new Student { Id = 13, FirstName = "George", LastName = "Miller", UniversityId = 1 },
                new Student { Id = 14, FirstName = "Judy", LastName = "Miller", UniversityId = 1 },
                new Student { Id = 15, FirstName = "Joe", LastName = "Wilson", UniversityId = 2 },
                new Student { Id = 16, FirstName = "Alice", LastName = "Wilson", UniversityId = 2 },
                new Student { Id = 17, FirstName = "Peter", LastName = "Moore", UniversityId = 3 },
                new Student { Id = 18, FirstName = "Lucy", LastName = "Moore", UniversityId = 3 },
                new Student { Id = 19, FirstName = "Mike", LastName = "Taylor", UniversityId = 2 },
                new Student { Id = 20, FirstName = "Nancy", LastName = "Taylor", UniversityId = 4 },
                new Student { Id = 21, FirstName = "Tim", LastName = "Anderson", UniversityId = 3 },
                new Student { Id = 22, FirstName = "Cindy", LastName = "Anderson", UniversityId = 0 },
                new Student { Id = 23, FirstName = "Ralph", LastName = "Thomas", UniversityId = 1 },
                new Student { Id = 24, FirstName = "Pam", LastName = "Thomas", UniversityId = 1 },
                new Student { Id = 25, FirstName = "Dave", LastName = "Jackson", UniversityId = 2 }
                ];
        }
    }
}
