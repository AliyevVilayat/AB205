//Fibonacci
// 0 1 1 2 3 5 8 13 21 34 55 89 144
#region FibonacciWay1

int fibonacci = 0;
int nextNum = 1;
int index = 0;

Console.Write("Fibonacci ededleri: ");
while (index != 15)
{
    Console.Write(fibonacci);
    Console.Write(" ");

    nextNum = nextNum + fibonacci;
    fibonacci = nextNum - fibonacci;

    index++;

}
#endregion

#region FibonacciWay2

int[] arr = new int[25];
arr[0] = 0;
arr[1] = 1;

//i = 0
for (int i = 0; i < arr.Length - 2; i++)
{
    arr[i + 2] = arr[i + 1] + arr[i];
}

//i = 1
for (int i = 1; i < arr.Length - 1; i++)
{
    arr[i + 1] = arr[i] + arr[i - 1];
}

//i = 2
for (int i = 2; i < arr.Length; i++)
{
    arr[i] = arr[i - 1] + arr[i - 2];
}

foreach (int i in arr)
{
    Console.Write(i);
    Console.Write(" ");
}

#endregion



//Verilmiş ədədin (N rəqəmli) rəqəmlərindən düzəldilə biləcək ən böyük ədədi tapan proqram.