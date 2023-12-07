using EFCoreCodeFirstDemo.Services.Students;

Dictionary<int,string> options =  new Dictionary<int,string>();
options.Add(1, "Create Student");
options.Add(2, "Read Students");
options.Add(3, "Get One Student");
options.Add(4, "Update Student");
options.Add(5, "Delete Student");

Console.WriteLine("Choose Option");
foreach (var option in options)
{
    Console.WriteLine($"{option.Key}:{option.Value}");
}

int optSelected = int.Parse(Console.ReadLine());
StudentService Std = new StudentService();
if (optSelected == 1)
{
    Std.AddStudent();
}
else if (optSelected == 2)
{
   await  Std.GetStudents();
} else if(optSelected == 3)
{
    Std.GetStudent();
}else if(optSelected == 4)
{
    Std.updateStudent();
}else if(optSelected == 5)
{
    Std.DeleteStudent();
}