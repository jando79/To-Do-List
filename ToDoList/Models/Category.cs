// //in project, test and Business Logic .cs first
// //next is controllers
// using System.Collections.Generic;

// namespace ToDoList.Models
// {
//   public class Category
//   {
//     private static List<Category> _instances = new List<Category> {};
//     //instances contains list of all Category (variable) objects
//     public string Name { get; set; }
//     //Name (variable) will contain name for category of items
//     public int Id { get; }
//     //Id will contain unique ID number assigned to constructor
//     public List<Item> Items { get; set; }
//     //Items is auto-implemented propert with data type as a List of Item (variable)  }
    
//     public Category(string categoryName)
//     {
//       Name = categoryName;
//       _instances.Add(this);
//       Id = _instances.Count;
//       Items = new List<Item>{};
//     }
//     //the above is what gets constructor (first test) to pass
//     //also passes second test

//     public static void ClearAll()
//     {
//       _instances.Clear();
//     }
//     //first 3 tests pass**write first three tests before running so all tests pass

//     public static List<Category> GetAll()
//     {
//       return _instances;
//     }  
//     //passes 4th test
  
//     public static Category Find(int searchId)
//     {
//       return _instances[searchId-1];
//     }
//     //passes 5th test

//     public void AddItem(Item item)
//     {
//       Items.Add(item);
//     }
//     //passes 6th test
//   }
//}