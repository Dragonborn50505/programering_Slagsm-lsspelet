using System;

string restart = "yes";
while (restart == "yes")
{
    Console.WriteLine("Please write your fighter´s name:");

    string name;

    name = "Vincent";

    name = Console.ReadLine();

    string ai = "";
    // string ai_number;

    Random generator = new Random();

    int ai_number = generator.Next(1, 4);

    string name_choice = "";
    string money = "";
    string bonus = "";
    int strong = 0;

    // int HitOrMiss = generator.Next(1, 6);

    //________________________________________________________________________________

    if (ai_number == 1)
    {
        ai = "Einstein";
    }
    if (ai_number == 2)
    {
        ai = "Napoleon";
    }
    if (ai_number == 3)
    {
        ai = "George Washington";
    }

    //________________________________________________________________________________

    int hp_ai = 200;
    int hp_name = 200;

    //________________________________________________________________________________

    Console.WriteLine(@"
      MMMMMMMM
      |      |
     @  O  O  @
      |  ~   |         \__
       \ -- /          |\ |
     ___|  |___        | \|
    /          \      /|__|
   /            \    / /
  /  /| .  . |\  \  / /
 /  / |      | \  \/ /
<  <  |      |  \   /
 \  \ |  .   |   \_/
  \  \|______|
    \_|______|
      |      |
      |  |   |
      |  |   |
      |__|___|
      |  |  |
      (  (  |
      |  |  |
      |  |  |
     _|  |  |
");

    if (ai_number == 1)
    {
        Console.WriteLine(@"
       -''--.
       _`>   `\.-'<
    _.'     _     '._
  .'   _.='   '=._   '.
  >_   / /_\ /_\ \   _<
    / (  \o/\\o/  ) \
    >._\ .-,_)-. /_.<
        /__/ \__\ 
          '---'     
");
    }

    if (ai_number == 2)
    {
        Console.WriteLine(@"
       .-´´´´´-.
    .-´         ´-.
 __/               \__
 \     .-´´´´´-.     /
  '----//o   o\\----'
      (    _\   )
  ,____`\  =  /`____,
// \   `;'---' `   / \
\\/     |-o        \//
|    |  |      |     |
|    |  |-o    |\    |
\    `--|      |/    /
 '._    |-o    |    /
    '|´´|      |  .'
     |  |-o    |-`
     |  |      |
     |_/ \_____|
      |   |   |
      |   |   |
      \'-.|.-'/
      ]  _|_  [
     /    |    \
    /    / \    \
   (___/`   `\___)
");
    }

    if (ai_number == 3)
    {
        Console.WriteLine(@"
    .-'~´-. 
    / `-    \ 
   />  `.  -.| 
  /_     '-.__) 
   |-  _.' \ | 
   `~~:     \\ 
      /      \\)
     '.___.-'`´

");
    }

    //________________________________________________________________________________

    money = "";
    Console.WriteLine($"{ name} will be fighting {ai}! You have 100 dollars, who will you set your money on?");

    while (money != $"{name}" && money != $"{ai}")
    {
        money = Console.ReadLine();
    }

    Console.WriteLine($"what type of fighter is {name}, Is he a strong or resilient");
    while (bonus != "strong" && bonus != "resilient")
    {
        bonus = Console.ReadLine();
    }

    if (bonus == "resilient") //Spelet gör det enklare för spelaren att vinna genom en bonus så inte han slutar lämmnar spelet
    {
        hp_name = 225;
    }
    else {
        strong = 5;
    }


    while (hp_ai > 0 && hp_name > 0)
    {

        Console.WriteLine($"{ai} hp = {hp_ai}, {name} hp = {hp_name}");
        Console.WriteLine($"Ska {name} 1) slå eller 2) sparka");

        name_choice = "";
        while (name_choice != "1" && name_choice != "2")
        {
            name_choice = Console.ReadLine();
        }


        if (name_choice == "2")
        {

            int KickOrMissName = generator.Next(1, 5);

            if (KickOrMissName == 1)
            {
                Console.WriteLine($"{name} missed {ai}!");
            }
            else
            {
                int damage = 20 + generator.Next(0, 26) + strong;
                Console.WriteLine($"{name} kicked {ai} and dealt {damage} damage");
                hp_ai -= damage;
                damage = 0;
            }
        }

        //________________________________________________________________________________

        else
        {
            int HitOrMissName = generator.Next(1, 11);

            if (HitOrMissName == 1)
            {
                Console.WriteLine($"{name} missed {ai}!");
                //Console.ReadLine();
            }
            else
            {
                int damage = 10 + generator.Next(0, 21) + strong;
                Console.WriteLine($"{name} hit {ai} and dealt {damage} damage");
                hp_ai -= damage;
                //Console.ReadLine();
                damage = 0;
            }
        }

        //________________________________________________________________________________
        int ai_choice = generator.Next(1, 6);

        if (ai_choice == 1)
        {
            int KickOrMissAI = generator.Next(1, 12);//ai förlorade för mycket så gode de lite bättre

            if (KickOrMissAI == 1)
            {
                Console.WriteLine($"{ai} missed {name}!");
                //Console.ReadLine();
            }
            else
            {
                int damage = 20 + generator.Next(0, 26);
                Console.WriteLine($"{ai} kicked {name} and dealt {damage} damage");
                hp_name -= damage;
                //Console.ReadLine();
                damage = 0;
            }
        }

        //________________________________________________________________________________

        else
        {
            int HitOrMissAI = generator.Next(1, 21);

            if (HitOrMissAI == 1)
            {
                Console.WriteLine($"{ai} missed {name}!");
                //Console.ReadLine();
            }

            else
            {
                int damage = 10 + generator.Next(0, 21);
                Console.WriteLine($"{ai} hit {name} and dealt {damage} damage");
                hp_name -= damage;
                damage = 0;
                //Console.ReadLine();
            }
        }

        //________________________________________________________________________________
    }
    if (hp_ai <= 1)
    {
        if (money == name)
        {
            Console.WriteLine($"Game! {name} KO {ai}, You got 200 dollars");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Game! {name} KO {ai}, You lost your money");
            Console.ReadLine();
        }
    }
    //________________________________________________________________________________
    if (hp_name <= 1)
    {
        if (money == ai)
        {
            Console.WriteLine($"Game! {ai} KO {name},You got 200 dollars ");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine($"Game! {name} KO {ai},You lost your money");
            Console.ReadLine();
        }
    }
    //________________________________________________________________________________
    if (hp_ai <= 0 && hp_name <= 0)
    {
        Console.WriteLine("Double KO, both fighters are down, You lost your money");
        Console.ReadLine();
    }
    //________________________________________________________________________________
    //string name

    Console.WriteLine("Restart?");
    restart = Console.ReadLine();

}