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


