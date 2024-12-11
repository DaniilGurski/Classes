public class Calculator {
    int a;
    int b;

    public Calculator(int a, int b) {
        this.a = a;
        this.b = b; 
    }

    private void Add() {
        Console.WriteLine(a + b); 
    }

    private void Subtract() {
        Console.WriteLine(a - b); 
    }

    private void Multiply() {
        Console.WriteLine(a * b); 
    }

    private void Divide() {
        Console.WriteLine(a / b); 
    }

    public void Perform(string operation) {
        switch (operation.ToUpper()) {
            case "A":
                Add();
                break;
            case "S":
                Subtract();
                break;
            case "M":
                Multiply();
                break;
            case "D":
                Divide();
                break;
            default: 
                Console.WriteLine("Invalid operaiton.");
                break;
        }
    } 
}