namespace Lab_1;

class Ex2 { 

    public static void Run()
    {
        Console.WriteLine("Input vars:\n");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if ((3 * a - b) > 0)
            y = 2 * Math.Log(x) - Math.Exp( (a * x - b) / 10);
        else
            y = Math.Asin(x / 10);

        // double y = (3 * a - b) > 0 ? 2 * Math.Log(x) - Math.Exp( (a * x - b) / 10) : Math.Atan(x / 10);
    
        Console.WriteLine(y);
    }

}
