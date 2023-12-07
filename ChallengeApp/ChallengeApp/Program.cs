string imię = "Tomek";
var płeć = "Mężczyzna";
int wiek = 16;

if (płeć == "Kobieta" && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imię == "Ewa" && wiek == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (płeć != "Kobieta" && wiek < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}