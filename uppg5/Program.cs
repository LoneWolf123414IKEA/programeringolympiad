int buldingscount = int.Parse(Console.ReadLine());
int goal = int.Parse(Console.ReadLine());
(int c, int p)[] buildings = new (int c, int p)[buldingscount];
string temp;
for (int i = 0; i < buldingscount; i++)
{
    temp = Console.ReadLine();
    buildings[i] = (int.Parse(temp.Split(' ')[0]), int.Parse(temp.Split(' ')[1]));
}
int[] stor = new int[buldingscount];
int cash = 0;
int second = 0;
int turnincrease = 0;

for (int i = 0; i < buldingscount; i++) stor[i] = 0;
stor[0]++;

while(cash <= goal)
{
    second++;
    turnincrease = 0;
    for (int i = 0; i < buldingscount; i++)
    {
        turnincrease += stor[i]*buildings[i].p;
        
    }
    cash += turnincrease;
    if (cash + turnincrease*2 >= goal) continue;
    for(int i = buldingscount-1; i >= 0; i--)
    {
        if (cash + turnincrease > buildings[i].p + turnincrease + cash - buildings[i].c) continue;
        if(cash > buildings[i].c)
        {
            stor[i]++;
            cash -= buildings[i].c;
        }
    }
}
Console.WriteLine(second);