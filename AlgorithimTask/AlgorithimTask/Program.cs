#region Task1
// Verilmiş 3 rəqəmli ədədin rəqəmlərinin cəminin cüt olub-olmamasının tapılması.
int num = 456;

int hundreads = num / 100;
int tens = (num / 10) % 10;
int units = num % 10;

int sum = hundreads + tens + units;

if (sum % 2 == 0)
{
    Console.WriteLine("eded cutdur");

}
else
{
    Console.WriteLine("eded cut deyil");
    Console.WriteLine(sum % 2 == 1);
}


#endregion

#region Task2
// Verilmiş 3 rəqəmli ədədin rəqəmləri cəminin 3-ə və(&&) 5-ə bölünüb-bölünmədiyinin tapılması.
int num2 = 456;

int hundreads2 = num2 / 100;
int tens2 = (num2 / 10) % 10;
int units2 = num2 % 10;

int sum2 = hundreads2 + tens2 + units2;

// Way1
if (sum2 % 3 == 0 && sum2 % 5 == 0)
{
    Console.WriteLine("3-e ve 5-e qaliqsiz bolunur");
}
else
{
    Console.WriteLine("3-e ve 5-e qaliqsiz bolunmur");
}

//Way2 
if (sum2 % 15 == 0) Console.WriteLine("3-e ve 5-e qaliqsiz bolunur");

else Console.WriteLine("3-e ve 5-e qaliqsiz bolunmur");


#endregion

#region Task6
//Verilmiş 2 dəyişəndən 1-i işçinin maaşını digəri isə bank-dan götürmək istədiyi krediti göstərir edir. Əgər işçinin kredit götürmək istədiyi məbləğ illik gəlirinin 60 faizindən çox olarsa sorğunun uğursuz olduğu ekrana çıxsın əks təqdirdə prosesin uğurlu şəkildə həyata keçdiyi yazılsın.



int salary = 500;

int desiredCredit = 1000;

int yearlySalary = 12 * salary;

if (yearlySalary * 0.6 < desiredCredit)
{
    Console.WriteLine("Unapproved");
}
else
{
    Console.WriteLine("Approved");
}
#endregion