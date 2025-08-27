
try
{
    Console.WriteLine("???");
    int a = int.Parse(Console.ReadLine());
    int b = a;
    int count = 0;
    while (a > 0)
    {
        if (a % 2 == 0) { count++; }
        a--;
    }
    Console.WriteLine($"чётных чисел {count} нечётных чисел {b - count}");
}
catch { Console.WriteLine("you're wrong !!! "); }
Console.ReadLine();

















//Console.WriteLine("give me a num, sir");

//try
//{
//    int num = int.Parse(Console.ReadLine());
//    if (num % 2 != 0) { Console.WriteLine("чётное"); } else { Console.WriteLine("нечётное"); }
//}
//catch
//{
//    Console.WriteLine("you're wrong !!! ");
//}

//try
//{
//    Console.WriteLine("первое число? ");
//    double num = double.Parse(Console.ReadLine());
//    Console.WriteLine("второе число? ");
//    double num2 = double.Parse(Console.ReadLine());
//    Console.WriteLine("выбери действие + - / * ");
//    string act = Console.ReadLine();

//if (act == "+") { Console.WriteLine($"{num} + {num2} = {num + num2}"); }
//if (act == "-") { Console.WriteLine($"{num} - {num2} = {num - num2}"); }
//if (act == "/") { Console.WriteLine($"{num} / {num2} = {num / num2}"); }
//if (act == "*") { Console.WriteLine($"{num} * {num2} = {num * num2}"); }
//else
//{
//    Console.WriteLine("you're wrong with action !!! ");
//}
//    switch (act)
//    {
//        case "+" :
//            Console.WriteLine($"{num} + {num2} = {num + num2}");
//            break;
//        case "-" :
//            Console.WriteLine($"{num} - {num2} = {num - num2}");
//            break;
//        case "*":
//            Console.WriteLine($"{num} * {num2} = {num * num2}");
//            break;
//        case "/":
//            Console.WriteLine($"{num} / {num2} = {num / num2}");
//            break;
//            Console.WriteLine("you're wrong with action !!! ");
//        default:

//            break;
//    }
//}
//catch
//{
//    Console.WriteLine("you're wrong !!! ");
//    Console.ReadLine();
//}

