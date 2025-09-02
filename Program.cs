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
p2.Enrolment = new Enrolment("2020-02-01", "P", 1, new Subject("PRG547", "Advanced C#", 800.0));

// Display p2 details
Console.WriteLine("\n[ P2 details ]");
Console.WriteLine(p2);

// Create p3
Person p3 = new Person("John Doe", "john.doe@gmail.com", "0412345678", new Address("123", "Happy Rd", "Adelaide", "5000", "SA"));

// Set p3 student details
p3.StudentID = "00123457";
p3.Program = "Diploma of IT";
p3.DateRegistered = "2019-01-01";

// Set p3 enrolment details
p3.Enrolment = new Enrolment("2019-02-01", "P", 1, new Subject("DBS506", "Design Databases", 850.0));

// Display p3 details
Console.WriteLine("\n[ P3 details ]");
Console.WriteLine(p3);

// Create p4 (same StudentID as p2)
Person p4 = new Person();

// Set p4 student details
p4.StudentID = "00123456";

// Compare p2 to p3
Console.WriteLine("\n[ Compare P2 to P3 ]");
Console.WriteLine("P2 equals P3 (Exp. False): " + p2.Equals(p3));
Console.WriteLine("P2 == P3 (Exp. False): " + (p2 == p3));
Console.WriteLine("P2 != P3 (Exp. True): " + (p2 != p3));

// Compare p2 to p4
Console.WriteLine("\n[ Compare P2 to P4 ]");
Console.WriteLine("P2 equals P4 (Exp. True): " + p2.Equals(p4));
Console.WriteLine("P2 == P4 (Exp. True): " + (p2 == p4));
Console.WriteLine("P2 != P4 (Exp. False): " + (p2 != p4));

