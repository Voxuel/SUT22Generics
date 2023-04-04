using System.Collections;

namespace SUT22Generics;

public class StudentEnumerator : IEnumerator<Student>
{
    private StudentCollection _students;
    private int _currentIndex;
    private Student _currentStudent;

    public StudentEnumerator(StudentCollection students)
    {
        _students = students;
        _currentIndex = -1;
        _currentStudent = default(Student);
    }
    
    public bool MoveNext()
    {
        if (_currentIndex >= _students.Count)
        {
            return false;
        }
        else
        {
            _currentStudent = _students[_currentIndex];
        }

        return true;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }

    public Student Current
    {
        get { return _currentStudent; }
    }

    object IEnumerator.Current
    {
        get { return Current; }
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}