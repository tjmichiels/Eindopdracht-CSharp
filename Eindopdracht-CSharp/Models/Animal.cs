using Eindopdracht_CSharp.Enums;

namespace Eindopdracht_CSharp.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Species Species { get; set; }
    public Category Category { get; set; }
    public Enclosure Enclosure { get; set; }
    public AnimalSize Size { get; set; }
    public DietaryClass DietaryClass { get; set; }
    public ActivityPattern ActivityPattern { get; set; }
    public HashSet<Animal> Prey { get; set; }
    public double SpaceRequirement { get; set; } // square meters per animal
    public SecurityLevel SecurityRequirement { get; set; }
}