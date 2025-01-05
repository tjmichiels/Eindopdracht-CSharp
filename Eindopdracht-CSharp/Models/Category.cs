﻿namespace Eindopdracht_CSharp.Models;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    public List<Animal> Animals { get; set; } = new();
}