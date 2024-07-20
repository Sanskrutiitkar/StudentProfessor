using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace INHStudentProfessor
{
    internal class Professor : Person
    {
        public decimal salary;// { get; set; }
        public Professor(int id, string address, DateTime dob, decimal salary)
    : base(id, address, dob)
        {
            this.salary = salary;
        }
        public  decimal CalculateAnnualSalary()
        {
            return salary * 12; // Assuming salary is monthly
        }
        public  string PrintDetails()
        {
            return  $"Type: {this.GetType().Name} Professor ID: {id}, Address: {address}, DOB: {dateOfBirth.ToShortDateString()}, Salary: {salary}, Annual Salary: {CalculateAnnualSalary()}";
        }
    }
}
