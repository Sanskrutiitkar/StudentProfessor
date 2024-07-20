using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace INHStudentProfessor
{
    internal class Student : Person
    {
        public string branch;
        public Student(int id,string address,DateTime dob,string branch) : base(id, address, dob)
        {
            this.branch = branch;
        }

        public  string PrintDetails()
        {
            return $"Type: {this.GetType().Name}, Student ID: {id}, Address: {address}, DOB: {dateOfBirth.ToShortDateString()}, Branch: {branch}";
        }
    }
}
