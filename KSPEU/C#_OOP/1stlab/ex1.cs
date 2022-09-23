namespace Lab_1;

class Ex1 { 

    public static void Run()
    {
        Console.WriteLine("Input alpha:\n");
        double a = Convert.ToDouble(Console.ReadLine());
        double z1 = Math.Cos(a) + Math.Cos(2.0 * a) + Math.Cos(6.0 * a) + Math.Cos(7.0 * a); 


        Console.WriteLine("Input alpha:\n");
        a = Convert.ToDouble(Console.ReadLine());
        double z2 = 4.0 * Math.Cos(a / 2.0) * Math.Cos(5 / 2.0 * a) * Math.Cos(4.0 * a);

        Console.WriteLine($"z1 = {z1}; z2 = {z2}");
    }

}
