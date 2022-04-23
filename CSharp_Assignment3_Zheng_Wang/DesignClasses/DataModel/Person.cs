using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignClasses.DataModel
{
    public abstract class Person
    {
        // Encapsulation
        private int id;
        public int Id { get { return id; } private set { id = value; } }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public abstract void Behavior();
    }
    // Inheritance: properties such as Id, Name, Email are inherited by Instructor and Student classes
    public class Instructor : Person
    {
        public string Title { get; set; }
        public string[] Courses { get; set; }
        // Encapsulation
        private decimal salary;
        private decimal Salary 
        {
            get { return salary; }
            set { salary = value; }
        }
        // Abstraction
        public override void Behavior()
        {
            Console.WriteLine("An instructor gives classes and grades homeworks.");
        }
    }

    public class Student : Person
    {
        // Encapsulation
        private decimal tuition;
        public decimal Tuition { get { return tuition; } private set { tuition = value; } }
        public string [] Courses { get; set; }
        public string Degree { get; set; } 
        public override void Behavior()
        {
            Console.WriteLine("A student attend classes and finish homeworks."); ;
        }
    }
}
