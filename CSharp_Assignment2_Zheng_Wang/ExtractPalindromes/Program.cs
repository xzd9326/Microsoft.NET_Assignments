static void ExtractPalindromes(string text)
{
    List<string> result = new List<string>();
    string[] words = text.Split('.',',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ');
    
    foreach (string word in words)
    {
        if (IsPalindrome(word) && word != "")
        {
            result.Add(word);
        }
    }
    result.Sort();

    Console.WriteLine(string.Join(", ", result));
}

static bool IsPalindrome(string s)
{
    int l = 0;
    int r = s.Length - 1;
    while (l < r)
    {
        if (s[l] != s[r])
        {
            return false;
        }
        l++;
        r--;
    }
    return true;
}

string input = "Hi,exe? ABBA! Hog fully a string: ExE. Bob";
ExtractPalindromes(input);