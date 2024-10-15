#region Notes

/*
Declare - təyin olunmaq, elan edilmək və s.                                               int age;
Set - dəyər daxil etmək. və ya Assign - mənimsətmək                                       age = 22;
Initialize - obyektlərin yaranması                                      Person person = new Person()
                                                                                                 {prop1 = value};
*/

/*
OOP Principles
Inheritance - miras alma
Encapsulation - kapsullama
          Abstraction
Polymorphism
*/

/*
Class members - field-lar, property-lər, method-lar, constructor-lar, [indexer-lər]

Field - Class-ın xüsusiyyətlərini saxlamaq üçün istifadə edilən, class daxilində yaradılan variable-lardır.

Property - Get və Set method-u olan field-lardır. Assembly səviyəsində bir field yaradır , get və set method-larını avtomatik generate edir.
*/

/*
Readonly - Hər hansısa bir dəyişəni yalnızca dəyərini oxunmaq üçün istifadə edə bilərik. Yəni biz bu dəyişənə başqa bir dəyər mənimsədə bilmərik. Property və Field-lara aiddir.

Readonly olaraq təyin olunan field və ya property-ə yalnızca Constructor daxilində və təyin edildikləri(yəni field və ya property-in elan olunduqları yerdə, class daxilində) yerdə dəyər set oluna bilər.

Readonly field - Readonly keyword ilə təyin olunur.

Readonly property - Set method-u yazılmadan sadəcə Get method-u yazılaraq readonly təyin edilir.

 Init only(init setter) - Readonly PROPERTY-dən fərqli olaraq Object Initialize(obyekt yaranan zaman) olan yerdə də dəyər mənimsədilə bilər. Bu da o deməkdir ki, Init only yalnızca PROPERTY-lərdə istifadə edilə bilər. Set method əvəzinə Init keyword yazılaraq təyin olunur.
*/

/*
Method Signature(yəni method imzası) -Method - un adı, qəbul etdiyi paremetrlərdir.

 Paremetr dedikdə onlarla bağlı qaydalara AIDDIR: Parametrlərin sayı, Parametrlərin tipi və Parametrlərin ardıcıllığı.

 Paremetr dedikdə onlarla bağlı qaydalara AID DEYIL: Parametrlərin adı. Method - un Return type
*/

/*
 Polymorphism - Yunan dilindən tərcümədə Çox biçimlilik(formalılıq) deməkdir. Polymorphism 2 cür olur. Dynamic və Static.
 

Overload - Eyni adda fərqli imzalara sahib method-ların və Constructor-ların yaranamsı deməkdir. Bu proses EYNİ class daxilində baş verəcək. Static Poylmorphism adlanır. Compile time Polymorphism 

 Override - Base class-ın method-un derived class daxilində EYNİ İMZAYA sahib şəkildə body-in özünə məxsus şəkildə dəyişdirilməsinə override deyilir. Dynamic Poylmorphism adlanır. Run time Polymorphism 

 Base class-ın override olunacaq method-u virtual olaraq təyin edilir. Derived class daxilində isə həmin method override keyword ilə təyin edilir. 

 */

#endregion


using AB205OOPPart2;


BaseCreature dog = new Dog();
dog.Talk();



BaseCreature cat = new Cat();
cat.Talk();



BaseCreature person = new Person();
person.Talk();