﻿Console.WriteLine("Podaj Imię:");
String imie = Console.ReadLine();

Console.WriteLine("Podaj pierwszą ocenę: ");
int ocena1 = int.Parse(Console.ReadLine());

while(ocena1 < 1 || ocena1 > 6)
{
    Console.WriteLine("Podaj ocene w przedziale 1-6!");
    Console.WriteLine("Spróbuj jeszcze raz");

    ocena1 = int.Parse(Console.ReadLine());
}

Console.WriteLine("Podaj drugą ocenę: ");
int ocena2 = int.Parse(Console.ReadLine());

while(ocena2 < 1 || ocena2 > 6)
{
    Console.WriteLine("Podaj ocene w przedziale 1-6!");
    Console.WriteLine("Spróbuj jeszcze raz");

    ocena2 = int.Parse(Console.ReadLine());
}


Console.WriteLine("Podaj trzecią ocenę: ");
int ocena3 = int.Parse(Console.ReadLine());

while(ocena3 < 1 || ocena3 > 6)
{
    Console.WriteLine("Podaj ocene w przedziale 1-6!");
    Console.WriteLine("Spróbuj jeszcze raz");

    ocena3 = int.Parse(Console.ReadLine());
}

double averageGrade = (ocena1+ocena2+ocena3) / 3.0;

if(averageGrade >= 3)
{
    Console.WriteLine($"{imie} twoja średnia to: {averageGrade:F2}");
    Console.WriteLine("Zaliczone!");
}
else
{
    Console.WriteLine($"{imie} twoja średnia to: {averageGrade:F2}");
    Console.WriteLine("Nie Zaliczone!");
}