using System.Collections;

namespace SUT22Generics;

public class StudentCollection : ICollection<Student>
{
    private List<Student> innerCol;

    public StudentCollection()
    {
        innerCol = new List<Student>();
    }

    public Student this[int index]
    {
        get { return innerCol[index]; }
        set { innerCol[index] = value; }
    }
    public IEnumerator<Student> GetEnumerator()
    {
        return new StudentEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new StudentEnumerator(this);
    }

    public void Add(Student item)
    {
        if (!Contains(item))
        {
            innerCol.Add(item);
        }
        else
        {
            Console.WriteLine($"Student with ID ({item.ID}) already exists in the system");
        }
    }

    public void Clear()
    {
        throw new NotImplementedException();
    }

    public bool Contains(Student item)
    {
        bool found = false;

        foreach (var student in innerCol)
        {
            if (student.Equals(item))
            {
                found = true;
            }
        }

        return found;
    }

    public void CopyTo(Student[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(Student item)
    {
        throw new NotImplementedException();
    }

    public int Count
    {
        get { return innerCol.Count; }
    }
    public bool IsReadOnly
    {
        get { return false; }
    }
}