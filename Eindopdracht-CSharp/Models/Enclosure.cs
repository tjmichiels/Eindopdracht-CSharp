using Eindopdracht_CSharp.Enums;

namespace Eindopdracht_CSharp.Models;

public class Enclosure
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Animal> Animals { get; set; }
    public Climate Climate { get; set; }
    public HabitatType HabitatType { get; set; }
    public SecurityLevel SecurityLevel { get; set; }
    public double Size { get; set; } // square meters
}