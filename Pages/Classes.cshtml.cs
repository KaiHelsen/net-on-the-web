using System;
using System.Collections.Generic;
using net_on_the_web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace net_on_the_web.Pages
{
    public class Classes : PageModel
    {
        public School _mySchool;
        public ClassRoom[] MyClasses;
        
        public void OnGet()
        {
            _mySchool = new School(3, 12, 30);
            MyClasses = _mySchool.GetClasses();
        }
    }
}