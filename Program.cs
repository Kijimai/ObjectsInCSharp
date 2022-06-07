using OOPDemo;

Person Gaius = new Person("Gaius", "Van Baelsar");
Student Nero = new Student("Nero", "Sauce", "CSharp");
Student Livia = new Student("Livia", "Sauce", "CSharp");
Student WoL = new Student("WoL", "Sauce", "CSharp");
Student Tataru = new Student("Tataru", "Taru", "CSharp");

List<Student> StudentList = new List<Student>(); 
StudentList.Add(Nero);
StudentList.Add(Livia);
StudentList.Add(WoL);
StudentList.Add(Tataru);

Lecture CSharpLecture = new Lecture("OOP", DateTime.Now, StudentList);

Console.WriteLine(Gaius.FullName());
CSharpLecture.PrintAttendance();