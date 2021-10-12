using System;

Console.WriteLine("Please write your fighter´s name:");

string name;

name = "Vincent";

name = Console.ReadLine();

string ai = "";
// string ai_number;

Random generator = new Random();

int ai_number = generator.Next(1, 4);



if (ai_number == 1)
{
    ai = "Putin";
}
if (ai_number == 2)
{
    ai = "Napoleon";
}
if (ai_number == 3)
{
    ai = "George Washington";
}




int hp_ai = 100;
int hp_name = 100;

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

if(ai_number == 1)
{
Console.WriteLine(@"
⣿⣿⣿⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣵⣿⣿⣿⠿⡟⣛⣧⣿⣯⣿⣝⡻⢿⣿⣿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⣿⠋⠁⣴⣶⣿⣿⣿⣿⣿⣿⣿⣦⣍⢿⣿⣿⣿⣿⣿
⣿⣿⣿⣿⢷⠄⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⢼⣿⣿⣿⣿
⢹⣿⣿⢻⠎⠔⣛⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⣿⣿⣿⣿
⢸⣿⣿⠇⡶⠄⣿⣿⠿⠟⡛⠛⠻⣿⡿⠿⠿⣿⣗⢣⣿⣿⣿⣿
⠐⣿⣿⡿⣷⣾⣿⣿⣿⣾⣶⣶⣶⣿⣁⣔⣤⣀⣼⢲⣿⣿⣿⣿
⠄⣿⣿⣿⣿⣾⣟⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⢟⣾⣿⣿⣿⣿
⠄⣟⣿⣿⣿⡷⣿⣿⣿⣿⣿⣮⣽⠛⢻⣽⣿⡇⣾⣿⣿⣿⣿⣿
⠄⢻⣿⣿⣿⡷⠻⢻⡻⣯⣝⢿⣟⣛⣛⣛⠝⢻⣿⣿⣿⣿⣿⣿
⠄⠸⣿⣿⡟⣹⣦⠄⠋⠻⢿⣶⣶⣶⡾⠃⡂⢾⣿⣿⣿⣿⣿⣿
⠄⠄⠟⠋⠄⢻⣿⣧⣲⡀⡀⠄⠉⠱⣠⣾⡇⠄⠉⠛⢿⣿⣿⣿
⠄⠄⠄⠄⠄⠈⣿⣿⣿⣷⣿⣿⢾⣾⣿⣿⣇⠄⠄⠄⠄⠄⠉⠉
⠄⠄⠄⠄⠄⠄⠸⣿⣿⠟⠃⠄⠄⢈⣻⣿⣿⠄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⠄⢿⣿⣾⣷⡄⠄⢾⣿⣿⣿⡄⠄⠄⠄⠄⠄⠄
⠄⠄⠄⠄⠄⠄⠄⠸⣿⣿⣿⠃⠄⠈⢿⣿⣿⠄⠄⠄⠄⠄⠄⠄

");
}

if(ai_number == 2)
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

if(ai_number == 3)
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


while (hp_ai > 0 && hp_name > 0)
{
    int damage = 10 + generator.Next(0, 21);
    Console.WriteLine($"{name} hit {ai} and dealt {damage} damage");
    hp_ai -= damage;
    Console.ReadLine();
    damage = 0;


    damage = 10 + generator.Next(0, 21);
    Console.WriteLine($"{ai} hit {name} and dealt {damage} damage");
    hp_name -= damage;
    Console.ReadLine();
}


if (hp_ai <= 1)
{
    Console.WriteLine($"Game! {ai} KO {name}");
    Console.ReadLine();

}

if (hp_name <= 1)
{
    Console.WriteLine($"Game! {name} KO {ai}");
    Console.ReadLine();

}

if (hp_ai <= 0 && hp_name <= 0)
{
    Console.WriteLine("Double KO, both fighters are down");
    Console.ReadLine();
}

//string name
