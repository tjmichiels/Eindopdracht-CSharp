using System.ComponentModel.DataAnnotations;
using Eindopdracht_CSharp.Enums;

namespace Eindopdracht_CSharp.Models;

public class Animal
{
    [Required]
    public int Id { get; }
    
    [MaxLength(100)]
    public string Name { get; set; }
    
    [Required]
    public Species Species { get; }
    
    public Category Category { get; set; }
    public Enclosure Enclosure { get; set; }
    public AnimalSize Size { get; }
    public DietaryClass DietaryClass { get; }
    public ActivityPattern ActivityPattern { get; }
    public HashSet<Animal> Prey { get; set; }
    public double SpaceRequirement { get; set; } // square meters per animal
    public SecurityLevel SecurityRequirement { get; set; }

    public Animal(int id, string name, Species species, AnimalSize size, DietaryClass dietaryClass,
        ActivityPattern activityPattern, double spaceRequirement, SecurityLevel securityRequirement)
    {
        Id = id;
        Name = name;
        Species = species;
        Size = size;
        DietaryClass = dietaryClass;
        ActivityPattern = activityPattern;
        SpaceRequirement = spaceRequirement;
        SecurityRequirement = securityRequirement;
        Prey = new HashSet<Animal>();
    }

    public string Sunrise()
    {
        // Actie Sunrise die aangeeft of het dier wakker wordt of gaan slapen of altijd actief is.
        return string.Empty;
    }

    public string Sunset()
    {
        // Actie Sunset die aangeeft of het dier wakker wordt of gaan slapen of altijd actief is.
        return string.Empty;
    }
}