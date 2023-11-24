
int count = int.Parse(Console.ReadLine());
int ns = 0;
for (int i = 1  ; i < count ; i++)
{
    if(i*(i+1)*(i+2) > count) break;
    ns++;
}
Console.WriteLine(ns);

