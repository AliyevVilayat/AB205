#region Notes
//If serti yalnız doğru olduğu halda (yəni daxilində yer alan ifadə true olduğu halda) onun code block-a daxil olur və code block-u işə düşür.
#endregion

//[datatype][variable] = [value]


string name = "MirHuseyn";
string surname = "Talibzade";
int age = 20;
float gpa = 79.5f;

//Console.WriteLine("Telebenin adi ve soyadi:" + name + " " + surname + ", Yasi:" + age);

#region If-then
/*if (age < 18)
{
    Console.WriteLine("18 yasindan kicik vetendaslara siqaret ve ya icki satisi qeti qadagandir. Istifade etmemeyi qetiyyetle tovsiye edirik.");
}*/
#endregion

#region If-then-else

/*if (age < 18)
{
    Console.WriteLine("18 yasindan kicik vetendaslara siqaret ve ya icki satisi qeti qadagandir. Istifade etmemeyi qetiyyetle tovsiye edirik.");
}
else
{
    Console.WriteLine("Icaze var lakin meslehet gorulmur");
}*/
#endregion

#region Else-If
//Task: Tələbənin GPA -nə uyğun olaraq semestr sonu hansı bal (A-F) alacağını qeyd edin.

if (gpa >= 91)
{
    Console.WriteLine("A");
}
else if (gpa >= 81)
{
    Console.WriteLine("B");
}
else if (gpa >= 71)
{
    Console.WriteLine("C");
}
else if (gpa >= 61)
{
    Console.WriteLine("D");
}
else if (gpa >= 51)
{
    Console.WriteLine("E");
}
else
{
    Console.WriteLine("Good Game");
}

#endregion

#region Switch Statement
//Task Else-If ilə yazılmış bu task-ı indi də Switch Statement ilə yazın. (Pattern Matching).
switch (gpa)
{
    case >= 91:

        Console.WriteLine("A");
        break;

    default:
        Console.WriteLine("Kesr");
        break;

}
#endregion