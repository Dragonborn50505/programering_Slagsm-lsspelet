using System;


Random generator = new Random();


int hp_Isak = 100;
int hp_Jonathan = 100;

Console.WriteLine(@"
       _.---._    /\\
    ./'       '--`\//
  ./              o \
 /./\  )______   \__ \
./  / /\ \   | \ \  \ \
   / /  \ \  | |\ \  \7
");

while (hp_Isak > 0 && hp_Jonathan > 0)
{
    int damage = 10  + generator.Next(0, 21);
    Console.WriteLine($"Jonathan hit Isak and dealt {damage} damage");
    hp_Isak -= damage;
    Console.ReadLine();
    damage = 0;


    damage = 10 + generator.Next(0, 21);
    Console.WriteLine($"Isak hit Jonathan and dealt {damage} damage");
    hp_Jonathan -= damage;
    Console.ReadLine();
}


if (hp_Isak <= 1)
{
    Console.WriteLine("Game! Isak KO Jonathan");
    Console.ReadLine();

}

if (hp_Jonathan <= 1)
{
    Console.WriteLine("Game! Jonathan KO Isak");
    Console.ReadLine();

}

if (hp_Isak <= 0 && hp_Jonathan <= 0)
{
    Console.WriteLine("Double KO, both fighters are down");
    Console.ReadLine();
}

//string name
