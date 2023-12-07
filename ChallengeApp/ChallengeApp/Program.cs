string name = "Tomek";
var sex = "Mężczyzna";
int age = 16;

if (sex == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}