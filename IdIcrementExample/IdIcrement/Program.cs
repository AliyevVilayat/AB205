/*
 
 
NOT: Id bizim tərəfimizdən daxil edilməməli, hər dəfə Employee'dan miras alan class'ın instace'ı alınan zaman avtomatik olaraq özü arxa tərəfdə Id-ə mənimsədilməlidir. Lakin bilməli olduğumuz məqam Id hər bir object üçün unique olmalıdır. Bu da deməkdir ki Id property readonly olmalıdır. Və static olaraq artan bir counter field'a ehtiyyacımız olacaq.
 */


using IdIncrement;

MyDerivedClass obj = new MyDerivedClass();
Console.WriteLine(obj.Id);

MyDerivedClass obj2 = new MyDerivedClass();
Console.WriteLine(obj2.Id);

MyDerivedClass obj3 = new MyDerivedClass();
Console.WriteLine(obj3.Id);

Console.WriteLine("----------------------------------------");


MyDerivedClass2 obj4 = new MyDerivedClass2();
Console.WriteLine(obj4.Id);

MyDerivedClass2 obj5 = new MyDerivedClass2();
Console.WriteLine(obj5.Id);

MyDerivedClass2 obj6 = new MyDerivedClass2();
Console.WriteLine(obj6.Id);
