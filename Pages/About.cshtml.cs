using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_on_the_web.Models;

namespace net_on_the_web.Pages
{
    public class AboutModel : PageModel
    {
        public School mySchool = new School(10, 20, 40);
        public Student[] _students;

        public void OnGet()
        {
            _students = mySchool.Students.GetStudentArray();
        }
    }
}
