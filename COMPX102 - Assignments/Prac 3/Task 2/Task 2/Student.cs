using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Student
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public bool HasPaid { get; set; }

        public Student(string name, int id, bool hasPaid)
        {
            Name = name;
            ID = id;
            HasPaid = hasPaid;
        }

        public override string ToString()
        {
            return $"{Name} {ID} has {(HasPaid ? "paid" : "not paid")}";
        }
    }
}
