Console.Write("Ordet ? ");
string word = Console.ReadLine();
Console.Write("\nAntal upprepningar ? ");
int count = int.Parse(Console.ReadLine());
Console.Write("\n\nSvar: ");
for(int i = 0; i < count; i++) Console.Write(word);