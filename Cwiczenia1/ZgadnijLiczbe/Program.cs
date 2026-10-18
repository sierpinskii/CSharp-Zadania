﻿Random rnd = new Random();

int randomNumber = rnd.Next(1, 101);
int userNumber;

Console.WriteLine("Zgadnij liczbę od 1-100: ");
userNumber = int.Parse(Console.ReadLine());

while(userNumber != randomNumber)
{
    if(userNumber < 1 || userNumber > 100)
    {
        Console.WriteLine("Podana liczba nie jest z przedziału 1-100!");
    }
    else if(userNumber < randomNumber)
    {
        Console.WriteLine("Za mało!");
    }
    else if(userNumber > randomNumber)
    {
        Console.WriteLine("Za dużo!");
    }

    Console.WriteLine("Zgadnij liczbę od 1-100: ");
    userNumber = int.Parse(Console.ReadLine());
}

Console.WriteLine("Brawo! Zgadłeś!");