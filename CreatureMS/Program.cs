
public static class Program
{

    public static void Main(string[] args)
    {
        var grandEnclosure = new Enclosure<Creature>("The Grand Enclosure");
        grandEnclosure.AddCreature(new Reptile("Viper", 100, 5));
        grandEnclosure.AddCreature(new Mammal("Wolf", 150, 3));
        grandEnclosure.AddCreature(new Bird("Eagle", 120, 5));
        grandEnclosure.AddCreature(new Mammal("Bear", 300, 3));

        Console.WriteLine("--- Creatures sorted by name (natural order) ---");
        var sortedCreatures = grandEnclosure.GetCreaturesSortedByName();
        foreach (var c in sortedCreatures)
        {
            c.DisplayInfo();
        }

        Console.WriteLine("\n--- Creatures with health below 130 ---");
        var weakCreatures = grandEnclosure.GetCreaturesWithHealthBelow(130);
        foreach (var c in weakCreatures)
        {
            c.DisplayInfo();
        }

        Console.WriteLine("\n--- Grouped by Age ---");
        var groupedByAge = grandEnclosure.GroupCreaturesByAge();
        foreach (var ageGroup in groupedByAge)
        {
            Console.WriteLine($"Age: {ageGroup.Key}");
            foreach (var creature in ageGroup.Value)
            {
                Console.WriteLine($"  - {creature.Name}");
            }
        }
    }
    // Expected output will include "[Enclosure Log]: Silverfang's health changed!"
}