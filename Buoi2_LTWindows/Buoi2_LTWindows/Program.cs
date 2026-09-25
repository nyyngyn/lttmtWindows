using System;
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Ha Giang");
        Student s2 = new Student("Ngoc Thao");
        Student s3 = new Student("Ha Nam");

        s1.Show();

        int num = Student.NumberOfInstance();

        Console.WriteLine("Number of objects: {0}", num);

        Console.ReadLine();
    }
}