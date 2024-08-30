Main();
void Main()
{
    // Method declaration
    // 'CalculateArea' is the method name
    // 'double' is the return type
    // 'double length' and 'double width' are parameters
    static double CalculateArea(double length, double width)
    {
        // Method body
        double area = length * width;
        return area; // Returning the calculated area
    }

    static void Main()
    {
        double length = 5.0;
        double width = 3.0;

        // Calling the method and storing the result
        double area = CalculateArea(length, width);

        // Output the result
        Console.WriteLine($"The area of the rectangle is: {area}");
    }
}
