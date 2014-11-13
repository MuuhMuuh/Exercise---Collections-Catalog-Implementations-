using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise___Collections
{
    public class Student : IIdentifiable
    {
        // private int _id;
        public int Id { get; private set; }

        public Student(int id)
        {
            Id = id;
        }

        //public Student(int id)
        //{
        //    _id = id;
        //}

        public override string ToString()
        {
            return "Student id: " + Id;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
