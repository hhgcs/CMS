public class Fish : Creature, ICanSwim
{
    public Fish(string name, int age, int health) : base(name, age, health)
    {
    }

    public override string MakeSound()
    {
        return "*Glup glup*";
    }

    public void Swim()
    {
        Console.WriteLine("*Darts through the water");
    }
}