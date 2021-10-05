using System;


Random generator = new Random();


int hp_Isak = 200;
int hp_Jonathan = 200;

while (hp_Isak > 0 && hp_Jonathan > 0)
{
    int damage = 10 + generator.Next(10, 21);
    Console.WriteLine("Jonathan hit Isak and dealt ", damage, "damage");
    hp_Isak -= damage;
    Console.ReadLine();
    damage = 0;


    damage = 10 + generator.Next(10, 21);
    Console.WriteLine("Isak hit Jonathan and dealt ", damage, "damage");
    hp_Jonathan -= damage;
    Console.ReadLine();
}

if (hp_Isak < 1)
{
Console.WriteLine("Game! Isak KO Jonathan");
}

if (hp_Jonathan < 1)
{
Console.WriteLine("Game! Jonathan KO Isak");
}