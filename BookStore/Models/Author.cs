﻿using System.ComponentModel.DataAnnotations;

namespace BookStore.Models;

public class Author
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Company> Companies { get; set; }
}