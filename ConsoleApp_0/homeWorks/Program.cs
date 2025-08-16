
Console.WriteLine("give me a num, sir");

try
{
    int num = int.Parse(Console.ReadLine());
    if (num % 2 != 0) { Console.WriteLine("чётное"); } else { Console.WriteLine("нечётное"); }
}
catch
{
    Console.WriteLine("you're wrong !!! ");
}