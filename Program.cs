while (true)
{
    try
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("--------------- ");
        Console.Write("CALCULATOR");
        Console.Write(" ---------------");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nInput a value: ");
        Console.ForegroundColor = ConsoleColor.White;
        double value1 = Convert.ToDouble(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Operators [ + ; - ; * ; / ]: ");
        Console.ForegroundColor = ConsoleColor.White;
        char opr = Convert.ToChar(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Enter a second value: ");
        Console.ForegroundColor = ConsoleColor.White;
        double value2 = Convert.ToDouble(Console.ReadLine());

        double result = 0.0;

        switch (opr)
        {
            case '+':
                result = value1 + value2;
                break;
            case '-':
                result = value1 - value2;
                break;
            case '*':
                result = value1 * value2;
                break;
            case '/':
                if (value2 != 0)
                {
                    result = value1 / value2;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error: No value can be divided by zero!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                break;
            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: Invalid operator input!");
                Console.ForegroundColor = ConsoleColor.White;
                break;
        }
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("==================");
        Console.WriteLine("Result: " + result);
        Console.WriteLine("==================");
        Console.ForegroundColor = ConsoleColor.White;
    }
    catch (Exception)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error: Invalid value");
        Console.ForegroundColor = ConsoleColor.White;
    }
Console.WriteLine("==========================================");
}