using System;
using System.Collections.Generic;
using System.Text;

namespace EFC2
{
    public class Student
    {
        public int Id { get; set; }
        public required string FullName { get; set; }
        public double Grade { get; set; }
        public string? Email { get; set; } // Optional property for email
        public override string ToString()
        {
            return $"Id: {Id}, FullName: {FullName}, Grade: {Grade}, Email: {Email ?? "N/A"}";
        }
    }
}
