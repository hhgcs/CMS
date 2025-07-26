
using System.ComponentModel.DataAnnotations;

public abstract class Creature : IComparable<Creature>
{
    // Delegate
    public event Action<Creature, int> HealthChangeHandle;
    // legacy: 
    // public delegate void HealthChangeHandle(Creature creature, int healtChange);

    // Constructor
    public Creature(string name, int age, int health)
    {
        _name = name;
        _age = age;
        _health = health;
    }

    // Private fields
    private readonly string _name;
    private int _health;
    private int _age;

    // Public Properties
    public string Name { get { return _name; } }
    public int Health
    {
        get { return _health; }
        set
        {
            _health = value < 0 ? 0 : value;
            OnHealthChange(this, value - _health);
        }
    }
    public int Age
    {
        get { return _age; }
        set
        {
            _age = value < 0 ? 0 : value;
        }
    }

    // public methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Creature \nName: {Name} \nAge: {Age} \nHealt: {Health}");
    }

    public int CompareTo(Creature? other)
    {
        if (other == null) { return 1; }
        return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
    }

    // virtual (overridable)
    public virtual void Move()
    {
        Console.WriteLine("The creature shuffles forward");
    }

    // abstract
    public abstract string MakeSound();

    // private methods
    protected virtual void OnHealthChange(Creature creature, int healthDelta)
    {
        HealthChangeHandle?.Invoke(creature, healthDelta);
    }
}