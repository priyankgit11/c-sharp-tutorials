using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Net.Mime;

namespace linqDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //IEnumerable<int> result = from numbers in Num
            //                          where numbers > 3
            //                          select numbers;
            //Console.WriteLine(result);
            //foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //}
            //int cnt =
            //(from numbers in Num
            // where numbers < 5
            // select numbers).Count();
            //Console.WriteLine("Count of numbers less than 5 : " + cnt);

            //int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            //// 2. Query creation.
            //// numQuery is an IEnumerable<int>
            //var numQuery =
            //    from num in numbers
            //    where (num % 2) == 0
            //    select num;

            //// 3. Query execution.
            //foreach (int num in numQuery)
            //{
            //    Console.Write("{0,1} ", num);
            //}

            //Creating DataContext
            var connectionString = "Data Source=DESKTOP-38HJ281;Initial Catalog=w3schools;Integrated Security=True;TrustServerCertificate=True";
            var context = new DataContext(connectionString);
            var mappingSource = context.Mapping.MappingSource;
            DataClasses1DataContext dc = new DataClasses1DataContext(connectionString, mappingSource);
            //var queryEmployee = from emp in dc.employees
            //                    where true
            //                    select emp;
            //foreach (var emp in queryEmployee)
            //{
            //    Console.WriteLine(emp.FirstName);
            //}

            //IEnumerable Queries
            //int[] scores = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, };
            //IEnumerable<int> highScoresQuery = from score in scores
            //                                   where score > 5
            //                                   orderby score descending  // use thenby after orderby if multiple column is to be ordered
            // becuase orderby reorders after ordering once while thenby orders it on the go
            //                                   select score;
            //foreach (int score in highScoresQuery)
            //{
            //    Console.WriteLine(score);
            //}
            //IEnumerable<string> highScoresQuery2 = from score in scores
            //                                       where score > 5
            //                                       orderby score descending
            //                                       select $"The score is {score}";
            //foreach (string score in highScoresQuery2)
            //{
            //    Console.WriteLine(score);
            //}

            //Returning Anonymous Type
            //var queryFnameBdate = from emp in dc.employees
            //                      select new
            //                      {
            //                          emp.FirstName,
            //                          emp.BirthDate
            //                      };// neccessary to make this variable as var because query returns anonymouse type .
            //foreach(var emp in queryFnameBdate)
            //{
            //    Console.WriteLine(emp);
            //}

            //Group by 
            //var queryOrderDetails = from emp in dc.orders
            //                        group emp by emp.ShipperID;
            //foreach(var emp in queryOrderDetails)
            //{
            //    Console.WriteLine(emp.Key);
            //}
            // alternatively use ToLookup
            var emp = dc.orders.ToLookup(x => x.ShipperID);
            foreach (var i in emp)
            {
                Console.WriteLine(i.Key);
            }

            // JOIN 
            //var queryJoin = from emp in dc.employees
            //                join ord in dc.orders on emp.EmployeeID equals ord.EmployeeID
            //                select new
            //                {
            //                    FirstName = emp.FirstName,
            //                    OrderDate = ord.OrderDate
            //                };
            //foreach(var entry in queryJoin)
            //{
            //    Console.WriteLine($"{entry.FirstName}  {entry.OrderDate}");
            //}

            //let clause
            //var queryLet = from emp in dc.employees
            //               let FullName = emp.FirstName.ToString()+" "+ emp.LastName.ToString()
            //               select FullName;
            //foreach(var entry in queryLet)
            //{
            //    Console.WriteLine(entry+" ");
            //}

            // Subqueries
            var querySub = from em in dc.employees
                           where em.BirthDate ==
                           (
                                from e in dc.employees
                                select e.BirthDate
                           ).Min()
                           select em;
            Console.WriteLine(querySub);
            //foreach (var emp in querySub)
            //{
            //    Console.WriteLine(emp.FirstName);
            //}
        }
    }
}