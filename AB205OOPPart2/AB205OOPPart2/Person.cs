namespace AB205OOPPart2;


public class Dog : BaseCreature
{

    public override void Talk()
    {
        Console.WriteLine("Dog say something");
    }
}

public class Cat : BaseCreature
{

    public override void Talk()
    {
        Console.WriteLine("Cat say something");
    }
}

public class Person : BaseCreature
{

    public override void Talk()
    {
        Console.WriteLine("Person say something");
    }
}

public class BaseCreature
{
    public virtual void Talk()
    {
        Console.WriteLine("Creatures say something");
    }
}
