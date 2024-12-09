using System.Collections.Generic;

namespace ToDoList.Models
{
  public class Item
  {
    public int ItemId { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
    public bool IsCompleted { get; set; } = false;
    public string DueDate { get; set; }
    public Category Category { get; set; }
    public List<ItemTag> JoinEntities { get; }
  }
}