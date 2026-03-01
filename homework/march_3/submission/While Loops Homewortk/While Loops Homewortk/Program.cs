// Homework assignment due March 5th
// "While Loops"

//Welcome message and While Loop Menu
Console.WriteLine("> Greetings. Please select a While Loop you'd like to observe:");
Console.WriteLine("[1] 1-5");
Console.WriteLine("[2] 100-150");
Console.WriteLine("[3] 0-100 Evens");
Console.WriteLine("[4] 20 to -20");
Console.WriteLine("[5] 1-100 by 3s");
Console.WriteLine("[6] 1-1024 by Powers of 2");
Console.WriteLine("[7] Ask User Loop");
Console.WriteLine("[8] True and False");
Console.WriteLine("[9] 1-20 Number is Odd or Even");
Console.WriteLine("[10] Poem");
Console.WriteLine("[11] Fizz Buzz");
Console.WriteLine("> Select a loop using it's [number]!");

//Prompt User 
var loopSelection = Console.ReadLine();

//Start Message (To separate user input from output)
Console.WriteLine("> Okay. Beginning loop "+loopSelection+".");

//Begin While Loops 'if' tree

// 1-5 While Loop
if (loopSelection == "1")
{
    int i = 0;

    while (i <= 4)
    {
        Console.WriteLine(i + 1);
        i++;
    }
}

// 100-150 While Loop
else if (loopSelection == "2")
{
    int i = 100;

    while (i <= 150)
    {
        Console.WriteLine(i);
        i++;
    }
}

// 0-100 Evens While Loop
else if (loopSelection == "3")
{
    int i = 0;

    while (i <= 100)
    {
        Console.WriteLine(i);
        i++;
        i++;
    }
}

// 20 to -20 While Loop
else if (loopSelection == "4")
{
    int i = 20;

    while (i >= -20)
    {
        Console.WriteLine(i);
        i--;
    }
}

// 1-100 by 3s
else if (loopSelection == "5")
{
    int i = 0;

    while (i <= 100)
    {
        Console.WriteLine(i + 1);
        i++;
        i++;
        i++;
    }
}

// 1-1024 by powers of 2
else if (loopSelection == "6")
{
    int i = 1;

    while (i <= 1024)
    {
        Console.WriteLine(i);
        i *= 2;
    }
}

// Ask User Loop While Loop
else if (loopSelection == "7")
{
    int i = 1;

    do
    {
        Console.WriteLine("Do you want the loop to stop?");
        string loopSeven = Console.ReadLine();
        if (loopSeven == "Y" || loopSeven == "y" || loopSeven == "Yes" || loopSeven == "yes")
        {
            i = 0;
        }
        else
        {
            i = 1;
        }
    } while (i >= 1);
}

// True and False While Loop
else if (loopSelection == "8")
{
    Console.WriteLine("> How many times would you like to iterate this loop?");
    var loopEightLength = Console.ReadLine();
    Console.WriteLine("> Understood.");
    
    int i = 0;
    int j = 0;

    while (j <= int.Parse(loopEightLength)-1)
    {
        if (i <= 0)
        {
            Console.WriteLine("True");
            i++;
            j++;
        }
        else if (i >= 1)
        {
            Console.WriteLine("False");
            i--;
            j++;
        }
    }
}

// Number is odd or even While Loop
else if (loopSelection == "9")
{
    int i = 0;
    var isEven = 0;

    while (i <= 19)
    {
        if (isEven == 0)
        {
            Console.WriteLine(i+1+" is odd.");
            isEven = 1;
            i++;
        }
        else if (isEven == 1)
        {
            Console.WriteLine(i+1+" is even.");
            isEven = 0;
            i++;
        }
    }
}

// Poem While Loop
else if (loopSelection == "10")
{
    string[] words = { "once", "upon", "a", "midnight", "dreary" };
    int i = 0;

    while (i <= 4)
    {
        Console.WriteLine(words[i]);
        i++;
    }
    
}

// Fizz Buzz While Loop
else if (loopSelection == "11")
{
    int i = 1;
    bool multThree = false;
    bool multFive = false;

    while (i <= 45)
    {
        // Checking FizzBuzz Conditions
        if (i % 3 == 0) 
        {
            multThree = true;
        }

        if (i % 5 == 0)
        {
            multFive = true;
        }
        // Output
        if (multThree == true && multFive == true)
        {
            Console.WriteLine("FizzBuzz");
            i++;
        }
        else if (multThree == true && multFive == false)
        {
            Console.WriteLine("Fizz");
        }
        else if (multThree == false && multFive == true)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }

        // Increase Integer and Reset Conditions
        i++;
        multThree = false;
        multFive = false;
    }
}

// Else
else
{
    Console.WriteLine("> That was not an acceptable input. Goodbye.");
}