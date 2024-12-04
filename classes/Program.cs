internal class Program
{
    private static void Main(string[] args)
    {
        // Assigment1();
        Assigment2();
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
}