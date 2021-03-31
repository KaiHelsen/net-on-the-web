using System;

namespace net_on_the_web.Models
{
    public class ClassRoom
    {
        private int _idCounter = 0;
        private int _id;
        public int Id { get => _id;}
        private string _className;
        private string _roomNumber;
        private StudentList _myStudents;
        private Teacher _myTeacher;

        public string ClassName
        {
            get => _className;
            set => _className = value;
        }

        public string RoomNumber
        {
            get => _roomNumber;
            set => _roomNumber = value;
        }

        public Teacher MyTeacher
        {
            get => _myTeacher;
            set => _myTeacher = value;
        }

        public ClassRoom(string className, string roomNumber)
        {
            this._id = _idCounter++;
            this._className = className;
            this._roomNumber = roomNumber;

            _myStudents = new StudentList(new Random().Next(10, 30));

        }
    }
}