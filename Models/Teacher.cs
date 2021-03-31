using System;
using System.Data.Common;
using net_on_the_web.Models;

namespace net_on_the_web.Models
{
    public class Teacher
    {
        private string _name;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private int _id;

        public int Id
        {
            get => _id;
        }

        public ClassRoom myClass;

        public Teacher(string name, ClassRoom classRoom)
        {
            Random rand = new Random();
            this._id = rand.Next(5000);
            this.Name = name;
            this.myClass = classRoom;
        }
    }
}