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

    


  }
}