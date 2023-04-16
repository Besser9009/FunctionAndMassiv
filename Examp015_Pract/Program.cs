Console.Clear();
string text = "- Я думая, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винцегероде, "
            + "вы бы взяли приступом Согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, 'к', 'К');
System.Console.WriteLine(newText);
newText = Replace(text, ' ', '_');
System.Console.WriteLine(newText);
newText = Replace(text, 'С', 'с');
System.Console.WriteLine(newText);