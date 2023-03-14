using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    [Required(ErrorMessage = "The item's description can't be empty!")]
    public string Description { get; set; }
   [Range(1, int.MaxValue, ErrorMessage = "You must add your item to a category. Have you created a category yet?")]
    public int CategoryId { get; set; }
    public bool IsComplete { get; set; } = false;
    public DateTime? DueDate { get; set; }
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get;}
  }
}