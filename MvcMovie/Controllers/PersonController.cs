using Microsoft.AspNetCore.Mvc;
using NGUYENTIENDUONGBTH.Models;
namespace NGUYENTIENDUONGBTH.Controllers
{
   public class PersonController : Controller
   {
     public ActionResult Index()
     {
        List<Person> StdList= new List<Person>
        { 
            new Person { Age = 20, Address = "HaNam", PhoneNumber = "0964220676" },
            new Person { Age = 21, Address = "Haiphong", PhoneNumber = "0869246872" },
            new Person { Age = 20, Address = "HaNoi", PhoneNumber = "0986324156" },
        };
         ViewBag.ThongtinSV = StdList.Count();
            return View();
     }
     [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Person std)
    {
       ViewBag.thongtin = std.Age + "-" + std.Address + "-" + std.PhoneNumber;
        return View();
    }
   }
}