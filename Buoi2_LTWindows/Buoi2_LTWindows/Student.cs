using System;
using System.Collections.Generic;
using System.Text;
    internal class Student
    {
        static int number; // Lưu số lượng đối tượng
        string name;

        // Constructor
        public Student(string n)
        {
            name = n;
            number++; // Tăng số lượng đối tượng lên 1
        }

        public void Show()
        {
            Console.WriteLine("{0}", name);
        }

        public static int NumberOfInstance()
        {
            return number; // Trả về số lượng đối tượng
        }
    }
