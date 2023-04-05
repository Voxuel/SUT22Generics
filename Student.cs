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
        if (new StudentSameProp().Equals(this,other))
        {
            return true;
        }

        return false;
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}