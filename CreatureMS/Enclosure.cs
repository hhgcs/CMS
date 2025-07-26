using Microsoft.VisualBasic;

public class Enclosure<T> where T : Creature
{
    // constructor
    public Enclosure(string name)
    {
        _name = name;
    }

    // private fields
    private readonly Dictionary<string, T> _residents = new();
    private string _name;
    public string Name { get { return _name; } }

    public void AddCreature(T creature)
    {
        creature.HealthChangeHandle += (creat, delta) =>
        {
            Console.WriteLine($"[Enclosure Log]: {creat.Name}'s health changed by {delta}!");
        };
        _residents.Add(creature.Name, creature);
    }
    public void DisplayResidents()
    {
        foreach (T resident in _residents.Values)
        {
            resident.DisplayInfo();
        }
    }

    public T? FindCreatureByName(string name)
    {
        _residents.TryGetValue(name, out T? creature);
        return creature;
    }

    public IEnumerable<T> GetCreaturesSortedByName()
    {
        return _residents.Values.OrderBy(c => c);
    }
    public IEnumerable<T> GetCreaturesWithHealthBelow(int threshold)
    {
        return _residents.Values.Where(c => c.Age < threshold);
    }
    public Dictionary<int, List<T>> GroupCreaturesByAge()
    {
        var groups = _residents.Values.GroupBy(c => c.Age).ToDictionary(g => g.Key, g => g.ToList());
        return groups;
    }

    public Creature GetStrongestCreature()
    {
        return _residents.OrderByDescending(c => c.Value.Health).FirstOrDefault().Value;
    }

}