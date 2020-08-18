using System;
using System.Linq;
using EFCore.Context;
using EFCore.Entities;

namespace EFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new Day2Context())
            {
                var query1 = context
                    .Subjects    
                    .Where(s => s
                        .Classes
                        .Any( c => c
                            .ClassStudents
                            .Any(cs => cs.AverageGrades < c.MinimunGrade)))
                    .Select(
                        x=> new {
                            Subject = x.Name,
                            MinimunGrade = x.Classes.FirstOrDefault().MinimunGrade,
                            Average = x.Classes.Select( y => y.ClassStudents.Average(xx => xx.AverageGrades)).Average(yy => yy)
                        }                        
                    )
                    .ToList();

                foreach (var item in query1)
                {
                    System.Console.WriteLine($"{item.Subject} - {item.MinimunGrade} - {item.Average}");
                }
                System.Console.WriteLine("\n");

                var query2 = context
                    .Subjects
                    .Where( s => s
                        .Classes
                        .Any( c => c
                            .ClassStudents
                            .Any(cs => cs.AverageGrades < c.MinimunGrade)))
                    .Select(
                        x=> new 
                        {
                            ProfessorName = x.Professor.Person.Name,
                            SubjectNmae = x.Name,
                            Grade = x
                                .Classes
                                .Select(c=> c
                                    .ClassStudents
                                    .Min(cc => cc
                                        .AverageGrades))
                                .Min(c => c)
                        }
                    )
                    .FirstOrDefault();

                System.Console.WriteLine($"{query2.ProfessorName} - {query2.SubjectNmae} - {query2.Grade}");
            }
        }
    }
}
