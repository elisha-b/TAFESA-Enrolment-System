using TAFESA_Enrolment_System;

// Create Person object p1
Console.WriteLine("[ Test Person class ]");
Person p1 = new Person();
Console.WriteLine(p1);

// Create p2
Person p2 = new Person("Alice Johnson", "a.johnson@gmail.com", "0411111111", new Address("456", "William St", "Adelaide", "5000", "SA"));

// Set p2 student details
p2.StudentID = "00123456";
p2.Program = "Diploma of IT";
p2.DateRegistered = "2020-01-01";

// Set p2 enrolment details
p2.Enrolment = new Enrolment("2020-02-01", "P", 1);

// Display p2 details
Console.WriteLine("\n[ P2 details ]");
Console.WriteLine(p2);


