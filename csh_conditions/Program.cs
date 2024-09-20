// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the grade earned for the class");
string input = Console.ReadLine();
int grade = Int16.Parse(input);
string letter = "";

if (grade >= 90){
    letter = "A";
}
else if (grade >= 80){
    letter = "B";
}
else if (grade >= 70){
    letter = "C";
}
else if (grade >= 60){
    letter = "D";
}
else {
    letter = "F";
}

Console.WriteLine($"Your grade: {letter}");