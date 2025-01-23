namespace P02_StudentSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("njjnjn");
            /*
        - Entity Framework Core
            This document defines the exercise assignments for the entity framework core 02.
            
        1.	Student System
            Your task is to create a database for the Student System, using the EF Core Code First approach. It should look like this:
            
            Constraints
        Your namespaces should be:
            •	P01_StudentSystem – Project Name 
            •	P01_ StudentSystem.Data – (New folder named Data) for your DbContext 
            •	P01_ StudentSystem.Models – (New folder named Models) for your models
        Your models should be:
            •	StudentSystemContext – your DbContext
            •	Student:
            o	StudentId
            o	Name (up to 100 characters, unicode)
            o	PhoneNumber (exactly 10 characters, not unicode, not required)
            o	RegisteredOn (DateTime)
            o	Birthday (not required)
            
        Course:
            o	CourseId
            o	Name (up to 80 characters, unicode)
            o	Description (unicode, not required)
            o	StartDate
            o	EndDate
            o	Price
        Resource:
            o	ResourceId
            o	Name (up to 50 characters, unicode)
            o	Url (not unicode)
            o	ResourceType (enum – can be Video, Presentation, Document or Other)
            o	CourseId
        Homework:
            o	HomeworkId
            o	Content (string, linking to a file, not unicode)
            o	ContentType (enum – can be Application, Pdf or Zip)
            o	SubmissionTime
            o	StudentId
            o	CourseId
        StudentCourse – mapping class between Students and Courses
            Table relations:	
            •	One student can have many CourseEnrollments
            •	One student can have many HomeworkSubmissions
            •	One course can have many StudentsEnrolled
            •	One course can have many Resources
            •	One course can have many HomeworkSubmissions
        Seed Some Data in the Database
            Write a seed method that fills the database with sample data.
            Fill a few students, courses, resources and homework submissions.
        Migration
            Add new migration. The migration should be named: "InitialCreate" and run the project.
            Bonus
            Create a console application that reads information about courses and students and store it.
            
           */

            
        }
    }
}

