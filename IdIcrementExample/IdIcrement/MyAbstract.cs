namespace IdIncrement;

#region Notes

/*
 Static Class member-lər bir başa olaraq Class-a aid olur. Class-a ilk müraciət edildiyi zaman gedir yaddaşda yerini ayırır.

 Lakin Non-static Class member-lər isə bir başaolaraq obyekt-ə aid olur. Və hər bir obyekt üçün özünəxas olur.
 */

#endregion

public abstract class MyAbstract
{
    private static int _counter;
    public int Id { get; set; }

    protected MyAbstract()
    {
        _counter++;
        Id = _counter;
    }

}

public class MyDerivedClass : MyAbstract
{
    public MyDerivedClass() : base()
    {

    }

}

public class MyDerivedClass2 : MyAbstract
{
    public MyDerivedClass2() : base()
    {

    }
}
