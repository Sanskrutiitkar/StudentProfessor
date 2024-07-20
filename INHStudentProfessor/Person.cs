using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INHStudentProfessor
{
    internal class Person
    {
        public int id;// {  get; set; }
        public string address;// { get; set; }
        public DateTime dateOfBirth;// { get; set; }

        public Person(int id, string address, DateTime dateOfBirth)
        {
            this.id = id;
            this.address = address;
            this.dateOfBirth = dateOfBirth;
        }

    }
}
