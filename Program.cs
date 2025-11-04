using TAFESA_Enrolment_System;

// Create Person object p1
Console.WriteLine("[ Test Person class ]");
Person p1 = new Person();
Console.WriteLine(p1);

// Create p2
Person p2 = new Person("Alice Johnson", "a.johnson@gmail.com", "0411111111", new Address("456", "William St", "Adelaide", "5000", "SA"));

Student s2 = new Student(p2);

// Set p2 student details
s2.StudentID = "00123456";
s2.Program = "Diploma of IT";
s2.DateRegistered = "2020-01-01";

// Set p2 enrolment details
s2.Enrolment = new Enrolment("2020-02-01", "P", 1, new Subject("PRG547", "Advanced C#", 800.0));

// Display p2 details
Console.WriteLine("\n[ S2 details ]");
Console.WriteLine(s2);

// Create p3
Person p3 = new Person("John Doe", "john.doe@gmail.com", "0412345678", new Address("123", "Happy Rd", "Adelaide", "5000", "SA"));

Student s3 = new Student(p3);

// Set p3 student details
s3.StudentID = "00123457";
s3.Program = "Diploma of IT";
s3.DateRegistered = "2019-01-01";

// Set p3 enrolment details
s3.Enrolment = new Enrolment("2019-02-01", "P", 1, new Subject("DBS506", "Design Databases", 850.0));

// Display p3 details
Console.WriteLine("\n[ S3 details ]");
Console.WriteLine(s3);

// Create p4 (same StudentID as p2)
Person p4 = new Person();
Student s4 = new Student(p4);

// Set p4 student details
s4.StudentID = "00123456";

// Compare p2 to p3
Console.WriteLine("\n[ Compare S2 to S3 ]");
Console.WriteLine("S2 equals S3 (Exp. False): " + s2.Equals(s3));
Console.WriteLine("S2 == S3 (Exp. False): " + (s2 == s3));
Console.WriteLine("S2 != S3 (Exp. True): " + (s2 != s3));

// Compare p2 to p4
Console.WriteLine("\n[ Compare S2 to S4 ]");
Console.WriteLine("S2 equals S4 (Exp. True): " + s2.Equals(s4));
Console.WriteLine("S2 == S4 (Exp. True): " + (s2 == s4));
Console.WriteLine("S2 != S4 (Exp. False): " + (s2 != s4));

