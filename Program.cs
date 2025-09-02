using TAFESA_Enrolment_System;

// Create Person object p1
Console.WriteLine("[ Test Person class ]");
Person p1 = new Person();
Console.WriteLine(p1);

// Set p1 details
p1.Name = "John Doe";
p1.Email = "john.doe@gmail.com";
p1.PhoneNumber = "0412345678";

// Re-display p1 details
Console.WriteLine("\n[ After setting P1 ]");
Console.WriteLine(p1);

// Create Address object addr1
Address addr1 = new Address("123", "Main St", "Adelaide", "5000", "SA");

// Create p2
Person p2 = new Person("Jane Doe", "jane.doe@outlook.com", "0498765432", addr1);

// Display p2 details
Console.WriteLine("\n[ P2 details ]");
Console.WriteLine(p2);

// Create student1
// Student student1 = new Student("0001234", "Diploma of IT", "2024-01-15");

// Create p3
Person p3 = new Person("Alice Johnson", "a.johnson@gmail.com", "0411111111", new Address("456", "William St", "Adelaide", "5000", "SA"));

// Set p3 student details
p3.StudentID = "00123456";
p3.Program = "Diploma of IT";
p3.DateRegistered = "2020-01-01";

// Display p3 details
Console.WriteLine("\n[ P3 details ]");
Console.WriteLine(p3);


