// See https://aka.ms/new-console-template for more information

using SUT22Generics;

Console.WriteLine("Working...");
App();
static void App()
{
    StudentCollection students = new StudentCollection();
    students.Add(new Student(1,75,80));
    students.Add(new Student(2,53,33));
    students.Add(new Student(3,77,100));
    students.Add(new Student(4,45,87));
    
    
    
    PrintData(students);
    
    students.Add(new Student(1,75,80));
    Console.ReadLine();

}

static void PrintData(StudentCollection studentCollection)
{
    Console.WriteLine("\nID\tGrade\tTotal\tHash");

    foreach (var student in studentCollection)
    {
        Console.WriteLine($"{student.ID}\t{student.Grade}\t{student.Total}\t{student.GetHashCode()}");
    }
}