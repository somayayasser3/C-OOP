using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Casting_Operator_Overloading
{
    // Model : Class that Representing Table Existed at Database
    // Entity FrameWork
    // 1. Database First (Database -Entity FrameWork-> Model)
    // 2. Code First (Model -Entity FrameWork-> Database)
    internal class Employee
    {
        // The same of Columns Names and numbers in database
        // if we want to hide data from user (viewer)
        // create class EmployeeView to detect what data can user views
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid SecurityStamp { get; set; } // Globally Unique Identifier (Generate Unique Guid)  

    }
}
