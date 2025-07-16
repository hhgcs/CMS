
public static class Program
{
    public static void Main(string[] args)
    {
        Creature goblin = new("Grizelda", 100, 5);
        goblin.DisplayInfo(); // Expected: Name: Grizelda, Health: 100, Age: 5

        // Test the health property's validation
        goblin.Health -= 120;
        Console.WriteLine($"Grizelda took 120 damage!");
        goblin.DisplayInfo(); // Expected: Name: Grizelda, Health: 0, Age: 5

        goblin.Age = 6;
        Console.WriteLine($"Grizelda had a birthday!");
        goblin.DisplayInfo(); // Expected: Name: Grizelda, Health: 0, Age: 6
    }
}