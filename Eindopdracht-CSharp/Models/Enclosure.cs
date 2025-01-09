using System.ComponentModel.DataAnnotations;
using Eindopdracht_CSharp.Enums;

namespace Eindopdracht_CSharp.Models;

public class Enclosure
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Animal> Animals { get; set; } = new();
    public Climate Climate { get; set; }
    public HabitatType HabitatType { get; set; }
    public SecurityLevel SecurityLevel { get; set; }
    public double Size { get; set; } // square meters
    
    
    public Enclosure(int id, string name, Climate climate, HabitatType habitatType, SecurityLevel securityLevel, double size)
    {
        Id = id;
        Name = name;
        Climate = climate;
        HabitatType = habitatType;
        SecurityLevel = securityLevel;
        Size = size;
    }
    
    
}

