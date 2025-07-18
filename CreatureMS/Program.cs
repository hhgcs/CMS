
public static class Program
{
    public static void Main(string[] args)
{
    // Note: You can't do `new Creature(...)` anymore because it's abstract!

    var wolf = new Mammal("Silverfang", 150, 4);
    var lizard = new Reptile("Scaly", 80, 2);

    List<Creature> creatures = new List<Creature> { wolf, lizard };

    foreach (var creature in creatures)
    {
        creature.DisplayInfo();
        Console.WriteLine($"Sound: {creature.MakeSound()}");
        creature.Move();
        Console.WriteLine("--------------------");
    }
}
}