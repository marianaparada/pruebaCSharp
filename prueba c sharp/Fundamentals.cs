namespace prueba_c_sharp;

public static class Fundamentals
{
    public static void Run()
    {
        Console.WriteLine(">> 1) Variables and Types");
        int number = 10;
        string text = "Hello C#";
        bool isTrue = true;
        DateTime today = DateTime.Now;

        Console.WriteLine($"Number: {number}");
        Console.WriteLine($"Text: {text}");
        Console.WriteLine($"Boolean: {isTrue}");
        Console.WriteLine($"Date: {today}");

        Console.WriteLine("\n>> 2) Operators");
        int sum = 5 + 3;
        int subtraction = 10 - 4;
        int multiplication = 6 * 2;
        int division = 20 / 5;
        int modulo = 10 % 3;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Subtraction: {subtraction}");
        Console.WriteLine($"Multiplication: {multiplication}");
        Console.WriteLine($"Division: {division}");
        Console.WriteLine($"Modulo: {modulo}");

        bool condition = (5 > 3) && (2 < 4);
        Console.WriteLine($"Is 5 > 3 AND 2 < 4?: {condition}");

        Console.WriteLine("\n>> 3) Conditionals");
        int age = 18;

        if (age >= 18)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are underage");
        }

        string day = "Monday";
        switch (day)
        {
            case "Monday":
                Console.WriteLine("Start of the week");
                break;
            case "Friday":
                Console.WriteLine("Almost weekend!");
                break;
            default:
                Console.WriteLine("Just another day");
                break;
        }

        Console.WriteLine("\n>> 4) Loops");

        // For
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"For loop, iteration {i}");
        }

        // While
        int counter = 0;
        while (counter < 3)
        {
            Console.WriteLine($"While loop, counter = {counter}");
            counter++;
        }

        // Foreach
        string[] fruits = { "Apple", "Banana", "Orange" };
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"Fruit: {fruit}");
        }

        Console.WriteLine("\n>> 5) Exceptions");
        try
        {
            int a = 10;
            int b = 0;
            int result = a / b; // ⚡ This will throw an exception
            Console.WriteLine(result);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("This block always executes");
        }
    }
}