string keys = Console.ReadLine();
HashSet<char> values = new HashSet<char>();
string testcase;
foreach(char i in keys) values.Add(i);
List<int> results = new();
int debugging;
for (int i = 0; i < Math.Pow(10, values.Count); i++)
{
    results.Add(0);
    
    //Console.WriteLine(i);
    //Console.WriteLine(results.Count());
    testcase = HSort(i, values);
    if(testcase.Length != values.Count) continue;
    //Console.WriteLine();
    for (int j = 0; j < keys.Length-1; j++)
    {
        //Console.WriteLine(testcase);
        //Console.WriteLine(testcase.IndexOf(keys[j]) - testcase.IndexOf(keys[j+1]));
        debugging = Math.Abs(testcase.IndexOf(keys[j]) - testcase.IndexOf(keys[j+1]));
        results[i] += debugging; 
    }
}
results.RemoveAll(item => item == 0);
results.Sort((a, b) => a.CompareTo(b));
Console.WriteLine(results[0]);





static string HSort(int val, HashSet<char> keys)
{
    try
    {
        for(int i = 0; i < val.ToString().Length; i++)
        {
            if(int.Parse(val.ToString()[i].ToString()) > keys.Count) return "";
        }
        //Console.WriteLine(val);
        //Console.WriteLine(keys.Count);
        string result = "";
        string key = val.ToString();
        while(key.Length != keys.Count)
        {
            if(key.Length > keys.Count) return "";
            key = "0" + key;
        }
        //Console.WriteLine(key);
        for(int i = 0; i < key.Length; i++)
        {
            //Console.WriteLine(keys.ToList()[int.Parse(key[i].ToString())]);
            result += keys.ToList()[int.Parse(key[i].ToString())];
            //Console.WriteLine(result);
        }
        if (result.Distinct().Count() < result.Length) return "";
        //Console.WriteLine(result);
        return result; 
    }
    catch
    {
        return "";
    }
}