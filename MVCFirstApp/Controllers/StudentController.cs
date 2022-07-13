using Microsoft.AspNetCore.Mvc;
using MVCFirstApp.Models;


namespace MVCFirstApp.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        public StudentController()
        {
        }
        [Route("boppudi")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("getstudents")]
        public IActionResult getstudents()
        {
            List<StudentsModel> student = getstudent();
            return View(student);
        }
        [Route("ShowStudents")]
        public IActionResult showstudents(StudentsModel model)
        {
            List<StudentsModel> student = new List<StudentsModel>();
            student.Add(model);
            return View(student);
        }
        public List<StudentsModel> getstudent()
        {
            List<StudentsModel> students = new List<StudentsModel>();
            var s1 = new StudentsModel();
            s1.name = "Satya";
            s1.regno = 122014008;
            s1.branch = "ICT";
            students.Add(s1);
            var s2 = new StudentsModel();
            s2.name = "Sampreeth";
            s2.regno = 122005045;
            s2.branch = "ECE";
            students.Add(s2);
            var s3 = new StudentsModel();
            s3.name = "Ram";
            s3.regno = 122015016;
            s3.branch = "CSE";
            students.Add(s3);
            return students;
        }













    }
}
