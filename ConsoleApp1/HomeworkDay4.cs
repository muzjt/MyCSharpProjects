﻿string name = "Ola";
string gender = "Female";
int age = 29;

if (gender == "Female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (gender == "Male" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}