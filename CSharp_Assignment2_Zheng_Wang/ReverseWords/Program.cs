using System.Text;

static void ReverseWords(string text)
{
    StringBuilder result = new StringBuilder();
    string[] words = text.Split(',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ');
    char[] x = text.ToCharArray();
    string[] punctuation = text.Split(x);
    foreach (string p in punctuation)
    {
        Console.WriteLine(p);
    }
    foreach (string w in words)
    {
        Console.WriteLine(w);
    }

}

ReverseWords("C# is not C++, and PHP is not Delphi!");

// Couldn't figure out this one, will keep working on it.
    