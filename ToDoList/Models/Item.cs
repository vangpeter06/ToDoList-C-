using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace ToDoList.Models
{
  public class Item
  {
    public Item()
    {
      this.JoinEntities =new HashSet<CategoryItem>();
      Completed = false;
    }
    public int ItemId { get; set; }
    public string Description { get; set; }
    [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy")]
    public DateTime Date {get; set;}
    public bool Completed { get; set; }
    public virtual ICollection<CategoryItem> JoinEntities { get; }
  }
} 