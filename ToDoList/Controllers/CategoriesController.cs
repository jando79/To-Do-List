using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;

namespace ToDoList.Controllers
{
  public class CategoriesController : Controller
  //everything above is boilerplate
  {

    [HttpGet("/categories")]
    public ActionResult Index()
    {
      List<Category> allCategories = Category.GetAll();
      return View(allCategories);
    }
    //creates an Index() route to display all Category(variable)
    //next add corresponding view in new Views subdirectory

    [HttpGet("/categories/new")]
    public ActionResult New()
    {
      return View();
    }
    //creates new categories with a form
    //next add new.cshtml
    //after new.cshtml form creates a new post request handled below

    [HttpPost("/categories")]
    public ActionResult Create(string categoryName)
    {
      Category newCategory = new Category(categoryName);
      return RedirectToAction("Index");
    }
    //in Category index view we added links to each Category name so user can click an individual Category
    //using RESTful routing convention, route is named Show() below

    [HttpGet("/categories/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category selectedCategory = Category.Find(id);
      List<Item> categoryItems = selectedCategory.Items;
      model.Add("category", selectedCategory);
      model.Add("items", categoryItems);
      return View(model);
    }
    //created new Dictionary called model because a Dictionary can hold multiple key-value pairs (list within category)
    //making routes view next in Show.cshtml
  
    // This one creates new Items within a given Category, not new Categories:
    [HttpPost("/categories/{categoryId}/items")]
    public ActionResult Create(int categoryId, string itemDescription)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Category foundCategory = Category.Find(categoryId);
      Item newItem = new Item(itemDescription);
      foundCategory.AddItem(newItem);
      List<Item> categoryItems = foundCategory.Items;
      model.Add("items", categoryItems);
      model.Add("category", foundCategory);
      return View("Show", model);
    }

  }
}