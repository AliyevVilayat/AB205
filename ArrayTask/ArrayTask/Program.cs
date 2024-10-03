



#region Task1

//1.Verilmiş natural ədədlərdən ibarət olan array daxilində ən böyük cüt elementin tapılması.

int[] numbers = { 13, 11, 1002, 9, 1001, 88, 99, 1004 };
int maxNum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > maxNum && numbers[i] % 2 == 0)
    {
        maxNum = numbers[i];
    }
}

if (maxNum == 0)
{
    Console.WriteLine("Array daxilində cüt ədədə rast gəlinmədi");
}
else
{

    Console.WriteLine("Max even num: " + maxNum);
}

#endregion


#region Task2

//2.Verilmiş natural ədədlərdən ibarət olan array daxilində ən kiçik tək elementin tapılması.

int[] numbers2 = { 13, 11, 1002, 9, 1001, 88, 99, 7, 1004 };

int minNum = 0;
foreach (int num in numbers2)
{
    if (num % 2 != 0)
    {
        minNum = num;
        break;
    }
}

if (minNum == 0) Console.WriteLine("Tek edede rast gelinmedi");
else
{

    for (int i = 0; i < numbers2.Length; i++)
    {
        if (minNum > numbers2[i] && numbers2[i] % 2 == 1)
        {
            minNum = numbers2[i];
        }
    }

    Console.WriteLine("Min odd number: " + minNum);

}
#endregion

#region Task3

//3.Verilmiş array-ın elementlərinin tərsinə çevrilməsi.

int[] numbers3 = { 13, 11, 1002, 9, 1001, 88, 99, 1004 };

int[] reversNumbers3 = new int[numbers3.Length];

int indexReverse = default;
for (int i = 0; i < reversNumbers3.Length; i++)
{
    indexReverse = (numbers3.Length - 1) - i;
    reversNumbers3[i] = numbers3[indexReverse];
}

Console.WriteLine("Normal Array:");
foreach (int num in numbers3)
{
    Console.Write(num + " ");
}

Console.WriteLine(" ----------------------");

Console.WriteLine("Reversed Array:");
foreach (int num in reversNumbers3)
{
    Console.Write(num + " ");
}

#endregion