namespace SUT22Generics;

public class StudentSameProp : EqualityComparer<Student>
{
    public override bool Equals(Student? x, Student? y)
    {
        if (x.ID == y.ID && x.Grade == y.Grade && x.Total == y.Total)
        {
            return true;
        }

        return false;
    }

    public override int GetHashCode(Student obj)
    {
        throw new NotImplementedException();
    }
}