using System.Collections.Specialized;
using Microsoft.AspNetCore.Mvc;
using NGUYENTIENDUONGBTH.Models;
namespace NGUYENTIENDUONGBTH.Controllers
{
   public class StudentController : Controller
   {
    // GET: Student
    public ActionResult Index()
    {
        List<Student> StdList= new List<Student>
        { 
            new Student { StudentID = 01, StudentName = "Nguyen Van A", Age = 18 },
            new Student { StudentID = 02, StudentName = "Nguyen Van B", Age = 21 },
            new Student { StudentID = 03, StudentName = "Nguyen Van C", Age = 25 },
            new Student { StudentID = 04, StudentName = "Nguyen Van D", Age = 20 },
            new Student { StudentID = 05, StudentName = "Nguyen Van E", Age = 31 },
            new Student{ StudentID = 06, StudentName = "Nguyen Van F", Age = 17 },
            new Student { StudentID = 07, StudentName = "Nguyen Van G", Age = 19 },
        };
        ViewBag.DanhsachSV = StdList.Count();
            return View();
        

    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Student std)
    {
       ViewBag.Sinhvien = std.StudentID + "-" + std.StudentName + "-" + std.Age;
        return View();
    }

    }
}