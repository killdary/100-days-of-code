using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore.Migrations
{
    public partial class SeedDummyData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                "INSERT INTO Persons"+
                "    ("+
                "        Id,"+
                "        Created,"+
                "        Name,"+
                "        DocumentNumber,"+
                "        Birthday,"+
                "        Sex"+
                "    )"+
                "VALUES "+
                "    (1,'2020-01-01', 'Person Student 1', 123456, '1990-01-01',1),"+
                "    (2,'2020-02-01', 'Person Student 2', 123457, '1991-02-01',2),"+
                "    (3,'2020-03-01', 'Person Student 3', 123458, '1992-03-01',3),"+
                "    (4,'2019-04-01', 'Person Professor 1', 123459, '1989-04-01',1),"+
                "    (5,'2019-05-01', 'Person Professor 2', 123460, '1988-05-01',2),"+
                "    (6,'2019-06-01', 'Person Professor 3', 123461, '1987-06-01',3),"+
                "    (7,'2020-01-01', 'Person Student 1', 123456, '1990-01-01',3),"+
                "    (8,'2020-02-01', 'Person Student 2', 123457, '1991-02-01',2),"+
                "    (9,'2020-03-01', 'Person Student 3', 123458, '1992-03-01',1);"+
                
                "INSERT INTO Courses "+
                "    ("+
                "        Id,"+
                "        Created,"+
                "        Name"+
                "    )"+
                "VALUES"+
                "    (1,'2018-01-01', 'Medicine'),"+
                "    (2,'2018-06-01', 'English'),"+
                "    (3,'2018-12-01', 'Computer Science');"+
                
                "INSERT INTO Professors "+
                "    ("+
                "        Id,"+
                "        Created,"+
                "        PersonId,"+
                "        WorkStartDate,"+
                "        \"Degree\","+
                "        CourseId "+
                "    )"+
                "VALUES"+
                "    (1, '2019-04-01', 4, '2019-04-02', 3, 1),"+
                "    (2, '2019-05-01', 5, '2019-05-10', 2, 2),"+
                "    (3, '2019-06-01', 6, '2019-06-20', 3, 3);"+
                
                "INSERT INTO Students "+
                "    ("+
                "        Id ,"+
                "        Created,"+
                "        PersonId,"+
                "        DateIngress,"+
                "        RegistrationCodeStudent"+
                "    )"+
                "VALUES"+
                "    (1,'2020-01-01', 1, '2020-01-02','MED001'),"+
                "    (2,'2020-02-01', 2, '2020-02-22','ENG001'),"+
                "    (3,'2020-03-01', 3, '2020-03-15','SCC001'),"+
                "    (7,'2020-01-01', 1, '2020-01-02','MED001'),"+
                "    (8,'2020-02-01', 2, '2020-02-22','ENG001'),"+
                "    (9,'2020-03-01', 3, '2020-03-15','SCC001');"+
                
                "INSERT INTO Subjects ("+
                "    Id,"+
                "    Created,"+
                "    Name,"+
                "    NumberStudents,"+
                "    ProfessorId"+
                ")"+
                "VALUES"+
                "    (1,'2018-01-01', 'Medicine 101', 10, 1),"+
                "    (2,'2018-06-01', 'English 101', 10, 2),"+
                "    (3,'2018-12-01', 'Computer Science 101', 10, 3);"+
                
                "INSERT INTO CourseStudent "+
                "    (CourseId ,StudentId )"+
                "VALUES"+
                "    (1, 1),"+
                "    (2, 2),"+
                "    (3, 3);"+
                
                "INSERT INTO CourseSubject "+
                "    (CourseId ,SubjectId )"+
                "VALUES"+
                "    (1, 1),"+
                "    (2, 2),"+
                "    (3, 3);"+
                
                "INSERT INTO Classes "+
                "    ( "+
                "        Created,"+
                "        SubjectId,"+
                "        MinimunGrade"+
                "    )"+
                "VALUES"+
                "    ('2020-08-12', 1, 6),"+
                "    ('2020-08-12', 2, 7),"+
                "    ('2020-08-12', 3, 9);"+
                
                "INSERT INTO ClassStudents "+
                "    ("+
                "        ClassId,"+
                "        StudentId,"+
                "        Grade1,"+
                "        Grade2,"+
                "        Grade3, "+
                "        AverageGrades"+
                "    )"+
                "VALUES"+
                "    (1,1,5,7,0,6),"+
                "    (2,2,6,8,0,7),"+
                "    (3,3,9,8,0,8.5),"+
                "    (1,7,8,8,0,8),"+
                "    (2,8,2,5,0,3.5),"+
                "    (3,9,7,4,0,5.5);");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
