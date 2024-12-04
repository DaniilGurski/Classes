public class Circle {
    public double radius; 

    public Circle(double radius) {
        this.radius = radius; 
    }

    public void CalculateDiameter() {
        double diameter = radius * 2 * Math.PI;
        Console.WriteLine($"Circle with radius {this.radius} has diameter of {diameter}");
    }
}