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
        innerCol.Clear();
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

    public bool Contains(Student? item, EqualityComparer<Student> comparer)
    {
        bool found = false;
        foreach (var student in innerCol)
        {
            if (comparer.Equals(student, item))
            {
                found = true;
            }
        }

        return found;
    }

    public void CopyTo(Student[] array, int arrayIndex)
    {
        if (array == null)
        {
            throw new ArgumentNullException();
        }

        if (arrayIndex < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (Count > array.Length - arrayIndex + 1)
        {
            throw new ArgumentException("The destination array has fewer elements than" +
                                        "the collection");
        }

        for (int i = 0; i < innerCol.Count; i++)
        {
            array[i + arrayIndex] = innerCol[i];
        }
    }

    public bool Remove(Student item)
    {
        bool result = false;

        for (int i = 0; i < innerCol.Count; i++)
        {
            Student student = innerCol[i];
            if (new StudentSameProp().Equals(student, item))
            {
                innerCol.RemoveAt(i);
                result = true;
                break;
            }
        }

        return result;
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