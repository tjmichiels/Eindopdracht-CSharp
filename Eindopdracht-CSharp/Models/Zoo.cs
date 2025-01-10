using System.ComponentModel.DataAnnotations;

namespace Eindopdracht_CSharp.Models;

public class Zoo
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }

    public List<Enclosure> Enclosures { get; set; }

    public Zoo()
    {
    }
}