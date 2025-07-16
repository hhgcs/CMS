
using System.ComponentModel.DataAnnotations;

public class Creature
{

    // Constructor
    public Creature(string name, int age, int health)
    {
        _name = name;
        _age = age;
        _health = health;
    }

    // Private fields
    private string _name;
    private int _health;
    private int _age;

    // Public Properties
    public string? Name { get; }
    public int Health
    {
        get { return _health; }
        set
        {
            _health = value < 0 ? 0 : value;
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

    // public Methods
    public void DisplayInfo()
    {
        Console.WriteLine($"Creature \nName: {Name} \nAge: {Age} \nHealt: {Health}");
    }

}