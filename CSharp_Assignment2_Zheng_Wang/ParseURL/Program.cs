using System.Text;
using System.Text.RegularExpressions;

static void ParseURL(string url)
{
    Console.WriteLine(url);
    Regex rx = new Regex(@"(?<protocol>[fhtps]*)(://)?(?<server>(\w|\.)+)(/)?(?<resource>\w*)", RegexOptions.Compiled | RegexOptions.IgnoreCase);

    Match match = rx.Match(url);
    //if (match.Success)
    //{
    //    GroupCollection groups = match.Groups;
    //    Console.WriteLine($"[protocol] = {groups["protocol"].Value}");
    //    Console.WriteLine($"[server] = {groups["server"].Value}");
    //    Console.WriteLine($"[resource] = {groups["resource"].Value}");
    //}
    GroupCollection groups = match.Groups;
    Console.WriteLine($"[protocol] = {groups["protocol"].Value}");
    Console.WriteLine($"[server] = {groups["server"].Value}");
    Console.WriteLine($"[resource] = {groups["resource"].Value}");
}

string input1 = "https://www.apple.com/iphone";
string input2 = "ftp://www.example.com/employee";
string input3 = "https://google.com";
string input4 = "www.apple.com";
ParseURL(input1);
ParseURL(input2);
ParseURL(input3);
ParseURL(input4);
