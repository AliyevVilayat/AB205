
#region Notes

/*
int num = 123;
Console.WriteLine(num / 10); // Div bölmə => 12

Console.WriteLine(num % 10); // Mod bölmə => 3
*/

#endregion

#region SwitchCasePatternMatchingTask
int point = 101;
switch (point)
{

    case >= 91 and < 100:

        Console.WriteLine("A");
        Console.ReadLine();
        break;

    case int p when p <= 90 && p >= 81:

        Console.WriteLine(p + " = B");
        Console.WriteLine("B");
        Console.ReadLine();
        break;

    case int p when p <= 80 && p >= 71:
        Console.WriteLine("C");
        Console.ReadLine();
        break;

    case >= 61:
        Console.WriteLine("D");
        Console.ReadLine();
        break;

    case >= 51:
        Console.WriteLine("E");
        Console.ReadLine();
        break;


    default:
        Console.WriteLine("Good Game");
        Console.ReadLine();
        break;

}
#endregion


