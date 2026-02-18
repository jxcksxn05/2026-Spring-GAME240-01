Console.WriteLine("> Hello, what is your name?");

var name = Console.ReadLine();

Console.WriteLine("> Hello there, " +name+ ".");

Console.WriteLine("> Is it your birthday?");

var isBirthday = Console.ReadLine();

if (isBirthday == "yes")
{
    Console.WriteLine("> Well, happy birthday!");
    Console.WriteLine("> How old are you, "+name+"?");

    var age = Console.ReadLine();

    Console.WriteLine("> That's great, "+name+"! You are "+age+" years old!");
}

else if (isBirthday == "no")
{
    Console.WriteLine("> Well I hope you are looking forward to it!");
}
else
{
    Console.WriteLine("> Huh?");
}