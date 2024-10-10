int num = 123456789;
int result = 0;

while (num > 0)
{

    result = result * 10 + num % 10;
    num = num - num % 10;
    num /= 10;
}

Console.WriteLine(result);