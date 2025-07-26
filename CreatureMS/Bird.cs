public class Bird : Creature, ICanFly
{
    public Bird(string name, int age, int health) : base(name, age, health)
    {

    }
    public override string MakeSound()
    {
        return "*chirps*";
    }
    public void Fly()
    {
        Console.WriteLine("*Soars through the sky*");
    }
}