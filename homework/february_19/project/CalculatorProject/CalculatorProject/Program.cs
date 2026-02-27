Console.WriteLine("> Hello! What would you like to calculate?");
Console.WriteLine("> Choose an operation: 'add', 'subtract', 'multiply', or 'divide'.");

string operation = Console.ReadLine();

if (operation == "add" || operation == "subtract" || operation == "multiply" || operation == "divide")
{
    Console.WriteLine("> Great! What is the first number that you'd like to " +operation+ "?");
    double firstNumber = double.Parse(Console.ReadLine());
    Console.WriteLine("> And what is the second number you'd like to " +operation+ "?");
    double secondNumber = double.Parse(Console.ReadLine());

    if (operation == "add")
    {
        Console.WriteLine("> Your result is:");
        Console.WriteLine(firstNumber + secondNumber);
    }
    else if (operation == "subtract")
    {
        Console.WriteLine("> Your result is:");
        Console.WriteLine(firstNumber - secondNumber);
    }
    else if (operation == "multiply")
    {
        Console.WriteLine("> Your result is:");
        Console.WriteLine(+firstNumber * secondNumber);
    }
    else if (operation == "divide")
    {
        if (secondNumber == 0)
        {
            Console.WriteLine("> Cannot divide by zero.");
        }
        else
        {
            Console.WriteLine("> Your result is:");
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
else
{
    Console.WriteLine("> That is not an acceptable operation.");
}