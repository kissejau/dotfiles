namespace Lab_1;

class Ex3 { 

    public static void Run()
    {
        int start = 1996;

        Console.WriteLine("Введите год..");
        int year = Convert.ToInt32(Console.ReadLine());
        int diff = year >= start ? (start - year) % 12 : 12 - (start - year) % 12;
        Foo(diff, start);
    }

    public static void Foo(int diff, int start)
    {
        Console.Write("Год ");
        switch (diff)
        {
            case 0:
                Console.WriteLine("крысы");
                break;
            case 1:
                Console.WriteLine("коровы");
                break;
            case 2:
                Console.WriteLine("тигра");
                break;
            case 3:
                Console.WriteLine("зайца");
                break;
            case 4:
                Console.WriteLine("дракона");
                break;
            case 5:
                Console.WriteLine("змеи");
                break;
            case 6:
                Console.WriteLine("лошади");
                break;
            case 7:
                Console.WriteLine("овцы");
                break;
            case 8:
                Console.WriteLine("обезьяны");
                break;
            case 9:
                Console.WriteLine("петуха");
                break;
            case 10:
                Console.WriteLine("собаки");
                break;
            case 11:
                Console.WriteLine("свиньи");
                break;
            default:
                Console.WriteLine("неопределён");
                Run();
                break;
        }
    }

}
