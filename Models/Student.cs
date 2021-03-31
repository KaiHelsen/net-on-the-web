using System;
using System.Data.Common;

namespace net_on_the_web.Models
{
    public class Student
    {
        private static int _idCounter = 0;
        public int Id;
        public string Name;
        public ClassRoom MyClass;

        public Student(string _name, ClassRoom classRoom)
        {
            Random rand = new Random();
            this.Id = _idCounter++;
            this.Name = _name;
            this.MyClass = classRoom;
        }

        public void ResetIdCounter()
        {
            _idCounter = 0;
        }
    }
}