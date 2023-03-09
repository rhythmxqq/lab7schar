using System;

public abstract class Transport
{
    public abstract double Speed { get; }
    public abstract double CarryingCapacity { get; }
    public abstract double Range { get; }

    public abstract string GetProperties();
}

public abstract class Car : Transport
{
    public string Brand { get; set; }

    public override string GetProperties()
    {
        return $"{Brand} грузоподъемностью в {CarryingCapacity}кг может проехать {Range}км";
    }
}

public class MercedesBenz : Car
{
    public override double Speed => 200;
    public override double CarryingCapacity => 500;
    public override double Range => 800;

    public MercedesBenz()
    {
        Brand = "Mercedes-Benz";
    }
}

public abstract class Airplane : Transport
{
    public string Model { get; set; }

    public override string GetProperties()
    {
        return $"{Model} грузоподъемностью в {CarryingCapacity}кг может пролететь {Range}км";
    }
}

public class Boeing : Airplane
{
    public override double Speed => 850;
    public override double CarryingCapacity => 10000;
    public override double Range => 12000;

    public Boeing()
    {
        Model = "Boeing 747";
    }
}

public abstract class Ship : Transport
{
    public string Name { get; set; }

    public override string GetProperties()
    {
        return $"{Name} грузоподъемностью в {CarryingCapacity}кг может плавать на расстояние {Range}км";
    }
}

public class Titanic : Ship
{
    public override double Speed => 23;
    public override double CarryingCapacity => 5000;
    public override double Range => 4000;

    public Titanic()
    {
        Name = "Titanic";
    }
}

class Program
{
    static void Main(string[] args)
    {
        MercedesBenz mercedesBenz = new MercedesBenz();
        Console.WriteLine(mercedesBenz.GetProperties());

        Boeing boeing = new Boeing();
        Console.WriteLine(boeing.GetProperties());

        Titanic titanic = new Titanic();
        Console.WriteLine(titanic.GetProperties());
    }
}
