using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PROJEM.Models;

namespace PROJEM.Controllers
{
 
 public class RolesController:Controller
 {
   private readonly RoleManager<AppRole> _roleManager;
    
    public RolesController(RoleManager<AppRole> roleManager)
    {
       _roleManager = roleManager;
    }

     public IActionResult Index()
        {
            return View();
        }

      public IActionResult Create()
     {
    return View();
     }
 
 
 
 
 }
}