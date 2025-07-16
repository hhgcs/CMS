public class Griffin : Mammal, ICanFly
{
    public Griffin(string name, int age, int health) : base(name, age, health) { }

    public override string MakeSound()
    {
        return "*Griffin noises*";
    }

    public void Fly()
    {
        Console.WriteLine("*Beats its powerful wings and takes off*");
    }
}