using Microsoft.AspNetCore.Mvc;
using NGUỶETIENDUONGBTH.Models;
namespace NGUYENTIENDUONGBTH.Controllers
{
  public class EmployeeController : Controller 
  {
    public ActionResult Index()
     {
        List<Employee> StdList= new List<Employee>
        { 
            new Employee { EmployeeID = 1, EmployeeName = "Cuong", Age = 20 },
            new Employee { EmployeeID = 2, EmployeeName = "Hieu", Age = 21 },
            new Employee { EmployeeID = 3, EmployeeName = "Hung", Age = 20 },
        };
         ViewBag.SNV = StdList.Count();
            return View();
      }
      [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee std)
    {
       ViewBag.thongtinNhanVien = std.EmployeeID+ "-" + std.EmployeeName+ "-" + std.Age;
        return View();
    }
   }
}