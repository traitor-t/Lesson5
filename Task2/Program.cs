class Program
{
    static void Main(string[] args)
    {
        Student[] student1 = new Student[]
        {
            new Student("Alice"),
            new Student("Alex"),
            new Student("Bob")
        };

        Student[] student2 = new Student[]
        {
            new Student("Dminty"),
            new Student("Kate"),
            new Student("Joe"),
        };

        Department department1 = new Department("Information Technology");
        Department department2 = new Department("Financial management");

        Professor professor1 = new Professor("Professor Jone");
        Professor professor2 = new Professor("Professor Jane");

        University university1 = new University(student1, department1, professor1);
        University university2 = new University(student2, department2, professor2);

        University[] universities = new University[] { university1, university2 };

        foreach (University university in universities)
        {
            university.ShowStudents();
            Console.WriteLine();
        }
    }
}