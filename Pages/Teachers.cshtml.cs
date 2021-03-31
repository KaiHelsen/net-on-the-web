using System;
using net_on_the_web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace net_on_the_web.Pages
{
    public class Teachers : PageModel
    {
        
        public School mySchool = new School(10, 20, 40);
        public Teacher[] MyTeachers;
        public void OnGet()
        {
            MyTeachers = mySchool._teachers.getTeachers();

        }
    }
}