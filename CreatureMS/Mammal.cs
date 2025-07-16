
public class Mammal : Creature
{
    public Mammal(string name, int age, int health) : base(name, age, health)
    {

    }

    public override string MakeSound()
    {
        return "*grunts*";
    }        
}