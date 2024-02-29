using StudentClass;

// 2.        Maak een dictionary met als key het studentennummer en als inhoud een student object.
Dictionary<int, Student> students = [];

// 3.        Bevolk deze dictionary met 10 studenten
students[69420] = new Student("Milan", 20);
students[69421] = new Student("Ace Raccon", 18);
students[69422] = new Student("Bert", 50);
students[69423] = new Student("Guy", 69);
students[69424] = new Student("Iemand", 99);
students[69425] = new Student("Hammer Time", 43);
students[69426] = new Student("Donnus", 25);
students[69427] = new Student("Zee Babar", 18);
students[69428] = new Student("Uvees", 18);
students[69429] = new Student("Levinio", 18);
students[69430] = new Student("Alessander", 18);
students[69431] = new Student("Burak", 19);

// oops bert is geen student haha
students.Remove(69422);

// 4.        Vind een bestaande student aan de hand van zijn studentnummer
Console.WriteLine(students[69420].Name);

// 5.        Probeer een niet bestaande student te vinden, dit mag geen fout opleveren
int studentIdToFind = 100;
if (students.ContainsKey(studentIdToFind))
{
    Student student = students[studentIdToFind];
    Console.WriteLine("Found Student: " + student.Name);
}
else
{
    Console.WriteLine("Student with ID " + studentIdToFind + " does not exist.");
}

// 6.        Druk een lijst met studentennummers af
Console.WriteLine("Studenten nummers:");
foreach (var (key, value) in students)
{
    Console.WriteLine(key);
}

// 7.        Druk een lijst met studentennamen af
Console.WriteLine("Studenten namen:");
foreach (var (key, value) in students)
{
    Console.WriteLine(value.Name);
}

// 8.        Verander de lijst in een SortedDictionary en druk een lijst met studentnummer en namen af
new SortedDictionary<int, Student>(students);
foreach (var (key, value) in students)
{
    Console.WriteLine($"{key} = {value.Name}");
}

// 9.        Zoek de oudste student op uit de lijst en druk deze af
Student oldestStudent = students.Values.OrderByDescending(s => s.Age).FirstOrDefault();
Console.WriteLine("Oldest Student: " + oldestStudent.Name);

// 10.  Druk een lijst van studenten af gesorteerd op leeftijd.
var sortedStudents = students.OrderBy(pair => pair.Value.Age);

Console.WriteLine("Students sorted by age:");
foreach (var (key, value) in sortedStudents)
{
    Console.WriteLine($"{key}: {value.Name} = {value.Age}");
}

