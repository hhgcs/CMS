public class Reptile : Creature
{
    public Reptile(string name, int age, int health) : base(name, age, health)
    {
    }

    public override string MakeSound()
    {
        return "*hisses*";
    }

    public override void Move() {
        Console.WriteLine("*Reptile moves forward*");
    }

}