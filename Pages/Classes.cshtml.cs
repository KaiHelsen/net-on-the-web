using System;
using System.Collections.Generic;
using net_on_the_web.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace net_on_the_web.Pages
{
    public class Classes : PageModel
    {
        public School _mySchool = new School(10,20,30);
        public ClassRoom[] MyClasses;
        
        public void OnGet()
        {
            MyClasses = _mySchool.GetClasses();
        }
    }
}