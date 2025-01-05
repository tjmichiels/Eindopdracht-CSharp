using Eindopdracht_CSharp.Enums;

namespace Eindopdracht_CSharp.Models;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Species { get; set; }
    public Category Category { get; set; }
    public Enclosure Enclosure { get; set; }
    public AnimalSize Size { get; set; }
    public DietaryClass DietaryClass { get; set; }
    public ActivityPattern ActivityPattern { get; set; }
    public List<Animal> Prey { get; set; }
    public double SpaceRequirement { get; set; }
    public SecurityLevel SecurityRequirement { get; set; }
}