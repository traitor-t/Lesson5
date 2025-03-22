class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class Department
{
    public string DepartmentName { get; set; }
    public Department(string departmentName)
    {
        DepartmentName = departmentName;
    }
}

class Professor
{
    public string Name { get; set; }
    public Professor(string name)
    {
        Name = name;
    }
}

class University
{
    private Student[] students;
    private Department department;
    private Professor professor;

    public University(Student[] students, Department department, Professor professor)
    {
        this.students = students;   
        this.department = department;
        this.professor = professor;
    }

    public void ShowStudents()
    {
        Console.WriteLine($"Студенты университета ({department.DepartmentName}):");
        foreach(Student student in students)
        {
            Console.WriteLine($"- {student.Name}");
        }
    }
}
