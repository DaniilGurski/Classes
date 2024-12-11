internal class Program
{
    private static void Main(string[] args)
    {
        // Assigment1();
        // Assigment2();
        Assigment3();
    }
    static void Assigment1() {
        Circle myCircle = new Circle(5);
        myCircle.CalculateDiameter(); 
    }

    static void Assigment2() {
        while (true) {
            try {
                Console.WriteLine("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Enter operation (A)dd (S)ubtract (M)ultiply (D)ivide");
                Calculator calculator = new Calculator(num1, num2);

                string? operation = Console.ReadLine();

                if (operation == null) {
                    continue;
                }
                
                calculator.Perform(operation);
            }

            catch {
                Console.WriteLine("Invalid number");
            }
        }
    }

    static void Assigment3() {
        string[] subjects = {"Sv", "Ma", "Fy", "Pe"}; 
        string[] grades = {"A", "B", "C", "D", "E", "F"};
        Random randomizer = new Random();

        Student[] students = {
            new Student("Daniil", "Gurski", new DateTime(2005, 11, 18).Date),
            new Student("Alice", "Smith", new DateTime(2004, 5, 22).Date),
            new Student("Bob", "Johnson", new DateTime(2003, 8, 14).Date),
            new Student("Charlie", "Brown", new DateTime(2002, 12, 30).Date),
            new Student("David", "Williams", new DateTime(2001, 3, 10).Date),
            new Student("Eva", "Jones", new DateTime(2008, 7, 25).Date),
            new Student("Frank", "Garcia", new DateTime(2009, 11, 5).Date),
            new Student("Grace", "Martinez", new DateTime(2004, 2, 18).Date),
            new Student("Hannah", "Rodriguez", new DateTime(2010, 6, 9).Date),
            new Student("Ian", "Lee", new DateTime(2005, 9, 21).Date)
        };


        // set random grades to each student and calculate total points
        foreach (Student student in students) {
            foreach (string subject in subjects) {
                student.SetGrade(subject, grades[randomizer.Next(0, 5)]);
            }

            student.calculateTotalPoints();
        }


        // find the best and worst student
        Student bestStudent = students[0];
        Student worstStudent = students[0];
        List<Student> studentsOfAge = new List<Student>(); 

        foreach (Student student in students) {
            if (student.TotalPoints > bestStudent.TotalPoints) {
                bestStudent = student;
            }

            if (student.TotalPoints < worstStudent.TotalPoints) {
                worstStudent = student; 
            }
        }

        Console.WriteLine($"Best student: {bestStudent.FullName} Total Points: {bestStudent.TotalPoints}"); 
        Console.WriteLine($"Worst student: {worstStudent.FullName} Total Points: {worstStudent.TotalPoints}");

        
        // find students of age > 18
        foreach (Student student in students) {
            if (student.isAdult()) {
                studentsOfAge.Add(student);
            }
        }

        Console.WriteLine($"{studentsOfAge.Count} Adult students");
    }       
}
