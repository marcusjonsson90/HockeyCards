using HockeyCards;

HockeyCardAlbum album = new();

//Uppgift 1
Console.Write("Förväntad output: 1722 | ");
Console.WriteLine("Er output: " + album.TaskOne() + "\n");

//Uppgift 2
Console.Write("Förväntad output: Pittsburgh Penguins | ");
Console.WriteLine("Er output: " + album.TaskTwo() + "\n");

//Uppgift 3
Console.Write("Förväntad output: 6 | ");
Console.WriteLine("Er output: " + album.TaskThree() + "\n");

//Uppgift 4
Console.Write("Förväntad output: Tom Kurvers | ");
Console.WriteLine("Er output: " + album.TaskFour() + "\n");

//Uppgift 5
Console.Write("Förväntad output: 19 | ");
Console.WriteLine("Er output: " + album.TaskFive() + "\n");

//Uppgift 6
Console.Write("Förväntad output: Todd Krygier - Dimitri Khristich - Don Beaupre - Michal Pivonka - Michal Pivonka \nEr output: ");
album.TaskSix();
foreach (HockeyCard hockeyCard in album.HockeyCards.Where(x => x.Team == Team.Capitals))
{
    Console.Write(hockeyCard.FullName + " - ");
}

Console.WriteLine("\n\n");