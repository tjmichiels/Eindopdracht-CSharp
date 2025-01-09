using System.ComponentModel.DataAnnotations;

namespace Eindopdracht_CSharp.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    [MaxLength(100)]
    public string Name { get; set; }
    public List<Animal> Animals { get; set; } = new();

    public Category(int id, string name)
    {
        Id = id;
        Name = name;
    }
}