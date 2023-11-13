using DnDInitiative.Infrastructure;

string input = null;
List<Character> characters = new List<Character>();
for (int count=1;true;count++)
{
    string name;
    int initiative;
    Console.WriteLine($"Write name of {count}'th character");
    input = Console.ReadLine();
    if(input == "done" || input == "")
        break;
    name = input;
    Console.WriteLine($"write the initiative roll of {name}");
    input = Console.ReadLine();
    initiative = int.Parse(input);
    characters.Add(new Character(name, initiative));
}
characters.Sort();

Console.WriteLine("-------------");
Console.WriteLine("The initiative order is:");
Console.WriteLine("-------------");
Console.WriteLine(string.Join("\n\r",characters));
while (true)
{
    foreach(Character character in characters)
    {
        Console.WriteLine($"It is now {character.name}'s turn");
        Console.ReadLine();
    }
}