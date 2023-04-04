namespace SUT22Generics;

public class Student : IEquatable<Student>
{
    public int ID { get; set; }
    public int Grade { get; set; }
    public int Total { get; set; }

    public Student(int id, int grade, int total)
    {
        ID = id;
        Grade = grade;
        Total = total;
    }

    public bool Equals(Student? other)
    {
        throw new NotImplementedException();
    }
}