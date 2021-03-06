using System;
using System.ComponentModel.DataAnnotations;

namespace burgerapi.Models
{
  public class Drink
  {

    public Drink()
    {

    }
    public Drink(string title, string description, float price)
    { 
      Title = title;
      Price = price;
      Description = description;
    }

    [Required]
    public string Title { get; set; }
    public float Price { get; set; }
    public string Description { get; set; }
    public int Id { get; set; }
  }
}