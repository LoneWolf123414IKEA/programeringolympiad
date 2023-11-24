string[] strings = new string[int.Parse(Console.ReadLine())];
Console.ReadLine();
for (int i = 0; i < strings.Length; i++) strings[i] = (Console.ReadLine());
Dictionary<int, char> chars = new Dictionary<int, char>();
for(int i = 0; i < strings.Length; i++)
{
    for(int j = 0; j < strings[i].Length; j++)
    {
        if (strings[i][j] != '.')
        {
            chars.Add(i+j, strings[i][j]);
        }
    }
}
for(int i = 0; i < strings.Length*strings[0].Length; i++)
{
    try
    {
        Console.Write(chars[i]);
    }
    catch{}
}