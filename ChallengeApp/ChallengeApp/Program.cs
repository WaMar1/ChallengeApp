string name = "Tomek";
var plec = "Mężczyzna";
int age = 16;

if (plec == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (plec != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}