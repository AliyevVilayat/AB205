namespace MyNameSpace2;


#region Notes

//Inheritance - Miras alma nəticəsində class adlandırılması dəyişir. Miras alan class DERIVED class adlanır. Miras verən class isə BASE class adlanır. 
// DerivedClass : BaseClass

//Miras alma prosesi nəticəsində nə baş verəcək?
//Base class daxilində yer alan bütün field-lar, method-lar, constructor-lar bir sözlə desək Class Member-lar Derived class daxilində əl çatan olacaq.

//This & Base keywords - Əgər ki, yer aldığımız class daxilində hər hansısa bir field-a müraciət etmək istəsək bunun üçün this keyword-dən istifadə etməliyik. Əgər ki, yer aldığımız class daxilində Base class-ın hər hansısa class member-a müraciət etmək istəsək bunun üçün Base keyword-dən istifadə edirik.


//Constructor - Obyekt yaranan zaman( və ya obyekt new-lanan zaman və ya obyekt instance alınan zaman hər 3 ifadədə eyni mənanı kəsb edir.) işə düşən return type-ı olmayan bir method-dur. Class-ın adı ilə yazılır. Parametr qəbul edə bilər. Parameterless(default və ya boş da adlanır) constructor vardır.

//Parameterless constructor, biz gəlib onu class daxilində yazmazsaq və ya heç bir overload halını yazmazsaq Assmebly səviyyəsində özü əlavə ediləcək. Əgər Parameterless constructor yazılmazsa və hər hansısa bir overload halı yazılarsa bu zaman parameterless halı işlənə bilməz.

//Constructor calling - Constructor özünü call edə bilməz. Yalnızca rekursivlik yaranmadan digər constructor-ları çağıra bilərlər. Bu proses This və Base keyword ilə baş verir.

//Constructor-lar bir-birini call edən zaman ilk olaraq call olunan işə düşür. Hər bir constructor yalnızca 1 constructor-u çağıra bilər.

#endregion

//[Access Modifier] [Class Keyword] [Class Name] - Class declaration-a bir nümunə
public class BaseClass
{

    public BaseClass()
    {

    }
    public BaseClass(string name)
    {

    }

}


public class DerivedClass : BaseClass
{

    public DerivedClass()
    {
        Console.WriteLine("Hello from Parameterless Constructor");

    }
    public DerivedClass(int num) //this() => DerivedClass()
    {
        Console.WriteLine("Hello from takes 1 Parameter Constructor");

    }

    public DerivedClass(int num, string name)
    {
        Console.WriteLine("Hello from takes 2 Parameter Constructor");
    }

}