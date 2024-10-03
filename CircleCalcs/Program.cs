class Program{

    static void Main(string[]args){
        while(true){
            Console.Write("What is the radius of your circle and sphere? ");
            double Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your radius is "+Radius);
            Console.WriteLine();
            CircleAndSphere(Radius);
        }
    }
    public static void CircleAndSphere(double radius) {
    double pi = Math.PI; // Use Math.PI for a more accurate value of π
    double squared = radius * radius;
    double cubed = radius * radius * radius;
    
    double circumference = 2 * pi * radius; // Circumference
    double area = pi * squared; // Area
    double volume = (4.0 / 3.0) * pi * cubed; // Volume

    Console.WriteLine("Your circumference = " + Math.Round(circumference, 2));
    Console.WriteLine("Your area = " + Math.Round(area, 2));
    Console.WriteLine("Your volume = " + Math.Round(volume, 2));
}

}