using System;
using net_on_the_web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace net_on_the_web.Pages
{
    public class Teachers : PageModel
    {
        
        public TeacherList _myTeachers;
        public Teacher[] MyClasses;
        public void OnGet()
        {
            _myTeachers = new TeacherList(12);
            MyClasses = _myTeachers.getTeachers();
        }
    }
}