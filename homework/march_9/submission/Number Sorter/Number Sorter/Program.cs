// Number Sorter Homework Assignment
// Take a list of random numbers, and using a while loop, find the biggest and smallest numbers in the array

// Introduce User

Console.WriteLine("> Welcome to Jackson's Number Sorting Program.");
Console.WriteLine("> This program will sort any five numbers that you input!");

// Prompt User Inputs

Console.WriteLine("> To begin, provide your first number (#).");
int j = int.Parse(Console.ReadLine());
Console.WriteLine("> Now your second number (#).");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("> Now your third (#).");
int l = int.Parse(Console.ReadLine());
Console.WriteLine("> And your fourth (#).");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("> Your final number (#).");
int n = int.Parse(Console.ReadLine());

Console.WriteLine("> The program will now begin sorting your numbers");

// Create Array with User Inputs

int[] numbers = new int[] { j, k, l, m, n };

// ~Sort Mechanic~

// Declare Comparison Variables

int smallest = numbers[0];
int biggest = numbers[0];
int i = 1;

// Run Loop with Comparison Vars

while (i < numbers.Length)
{
    if (numbers[i] < smallest)
    {
        smallest = numbers[i];
    }
    if (numbers[i] > biggest)
    {
        biggest = numbers[i];
    }
    i++;
}

// Output

Console.WriteLine("> Your smallest number is: " + smallest);
Console.WriteLine("> Your biggest number is: " + biggest);
Console.WriteLine("> Goodbye!");


