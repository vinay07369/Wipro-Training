using System;
using System.Collections.Generic;

// Course class 
class Course
{
    public int Id { get; set; }
    public string Title { get; set; }
    public double Fee { get; set; }
}

// Interface
interface IEnrollable
{
    void Enroll(Course course);
    void Enroll(Course course, string couponCode);
}

// User class  and method overloading
class User : IEnrollable
{
    private List<Course> enrolledCourses = new List<Course>();
    private List<double> finalFees = new List<double>();

    public void Enroll(Course course)
    {
        enrolledCourses.Add(course);
        finalFees.Add(course.Fee);
    }

    public void Enroll(Course course, string couponCode)
    {
        double discount = 0;

        if (couponCode == "SAVE10")
            discount = 0.10;
        else if (couponCode == "SAVE20")
            discount = 0.20;

        double discountedFee = course.Fee * (1 - discount);
        enrolledCourses.Add(course);
        finalFees.Add(discountedFee);
    }

    public void PrintEnrolledCourses()
    {
        for (int i = 0; i < enrolledCourses.Count; i++)
        {
            Console.WriteLine($"Course: {enrolledCourses[i].Title}, Final Fee: {finalFees[i]}");
        }
    }
}

// Main program
class Program
{
    static void Main()
    {
        // Create course objects using properties instead of constructor
        Course c1 = new Course { Id = 101, Title = "C# Basics", Fee = 5000 };
        Course c2 = new Course { Id = 102, Title = "Advanced C#", Fee = 7000 };

        // Create user and enroll
        User user = new User();
        user.Enroll(c1);
        user.Enroll(c2, "SAVE10");

        // Print enrolled courses
        user.PrintEnrolledCourses();
    }
}